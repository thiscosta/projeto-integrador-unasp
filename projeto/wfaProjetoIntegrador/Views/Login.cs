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
            InitializeComponent();
            txtUser.Focus();

            UserRepository repo = new UserRepository();
            var lista = repo.getAll();
            Console.WriteLine(lista.Count);

            var usuario = new Users { name = "teste via c#", email = "teste", password = "teste" };

            List<String> teste = typeof(Users).GetProperties().Select(f => f.Name).ToList();
            teste.Remove("id");
            string stringona = "INSERT INTO users(" + string.Join(",", teste) + ") values (";
            foreach(var field in teste)
            {
                stringona += usuario.GetType().GetProperty(field).GetValue(usuario);

                if(teste.IndexOf(field) != (teste.Count - 1))
                {
                    stringona += ", ";
                }
            }
            Console.WriteLine(stringona+");");
            teste.ToString();
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
