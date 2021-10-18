using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using web_lab1.Entities;

namespace web_lab1
{
    public partial class AddSagesModal : Form
    {
        public ImmutableList<Sage> SelectedSages { get; private set; } = ImmutableList<Sage>.Empty;
        private readonly List<Sage> _sages;

        public AddSagesModal(List<Sage> sages)
        {
            _sages = sages;
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }

        private void AddSagesModal_Load(object sender, EventArgs e)
        {
            dataGridViewSages.DataSource = _sages;
            dataGridViewSages.Columns.Remove("Photo");
            dataGridViewSages.ClearSelection();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void dataGridViewSages_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridViewSages.Columns["Add"]?.Index)
            {
                if (dataGridViewSages.CurrentRow is var row && row != null)
                {
                    var isSelected = !(bool) (row.Cells["Add"].Value ?? false);
                    row.Cells["Add"].Value = isSelected;
                    SelectedSages = isSelected
                        ? SelectedSages.Add(_sages[row.Index])
                        : SelectedSages.Remove(_sages[row.Index]);
                }
            }
        }

        private void dataGridViewSages_SelectionChanged(object sender, EventArgs e)
        {
            imgProfile.Image = dataGridViewSages.CurrentRow?.Selected == true
                ? _sages[dataGridViewSages.CurrentRow!.Index].Photo.ToImage()
                : null;
        }
    }
}