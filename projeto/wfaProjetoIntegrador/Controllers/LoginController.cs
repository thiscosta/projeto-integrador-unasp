using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using wfaProjetoIntegrador.Views;
using wfaProjetoIntegrador.Models;
using wfaProjetoIntegrador.Repository;

namespace wfaProjetoIntegrador.Controllers
{
    class LoginController
    {
        private static UserRepository repo = new UserRepository();

        public static void login(String userName, String password)
        {
            if(validUserName(userName))
            {
                if(validPassword(userName, password))
                {
                    MenuHome menu = new MenuHome();
                    Login login = new Login();

                    login.Close();
                    menu.Show();
                }
                else
                {
                    MessageBox.Show("Senha inválida.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Usuário inválido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static Boolean validUserName(String userName)
        {
            List<Users> users = repo.queryBy(new Dictionary<string, dynamic> {
                { "email", userName }
            });

            return users.Count == 1;
        }

        public static Boolean validPassword(String userName, String password)
        {
            List<Users> users = repo.queryBy(new Dictionary<string, dynamic> {
                { "email", userName },
                { "password", password },
            });

            return users.Count == 1;
        }
    }
}
