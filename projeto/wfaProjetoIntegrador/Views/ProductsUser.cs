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
    public partial class ProductsUser : UserControl
    {
        private static bool saving = false;
        List<TextBox> TextBoxes;
        Product prod = new Product();

        public ProductsUser()
        {
            InitializeComponent();
            TextBoxes = new List<TextBox> {
                txtProductName,
                txtProductCompany,
                txtProductsCategory,
                txtProductPurchasePrice,
                txtProductSalesPrice,
                txtProductHub,
                txtDueDate
            };
            prod = new Product();
            ProductsUserController.list(dgvProduct);
        }

        private void ProductUser_Load(object sender, EventArgs e)
        {

        }

        private void btnProductInsert_Click(object sender, EventArgs e)
        {
            if (saving)
            {
                if (validateFields())
                    return;

                setProduct();
                ProductsUserController.insert(prod);
                ProductsUserController.list(dgvProduct);
                saving = false;

                btnProductInsert.Text = "Insert";
                disableFields();
            }
            else
            {
                saving = true;

                eraseFields();
                enableFields();

                btnProductInsert.Text = "Save";
            }
        }

        private void setProduct()
        {
            prod.name = txtProductName.Text;
            prod.address1 = txtProductAddress1.Text;
            prod.address2 = txtProductAddress2.Text;
            prod.phone = txtProductPhone.Text;
            prod.cpf = txtProductCpf.Text;
            prod.birthdate = DateTime.Parse(txtProductBirthday.Text);
            prod.email = txtProductEmail.Text;
        }

        private void btnProductUpdate_Click(object sender, EventArgs e)
        {
            if (saving)
            {
                if (validateFields())
                    return;

                if (customValidateFields())
                    return;

                setProduct();
                ProductsUserController.update(prod);
                ProductsUserController.list(dgvProduct);
                saving = false;

                btnProductUpdate.Text = "Update";
                disableFields();
            }
            else
            {
                if (prod.id == 0)
                {
                    MessageBox.Show("Choose a record to update", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                saving = true;

                enableFields();

                btnProductUpdate.Text = "Save";
            }
        }
        private void enableFields()
        {
            foreach (TextBox field in TextBoxes)
            {
                field.Enabled = true;
            }
        }
        private void disableFields()
        {
            foreach (TextBox field in TextBoxes)
            {
                field.Enabled = false;
            }
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

            return hasError;
        }

        private bool customValidateFields()
        {
            bool hasError = false;
            setErrorsFalse();
            if (!Regex.Match(txtProductBirthday.Text, @"^([0]?[0-9]|[12][0-9]|[3][01])[./-]([0]?[1-9]|[1][0-2])[./-]([0-9]{4}|[0-9]{2})$").Success)
            {
                errorProvider1.SetError(txtProductBirthday, "Invalid value (dd/mm/yyyy)");
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

        private void btnProductDelete_Click_1(object sender, EventArgs e)
        {
            if (prod.id == 0)
            {
                MessageBox.Show("Choose a record to delete", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var confirm = MessageBox.Show("Are you sure to delete this item?", "Confirm Delete", MessageBoxButtons.YesNo);
            if (confirm == DialogResult.Yes)
            {
                ProductsUserController.delete(prod);
                ProductsUserController.list(dgvProduct);
                eraseFields();
            }
        }

        private void dgvProduct_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Int32 catchRowIndex = dgvProduct.SelectedCells[0].RowIndex;
            foreach (DataGridViewRow row in dgvProduct.SelectedRows)
            {
                prod.id = Int32.Parse(row.Cells[0].Value.ToString());
                prod.cpf = row.Cells[1].Value.ToString();
                prod.name = row.Cells[2].Value.ToString();
                prod.phone = row.Cells[3].Value.ToString();
                prod.birthdate = DateTime.Parse(row.Cells[4].Value.ToString());
                prod.email = row.Cells[5].Value.ToString();
                prod.address1 = row.Cells[6].Value.ToString();
                prod.address2 = row.Cells[7].Value.ToString();
            }

            fillFields();
        }

        private void fillFields()
        {
            txtProductName.Text = prod.name;
            txtProductAddress1.Text = prod.address1;
            txtProductAddress2.Text = prod.address2;
            txtProductPhone.Text = prod.phone;
            txtProductCpf.Text = prod.cpf;
            txtProductBirthday.Text = prod.birthdate.ToString();
            txtProductEmail.Text = prod.email;
        }

        private void eraseFields()
        {
            foreach (TextBox field in TextBoxes)
            {
                field.Text = "";
            }
        }
    }
}
