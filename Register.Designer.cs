namespace HospitalManagementSystem
{
    partial class frmRegister
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.lblUsernameRgstr = new System.Windows.Forms.Label();
            this.lblPasswordRgsrtr = new System.Windows.Forms.Label();
            this.lblConfirmPassword = new System.Windows.Forms.Label();
            this.lblRole = new System.Windows.Forms.Label();
            this.txtUsernameRgstr = new System.Windows.Forms.TextBox();
            this.txtPasswordRgstr = new System.Windows.Forms.TextBox();
            this.txtConfirmPassword = new System.Windows.Forms.TextBox();
            this.btnRegister = new System.Windows.Forms.Button();
            this.cbRole = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(195, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "REGISTER";
            // 
            // lblUsernameRgstr
            // 
            this.lblUsernameRgstr.AutoSize = true;
            this.lblUsernameRgstr.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblUsernameRgstr.Location = new System.Drawing.Point(71, 94);
            this.lblUsernameRgstr.Name = "lblUsernameRgstr";
            this.lblUsernameRgstr.Size = new System.Drawing.Size(87, 16);
            this.lblUsernameRgstr.TabIndex = 1;
            this.lblUsernameRgstr.Text = "USERNAME:";
            // 
            // lblPasswordRgsrtr
            // 
            this.lblPasswordRgsrtr.AutoSize = true;
            this.lblPasswordRgsrtr.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPasswordRgsrtr.Location = new System.Drawing.Point(69, 145);
            this.lblPasswordRgsrtr.Name = "lblPasswordRgsrtr";
            this.lblPasswordRgsrtr.Size = new System.Drawing.Size(89, 16);
            this.lblPasswordRgsrtr.TabIndex = 1;
            this.lblPasswordRgsrtr.Text = "PASSWORD:";
            // 
            // lblConfirmPassword
            // 
            this.lblConfirmPassword.AutoSize = true;
            this.lblConfirmPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblConfirmPassword.Location = new System.Drawing.Point(5, 200);
            this.lblConfirmPassword.Name = "lblConfirmPassword";
            this.lblConfirmPassword.Size = new System.Drawing.Size(153, 16);
            this.lblConfirmPassword.TabIndex = 1;
            this.lblConfirmPassword.Text = "CONFIRM PASSWORD:";
            // 
            // lblRole
            // 
            this.lblRole.AutoSize = true;
            this.lblRole.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblRole.Location = new System.Drawing.Point(112, 253);
            this.lblRole.Name = "lblRole";
            this.lblRole.Size = new System.Drawing.Size(46, 16);
            this.lblRole.TabIndex = 7;
            this.lblRole.Text = "ROLE:";
            // 
            // txtUsernameRgstr
            // 
            this.txtUsernameRgstr.Location = new System.Drawing.Point(164, 93);
            this.txtUsernameRgstr.Name = "txtUsernameRgstr";
            this.txtUsernameRgstr.Size = new System.Drawing.Size(175, 20);
            this.txtUsernameRgstr.TabIndex = 1;
            // 
            // txtPasswordRgstr
            // 
            this.txtPasswordRgstr.Location = new System.Drawing.Point(164, 144);
            this.txtPasswordRgstr.Name = "txtPasswordRgstr";
            this.txtPasswordRgstr.Size = new System.Drawing.Size(175, 20);
            this.txtPasswordRgstr.TabIndex = 2;
            // 
            // txtConfirmPassword
            // 
            this.txtConfirmPassword.Location = new System.Drawing.Point(164, 199);
            this.txtConfirmPassword.Name = "txtConfirmPassword";
            this.txtConfirmPassword.Size = new System.Drawing.Size(175, 20);
            this.txtConfirmPassword.TabIndex = 3;
            // 
            // btnRegister
            // 
            this.btnRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnRegister.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnRegister.Location = new System.Drawing.Point(187, 298);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(120, 30);
            this.btnRegister.TabIndex = 5;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // cbRole
            // 
            this.cbRole.FormattingEnabled = true;
            this.cbRole.Items.AddRange(new object[] {
            "Admin",
            "Staff"});
            this.cbRole.Location = new System.Drawing.Point(164, 248);
            this.cbRole.Name = "cbRole";
            this.cbRole.Size = new System.Drawing.Size(175, 21);
            this.cbRole.TabIndex = 4;
            // 
            // frmRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(408, 353);
            this.Controls.Add(this.cbRole);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.txtConfirmPassword);
            this.Controls.Add(this.txtPasswordRgstr);
            this.Controls.Add(this.txtUsernameRgstr);
            this.Controls.Add(this.lblRole);
            this.Controls.Add(this.lblConfirmPassword);
            this.Controls.Add(this.lblPasswordRgsrtr);
            this.Controls.Add(this.lblUsernameRgstr);
            this.Controls.Add(this.label1);
            this.Name = "frmRegister";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblUsernameRgstr;
        private System.Windows.Forms.Label lblPasswordRgsrtr;
        private System.Windows.Forms.Label lblConfirmPassword;
        private System.Windows.Forms.Label lblRole;
        private System.Windows.Forms.TextBox txtUsernameRgstr;
        private System.Windows.Forms.TextBox txtPasswordRgstr;
        private System.Windows.Forms.TextBox txtConfirmPassword;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.ComboBox cbRole;
    }
}