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
    public partial class ServicesUser : UserControl
    {
        private static bool saving = false;
        List<TextBox> TextBoxes;
        Service service = new Service();

        public ServicesUser()
        {
            InitializeComponent();
            TextBoxes = new List<TextBox> {
                txtProductId,
                txtServiceDescription
            };
            ServicesUserController.list(dgvService);
        }

        private void btnServiceDelete_Click(object sender, EventArgs e)
        {
            if (service.id == 0)
            {
                MessageBox.Show("Choose a record to delete", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var confirm = MessageBox.Show("Are you sure to delete this item?", "Confirm Delete", MessageBoxButtons.YesNo);
            if (confirm == DialogResult.Yes)
            {
                ServicesUserController.delete(service);
                ServicesUserController.list(dgvService);
                eraseFields();
            }
        }

        private void btnServiceUpdate_Click(object sender, EventArgs e)
        {
            if (saving)
            {
                if (validateFields())
                    return;

                if (customValidateFields())
                    return;

                setService();
                ServicesUserController.update(service);
                ServicesUserController.list(dgvService);
                saving = false;

                btnServiceUpdate.Text = "Update";
                disableFields();
            }
            else
            {
                if (service.id == 0)
                {
                    MessageBox.Show("Choose a record to update", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                saving = true;

                enableFields();

                btnServiceUpdate.Text = "Save";
            }
        }

        private void btnServiceInsert_Click(object sender, EventArgs e)
        {
            if (saving)
            {
                if (validateFields())
                    return;

                setService();
                ServicesUserController.insert(service);
                ServicesUserController.list(dgvService);
                saving = false;

                btnServiceInsert.Text = "Insert";
                disableFields();
            }
            else
            {
                saving = true;

                eraseFields();
                enableFields();

                btnServiceInsert.Text = "Save";
            }
        }
        private bool customValidateFields()
        {
            bool hasError = false;
            setErrorsFalse();


            return hasError;
        }
        private void setService()
        {
            service.description = txtServiceDescription.Text;
        }

        private void enableFields()
        {
            foreach (TextBox field in TextBoxes)
            {
                if (field != txtProductId)
                    field.Enabled = true;
                else
                {
                    searchProduct.Enabled = true;
                }
            }
        }
        private void disableFields()
        {
            foreach (TextBox field in TextBoxes)
            {
                if (field != txtProductId)
                    field.Enabled = false;
                else
                {
                    searchProduct.Enabled = false;
                }
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
        private void setErrorsFalse()
        {

            foreach (TextBox field in TextBoxes)
            {
                errorProvider1.SetError(field, "");
            }
        }
        private void eraseFields()
        {
            foreach (TextBox field in TextBoxes)
            {
                field.Text = "";
            }
        }
        private void fillFields()
        {
            txtProductId.Text = ProductsUserController.find(service.productId).name;
            txtServiceDescription.Text = service.description;
        }

        private void dgvService_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Int32 catchRowIndex = dgvService.SelectedCells[0].RowIndex;
            foreach (DataGridViewRow row in dgvService.SelectedRows)
            {
                service.id = Int32.Parse(row.Cells[0].Value.ToString());
                service.productId = Int32.Parse(row.Cells[2].Value.ToString());
                service.description = row.Cells[3].Value.ToString();
            }

            fillFields();
        }
        
        private void searchProduct_Click(object sender, EventArgs e)
        {
            SearchForm s = new SearchForm(new SearchFormImplementation((int Id) =>
            {
                service.productId = Id;
                txtProductId.Text = ProductsUserController.find(Id).name;
            }),
            ProductsUserController.listAll().Cast<dynamic>().ToList());
            s.ShowDialog();
        }
    }
}
