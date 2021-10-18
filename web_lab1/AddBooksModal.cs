using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using web_lab1.Entities;

namespace web_lab1
{
    public partial class AddBooksModal : Form
    {
        public ImmutableList<Book> SelectedBooks { get; private set; } = ImmutableList<Book>.Empty;
        private readonly List<Book> _books;

        public AddBooksModal(List<Book> books)
        {
            _books = books;
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }

        private void AddBooksModal_Load(object sender, EventArgs e)
        {
            dataGridViewBooks.DataSource = _books;
            dataGridViewBooks.ClearSelection();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void dataGridViewBooks_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridViewBooks.Columns["Add"]?.Index)
            {
                if (dataGridViewBooks.CurrentRow is var row && row != null)
                {
                    var isSelected = !(bool) (row.Cells["Add"].Value ?? false);
                    row.Cells["Add"].Value = isSelected;
                    SelectedBooks = isSelected
                        ? SelectedBooks.Add(_books[row.Index])
                        : SelectedBooks.Remove(_books[row.Index]);
                }
            }
        }
    }
}