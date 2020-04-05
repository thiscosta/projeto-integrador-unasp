using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using wfaProjetoIntegrador.Controllers;


namespace wfaProjetoIntegrador.Views
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            txtUser.Focus();
        }
        
        private void btnLogin_Click(object sender, EventArgs e)
        {
            LoginController.login(txtUser.Text, txtPassword.Text);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
