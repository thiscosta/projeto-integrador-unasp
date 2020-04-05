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
            this.label9 = new System.Windows.Forms.Label();
            this.dgvService = new System.Windows.Forms.DataGridView();
            this.txtServicePrice = new System.Windows.Forms.TextBox();
            this.txtServiceDescription = new System.Windows.Forms.TextBox();
            this.txtServiceId = new System.Windows.Forms.TextBox();
            this.btnServiceDelete = new System.Windows.Forms.Button();
            this.btnServiceUpdate = new System.Windows.Forms.Button();
            this.btnServiceInsert = new System.Windows.Forms.Button();
            this.lbl2 = new System.Windows.Forms.Label();
            this.lblProductCompany = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvService)).BeginInit();
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
            // 
            // txtServicePrice
            // 
            this.txtServicePrice.BackColor = System.Drawing.SystemColors.Control;
            this.txtServicePrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtServicePrice.Enabled = false;
            this.txtServicePrice.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtServicePrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(37)))), ((int)(((byte)(47)))));
            this.txtServicePrice.Location = new System.Drawing.Point(130, 227);
            this.txtServicePrice.Name = "txtServicePrice";
            this.txtServicePrice.Size = new System.Drawing.Size(441, 23);
            this.txtServicePrice.TabIndex = 64;
            // 
            // txtServiceDescription
            // 
            this.txtServiceDescription.BackColor = System.Drawing.SystemColors.Control;
            this.txtServiceDescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtServiceDescription.Enabled = false;
            this.txtServiceDescription.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtServiceDescription.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(37)))), ((int)(((byte)(47)))));
            this.txtServiceDescription.Location = new System.Drawing.Point(130, 192);
            this.txtServiceDescription.Name = "txtServiceDescription";
            this.txtServiceDescription.Size = new System.Drawing.Size(441, 23);
            this.txtServiceDescription.TabIndex = 58;
            // 
            // txtServiceId
            // 
            this.txtServiceId.BackColor = System.Drawing.SystemColors.Control;
            this.txtServiceId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtServiceId.Enabled = false;
            this.txtServiceId.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtServiceId.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(37)))), ((int)(((byte)(47)))));
            this.txtServiceId.Location = new System.Drawing.Point(130, 157);
            this.txtServiceId.Name = "txtServiceId";
            this.txtServiceId.Size = new System.Drawing.Size(441, 23);
            this.txtServiceId.TabIndex = 65;
            // 
            // btnServiceDelete
            // 
            this.btnServiceDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(37)))), ((int)(((byte)(47)))));
            this.btnServiceDelete.FlatAppearance.BorderSize = 0;
            this.btnServiceDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnServiceDelete.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnServiceDelete.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnServiceDelete.Location = new System.Drawing.Point(396, 270);
            this.btnServiceDelete.Name = "btnServiceDelete";
            this.btnServiceDelete.Size = new System.Drawing.Size(175, 106);
            this.btnServiceDelete.TabIndex = 55;
            this.btnServiceDelete.Text = "Delete";
            this.btnServiceDelete.UseVisualStyleBackColor = false;
            // 
            // btnServiceUpdate
            // 
            this.btnServiceUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(37)))), ((int)(((byte)(47)))));
            this.btnServiceUpdate.FlatAppearance.BorderSize = 0;
            this.btnServiceUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnServiceUpdate.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnServiceUpdate.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnServiceUpdate.Location = new System.Drawing.Point(215, 270);
            this.btnServiceUpdate.Name = "btnServiceUpdate";
            this.btnServiceUpdate.Size = new System.Drawing.Size(175, 106);
            this.btnServiceUpdate.TabIndex = 56;
            this.btnServiceUpdate.Text = "Update";
            this.btnServiceUpdate.UseVisualStyleBackColor = false;
            // 
            // btnServiceInsert
            // 
            this.btnServiceInsert.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(37)))), ((int)(((byte)(47)))));
            this.btnServiceInsert.FlatAppearance.BorderSize = 0;
            this.btnServiceInsert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnServiceInsert.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnServiceInsert.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnServiceInsert.Location = new System.Drawing.Point(34, 270);
            this.btnServiceInsert.Name = "btnServiceInsert";
            this.btnServiceInsert.Size = new System.Drawing.Size(175, 106);
            this.btnServiceInsert.TabIndex = 57;
            this.btnServiceInsert.Text = "Insert";
            this.btnServiceInsert.UseVisualStyleBackColor = false;
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(37)))), ((int)(((byte)(47)))));
            this.lbl2.Location = new System.Drawing.Point(30, 227);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(43, 17);
            this.lbl2.TabIndex = 47;
            this.lbl2.Text = "Price:";
            // 
            // lblProductCompany
            // 
            this.lblProductCompany.AutoSize = true;
            this.lblProductCompany.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductCompany.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(37)))), ((int)(((byte)(47)))));
            this.lblProductCompany.Location = new System.Drawing.Point(30, 191);
            this.lblProductCompany.Name = "lblProductCompany";
            this.lblProductCompany.Size = new System.Drawing.Size(84, 17);
            this.lblProductCompany.TabIndex = 53;
            this.lblProductCompany.Text = "Description:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(37)))), ((int)(((byte)(47)))));
            this.label10.Location = new System.Drawing.Point(30, 157);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(73, 17);
            this.label10.TabIndex = 54;
            this.label10.Text = "Id Service:";
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
            this.Controls.Add(this.label9);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dgvService);
            this.Controls.Add(this.txtServicePrice);
            this.Controls.Add(this.txtServiceDescription);
            this.Controls.Add(this.txtServiceId);
            this.Controls.Add(this.btnServiceDelete);
            this.Controls.Add(this.btnServiceUpdate);
            this.Controls.Add(this.btnServiceInsert);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.lblProductCompany);
            this.Controls.Add(this.label10);
            this.Name = "ServicesUser";
            this.Size = new System.Drawing.Size(1080, 573);
            ((System.ComponentModel.ISupportInitialize)(this.dgvService)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dgvService;
        private System.Windows.Forms.TextBox txtServicePrice;
        private System.Windows.Forms.TextBox txtServiceDescription;
        private System.Windows.Forms.TextBox txtServiceId;
        private System.Windows.Forms.Button btnServiceDelete;
        private System.Windows.Forms.Button btnServiceUpdate;
        private System.Windows.Forms.Button btnServiceInsert;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Label lblProductCompany;
        private System.Windows.Forms.Label label10;
    }
}
