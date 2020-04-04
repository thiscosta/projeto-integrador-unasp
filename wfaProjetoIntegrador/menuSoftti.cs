using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wfaProjetoIntegrador
{
    public partial class menuSoftti : Form
    {
  
        public menuSoftti()
        {
            InitializeComponent();
            sidePanel.Height = btnHome.Height;
            sidePanel.Top = btnHome.Top;
            homeUserControl1.BringToFront();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
 
        private void btnHome_Click(object sender, EventArgs e)
        {
            sidePanel.Height = btnHome.Height;
            sidePanel.Top = btnHome.Top;
            homeUserControl1.BringToFront();
        }

        private void btnCustomers_Click(object sender, EventArgs e)
        {
            sidePanel.Height = btnCustomers.Height;
            sidePanel.Top = btnCustomers.Top;
            customerUserControlDB.BringToFront();
        }

        private void btnProducts_Click(object sender, EventArgs e)
        {
            sidePanel.Height = btnProducts.Height;
            sidePanel.Top = btnProducts.Top;
            productsUserControl1.BringToFront();
        }

        private void btnPowerOff_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnServices_Click(object sender, EventArgs e)
        {
            sidePanel.Height = btnServices.Height;
            sidePanel.Top = btnServices.Top;
            servicesUserControl1.BringToFront();
        }

        private void btnSales_Click(object sender, EventArgs e)
        {
            sidePanel.Height = btnSales.Height;
            sidePanel.Top = btnSales.Top;
            salesUserControl1.BringToFront();
        }

        private void btnBills_Click(object sender, EventArgs e)
        {
            sidePanel.Height = btnBills.Height;
            sidePanel.Top = btnBills.Top;
            billsUsercontrol1.BringToFront();
        }
    }
}
