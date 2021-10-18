using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Cache;
using System.Net.NetworkInformation;
using System.Text;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;
using web_lab1.Entities;
using web_lab1.Services;

namespace web_lab1
{
    public partial class FormSagesList : Form
    {
        private readonly BookService _bookService;
        private readonly BindingSource _booksSages = new BindingSource();

        private readonly SageService _sageService;
        private readonly BindingSource _sagesBooks = new BindingSource();

        private Mode _mode;

        public FormSagesList(BookService bookService, SageService sageService)
        {
            _bookService = bookService;
            _sageService = sageService;
            InitializeComponent();
        }

        private void FormSagesList_Load(object sender, EventArgs e)
        {
            InitTab();
        }

        private void Sages_Selected(object sender, TabControlEventArgs e)
        {
            InitTab();
        }

        private void InitTab()
        {
            switch (Sages.SelectedTab.TabIndex)
            {
                case 0:
                    FetchSages();
                    infoPanel.Hide();
                    break;
                case 1:
                    FetchBooks();
                    panel1.Hide();
                    break;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            _mode = Mode.Add;
            switch (Sages.SelectedTab.TabIndex)
            {
                case 0:
                    SetUpSageForm();
                    break;
                case 1:
                    SetUpBookForm();
                    break;
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            _mode = Mode.Edit;
            switch (Sages.SelectedTab.TabIndex)
            {
                case 0:
                    SetUpSageForm();
                    FillSageForm();
                    break;
                case 1:
                    SetUpBookForm();
                    FillBookForm();
                    break;
            }
        }

        private async void btnDelete_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show(@"Are you sure you want to delete?", @"Confirmation", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                int id;
                switch (Sages.SelectedTab.TabIndex)
                {
                    case 0:
                        id = (int) dataGridViewSages.CurrentRow!.Cells["Id"].Value;
                        await _sageService.Delete(id);
                        FetchSages();
                        break;
                    case 1:
                        id = (int) dataGridViewBooks.CurrentRow!.Cells["Id"].Value;
                        await _bookService.Delete(id);
                        FetchBooks();
                        break;
                }
            }
        }

        #region Books

        private async void FetchBooks()
        {
            dataGridViewBooks.DataSource = await _bookService.GetBooks();
            dataGridViewBooks.ClearSelection();
        }

        private void SetUpBookForm()
        {
            ClearBookForm();
            panel1.Show();
            textBookName.Focus();
        }

        private void ClearBookForm()
        {
            textBookId.Clear();
            textBookName.Clear();
            textBookDescription.Clear();
            _booksSages.DataSource = new List<Sage>();
            dataGridViewBookSages.DataSource = _booksSages;
            dataGridViewBooks.ClearSelection();
        }

        private void btnBookCancel_Click(object sender, EventArgs e)
        {
            panel1.Hide();
        }

        private async void FillBookForm()
        {
            var id = (int) dataGridViewBooks.CurrentRow!.Cells[0].Value;
            var book = await _bookService.GetBookWithSages(id);

            textBookId.Text = book.Id.ToString();
            textBookName.Text = book.Name;
            textBookDescription.Text = book.Description;
            FillBookSages(book.Sages);
        }

        private void FillBookSages(List<Sage> sages)
        {
            _booksSages.DataSource = new List<Sage>(sages);

            dataGridViewBookSages.Columns.Clear();
            dataGridViewBookSages.DataSource = null;
            dataGridViewBookSages.DataSource = _booksSages;
            dataGridViewBookSages.Columns.Remove("Photo");
            dataGridViewBookSages.Columns.Remove("City");
            var button = new DataGridViewButtonColumn();
            {
                button.Name = "removeBtn";
                button.HeaderText = @"Remove";
                button.Text = "Remove";
                button.UseColumnTextForButtonValue = true;
                dataGridViewBookSages.Columns.Add(button);
            }
            dataGridViewBookSages.ClearSelection();
        }

        private void dataGridViewBooks_SelectionChanged(object sender, EventArgs e)
        {
            var isCellSelected = dataGridViewBooks.SelectedCells.Count != 0;
            btnEdit.Enabled = isCellSelected;
            btnDelete.Enabled = isCellSelected;
        }

        private void dataGridViewBookSages_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridViewBookSages.Columns["removeBtn"]?.Index)
            {
                if (dataGridViewBookSages.CurrentRow != null)
                {
                    dataGridViewBookSages.Rows.Remove(dataGridViewBookSages.CurrentRow);
                    dataGridViewBookSages.Refresh();
                }
            }
        }

        private async void btnBookSave_Click(object sender, EventArgs e)
        {
            switch (_mode)
            {
                case Mode.Add:
                    await _bookService.Save(new Book
                    {
                        Name = textBookName.Text,
                        Description = textBookDescription.Text,
                        Sages = _booksSages.DataSource as List<Sage>
                    });
                    break;
                case Mode.Edit:
                    await _bookService.Update(new Book
                    {
                        Id = int.Parse(textBookId.Text),
                        Name = textBookName.Text,
                        Description = textBookDescription.Text,
                        Sages = _booksSages.DataSource as List<Sage>
                    });
                    break;
            }

            panel1.Visible = false;
            FetchBooks();
        }

