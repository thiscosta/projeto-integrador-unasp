namespace wfaProjetoIntegrador.Views
{
    partial class ServicesUser
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
            this.dgvService = new System.Windows.Forms.DataGridView();
            this.txtServiceDescription = new System.Windows.Forms.TextBox();
            this.btnServiceDelete = new System.Windows.Forms.Button();
            this.btnServiceUpdate = new System.Windows.Forms.Button();
            this.btnServiceInsert = new System.Windows.Forms.Button();
            this.lblProductCompany = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.searchProduct = new System.Windows.Forms.Button();
            this.txtProductId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvService)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            this.label9.Size = new System.Drawing.Size(532, 78);
            this.label9.TabIndex = 46;
            this.label9.Text = "Services Control";
            // 
            // dgvService
            // 
            this.dgvService.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvService.Location = new System.Drawing.Point(594, 154);
            this.dgvService.Name = "dgvService";
            this.dgvService.Size = new System.Drawing.Size(483, 409);
            this.dgvService.TabIndex = 66;
            this.dgvService.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvService_CellContentClick);
            // 
            // txtServiceDescription
            // 
            this.txtServiceDescription.BackColor = System.Drawing.SystemColors.Window;
            this.txtServiceDescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtServiceDescription.Enabled = false;
            this.txtServiceDescription.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtServiceDescription.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(37)))), ((int)(((byte)(47)))));
            this.txtServiceDescription.Location = new System.Drawing.Point(131, 229);
            this.txtServiceDescription.Name = "txtServiceDescription";
            this.txtServiceDescription.Size = new System.Drawing.Size(441, 23);
            this.txtServiceDescription.TabIndex = 58;
            // 
            // btnServiceDelete
            // 
            this.btnServiceDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(37)))), ((int)(((byte)(47)))));
            this.btnServiceDelete.FlatAppearance.BorderSize = 0;
            this.btnServiceDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnServiceDelete.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnServiceDelete.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnServiceDelete.Location = new System.Drawing.Point(398, 273);
            this.btnServiceDelete.Name = "btnServiceDelete";
            this.btnServiceDelete.Size = new System.Drawing.Size(175, 106);
            this.btnServiceDelete.TabIndex = 55;
            this.btnServiceDelete.Text = "Delete";
            this.btnServiceDelete.UseVisualStyleBackColor = false;
            this.btnServiceDelete.Click += new System.EventHandler(this.btnServiceDelete_Click);
            // 
            // btnServiceUpdate
            // 
            this.btnServiceUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(37)))), ((int)(((byte)(47)))));
            this.btnServiceUpdate.FlatAppearance.BorderSize = 0;
            this.btnServiceUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnServiceUpdate.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnServiceUpdate.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnServiceUpdate.Location = new System.Drawing.Point(217, 273);
            this.btnServiceUpdate.Name = "btnServiceUpdate";
            this.btnServiceUpdate.Size = new System.Drawing.Size(175, 106);
            this.btnServiceUpdate.TabIndex = 56;
            this.btnServiceUpdate.Text = "Update";
            this.btnServiceUpdate.UseVisualStyleBackColor = false;
            this.btnServiceUpdate.Click += new System.EventHandler(this.btnServiceUpdate_Click);
            // 
            // btnServiceInsert
            // 
            this.btnServiceInsert.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(37)))), ((int)(((byte)(47)))));
            this.btnServiceInsert.FlatAppearance.BorderSize = 0;
            this.btnServiceInsert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnServiceInsert.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnServiceInsert.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnServiceInsert.Location = new System.Drawing.Point(36, 273);
            this.btnServiceInsert.Name = "btnServiceInsert";
            this.btnServiceInsert.Size = new System.Drawing.Size(175, 106);
            this.btnServiceInsert.TabIndex = 57;
            this.btnServiceInsert.Text = "Insert";
            this.btnServiceInsert.UseVisualStyleBackColor = false;
            this.btnServiceInsert.Click += new System.EventHandler(this.btnServiceInsert_Click);
            // 
            // lblProductCompany
            // 
            this.lblProductCompany.AutoSize = true;
            this.lblProductCompany.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductCompany.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(37)))), ((int)(((byte)(47)))));
            this.lblProductCompany.Location = new System.Drawing.Point(31, 228);
            this.lblProductCompany.Name = "lblProductCompany";
            this.lblProductCompany.Size = new System.Drawing.Size(84, 17);
            this.lblProductCompany.TabIndex = 53;
            this.lblProductCompany.Text = "Description:";
            // 
            // errorProvider1
            // 
            this.errorProvider1.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider1.ContainerControl = this;
            // 
            // searchProduct
            // 
            this.searchProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(37)))), ((int)(((byte)(47)))));
            this.searchProduct.Enabled = false;
            this.searchProduct.FlatAppearance.BorderSize = 0;
            this.searchProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchProduct.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchProduct.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.searchProduct.Location = new System.Drawing.Point(132, 191);
            this.searchProduct.Name = "searchProduct";
            this.searchProduct.Size = new System.Drawing.Size(33, 23);
            this.searchProduct.TabIndex = 81;
            this.searchProduct.Text = "...";
            this.searchProduct.UseVisualStyleBackColor = false;
            this.searchProduct.Click += new System.EventHandler(this.searchProduct_Click);
            // 
            // txtProductId
            // 
            this.txtProductId.BackColor = System.Drawing.SystemColors.Window;
            this.txtProductId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtProductId.Enabled = false;
            this.txtProductId.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProductId.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(37)))), ((int)(((byte)(47)))));
            this.txtProductId.Location = new System.Drawing.Point(171, 192);
            this.txtProductId.Name = "txtProductId";
            this.txtProductId.Size = new System.Drawing.Size(402, 23);
            this.txtProductId.TabIndex = 80;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(37)))), ((int)(((byte)(47)))));
            this.label1.Location = new System.Drawing.Point(32, 192);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 17);
            this.label1.TabIndex = 79;
            this.label1.Text = "Product:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::wfaProjetoIntegrador.Properties.Resources.blueServices;
            this.pictureBox1.Location = new System.Drawing.Point(-62, -8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(254, 151);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 67;
            this.pictureBox1.TabStop = false;
            // 
            // ServicesUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.searchProduct);
            this.Controls.Add(this.txtProductId);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dgvService);
            this.Controls.Add(this.txtServiceDescription);
            this.Controls.Add(this.btnServiceDelete);
            this.Controls.Add(this.btnServiceUpdate);
            this.Controls.Add(this.btnServiceInsert);
            this.Controls.Add(this.lblProductCompany);
            this.Name = "ServicesUser";
            this.Size = new System.Drawing.Size(1080, 573);
            ((System.ComponentModel.ISupportInitialize)(this.dgvService)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dgvService;
        private System.Windows.Forms.TextBox txtServiceDescription;
        private System.Windows.Forms.Button btnServiceDelete;
        private System.Windows.Forms.Button btnServiceUpdate;
        private System.Windows.Forms.Button btnServiceInsert;
        private System.Windows.Forms.Label lblProductCompany;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button searchProduct;
        private System.Windows.Forms.TextBox txtProductId;
        private System.Windows.Forms.Label label1;
    }
}
