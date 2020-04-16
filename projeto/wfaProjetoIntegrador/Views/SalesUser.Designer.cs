namespace wfaProjetoIntegrador.Views
{
    partial class SalesUser
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

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label9 = new System.Windows.Forms.Label();
            this.txtSalesPrice = new System.Windows.Forms.TextBox();
            this.lbl2 = new System.Windows.Forms.Label();
            this.lblProductCompany = new System.Windows.Forms.Label();
            this.lbPayment = new System.Windows.Forms.ListBox();
            this.btnSaleDelete = new System.Windows.Forms.Button();
            this.btnSaleInsert = new System.Windows.Forms.Button();
            this.btnSaleUpdate = new System.Windows.Forms.Button();
            this.dgvSales = new System.Windows.Forms.DataGridView();
            this.txtServiceId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.searchService = new System.Windows.Forms.Button();
            this.searchClient = new System.Windows.Forms.Button();
            this.txtClientId = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSales)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(37)))), ((int)(((byte)(47)))));
            this.label9.Location = new System.Drawing.Point(118, 35);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(437, 78);
            this.label9.TabIndex = 46;
            this.label9.Text = "Sales Control";
            // 
            // txtSalesPrice
            // 
            this.txtSalesPrice.BackColor = System.Drawing.SystemColors.Window;
            this.txtSalesPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSalesPrice.Enabled = false;
            this.txtSalesPrice.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSalesPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(37)))), ((int)(((byte)(47)))));
            this.txtSalesPrice.Location = new System.Drawing.Point(129, 217);
            this.txtSalesPrice.Name = "txtSalesPrice";
            this.txtSalesPrice.Size = new System.Drawing.Size(441, 23);
            this.txtSalesPrice.TabIndex = 58;
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(37)))), ((int)(((byte)(47)))));
            this.lbl2.Location = new System.Drawing.Point(29, 251);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(69, 17);
            this.lbl2.TabIndex = 47;
            this.lbl2.Text = "Payment:";
            // 
            // lblProductCompany
            // 
            this.lblProductCompany.AutoSize = true;
            this.lblProductCompany.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductCompany.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(37)))), ((int)(((byte)(47)))));
            this.lblProductCompany.Location = new System.Drawing.Point(29, 217);
            this.lblProductCompany.Name = "lblProductCompany";
            this.lblProductCompany.Size = new System.Drawing.Size(43, 17);
            this.lblProductCompany.TabIndex = 53;
            this.lblProductCompany.Text = "Price:";
            // 
            // lbPayment
            // 
            this.lbPayment.BackColor = System.Drawing.SystemColors.Window;
            this.lbPayment.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbPayment.Enabled = false;
            this.lbPayment.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPayment.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(37)))), ((int)(((byte)(47)))));
            this.lbPayment.FormattingEnabled = true;
            this.lbPayment.ItemHeight = 17;
            this.lbPayment.Items.AddRange(new object[] {
            "Money",
            "Debit",
            "Credit"});
            this.lbPayment.Location = new System.Drawing.Point(129, 251);
            this.lbPayment.Name = "lbPayment";
            this.lbPayment.Size = new System.Drawing.Size(441, 19);
            this.lbPayment.TabIndex = 68;
            // 
            // btnSaleDelete
            // 
            this.btnSaleDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(37)))), ((int)(((byte)(47)))));
            this.btnSaleDelete.FlatAppearance.BorderSize = 0;
            this.btnSaleDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaleDelete.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaleDelete.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSaleDelete.Location = new System.Drawing.Point(396, 292);
            this.btnSaleDelete.Name = "btnSaleDelete";
            this.btnSaleDelete.Size = new System.Drawing.Size(175, 106);
            this.btnSaleDelete.TabIndex = 69;
            this.btnSaleDelete.Text = "Delete";
            this.btnSaleDelete.UseVisualStyleBackColor = false;
            this.btnSaleDelete.Click += new System.EventHandler(this.btnSaleDelete_Click);
            // 
            // btnSaleInsert
            // 
            this.btnSaleInsert.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(37)))), ((int)(((byte)(47)))));
            this.btnSaleInsert.FlatAppearance.BorderSize = 0;
            this.btnSaleInsert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaleInsert.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaleInsert.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSaleInsert.Location = new System.Drawing.Point(34, 292);
            this.btnSaleInsert.Name = "btnSaleInsert";
            this.btnSaleInsert.Size = new System.Drawing.Size(175, 106);
            this.btnSaleInsert.TabIndex = 71;
            this.btnSaleInsert.Text = "Insert";
            this.btnSaleInsert.UseVisualStyleBackColor = false;
            this.btnSaleInsert.Click += new System.EventHandler(this.btnSaleInsert_Click);
            // 
            // btnSaleUpdate
            // 
            this.btnSaleUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(37)))), ((int)(((byte)(47)))));
            this.btnSaleUpdate.FlatAppearance.BorderSize = 0;
            this.btnSaleUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaleUpdate.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaleUpdate.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSaleUpdate.Location = new System.Drawing.Point(215, 292);
            this.btnSaleUpdate.Name = "btnSaleUpdate";
            this.btnSaleUpdate.Size = new System.Drawing.Size(175, 106);
            this.btnSaleUpdate.TabIndex = 70;
            this.btnSaleUpdate.Text = "Update";
            this.btnSaleUpdate.UseVisualStyleBackColor = false;
            this.btnSaleUpdate.Click += new System.EventHandler(this.btnSaleUpdate_Click);
            // 
            // dgvSales
            // 
            this.dgvSales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSales.Location = new System.Drawing.Point(594, 129);
            this.dgvSales.Name = "dgvSales";
            this.dgvSales.Size = new System.Drawing.Size(483, 409);
            this.dgvSales.TabIndex = 72;
            this.dgvSales.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSales_CellContentClick);
            // 
            // txtServiceId
            // 
            this.txtServiceId.BackColor = System.Drawing.SystemColors.Window;
            this.txtServiceId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtServiceId.Enabled = false;
            this.txtServiceId.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtServiceId.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(37)))), ((int)(((byte)(47)))));
            this.txtServiceId.Location = new System.Drawing.Point(169, 183);
            this.txtServiceId.Name = "txtServiceId";
            this.txtServiceId.Size = new System.Drawing.Size(401, 23);
            this.txtServiceId.TabIndex = 74;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(37)))), ((int)(((byte)(47)))));
            this.label1.Location = new System.Drawing.Point(30, 182);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 17);
            this.label1.TabIndex = 73;
            this.label1.Text = "Service:";
            // 
            // searchService
            // 
            this.searchService.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(37)))), ((int)(((byte)(47)))));
            this.searchService.Enabled = false;
            this.searchService.FlatAppearance.BorderSize = 0;
            this.searchService.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchService.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchService.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.searchService.Location = new System.Drawing.Point(130, 182);
            this.searchService.Name = "searchService";
            this.searchService.Size = new System.Drawing.Size(33, 23);
            this.searchService.TabIndex = 76;
            this.searchService.Text = "...";
            this.searchService.UseVisualStyleBackColor = false;
            this.searchService.Click += new System.EventHandler(this.searchService_Click);
            // 
            // searchClient
            // 
            this.searchClient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(37)))), ((int)(((byte)(47)))));
            this.searchClient.Enabled = false;
            this.searchClient.FlatAppearance.BorderSize = 0;
            this.searchClient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchClient.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchClient.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.searchClient.Location = new System.Drawing.Point(130, 144);
            this.searchClient.Name = "searchClient";
            this.searchClient.Size = new System.Drawing.Size(33, 23);
            this.searchClient.TabIndex = 81;
            this.searchClient.Text = "...";
            this.searchClient.UseVisualStyleBackColor = false;
            this.searchClient.Click += new System.EventHandler(this.searchClient_Click);
            // 
            // txtClientId
            // 
            this.txtClientId.BackColor = System.Drawing.SystemColors.Window;
            this.txtClientId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtClientId.Enabled = false;
            this.txtClientId.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClientId.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(37)))), ((int)(((byte)(47)))));
            this.txtClientId.Location = new System.Drawing.Point(169, 145);
            this.txtClientId.Name = "txtClientId";
            this.txtClientId.Size = new System.Drawing.Size(402, 23);
            this.txtClientId.TabIndex = 80;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(37)))), ((int)(((byte)(47)))));
            this.label10.Location = new System.Drawing.Point(30, 145);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(50, 17);
            this.label10.TabIndex = 79;
            this.label10.Text = "Client:";
            // 
            // errorProvider1
            // 
            this.errorProvider1.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider1.ContainerControl = this;
            // 
            // SalesUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.searchClient);
            this.Controls.Add(this.txtClientId);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.searchService);
            this.Controls.Add(this.txtServiceId);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvSales);
            this.Controls.Add(this.btnSaleDelete);
            this.Controls.Add(this.btnSaleUpdate);
            this.Controls.Add(this.btnSaleInsert);
            this.Controls.Add(this.lbPayment);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtSalesPrice);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.lblProductCompany);
            this.Name = "SalesUser";
            this.Size = new System.Drawing.Size(1080, 573);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSales)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtSalesPrice;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Label lblProductCompany;
        private System.Windows.Forms.ListBox lbPayment;
        private System.Windows.Forms.Button btnSaleDelete;
        private System.Windows.Forms.Button btnSaleInsert;
        private System.Windows.Forms.Button btnSaleUpdate;
        private System.Windows.Forms.DataGridView dgvSales;
        private System.Windows.Forms.TextBox txtServiceId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button searchService;
        private System.Windows.Forms.Button searchClient;
        private System.Windows.Forms.TextBox txtClientId;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}
