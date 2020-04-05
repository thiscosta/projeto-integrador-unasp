using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using wfaProjetoIntegrador.Views;

namespace wfaProjetoIntegrador.Controllers
{
    class LoginController
    {
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
            return true;
        }

        public static Boolean validPassword(String userName, String password)
        {
            return true;
        }
    }
}
