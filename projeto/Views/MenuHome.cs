using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wfaProjetoIntegrador.Views
{
    public partial class MenuHome : Form
    {
  
        public MenuHome()
        {
            InitializeComponent();
            sidePanel.Height = btnHome.Height;
            sidePanel.Top = btnHome.Top;
            HomeUser1.BringToFront();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
 
        private void btnHome_Click(object sender, EventArgs e)
        {
            sidePanel.Height = btnHome.Height;
            sidePanel.Top = btnHome.Top;
            HomeUser1.BringToFront();
            btnPowerOff.BringToFront();
        }

        private void btnCustomers_Click(object sender, EventArgs e)
        {
            sidePanel.Height = btnCustomers.Height;
            sidePanel.Top = btnCustomers.Top;
            CustomerUserDB.BringToFront();
            btnPowerOff.BringToFront();
        }

        private void btnProducts_Click(object sender, EventArgs e)
        {
            sidePanel.Height = btnProducts.Height;
            sidePanel.Top = btnProducts.Top;
            ProductsUser1.BringToFront();
            btnPowerOff.BringToFront();
        }

        private void btnPowerOff_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnServices_Click(object sender, EventArgs e)
        {
            sidePanel.Height = btnServices.Height;
            sidePanel.Top = btnServices.Top;
            ServicesUser1.BringToFront();
            btnPowerOff.BringToFront();
        }

        private void btnSales_Click(object sender, EventArgs e)
        {
            sidePanel.Height = btnSales.Height;
            sidePanel.Top = btnSales.Top;
            SalesUser1.BringToFront();
            btnPowerOff.BringToFront();
        }

        private void btnBills_Click(object sender, EventArgs e)
        {
            sidePanel.Height = btnBills.Height;
            sidePanel.Top = btnBills.Top;
            BillUser1.BringToFront();
            btnPowerOff.BringToFront();
        }

        private void BillUser1_Load(object sender, EventArgs e)
        {

        }
    }
}