        private async void btnAddSage_Click(object sender, EventArgs e)
        {
            var selectedSages = (_booksSages.DataSource as List<Sage>)!.Select(s => s.Id);
            var availableSages = await _sageService.GetSagesExcept(selectedSages);

            using var modal = new AddSagesModal(availableSages);
            var result = modal.ShowDialog(this);
            if (result == DialogResult.OK)
            {
                var sages = (_booksSages.DataSource as List<Sage>)!
                    .Concat(modal.SelectedSages)
                    .ToList();
                FillBookSages(sages);
            }
        }

        #endregion

        #region Sages

        private async void FetchSages()
        {
            dataGridViewSages.DataSource = await _sageService.GetSages();
            if (dataGridViewSages.Columns["Photo"] != null)
            {
                dataGridViewSages.Columns.Remove("Photo");
            }

            dataGridViewSages.ClearSelection();
        }

        private void SetUpSageForm()
        {
            ClearSageForm();
            infoPanel.Show();
            textName.Focus();
        }

        private void ClearSageForm()
        {
            textSageId.Clear();
            textName.Clear();
            textAge.Clear();
            textCity.Clear();
            imgProfile.Image = null;
            _sagesBooks.DataSource = new List<Book>();
            dataGridViewSageBooks.DataSource = _sagesBooks;
            dataGridViewSageBooks.ClearSelection();
        }

        private async void FillSageForm()
        {
            var id = (int) dataGridViewSages.CurrentRow!.Cells[0].Value;
            var sage = await _sageService.GetSageWithBooks(id);

            textSageId.Text = sage.Id.ToString();
            textName.Text = sage.Name;
            textAge.Text = sage.Age.ToString();
            textCity.Text = sage.City;
            imgProfile.Image = sage.Photo.ToImage();

            FillSageBooks(sage.Books);
        }

        private void FillSageBooks(List<Book> books)
        {
            _sagesBooks.DataSource = new List<Book>(books);

            dataGridViewSageBooks.Columns.Clear();
            dataGridViewSageBooks.DataSource = null;
            dataGridViewSageBooks.DataSource = _sagesBooks;
            dataGridViewSageBooks.Columns.Remove("Description");
            var button = new DataGridViewButtonColumn();
            {
                button.Name = "removeBtn";
                button.HeaderText = @"Remove";
                button.Text = "Remove";
                button.UseColumnTextForButtonValue = true;
                dataGridViewSageBooks.Columns.Add(button);
            }
            dataGridViewSageBooks.ClearSelection();
        }

        private async void bntSave_Click(object sender, EventArgs e)
        {
            switch (_mode)
            {
                case Mode.Add:
                    await _sageService.Save(new Sage
                    {
                        Name = textName.Text,
                        Age = int.Parse(textAge.Text),
                        City = textCity.Text,
                        Photo = imgProfile.Image.ToByteArray(),
                        Books = _sagesBooks.DataSource as List<Book>
                    });
                    break;
                case Mode.Edit:
                    await _sageService.Update(new Sage
                    {
                        Id = int.Parse(textSageId.Text),
                        Name = textName.Text,
                        Age = int.Parse(textAge.Text),
                        City = textCity.Text,
                        Photo = imgProfile.Image.ToByteArray(),
                        Books = _sagesBooks.DataSource as List<Book>
                    });
                    break;
            }

            infoPanel.Hide();
            FetchSages();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            infoPanel.Hide();
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            BrowseProfileImg();
        }

        private void BrowseProfileImg()
        {
            var open = new OpenFileDialog
            {
                Filter = @"Image Files(*.jpg; *.jpeg; *.bmp)|*.jpg; *.jpeg; *.bmp"
            };

            if (open.ShowDialog() == DialogResult.OK)
            {
                imgProfile.ImageLocation = open.FileName;
            }
        }

        private async void btnAddBook_Click(object sender, EventArgs e)
        {
            var selectedBooks = (_sagesBooks.DataSource as List<Book>)!.Select(s => s.Id);
            var availableBooks = await _bookService.GetBooksExcept(selectedBooks);

            using var modal = new AddBooksModal(availableBooks);
            var result = modal.ShowDialog(this);
            if (result == DialogResult.OK)
            {
                var books = (_sagesBooks.DataSource as List<Book>)!
                    .Concat(modal.SelectedBooks)
                    .ToList();
                FillSageBooks(books);
            }
        }

        private void dataGridViewSageBooks_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridViewSageBooks.Columns["removeBtn"]?.Index)
            {
                if (dataGridViewSageBooks.CurrentRow != null)
                {
                    dataGridViewSageBooks.Rows.Remove(dataGridViewSageBooks.CurrentRow);
                    dataGridViewSageBooks.Refresh();
                }
            }
        }

        private void dataGridViewSages_SelectionChanged(object sender, EventArgs e)
        {
            var isCellSelected = dataGridViewSages.SelectedCells.Count != 0;
            btnEdit.Enabled = isCellSelected;
            btnDelete.Enabled = isCellSelected;
        }

        #endregion

        private void textAge_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verify that the pressed key isn't CTRL or any non-numeric digit
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}

public enum Mode
{
    Add,
    Edit,
}