namespace HMS_Presontation_Layer.Login
{
    partial class frmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbUserName = new System.Windows.Forms.TextBox();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.gbUserType = new System.Windows.Forms.GroupBox();
            this.rdbAdminUser = new System.Windows.Forms.RadioButton();
            this.rdbNormalUser = new System.Windows.Forms.RadioButton();
            this.chbRememeberUser = new System.Windows.Forms.CheckBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.gbUserType.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Mongolian Baiti", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(34, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(385, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hotel Management System";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 394);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "UserName";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 453);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Password";
            // 
            // tbUserName
            // 
            this.tbUserName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbUserName.Location = new System.Drawing.Point(134, 395);
            this.tbUserName.Name = "tbUserName";
            this.tbUserName.Size = new System.Drawing.Size(145, 26);
            this.tbUserName.TabIndex = 4;
            // 
            // tbPassword
            // 
            this.tbPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbPassword.Location = new System.Drawing.Point(134, 453);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.PasswordChar = '*';
            this.tbPassword.Size = new System.Drawing.Size(145, 26);
            this.tbPassword.TabIndex = 5;
            // 
            // gbUserType
            // 
            this.gbUserType.Controls.Add(this.rdbAdminUser);
            this.gbUserType.Controls.Add(this.rdbNormalUser);
            this.gbUserType.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbUserType.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.gbUserType.Location = new System.Drawing.Point(298, 394);
            this.gbUserType.Name = "gbUserType";
            this.gbUserType.Size = new System.Drawing.Size(139, 100);
            this.gbUserType.TabIndex = 6;
            this.gbUserType.TabStop = false;
            this.gbUserType.Text = "User Type";
            // 
            // rdbAdminUser
            // 
            this.rdbAdminUser.AutoSize = true;
            this.rdbAdminUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbAdminUser.Location = new System.Drawing.Point(14, 65);
            this.rdbAdminUser.Name = "rdbAdminUser";
            this.rdbAdminUser.Size = new System.Drawing.Size(72, 24);
            this.rdbAdminUser.TabIndex = 1;
            this.rdbAdminUser.Text = "Admin";
            this.rdbAdminUser.UseVisualStyleBackColor = true;
            // 
            // rdbNormalUser
            // 
            this.rdbNormalUser.AutoSize = true;
            this.rdbNormalUser.Checked = true;
            this.rdbNormalUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbNormalUser.Location = new System.Drawing.Point(14, 35);
            this.rdbNormalUser.Name = "rdbNormalUser";
            this.rdbNormalUser.Size = new System.Drawing.Size(77, 24);
            this.rdbNormalUser.TabIndex = 0;
            this.rdbNormalUser.TabStop = true;
            this.rdbNormalUser.Text = "Normal";
            this.rdbNormalUser.UseVisualStyleBackColor = true;
            // 
            // chbRememeberUser
            // 
            this.chbRememeberUser.AutoSize = true;
            this.chbRememeberUser.Checked = true;
            this.chbRememeberUser.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chbRememeberUser.Font = new System.Drawing.Font("MV Boli", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbRememeberUser.Location = new System.Drawing.Point(111, 497);
            this.chbRememeberUser.Name = "chbRememeberUser";
            this.chbRememeberUser.Size = new System.Drawing.Size(178, 29);
            this.chbRememeberUser.TabIndex = 7;
            this.chbRememeberUser.Text = "Rememeber Me";
            this.chbRememeberUser.UseVisualStyleBackColor = true;
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.Blue;
            this.btnLogin.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnLogin.FlatAppearance.BorderSize = 5;
            this.btnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogin.Location = new System.Drawing.Point(145, 546);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(177, 64);
            this.btnLogin.TabIndex = 8;
            this.btnLogin.Text = "     Login";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::HMS_Presontation_Layer.Properties.Resources.LoginImage;
            this.pictureBox1.Location = new System.Drawing.Point(12, 65);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(441, 303);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // frmLogin
            // 
            this.AcceptButton = this.btnLogin;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(465, 622);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.chbRememeberUser);
            this.Controls.Add(this.gbUserType);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.tbUserName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login Screen";
            this.gbUserType.ResumeLayout(false);
            this.gbUserType.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbUserName;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.GroupBox gbUserType;
        private System.Windows.Forms.RadioButton rdbAdminUser;
        private System.Windows.Forms.RadioButton rdbNormalUser;
        private System.Windows.Forms.CheckBox chbRememeberUser;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}