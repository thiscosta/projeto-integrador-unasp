using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using wfaProjetoIntegrador.Controllers;
using wfaProjetoIntegrador.Models;
using wfaProjetoIntegrador.Repository;

namespace wfaProjetoIntegrador.Views
{
    public partial class SearchForm : Form
    {
        SearchFormInterface2 inter;
        int id;

        public SearchForm(SearchFormInterface2 inter, List<dynamic> list)
        {
            InitializeComponent();
            this.inter = inter;
            dgv.DataSource = list;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            inter.handleSelect(id);
            this.Close();
        }

        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            foreach (DataGridViewRow row in dgv.SelectedRows)
            {
                dgv.CurrentRow.Selected = true;
                id = Int32.Parse(row.Cells[0].Value.ToString());
            }
        }
    }
}
