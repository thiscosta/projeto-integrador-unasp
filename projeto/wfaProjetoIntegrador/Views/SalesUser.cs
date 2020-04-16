using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using wfaProjetoIntegrador.Models;
using wfaProjetoIntegrador.Controllers;
using System.Text.RegularExpressions;

namespace wfaProjetoIntegrador.Views
{
    public partial class SalesUser : UserControl
    {
        private static bool saving = false;
        List<TextBox> TextBoxes;
        Sale sale = new Sale();

        public SalesUser()
        {
            InitializeComponent();
            TextBoxes = new List<TextBox> {
                txtClientId,
                txtServiceId,
                txtSalesPrice
            };
            SalesUserController.list(dgvSales);
        }

        private void dgvSales_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Int32 catchRowIndex = dgvSales.SelectedCells[0].RowIndex;
            foreach (DataGridViewRow row in dgvSales.SelectedRows)
            {
                sale.id = Int32.Parse(row.Cells[0].Value.ToString());
                sale.clientId = Int32.Parse(row.Cells[1].Value.ToString());
                sale.serviceId = Int32.Parse(row.Cells[2].Value.ToString());
                sale.payment = row.Cells[3].Value.ToString();
                sale.price = Double.Parse(row.Cells[3].Value.ToString());
            }

            fillFields();
        }
        private void setSale()
        {
            sale.payment = lbPayment.GetItemText(lbPayment.SelectedItem);
            sale.price = Double.Parse(txtSalesPrice.Text);
        }
        private void fillFields()
        {
            txtClientId.Text = CustomerUserController.find(sale.clientId).name;
            txtServiceId.Text = ServicesUserController.find(sale.serviceId).description;
            txtSalesPrice.Text = sale.price.ToString();
            lbPayment.SelectedItem = sale.payment;
        }

        private void searchClient_Click(object sender, EventArgs e)
        {
            SearchForm s = new SearchForm(new SearchFormImplementation((int Id) =>
            {
                sale.clientId = Id;
                txtClientId.Text = CustomerUserController.find(Id).name;
            }),
            CustomerUserController.listAll().Cast<dynamic>().ToList());

            s.ShowDialog();
        }

        private void btnSaleInsert_Click(object sender, EventArgs e)
        {
            if (saving)
            {
                if (validateFields())
                    return;

                setSale();
                SalesUserController.insert(sale);
                SalesUserController.list(dgvSales);
                saving = false;

                btnSaleInsert.Text = "Insert";
                disableFields();
            }
            else
            {
                saving = true;

                eraseFields();
                enableFields();

                btnSaleInsert.Text = "Save";
            }
        }

        private void btnSaleUpdate_Click(object sender, EventArgs e)
        {
            if (saving)
            {
                if (validateFields())
                    return;

                if (customValidateFields())
                    return;

                setSale();
                SalesUserController.update(sale);
                SalesUserController.list(dgvSales);
                saving = false;

                btnSaleUpdate.Text = "Update";
                disableFields();
            }
            else
            {
                if (sale.id == 0)
                {
                    MessageBox.Show("Choose a record to update", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                saving = true;

                enableFields();

                btnSaleUpdate.Text = "Save";
            }
        }

        private void btnSaleDelete_Click(object sender, EventArgs e)
        {
            if (sale.id == 0)
            {
                MessageBox.Show("Choose a record to delete", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var confirm = MessageBox.Show("Are you sure to delete this item?", "Confirm Delete", MessageBoxButtons.YesNo);
            if (confirm == DialogResult.Yes)
            {
                SalesUserController.delete(sale);
                SalesUserController.list(dgvSales);
                eraseFields();
            }
        }
        private void eraseFields()
        {
            foreach (TextBox field in TextBoxes)
            {
                field.Text = "";
            }
        }
        private bool customValidateFields()
        {
            bool hasError = false;
            setErrorsFalse();


            return hasError;
        }
        private void enableFields()
        {
            foreach (TextBox field in TextBoxes)
            {
                if (field != txtClientId && field != txtServiceId)
                    field.Enabled = true;
                else
                {
                    searchClient.Enabled = true;
                    searchService.Enabled = true;
                }
            }

            lbPayment.Enabled = true;
        }
        private void disableFields()
        {
            foreach (TextBox field in TextBoxes)
            {
                if (field != txtClientId && field != txtServiceId)
                    field.Enabled = false;
                else
                {
                    searchClient.Enabled = false;
                    searchService.Enabled = false;
                }
            }

            lbPayment.Enabled = false;
        }
        private bool validateFields()
        {
            bool hasError = false;
            setErrorsFalse();

            foreach (TextBox field in TextBoxes)
            {
                if (String.IsNullOrEmpty(field.Text))
                {
                    errorProvider1.SetError(field, "Required Field");
                    hasError = true;
                }
            }

            if (lbPayment.SelectedItem == null)
            {
                errorProvider1.SetError(lbPayment, "Required Field");
                hasError = true;
            }

            return hasError;
        }
        private void setErrorsFalse()
        {

            foreach (TextBox field in TextBoxes)
            {
                errorProvider1.SetError(field, "");
            }
        }

        private void searchService_Click(object sender, EventArgs e)
        {
            if(sale.clientId == 0) { 
                MessageBox.Show("Choose a client first", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            SearchForm s = new SearchForm(new SearchFormImplementation((int Id) =>
            {
                sale.serviceId = Id;
                txtServiceId.Text = CustomerUserController.find(Id).name;
            }),
            ServicesUserController.listAll().Cast<dynamic>().ToList());

            s.ShowDialog();
        }
    }
}
