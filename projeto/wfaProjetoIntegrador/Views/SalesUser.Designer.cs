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
            this.label9 = new System.Windows.Forms.Label();
            this.txtSalesPrice = new System.Windows.Forms.TextBox();
            this.lbl3 = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.lblProductCompany = new System.Windows.Forms.Label();
            this.lbPayment = new System.Windows.Forms.ListBox();
            this.lbInstallments = new System.Windows.Forms.ListBox();
            this.btnProductDelete = new System.Windows.Forms.Button();
            this.btnProductInsert = new System.Windows.Forms.Button();
            this.btnProductUpdate = new System.Windows.Forms.Button();
            this.dgvSales = new System.Windows.Forms.DataGridView();
            this.txtServiceId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.searchService = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSales)).BeginInit();
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
            this.txtSalesPrice.Location = new System.Drawing.Point(130, 200);
            this.txtSalesPrice.Name = "txtSalesPrice";
            this.txtSalesPrice.Size = new System.Drawing.Size(441, 23);
            this.txtSalesPrice.TabIndex = 58;
            // 
            // lbl3
            // 
            this.lbl3.AutoSize = true;
            this.lbl3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(37)))), ((int)(((byte)(47)))));
            this.lbl3.Location = new System.Drawing.Point(30, 269);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(87, 17);
            this.lbl3.TabIndex = 48;
            this.lbl3.Text = "Installments:";
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(37)))), ((int)(((byte)(47)))));
            this.lbl2.Location = new System.Drawing.Point(30, 234);
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
            this.lblProductCompany.Location = new System.Drawing.Point(30, 200);
            this.lblProductCompany.Name = "lblProductCompany";
            this.lblProductCompany.Size = new System.Drawing.Size(43, 17);
            this.lblProductCompany.TabIndex = 53;
            this.lblProductCompany.Text = "Price:";
            // 
            // lbPayment
            // 
            this.lbPayment.BackColor = System.Drawing.SystemColors.Window;
            this.lbPayment.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbPayment.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPayment.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(37)))), ((int)(((byte)(47)))));
            this.lbPayment.FormattingEnabled = true;
            this.lbPayment.ItemHeight = 17;
            this.lbPayment.Items.AddRange(new object[] {
            "Money",
            "Debit",
            "Credit"});
            this.lbPayment.Location = new System.Drawing.Point(130, 234);
            this.lbPayment.Name = "lbPayment";
            this.lbPayment.Size = new System.Drawing.Size(441, 19);
            this.lbPayment.TabIndex = 68;
            // 
            // lbInstallments
            // 
            this.lbInstallments.BackColor = System.Drawing.SystemColors.Window;
            this.lbInstallments.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbInstallments.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbInstallments.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(37)))), ((int)(((byte)(47)))));
            this.lbInstallments.FormattingEnabled = true;
            this.lbInstallments.ItemHeight = 17;
            this.lbInstallments.Items.AddRange(new object[] {
            "Cash",
            "1x",
            "2x",
            "3x",
            "4x",
            "5x",
            "6x",
            "7x",
            "8x",
            "9x",
            "10x",
            "11x",
            "12x"});
            this.lbInstallments.Location = new System.Drawing.Point(130, 269);
            this.lbInstallments.Name = "lbInstallments";
            this.lbInstallments.Size = new System.Drawing.Size(441, 19);
            this.lbInstallments.TabIndex = 68;
            // 
            // btnProductDelete
            // 
            this.btnProductDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(37)))), ((int)(((byte)(47)))));
            this.btnProductDelete.FlatAppearance.BorderSize = 0;
            this.btnProductDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProductDelete.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProductDelete.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnProductDelete.Location = new System.Drawing.Point(396, 309);
            this.btnProductDelete.Name = "btnProductDelete";
            this.btnProductDelete.Size = new System.Drawing.Size(175, 106);
            this.btnProductDelete.TabIndex = 69;
            this.btnProductDelete.Text = "Delete";
            this.btnProductDelete.UseVisualStyleBackColor = false;
            // 
            // btnProductInsert
            // 
            this.btnProductInsert.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(37)))), ((int)(((byte)(47)))));
            this.btnProductInsert.FlatAppearance.BorderSize = 0;
            this.btnProductInsert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProductInsert.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProductInsert.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnProductInsert.Location = new System.Drawing.Point(34, 309);
            this.btnProductInsert.Name = "btnProductInsert";
            this.btnProductInsert.Size = new System.Drawing.Size(175, 106);
            this.btnProductInsert.TabIndex = 71;
            this.btnProductInsert.Text = "Insert";
            this.btnProductInsert.UseVisualStyleBackColor = false;
            // 
            // btnProductUpdate
            // 
            this.btnProductUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(37)))), ((int)(((byte)(47)))));
            this.btnProductUpdate.FlatAppearance.BorderSize = 0;
            this.btnProductUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProductUpdate.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProductUpdate.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnProductUpdate.Location = new System.Drawing.Point(215, 309);
            this.btnProductUpdate.Name = "btnProductUpdate";
            this.btnProductUpdate.Size = new System.Drawing.Size(175, 106);
            this.btnProductUpdate.TabIndex = 70;
            this.btnProductUpdate.Text = "Update";
            this.btnProductUpdate.UseVisualStyleBackColor = false;
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
            this.txtServiceId.Location = new System.Drawing.Point(170, 166);
            this.txtServiceId.Name = "txtServiceId";
            this.txtServiceId.Size = new System.Drawing.Size(401, 23);
            this.txtServiceId.TabIndex = 74;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(37)))), ((int)(((byte)(47)))));
            this.label1.Location = new System.Drawing.Point(31, 165);
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
            this.searchService.Location = new System.Drawing.Point(131, 165);
            this.searchService.Name = "searchService";
            this.searchService.Size = new System.Drawing.Size(33, 23);
            this.searchService.TabIndex = 76;
            this.searchService.Text = "...";
            this.searchService.UseVisualStyleBackColor = false;
            // 
            // SalesUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.searchService);
            this.Controls.Add(this.txtServiceId);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvSales);
            this.Controls.Add(this.btnProductDelete);
            this.Controls.Add(this.btnProductUpdate);
            this.Controls.Add(this.btnProductInsert);
            this.Controls.Add(this.lbInstallments);
            this.Controls.Add(this.lbPayment);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtSalesPrice);
            this.Controls.Add(this.lbl3);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.lblProductCompany);
            this.Name = "SalesUser";
            this.Size = new System.Drawing.Size(1080, 573);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSales)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtSalesPrice;
        private System.Windows.Forms.Label lbl3;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Label lblProductCompany;
        private System.Windows.Forms.ListBox lbPayment;
        private System.Windows.Forms.ListBox lbInstallments;
        private System.Windows.Forms.Button btnProductDelete;
        private System.Windows.Forms.Button btnProductInsert;
        private System.Windows.Forms.Button btnProductUpdate;
        private System.Windows.Forms.DataGridView dgvSales;
        private System.Windows.Forms.TextBox txtServiceId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button searchService;
    }
}
