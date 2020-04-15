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
                txtProductHub
            };
            prod = new Product();
            ProductsUserController.list(dgvProduct);
        }
        
        private void setProduct()
        {
            prod.name = txtProductName.Text;
            prod.sellPrice = Double.Parse(txtProductSalesPrice.Text);
            prod.company = txtProductCompany.Text;
            prod.quantity = Int32.Parse(txtProductHub.Text);
            prod.category = txtProductsCategory.Text;
            prod.buyprice = Double.Parse(txtProductPurchasePrice.Text);
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
        }
        
        private void fillFields()
        {
            txtProductName.Text = prod.name;
            txtProductSalesPrice.Text = prod.sellPrice.ToString();
            txtProductCompany.Text = prod.company;
            txtProductHub.Text = prod.quantity.ToString();
            txtProductsCategory.Text = prod.category;
            txtProductPurchasePrice.Text = prod.buyprice.ToString();
        }

        private void eraseFields()
        {
            foreach (TextBox field in TextBoxes)
            {
                field.Text = "";
            }
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

        private void dgvProduct_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Int32 catchRowIndex = dgvProduct.SelectedCells[0].RowIndex;
            foreach (DataGridViewRow row in dgvProduct.SelectedRows)
            {
                prod.id = Int32.Parse(row.Cells[0].Value.ToString());
                prod.name = row.Cells[1].Value.ToString();
                prod.sellPrice = Double.Parse(row.Cells[2].Value.ToString());
                prod.company = row.Cells[3].Value.ToString();
                prod.quantity = Int32.Parse(row.Cells[4].Value.ToString());
                prod.buyprice = Double.Parse(row.Cells[5].Value.ToString());
            }

            fillFields();
        }

        private void btnProductDelete_Click(object sender, EventArgs e)
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
    }
}
