using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using wfaProjetoIntegrador.Controllers;
using wfaProjetoIntegrador.Models;
using wfaProjetoIntegrador.Repository;

namespace wfaProjetoIntegrador.Views
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent(); //Não mexe nessa classe
            txtUser.Focus();

            UserRepository repo = new UserRepository();
            List<Users> lista = repo.getAll();
            bool created = repo.create(new Users
            {
                name = "oi",
                email = "teste@email.com",
                password = "123"
            });
            bool updated = repo.update(2, new Users
            {
                name = "oi",
                email = "teste@email.com",
                password = "123"
            });
            Users user = repo.find(2);
            Users user3 = repo.findBy("id", 13);
            Users user2 = repo.findBy(new Dictionary<string, dynamic> {
                { "id", 13 },
                { "name", "oi" },
                { "email", "teste@email.com" },
                { "password", "123" }
            });
            List<Users> users = repo.queryBy(new Dictionary<string, dynamic> {
                { "email", "teste@email.com" }
            });
            bool deleted = repo.delete(8);
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
