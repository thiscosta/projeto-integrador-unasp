namespace wfaProjetoIntegrador.Views
{
    partial class MenuHome
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuHome));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.sidePanel = new System.Windows.Forms.Panel();
            this.btnBills = new System.Windows.Forms.Button();
            this.btnSales = new System.Windows.Forms.Button();
            this.btnServices = new System.Windows.Forms.Button();
            this.btnProducts = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.btnCustomers = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnPowerOff = new System.Windows.Forms.Button();
            this.BillUser1 = new wfaProjetoIntegrador.Views.BillUser();
            this.SalesUser1 = new wfaProjetoIntegrador.Views.SalesUser();
            this.ServicesUser1 = new wfaProjetoIntegrador.Views.ServicesUser();
            this.ProductsUser1 = new wfaProjetoIntegrador.Views.ProductsUser();
            this.CustomerUserDB = new wfaProjetoIntegrador.Views.CustomerUser();
            this.HomeUser1 = new wfaProjetoIntegrador.Views.HomeUser();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(37)))), ((int)(((byte)(44)))));
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.sidePanel);
            this.panel1.Controls.Add(this.btnBills);
            this.panel1.Controls.Add(this.btnSales);
            this.panel1.Controls.Add(this.btnServices);
            this.panel1.Controls.Add(this.btnProducts);
            this.panel1.Controls.Add(this.btnHome);
            this.panel1.Controls.Add(this.btnCustomers);
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Name = "label2";
            // 
            // sidePanel
            // 
            this.sidePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(53)))), ((int)(((byte)(157)))));
            resources.ApplyResources(this.sidePanel, "sidePanel");
            this.sidePanel.Name = "sidePanel";
            // 
            // btnBills
            // 
            this.btnBills.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.btnBills, "btnBills");
            this.btnBills.ForeColor = System.Drawing.Color.White;
            this.btnBills.Image = global::wfaProjetoIntegrador.Properties.Resources.btnBills;
            this.btnBills.Name = "btnBills";
            this.btnBills.UseVisualStyleBackColor = true;
            this.btnBills.Click += new System.EventHandler(this.btnBills_Click);
            // 
            // btnSales
            // 
            this.btnSales.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.btnSales, "btnSales");
            this.btnSales.ForeColor = System.Drawing.Color.White;
            this.btnSales.Image = global::wfaProjetoIntegrador.Properties.Resources.btnSales;
            this.btnSales.Name = "btnSales";
            this.btnSales.UseVisualStyleBackColor = true;
            this.btnSales.Click += new System.EventHandler(this.btnSales_Click);
            // 
            // btnServices
            // 
            this.btnServices.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.btnServices, "btnServices");
            this.btnServices.ForeColor = System.Drawing.Color.White;
            this.btnServices.Image = global::wfaProjetoIntegrador.Properties.Resources.btnServices;
            this.btnServices.Name = "btnServices";
            this.btnServices.UseVisualStyleBackColor = true;
            this.btnServices.Click += new System.EventHandler(this.btnServices_Click);
            // 
            // btnProducts
            // 
            this.btnProducts.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.btnProducts, "btnProducts");
            this.btnProducts.ForeColor = System.Drawing.Color.White;
            this.btnProducts.Image = global::wfaProjetoIntegrador.Properties.Resources.btnProducts;
            this.btnProducts.Name = "btnProducts";
            this.btnProducts.UseVisualStyleBackColor = true;
            this.btnProducts.Click += new System.EventHandler(this.btnProducts_Click);
            // 
            // btnHome
            // 
            this.btnHome.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.btnHome, "btnHome");
            this.btnHome.ForeColor = System.Drawing.Color.White;
            this.btnHome.Image = global::wfaProjetoIntegrador.Properties.Resources.btnHome;
            this.btnHome.Name = "btnHome";
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // btnCustomers
            // 
            this.btnCustomers.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.btnCustomers, "btnCustomers");
            this.btnCustomers.ForeColor = System.Drawing.Color.White;
            this.btnCustomers.Image = global::wfaProjetoIntegrador.Properties.Resources.btnCustomer;
            this.btnCustomers.Name = "btnCustomers";
            this.btnCustomers.UseVisualStyleBackColor = true;
            this.btnCustomers.Click += new System.EventHandler(this.btnCustomers_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(53)))), ((int)(((byte)(157)))));
            resources.ApplyResources(this.panel2, "panel2");
            this.panel2.Name = "panel2";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(157)))));
            this.panel3.Controls.Add(this.pictureBox1);
            resources.ApplyResources(this.panel3, "panel3");
            this.panel3.Name = "panel3";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::wfaProjetoIntegrador.Properties.Resources.render_Softti;
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.btnPowerOff);
            this.panel5.Controls.Add(this.BillUser1);
            this.panel5.Controls.Add(this.SalesUser1);
            this.panel5.Controls.Add(this.ServicesUser1);
            this.panel5.Controls.Add(this.ProductsUser1);
            this.panel5.Controls.Add(this.CustomerUserDB);
            this.panel5.Controls.Add(this.HomeUser1);
            resources.ApplyResources(this.panel5, "panel5");
            this.panel5.Name = "panel5";
            // 
            // btnPowerOff
            // 
            this.btnPowerOff.BackColor = System.Drawing.SystemColors.Control;
            this.btnPowerOff.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.btnPowerOff, "btnPowerOff");
            this.btnPowerOff.ForeColor = System.Drawing.Color.Transparent;
            this.btnPowerOff.Image = global::wfaProjetoIntegrador.Properties.Resources.btnPowerOff;
            this.btnPowerOff.Name = "btnPowerOff";
            this.btnPowerOff.UseVisualStyleBackColor = false;
            this.btnPowerOff.Click += new System.EventHandler(this.btnPowerOff_Click);
            // 
            // BillUser1
            // 
            this.BillUser1.BackColor = System.Drawing.SystemColors.Control;
            resources.ApplyResources(this.BillUser1, "BillUser1");
            this.BillUser1.Name = "BillUser1";
            this.BillUser1.Load += new System.EventHandler(this.BillUser1_Load);
            // 
            // SalesUser1
            // 
            this.SalesUser1.BackColor = System.Drawing.SystemColors.Control;
            resources.ApplyResources(this.SalesUser1, "SalesUser1");
            this.SalesUser1.Name = "SalesUser1";
            // 
            // ServicesUser1
            // 
            this.ServicesUser1.BackColor = System.Drawing.SystemColors.Control;
            resources.ApplyResources(this.ServicesUser1, "ServicesUser1");
            this.ServicesUser1.Name = "ServicesUser1";
            // 
            // ProductsUser1
            // 
            this.ProductsUser1.BackColor = System.Drawing.SystemColors.Control;
            resources.ApplyResources(this.ProductsUser1, "ProductsUser1");
            this.ProductsUser1.Name = "ProductsUser1";
            // 
            // CustomerUserDB
            // 
            this.CustomerUserDB.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.CustomerUserDB.Cursor = System.Windows.Forms.Cursors.Arrow;
            resources.ApplyResources(this.CustomerUserDB, "CustomerUserDB");
            this.CustomerUserDB.Name = "CustomerUserDB";
            // 
            // HomeUser1
            // 
            resources.ApplyResources(this.HomeUser1, "HomeUser1");
            this.HomeUser1.Name = "HomeUser1";
            // 
            // MenuHome
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MenuHome";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnCustomers;
        private System.Windows.Forms.Button btnBills;
        private System.Windows.Forms.Button btnSales;
        private System.Windows.Forms.Button btnServices;
        private System.Windows.Forms.Button btnProducts;
        private System.Windows.Forms.Panel sidePanel;
        private System.Windows.Forms.Button btnPowerOff;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btnHome;
        private HomeUser HomeUser1;
        private CustomerUser CustomerUserDB;
        private ProductsUser ProductsUser1;
        private ServicesUser ServicesUser1;
        private SalesUser SalesUser1;
        private BillUser BillUser1;
    }
}

