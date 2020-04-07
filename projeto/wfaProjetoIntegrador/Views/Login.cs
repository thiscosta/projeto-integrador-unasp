using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using wfaProjetoIntegrador.Controllers;
using wfaProjetoIntegrador.Models;
using wfaProjetoIntegrador.Repository;
using wfaProjetoIntegrador.Util;

namespace wfaProjetoIntegrador.Views
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            txtUser.Focus();

            UserRepository repo = new UserRepository();
            var lista = repo.getAll();
            Console.WriteLine(lista.Count);

            bool updated = repo.update(2, new Users
            {
                name = "oi",
                email = "teste@email.com",
                password = "123"
            });

            Users user = repo.find(2);

            Console.WriteLine("updated: " + updated);
            Console.WriteLine("user: " + user.email);

            repo.delete(8);
            repo.delete(3);
            repo.delete(4);
            repo.delete(5);
            repo.delete(6);
            repo.delete(7);
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
