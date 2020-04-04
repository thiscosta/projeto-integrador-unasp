namespace wfaProjetoIntegrador
{
    partial class BillsUsercontrol
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
            this.dgvBill = new System.Windows.Forms.DataGridView();
            this.txtBillTotalPrice = new System.Windows.Forms.TextBox();
            this.txtBillPayDate = new System.Windows.Forms.TextBox();
            this.txtBillDueDate = new System.Windows.Forms.TextBox();
            this.txtBillCode = new System.Windows.Forms.TextBox();
            this.btnDeleteBill = new System.Windows.Forms.Button();
            this.btnUpdateBill = new System.Windows.Forms.Button();
            this.btnInsertBill = new System.Windows.Forms.Button();
            this.lbl3 = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.lblProductCompany = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBill)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(37)))), ((int)(((byte)(47)))));
            this.label9.Location = new System.Drawing.Point(3, 19);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(359, 78);
            this.label9.TabIndex = 46;
            this.label9.Text = "Bill Control";
            // 
            // dgvBill
            // 
            this.dgvBill.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBill.Location = new System.Drawing.Point(594, 160);
            this.dgvBill.Name = "dgvBill";
            this.dgvBill.Size = new System.Drawing.Size(483, 409);
            this.dgvBill.TabIndex = 66;
            // 
            // txtBillTotalPrice
            // 
            this.txtBillTotalPrice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(157)))));
            this.txtBillTotalPrice.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBillTotalPrice.Enabled = false;
            this.txtBillTotalPrice.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBillTotalPrice.ForeColor = System.Drawing.Color.White;
            this.txtBillTotalPrice.Location = new System.Drawing.Point(130, 325);
            this.txtBillTotalPrice.Name = "txtBillTotalPrice";
            this.txtBillTotalPrice.Size = new System.Drawing.Size(440, 16);
            this.txtBillTotalPrice.TabIndex = 59;
            // 
            // txtBillPayDate
            // 
            this.txtBillPayDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(157)))));
            this.txtBillPayDate.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBillPayDate.Enabled = false;
            this.txtBillPayDate.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBillPayDate.ForeColor = System.Drawing.Color.White;
            this.txtBillPayDate.Location = new System.Drawing.Point(130, 290);
            this.txtBillPayDate.Name = "txtBillPayDate";
            this.txtBillPayDate.Size = new System.Drawing.Size(440, 16);
            this.txtBillPayDate.TabIndex = 64;
            // 
            // txtBillDueDate
            // 
            this.txtBillDueDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(157)))));
            this.txtBillDueDate.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBillDueDate.Enabled = false;
            this.txtBillDueDate.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBillDueDate.ForeColor = System.Drawing.Color.White;
            this.txtBillDueDate.Location = new System.Drawing.Point(130, 256);
            this.txtBillDueDate.Name = "txtBillDueDate";
            this.txtBillDueDate.Size = new System.Drawing.Size(440, 16);
            this.txtBillDueDate.TabIndex = 58;
            // 
            // txtBillCode
            // 
            this.txtBillCode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(157)))));
            this.txtBillCode.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBillCode.Enabled = false;
            this.txtBillCode.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBillCode.ForeColor = System.Drawing.Color.White;
            this.txtBillCode.Location = new System.Drawing.Point(130, 220);
            this.txtBillCode.Name = "txtBillCode";
            this.txtBillCode.Size = new System.Drawing.Size(440, 16);
            this.txtBillCode.TabIndex = 65;
            // 
            // btnDeleteBill
            // 
            this.btnDeleteBill.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(37)))), ((int)(((byte)(47)))));
            this.btnDeleteBill.FlatAppearance.BorderSize = 0;
            this.btnDeleteBill.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteBill.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteBill.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDeleteBill.Location = new System.Drawing.Point(394, 363);
            this.btnDeleteBill.Name = "btnDeleteBill";
            this.btnDeleteBill.Size = new System.Drawing.Size(175, 106);
            this.btnDeleteBill.TabIndex = 55;
            this.btnDeleteBill.Text = "Delete";
            this.btnDeleteBill.UseVisualStyleBackColor = false;
            // 
            // btnUpdateBill
            // 
            this.btnUpdateBill.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(37)))), ((int)(((byte)(47)))));
            this.btnUpdateBill.FlatAppearance.BorderSize = 0;
            this.btnUpdateBill.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateBill.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateBill.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnUpdateBill.Location = new System.Drawing.Point(213, 363);
            this.btnUpdateBill.Name = "btnUpdateBill";
            this.btnUpdateBill.Size = new System.Drawing.Size(175, 106);
            this.btnUpdateBill.TabIndex = 56;
            this.btnUpdateBill.Text = "Update";
            this.btnUpdateBill.UseVisualStyleBackColor = false;
            // 
            // btnInsertBill
            // 
            this.btnInsertBill.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(37)))), ((int)(((byte)(47)))));
            this.btnInsertBill.FlatAppearance.BorderSize = 0;
            this.btnInsertBill.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInsertBill.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsertBill.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnInsertBill.Location = new System.Drawing.Point(32, 363);
            this.btnInsertBill.Name = "btnInsertBill";
            this.btnInsertBill.Size = new System.Drawing.Size(175, 106);
            this.btnInsertBill.TabIndex = 57;
            this.btnInsertBill.Text = "Insert";
            this.btnInsertBill.UseVisualStyleBackColor = false;
            // 
            // lbl3
            // 
            this.lbl3.AutoSize = true;
            this.lbl3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(37)))), ((int)(((byte)(47)))));
            this.lbl3.Location = new System.Drawing.Point(30, 325);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(78, 17);
            this.lbl3.TabIndex = 48;
            this.lbl3.Text = "Total Price:";
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(37)))), ((int)(((byte)(47)))));
            this.lbl2.Location = new System.Drawing.Point(30, 290);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(71, 17);
            this.lbl2.TabIndex = 47;
            this.lbl2.Text = "Pay Date:";
            // 
            // lblProductCompany
            // 
            this.lblProductCompany.AutoSize = true;
            this.lblProductCompany.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductCompany.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(37)))), ((int)(((byte)(47)))));
            this.lblProductCompany.Location = new System.Drawing.Point(30, 255);
            this.lblProductCompany.Name = "lblProductCompany";
            this.lblProductCompany.Size = new System.Drawing.Size(74, 17);
            this.lblProductCompany.TabIndex = 53;
            this.lblProductCompany.Text = "Due Date:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(37)))), ((int)(((byte)(47)))));
            this.label10.Location = new System.Drawing.Point(30, 220);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(24, 17);
            this.label10.TabIndex = 54;
            this.label10.Text = "Id:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::wfaProjetoIntegrador.Properties.Resources.blueBills;
            this.pictureBox1.Location = new System.Drawing.Point(349, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(187, 120);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 67;
            this.pictureBox1.TabStop = false;
            // 
            // BillsUsercontrol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label9);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dgvBill);
            this.Controls.Add(this.txtBillTotalPrice);
            this.Controls.Add(this.txtBillPayDate);
            this.Controls.Add(this.txtBillDueDate);
            this.Controls.Add(this.txtBillCode);
            this.Controls.Add(this.btnDeleteBill);
            this.Controls.Add(this.btnUpdateBill);
            this.Controls.Add(this.btnInsertBill);
            this.Controls.Add(this.lbl3);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.lblProductCompany);
            this.Controls.Add(this.label10);
            this.Name = "BillsUsercontrol";
            this.Size = new System.Drawing.Size(1080, 573);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBill)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dgvBill;
        private System.Windows.Forms.TextBox txtBillTotalPrice;
        private System.Windows.Forms.TextBox txtBillPayDate;
        private System.Windows.Forms.TextBox txtBillDueDate;
        private System.Windows.Forms.TextBox txtBillCode;
        private System.Windows.Forms.Button btnDeleteBill;
        private System.Windows.Forms.Button btnUpdateBill;
        private System.Windows.Forms.Button btnInsertBill;
        private System.Windows.Forms.Label lbl3;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Label lblProductCompany;
        private System.Windows.Forms.Label label10;
    }
}
