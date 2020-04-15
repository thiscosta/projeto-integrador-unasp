namespace wfaProjetoIntegrador.Views
{
    partial class ProductsUser
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
            this.dgvProduct = new System.Windows.Forms.DataGridView();
            this.txtProductHub = new System.Windows.Forms.TextBox();
            this.txtProductSalesPrice = new System.Windows.Forms.TextBox();
            this.txtProductPurchasePrice = new System.Windows.Forms.TextBox();
            this.txtProductsCategory = new System.Windows.Forms.TextBox();
            this.txtProductCompany = new System.Windows.Forms.TextBox();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.btnProductDelete = new System.Windows.Forms.Button();
            this.btnProductUpdate = new System.Windows.Forms.Button();
            this.btnProductInsert = new System.Windows.Forms.Button();
            this.lbl5 = new System.Windows.Forms.Label();
            this.lbl4 = new System.Windows.Forms.Label();
            this.lbl3 = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.lblProductCompany = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(37)))), ((int)(((byte)(47)))));
            this.label9.Location = new System.Drawing.Point(118, 30);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(549, 78);
            this.label9.TabIndex = 24;
            this.label9.Text = "Products Control";
            // 
            // dgvProduct
            // 
            this.dgvProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProduct.Location = new System.Drawing.Point(594, 145);
            this.dgvProduct.Name = "dgvProduct";
            this.dgvProduct.Size = new System.Drawing.Size(483, 409);
            this.dgvProduct.TabIndex = 44;
            this.dgvProduct.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProduct_CellContentClick);
            // 
            // txtProductHub
            // 
            this.txtProductHub.BackColor = System.Drawing.SystemColors.Window;
            this.txtProductHub.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtProductHub.Enabled = false;
            this.txtProductHub.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProductHub.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(37)))), ((int)(((byte)(47)))));
            this.txtProductHub.Location = new System.Drawing.Point(130, 320);
            this.txtProductHub.Name = "txtProductHub";
            this.txtProductHub.Size = new System.Drawing.Size(441, 23);
            this.txtProductHub.TabIndex = 39;
            // 
            // txtProductSalesPrice
            // 
            this.txtProductSalesPrice.BackColor = System.Drawing.SystemColors.Window;
            this.txtProductSalesPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtProductSalesPrice.Enabled = false;
            this.txtProductSalesPrice.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProductSalesPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(37)))), ((int)(((byte)(47)))));
            this.txtProductSalesPrice.Location = new System.Drawing.Point(130, 285);
            this.txtProductSalesPrice.Name = "txtProductSalesPrice";
            this.txtProductSalesPrice.Size = new System.Drawing.Size(441, 23);
            this.txtProductSalesPrice.TabIndex = 38;
            // 
            // txtProductPurchasePrice
            // 
            this.txtProductPurchasePrice.BackColor = System.Drawing.SystemColors.Window;
            this.txtProductPurchasePrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtProductPurchasePrice.Enabled = false;
            this.txtProductPurchasePrice.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProductPurchasePrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(37)))), ((int)(((byte)(47)))));
            this.txtProductPurchasePrice.Location = new System.Drawing.Point(130, 250);
            this.txtProductPurchasePrice.Name = "txtProductPurchasePrice";
            this.txtProductPurchasePrice.Size = new System.Drawing.Size(441, 23);
            this.txtProductPurchasePrice.TabIndex = 37;
            // 
            // txtProductsCategory
            // 
            this.txtProductsCategory.BackColor = System.Drawing.SystemColors.Window;
            this.txtProductsCategory.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtProductsCategory.Enabled = false;
            this.txtProductsCategory.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProductsCategory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(37)))), ((int)(((byte)(47)))));
            this.txtProductsCategory.Location = new System.Drawing.Point(130, 215);
            this.txtProductsCategory.Name = "txtProductsCategory";
            this.txtProductsCategory.Size = new System.Drawing.Size(441, 23);
            this.txtProductsCategory.TabIndex = 42;
            // 
            // txtProductCompany
            // 
            this.txtProductCompany.BackColor = System.Drawing.SystemColors.Window;
            this.txtProductCompany.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtProductCompany.Enabled = false;
            this.txtProductCompany.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProductCompany.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(37)))), ((int)(((byte)(47)))));
            this.txtProductCompany.Location = new System.Drawing.Point(130, 181);
            this.txtProductCompany.Name = "txtProductCompany";
            this.txtProductCompany.Size = new System.Drawing.Size(441, 23);
            this.txtProductCompany.TabIndex = 36;
            // 
            // txtProductName
            // 
            this.txtProductName.BackColor = System.Drawing.SystemColors.Window;
            this.txtProductName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtProductName.Enabled = false;
            this.txtProductName.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProductName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(37)))), ((int)(((byte)(47)))));
            this.txtProductName.Location = new System.Drawing.Point(130, 145);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(441, 23);
            this.txtProductName.TabIndex = 43;
            // 
            // btnProductDelete
            // 
            this.btnProductDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(37)))), ((int)(((byte)(47)))));
            this.btnProductDelete.FlatAppearance.BorderSize = 0;
            this.btnProductDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProductDelete.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProductDelete.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnProductDelete.Location = new System.Drawing.Point(396, 422);
            this.btnProductDelete.Name = "btnProductDelete";
            this.btnProductDelete.Size = new System.Drawing.Size(175, 106);
            this.btnProductDelete.TabIndex = 33;
            this.btnProductDelete.Text = "Delete";
            this.btnProductDelete.UseVisualStyleBackColor = false;
            this.btnProductDelete.Click += new System.EventHandler(this.btnProductDelete_Click);
            // 
            // btnProductUpdate
            // 
            this.btnProductUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(37)))), ((int)(((byte)(47)))));
            this.btnProductUpdate.FlatAppearance.BorderSize = 0;
            this.btnProductUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProductUpdate.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProductUpdate.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnProductUpdate.Location = new System.Drawing.Point(215, 422);
            this.btnProductUpdate.Name = "btnProductUpdate";
            this.btnProductUpdate.Size = new System.Drawing.Size(175, 106);
            this.btnProductUpdate.TabIndex = 34;
            this.btnProductUpdate.Text = "Update";
            this.btnProductUpdate.UseVisualStyleBackColor = false;
            this.btnProductUpdate.Click += new System.EventHandler(this.btnProductUpdate_Click);
            // 
            // btnProductInsert
            // 
            this.btnProductInsert.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(37)))), ((int)(((byte)(47)))));
            this.btnProductInsert.FlatAppearance.BorderSize = 0;
            this.btnProductInsert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProductInsert.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProductInsert.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnProductInsert.Location = new System.Drawing.Point(34, 422);
            this.btnProductInsert.Name = "btnProductInsert";
            this.btnProductInsert.Size = new System.Drawing.Size(175, 106);
            this.btnProductInsert.TabIndex = 35;
            this.btnProductInsert.Text = "Insert";
            this.btnProductInsert.UseVisualStyleBackColor = false;
            this.btnProductInsert.Click += new System.EventHandler(this.btnProductInsert_Click);
            // 
            // lbl5
            // 
            this.lbl5.AutoSize = true;
            this.lbl5.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(37)))), ((int)(((byte)(47)))));
            this.lbl5.Location = new System.Drawing.Point(30, 320);
            this.lbl5.Name = "lbl5";
            this.lbl5.Size = new System.Drawing.Size(97, 17);
            this.lbl5.TabIndex = 28;
            this.lbl5.Text = "Hub Quantity:";
            // 
            // lbl4
            // 
            this.lbl4.AutoSize = true;
            this.lbl4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(37)))), ((int)(((byte)(47)))));
            this.lbl4.Location = new System.Drawing.Point(30, 285);
            this.lbl4.Name = "lbl4";
            this.lbl4.Size = new System.Drawing.Size(78, 17);
            this.lbl4.TabIndex = 27;
            this.lbl4.Text = "Sales Price:";
            // 
            // lbl3
            // 
            this.lbl3.AutoSize = true;
            this.lbl3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(37)))), ((int)(((byte)(47)))));
            this.lbl3.Location = new System.Drawing.Point(30, 250);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(105, 17);
            this.lbl3.TabIndex = 26;
            this.lbl3.Text = "Purchase Price:";
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(37)))), ((int)(((byte)(47)))));
            this.lbl2.Location = new System.Drawing.Point(30, 215);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(73, 17);
            this.lbl2.TabIndex = 25;
            this.lbl2.Text = "Category:";
            // 
            // lblProductCompany
            // 
            this.lblProductCompany.AutoSize = true;
            this.lblProductCompany.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductCompany.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(37)))), ((int)(((byte)(47)))));
            this.lblProductCompany.Location = new System.Drawing.Point(30, 180);
            this.lblProductCompany.Name = "lblProductCompany";
            this.lblProductCompany.Size = new System.Drawing.Size(77, 17);
            this.lblProductCompany.TabIndex = 31;
            this.lblProductCompany.Text = "Company:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(37)))), ((int)(((byte)(47)))));
            this.label10.Location = new System.Drawing.Point(30, 145);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(52, 17);
            this.label10.TabIndex = 32;
            this.label10.Text = "Name:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::wfaProjetoIntegrador.Properties.Resources.blueProductBox;
            this.pictureBox1.Location = new System.Drawing.Point(-38, -5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(187, 120);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 45;
            this.pictureBox1.TabStop = false;
            // 
            // errorProvider1
            // 
            this.errorProvider1.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider1.ContainerControl = this;
            // 
            // ProductsUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.label9);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dgvProduct);
            this.Controls.Add(this.txtProductHub);
            this.Controls.Add(this.txtProductSalesPrice);
            this.Controls.Add(this.txtProductPurchasePrice);
            this.Controls.Add(this.txtProductsCategory);
            this.Controls.Add(this.txtProductCompany);
            this.Controls.Add(this.txtProductName);
            this.Controls.Add(this.btnProductDelete);
            this.Controls.Add(this.btnProductUpdate);
            this.Controls.Add(this.btnProductInsert);
            this.Controls.Add(this.lbl5);
            this.Controls.Add(this.lbl4);
            this.Controls.Add(this.lbl3);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.lblProductCompany);
            this.Controls.Add(this.label10);
            this.Name = "ProductsUser";
            this.Size = new System.Drawing.Size(1080, 573);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dgvProduct;
        private System.Windows.Forms.TextBox txtProductHub;
        private System.Windows.Forms.TextBox txtProductSalesPrice;
        private System.Windows.Forms.TextBox txtProductPurchasePrice;
        private System.Windows.Forms.TextBox txtProductsCategory;
        private System.Windows.Forms.TextBox txtProductCompany;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.Button btnProductDelete;
        private System.Windows.Forms.Button btnProductUpdate;
        private System.Windows.Forms.Button btnProductInsert;
        private System.Windows.Forms.Label lbl5;
        private System.Windows.Forms.Label lbl4;
        private System.Windows.Forms.Label lbl3;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Label lblProductCompany;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}
