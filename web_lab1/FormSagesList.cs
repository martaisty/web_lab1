using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Cache;
using System.Text;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;
using web_lab1.Entities;

namespace web_lab1
{
    public partial class FormSagesList : Form
    {
        private readonly DatabaseContext _db;

        public FormSagesList(DatabaseContext db)
        {
            this._db = db;
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            ClearForm();
            textName.Focus();
        }

        private void ClearForm()
        {
            textName.Clear();
            textAge.Clear();
            textCity.Clear();
            imgProfile.Image = null;
        }

        private void bntSave_Click(object sender, EventArgs e)
        {
            _db.Sages.Add(new Sage
            {
                Age = int.Parse(textAge.Text),
                City = textCity.Text,
                Name = textName.Text,
                Photo = ImageToByteArray(imgProfile.Image)
            });
            _db.SaveChanges();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void FormSagesList_Load(object sender, EventArgs e)
        {
            dataGridViewSages.DataSource = this._db.Sages.ToList();
            dataGridViewSages.Columns.RemoveAt(3);
            dataGridViewSages.ClearSelection();
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

        public byte[] ImageToByteArray(System.Drawing.Image imageIn)
        {
            using var ms = new MemoryStream();
            imageIn.Save(ms, System.Drawing.Imaging.ImageFormat.Gif);

            return ms.ToArray();
        }

        public Image ByteArrayToImage(byte[] byteArrayIn)
        {
            using var ms = new MemoryStream(byteArrayIn);
            var returnImage = Image.FromStream(ms);

            return returnImage;
        }

        private void dataGridViewSages_SelectionChanged(object sender, EventArgs e)
        {
            var isCellSelected = dataGridViewSages.SelectedCells.Count != 0;
            btnEdit.Enabled = isCellSelected;
            btnDelete.Enabled = isCellSelected;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            var id = dataGridViewSages.CurrentRow!.Cells[0].Value as int?;
            var sage = this._db.Sages
                .Include(s => s.Books)
                .Single(s => s.Id == id);
            FillSageForm(sage);
        }

        private void FillSageForm(Sage sage)
        {
            textName.Text = sage.Name;
            textAge.Text = sage.Age.ToString();
            textCity.Text = sage.City;
            imgProfile.Image = ByteArrayToImage(sage.Photo);
            textSageId.Text = sage.Id.ToString();
            dataGridViewSageBooks.DataSource = sage.Books;
            if (dataGridViewSageBooks.Columns["removeBookBtn"] == null)
            {
                var button = new DataGridViewButtonColumn();
                {
                    button.Name = "removeBookBtn";
                    button.HeaderText = @"Remove";
                    button.Text = "Remove";
                    button.UseColumnTextForButtonValue = true;
                    this.dataGridViewSageBooks.Columns.Add(button);
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var id = dataGridViewSages.CurrentRow!.Cells[0].Value as int?;
            var sage = this._db.Sages.Find(id);
            this._db.Sages.Remove(sage);
            this._db.SaveChanges();
        }

        private void Sages_Selected(object sender, TabControlEventArgs e)
        {
            switch (Sages.SelectedTab.TabIndex)
            {
                case 0:
                    dataGridViewSages.DataSource = this._db.Sages.ToList();
                    dataGridViewSages.Columns.RemoveAt(3);
                    dataGridViewSages.ClearSelection();
                    break;
                case 1:
                    dataGridViewBooks.DataSource = this._db.Books.ToList();
                    dataGridViewBooks.ClearSelection();
                    break;
            }
        }

        private void btnBookSave_Click(object sender, EventArgs e)
        {
            _db.Books.Add(new Book
            {
                Name = textBookName.Text,
                Description = textBookDescription.Text
            });
            _db.SaveChanges();
        }

        private void dataGridViewSageBooks_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridViewSageBooks.Columns["removeBookBtn"]?.Index)
            {
                if (dataGridViewSageBooks.SelectedCells.Count == 0) return;
                var bookId = dataGridViewSageBooks.CurrentRow!.Cells["Id"].Value as int?;
                var sage = this._db.Sages
                        .Include(s => s.Books)
                        .Single(s => s.Id == int.Parse(textSageId.Text));
                var book = sage.Books.Find(b => b.Id == bookId);
                sage.Books.Remove(book);
                _db.Sages.Update(sage);
                _db.SaveChanges();
            }
        }
    }
}