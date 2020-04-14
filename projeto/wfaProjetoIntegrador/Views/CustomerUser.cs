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
    public partial class CustomerUser : UserControl
    {
        private static bool saving = false;
        List<TextBox> TextBoxes;
        Customer customer = new Customer();

        public CustomerUser()
        {
            InitializeComponent();
            TextBoxes = new List<TextBox> { 
                txtCustomerName, 
                txtCustomerAddress1, 
                txtCustomerAddress2, 
                txtCustomerPhone, 
                txtCustomerCpf,
                txtCustomerBirthday,
                txtCustomerEmail
            };
            customer = new Customer();
            CustomerUserController.list(dgvCustomer);
        }

        private void CustomerUser_Load(object sender, EventArgs e)
        {

        }

        private void btnCustomerInsert_Click(object sender, EventArgs e)
        {
            if (saving)
            {
                if (validateFields())
                    return;

                setCustomer();
                CustomerUserController.insert(customer);
                CustomerUserController.list(dgvCustomer);
                saving = false;

                btnCustomerInsert.Text = "Insert";
                disableFields();
            }
            else
            {
                saving = true;

                eraseFields();
                enableFields();

                btnCustomerInsert.Text = "Save";
            }
        }

        private void setCustomer()
        {
            customer.name = txtCustomerName.Text;
            customer.address1 = txtCustomerAddress1.Text;
            customer.address2 = txtCustomerAddress2.Text;
            customer.phone = txtCustomerPhone.Text;
            customer.cpf = txtCustomerCpf.Text;
            customer.birthdate = DateTime.Parse(txtCustomerBirthday.Text);
            customer.email = txtCustomerEmail.Text;
        }

        private void btnCustomerUpdate_Click(object sender, EventArgs e)
        {
            if (saving)
            {
                if (validateFields())
                    return;

                if (customValidateFields())
                    return;

                setCustomer();
                CustomerUserController.update(customer);
                CustomerUserController.list(dgvCustomer);
                saving = false;

                btnCustomerUpdate.Text = "Update";
                disableFields();
            }
            else
            {
                if(customer.id == 0)
                {
                    MessageBox.Show("Choose a record to update", "Error" , MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                saving = true;

                enableFields();

                btnCustomerUpdate.Text = "Save";
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
            if (!Regex.Match(txtCustomerBirthday.Text, @"^([0]?[0-9]|[12][0-9]|[3][01])[./-]([0]?[1-9]|[1][0-2])[./-]([0-9]{4}|[0-9]{2})$").Success)
            {
                errorProvider1.SetError(txtCustomerBirthday, "Invalid value (dd/mm/yyyy)");
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

        private void btnCustomerDelete_Click_1(object sender, EventArgs e)
        {
            if (customer.id == 0)
            {
                MessageBox.Show("Choose a record to delete", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var confirm = MessageBox.Show("Are you sure to delete this item?", "Confirm Delete", MessageBoxButtons.YesNo);
            if (confirm == DialogResult.Yes)
            {
                CustomerUserController.delete(customer);
                CustomerUserController.list(dgvCustomer);
                eraseFields();
            }
        }

        private void dgvCustomer_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Int32 catchRowIndex = dgvCustomer.SelectedCells[0].RowIndex;
            foreach (DataGridViewRow row in dgvCustomer.SelectedRows)
            {
                customer.id = Int32.Parse(row.Cells[0].Value.ToString());
                customer.cpf = row.Cells[1].Value.ToString();
                customer.name = row.Cells[2].Value.ToString();
                customer.phone = row.Cells[3].Value.ToString();
                customer.birthdate = DateTime.Parse(row.Cells[4].Value.ToString());
                customer.email = row.Cells[5].Value.ToString();
                customer.address1 = row.Cells[6].Value.ToString();
                customer.address2 = row.Cells[7].Value.ToString();
            }

            fillFields();
        }

        private void fillFields()
        {
            txtCustomerName.Text = customer.name;
            txtCustomerAddress1.Text = customer.address1;
            txtCustomerAddress2.Text = customer.address2;
            txtCustomerPhone.Text = customer.phone;
            txtCustomerCpf.Text = customer.cpf;
            txtCustomerBirthday.Text = customer.birthdate.ToString();
            txtCustomerEmail.Text = customer.email;
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
