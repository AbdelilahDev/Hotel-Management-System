namespace HMS_Presontation_Layer.Users
{
    partial class CtrlAddUpdateUser
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tbUserName = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.lblEmployeeID = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblUserID = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pbShowOrHideCurrentPassword = new System.Windows.Forms.PictureBox();
            this.pictureBox11 = new System.Windows.Forms.PictureBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.grbUserActice = new System.Windows.Forms.GroupBox();
            this.rdbActive = new System.Windows.Forms.RadioButton();
            this.rdbNotActive = new System.Windows.Forms.RadioButton();
            this.grbUserType = new System.Windows.Forms.GroupBox();
            this.rdbAdminUser = new System.Windows.Forms.RadioButton();
            this.rdbNormalUser = new System.Windows.Forms.RadioButton();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbShowOrHideCurrentPassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.grbUserActice.SuspendLayout();
            this.grbUserType.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.BackColor = System.Drawing.Color.White;
            this.splitContainer1.Location = new System.Drawing.Point(22, 362);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.pictureBox2);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.pbShowOrHideCurrentPassword);
            this.splitContainer1.Panel1.Controls.Add(this.tbPassword);
            this.splitContainer1.Panel1.Controls.Add(this.pictureBox11);
            this.splitContainer1.Panel1.Controls.Add(this.tbUserName);
            this.splitContainer1.Panel1.Controls.Add(this.label11);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.grbUserType);
            this.splitContainer1.Panel2.Controls.Add(this.grbUserActice);
            this.splitContainer1.Size = new System.Drawing.Size(736, 181);
            this.splitContainer1.SplitterDistance = 353;
            this.splitContainer1.TabIndex = 43;
            // 
            // tbUserName
            // 
            this.tbUserName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbUserName.Location = new System.Drawing.Point(178, 34);
            this.tbUserName.Name = "tbUserName";
            this.tbUserName.Size = new System.Drawing.Size(166, 26);
            this.tbUserName.TabIndex = 43;
            this.tbUserName.Validating += new System.ComponentModel.CancelEventHandler(this.tbUserName_Validating);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(8, 33);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(126, 24);
            this.label11.TabIndex = 38;
            this.label11.Text = "UserName:  ";
            // 
            // lblEmployeeID
            // 
            this.lblEmployeeID.AutoSize = true;
            this.lblEmployeeID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmployeeID.Location = new System.Drawing.Point(418, 271);
            this.lblEmployeeID.Name = "lblEmployeeID";
            this.lblEmployeeID.Size = new System.Drawing.Size(36, 20);
            this.lblEmployeeID.TabIndex = 41;
            this.lblEmployeeID.Text = "???";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(283, 268);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(141, 24);
            this.label6.TabIndex = 40;
            this.label6.Text = "EmployeeID:  ";
            // 
            // lblUserID
            // 
            this.lblUserID.AutoSize = true;
            this.lblUserID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserID.Location = new System.Drawing.Point(418, 309);
            this.lblUserID.Name = "lblUserID";
            this.lblUserID.Size = new System.Drawing.Size(36, 20);
            this.lblUserID.TabIndex = 45;
            this.lblUserID.Text = "???";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(332, 306);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 24);
            this.label2.TabIndex = 44;
            this.label2.Text = "UserID:  ";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.Red;
            this.lblTitle.Location = new System.Drawing.Point(274, 6);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(0, 37);
            this.lblTitle.TabIndex = 46;
            // 
            // tbPassword
            // 
            this.tbPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPassword.Location = new System.Drawing.Point(178, 98);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(166, 26);
            this.tbPassword.TabIndex = 49;
            this.tbPassword.Tag = "pbShowOrHideCurrentPassword";
            this.tbPassword.Validating += new System.ComponentModel.CancelEventHandler(this.tbUserName_Validating);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 24);
            this.label1.TabIndex = 51;
            this.label1.Text = "Password:  ";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::HMS_Presontation_Layer.Properties.Resources.password;
            this.pictureBox2.Location = new System.Drawing.Point(131, 89);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(41, 43);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 52;
            this.pictureBox2.TabStop = false;
            // 
            // pbShowOrHideCurrentPassword
            // 
            this.pbShowOrHideCurrentPassword.Image = global::HMS_Presontation_Layer.Properties.Resources.ShowPasswordIcon;
            this.pbShowOrHideCurrentPassword.Location = new System.Drawing.Point(324, 149);
            this.pbShowOrHideCurrentPassword.Name = "pbShowOrHideCurrentPassword";
            this.pbShowOrHideCurrentPassword.Size = new System.Drawing.Size(20, 20);
            this.pbShowOrHideCurrentPassword.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbShowOrHideCurrentPassword.TabIndex = 50;
            this.pbShowOrHideCurrentPassword.TabStop = false;
            this.pbShowOrHideCurrentPassword.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pbShowOrHideCurrentPassword_MouseDown);
            this.pbShowOrHideCurrentPassword.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pbShowOrHideCurrentPassword_MouseUp);
            // 
            // pictureBox11
            // 
            this.pictureBox11.Image = global::HMS_Presontation_Layer.Properties.Resources.id_card;
            this.pictureBox11.Location = new System.Drawing.Point(131, 24);
            this.pictureBox11.Name = "pictureBox11";
            this.pictureBox11.Size = new System.Drawing.Size(41, 43);
            this.pictureBox11.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox11.TabIndex = 48;
            this.pictureBox11.TabStop = false;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnSave.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.btnSave.FlatAppearance.BorderSize = 2;
            this.btnSave.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SlateGray;
            this.btnSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.Black;
            this.btnSave.Image = global::HMS_Presontation_Layer.Properties.Resources.Saveicon50;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(319, 558);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(124, 55);
            this.btnSave.TabIndex = 42;
            this.btnSave.Text = "       Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::HMS_Presontation_Layer.Properties.Resources.users;
            this.pictureBox1.Location = new System.Drawing.Point(287, 46);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(231, 213);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // grbUserActice
            // 
            this.grbUserActice.Controls.Add(this.rdbNotActive);
            this.grbUserActice.Controls.Add(this.rdbActive);
            this.grbUserActice.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbUserActice.Location = new System.Drawing.Point(12, 34);
            this.grbUserActice.Name = "grbUserActice";
            this.grbUserActice.Size = new System.Drawing.Size(173, 135);
            this.grbUserActice.TabIndex = 0;
            this.grbUserActice.TabStop = false;
            this.grbUserActice.Text = "User active";
            // 
            // rdbActive
            // 
            this.rdbActive.AutoSize = true;
            this.rdbActive.Checked = true;
            this.rdbActive.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbActive.Location = new System.Drawing.Point(18, 46);
            this.rdbActive.Name = "rdbActive";
            this.rdbActive.Size = new System.Drawing.Size(76, 24);
            this.rdbActive.TabIndex = 0;
            this.rdbActive.TabStop = true;
            this.rdbActive.Text = "Active";
            this.rdbActive.UseVisualStyleBackColor = true;
            // 
            // rdbNotActive
            // 
            this.rdbNotActive.AutoSize = true;
            this.rdbNotActive.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbNotActive.Location = new System.Drawing.Point(18, 89);
            this.rdbNotActive.Name = "rdbNotActive";
            this.rdbNotActive.Size = new System.Drawing.Size(109, 24);
            this.rdbNotActive.TabIndex = 1;
            this.rdbNotActive.Text = "Not Active";
            this.rdbNotActive.UseVisualStyleBackColor = true;
            // 
            // grbUserType
            // 
            this.grbUserType.Controls.Add(this.rdbAdminUser);
            this.grbUserType.Controls.Add(this.rdbNormalUser);
            this.grbUserType.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbUserType.Location = new System.Drawing.Point(191, 34);
            this.grbUserType.Name = "grbUserType";
            this.grbUserType.Size = new System.Drawing.Size(173, 135);
            this.grbUserType.TabIndex = 2;
            this.grbUserType.TabStop = false;
            this.grbUserType.Text = "User Type";
            // 
            // rdbAdminUser
            // 
            this.rdbAdminUser.AutoSize = true;
            this.rdbAdminUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbAdminUser.Location = new System.Drawing.Point(18, 89);
            this.rdbAdminUser.Name = "rdbAdminUser";
            this.rdbAdminUser.Size = new System.Drawing.Size(77, 24);
            this.rdbAdminUser.TabIndex = 1;
            this.rdbAdminUser.Text = "Admin";
            this.rdbAdminUser.UseVisualStyleBackColor = true;
            // 
            // rdbNormalUser
            // 
            this.rdbNormalUser.AutoSize = true;
            this.rdbNormalUser.Checked = true;
            this.rdbNormalUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbNormalUser.Location = new System.Drawing.Point(18, 46);
            this.rdbNormalUser.Name = "rdbNormalUser";
            this.rdbNormalUser.Size = new System.Drawing.Size(83, 24);
            this.rdbNormalUser.TabIndex = 0;
            this.rdbNormalUser.TabStop = true;
            this.rdbNormalUser.Text = "Normal";
            this.rdbNormalUser.UseVisualStyleBackColor = true;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // CtrlAddUpdateUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblUserID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblEmployeeID);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "CtrlAddUpdateUser";
            this.Size = new System.Drawing.Size(772, 627);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbShowOrHideCurrentPassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.grbUserActice.ResumeLayout(false);
            this.grbUserActice.PerformLayout();
            this.grbUserType.ResumeLayout(false);
            this.grbUserType.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.PictureBox pictureBox11;
        private System.Windows.Forms.TextBox tbUserName;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblEmployeeID;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblUserID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.PictureBox pbShowOrHideCurrentPassword;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grbUserActice;
        private System.Windows.Forms.GroupBox grbUserType;
        private System.Windows.Forms.RadioButton rdbAdminUser;
        private System.Windows.Forms.RadioButton rdbNormalUser;
        private System.Windows.Forms.RadioButton rdbNotActive;
        private System.Windows.Forms.RadioButton rdbActive;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}
