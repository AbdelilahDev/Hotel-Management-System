namespace HMS_Presontation_Layer.CurrentUser
{
    partial class CtrlChangePassword
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
            this.label1 = new System.Windows.Forms.Label();
            this.grbChangePassword = new System.Windows.Forms.GroupBox();
            this.tbConfirmPassword = new System.Windows.Forms.TextBox();
            this.pbShowOrHideNewPassword = new System.Windows.Forms.PictureBox();
            this.tbNewPassword = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbCurrentPassword = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnSave = new System.Windows.Forms.Button();
            this.pbShowOrHideCurrentPassword = new System.Windows.Forms.PictureBox();
            this.pbShoworHideConfirmPassword = new System.Windows.Forms.PictureBox();
            this.grbChangePassword.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbShowOrHideNewPassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbShowOrHideCurrentPassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbShoworHideConfirmPassword)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Current Passowrd";
            // 
            // grbChangePassword
            // 
            this.grbChangePassword.Controls.Add(this.pbShoworHideConfirmPassword);
            this.grbChangePassword.Controls.Add(this.tbConfirmPassword);
            this.grbChangePassword.Controls.Add(this.pbShowOrHideNewPassword);
            this.grbChangePassword.Controls.Add(this.tbNewPassword);
            this.grbChangePassword.Controls.Add(this.label3);
            this.grbChangePassword.Controls.Add(this.label2);
            this.grbChangePassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.grbChangePassword.Location = new System.Drawing.Point(3, 105);
            this.grbChangePassword.Name = "grbChangePassword";
            this.grbChangePassword.Size = new System.Drawing.Size(440, 112);
            this.grbChangePassword.TabIndex = 1;
            this.grbChangePassword.TabStop = false;
            // 
            // tbConfirmPassword
            // 
            this.tbConfirmPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbConfirmPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbConfirmPassword.Location = new System.Drawing.Point(183, 64);
            this.tbConfirmPassword.Name = "tbConfirmPassword";
            this.tbConfirmPassword.Size = new System.Drawing.Size(205, 26);
            this.tbConfirmPassword.TabIndex = 6;
            this.tbConfirmPassword.Validating += new System.ComponentModel.CancelEventHandler(this.tbCurrentPassword_Validating);
            // 
            // pbShowOrHideNewPassword
            // 
            this.pbShowOrHideNewPassword.Image = global::HMS_Presontation_Layer.Properties.Resources.ShowPasswordIcon;
            this.pbShowOrHideNewPassword.Location = new System.Drawing.Point(414, 19);
            this.pbShowOrHideNewPassword.Name = "pbShowOrHideNewPassword";
            this.pbShowOrHideNewPassword.Size = new System.Drawing.Size(20, 20);
            this.pbShowOrHideNewPassword.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbShowOrHideNewPassword.TabIndex = 5;
            this.pbShowOrHideNewPassword.TabStop = false;
            this.pbShowOrHideNewPassword.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pbShowOrHideNewPassword_MouseDown);
            this.pbShowOrHideNewPassword.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pbShowOrHideNewPassword_MouseUp);
            // 
            // tbNewPassword
            // 
            this.tbNewPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbNewPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNewPassword.Location = new System.Drawing.Point(183, 16);
            this.tbNewPassword.Name = "tbNewPassword";
            this.tbNewPassword.Size = new System.Drawing.Size(205, 26);
            this.tbNewPassword.TabIndex = 4;
            this.tbNewPassword.Tag = "pbShowOrHideNewPassword";
            this.tbNewPassword.Validating += new System.ComponentModel.CancelEventHandler(this.tbCurrentPassword_Validating);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(2, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(178, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "Confirm Passowrd";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(34, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "New Password";
            // 
            // tbCurrentPassword
            // 
            this.tbCurrentPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbCurrentPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCurrentPassword.Location = new System.Drawing.Point(186, 64);
            this.tbCurrentPassword.Name = "tbCurrentPassword";
            this.tbCurrentPassword.Size = new System.Drawing.Size(205, 26);
            this.tbCurrentPassword.TabIndex = 2;
            this.tbCurrentPassword.Tag = "pbShowOrHideCurrentPassword";
            this.tbCurrentPassword.TextChanged += new System.EventHandler(this.tbCurrentPassword_TextChanged);
            this.tbCurrentPassword.Validating += new System.ComponentModel.CancelEventHandler(this.tbCurrentPassword_Validating);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(97, 5);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(294, 37);
            this.label4.TabIndex = 4;
            this.label4.Text = "Change Password";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // btnSave
            // 
            this.btnSave.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.btnSave.FlatAppearance.BorderSize = 3;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Image = global::HMS_Presontation_Layer.Properties.Resources.Saveicon50;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(165, 226);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(166, 55);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "     Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // pbShowOrHideCurrentPassword
            // 
            this.pbShowOrHideCurrentPassword.Image = global::HMS_Presontation_Layer.Properties.Resources.ShowPasswordIcon;
            this.pbShowOrHideCurrentPassword.Location = new System.Drawing.Point(423, 70);
            this.pbShowOrHideCurrentPassword.Name = "pbShowOrHideCurrentPassword";
            this.pbShowOrHideCurrentPassword.Size = new System.Drawing.Size(20, 20);
            this.pbShowOrHideCurrentPassword.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbShowOrHideCurrentPassword.TabIndex = 3;
            this.pbShowOrHideCurrentPassword.TabStop = false;
            this.pbShowOrHideCurrentPassword.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pbShowOrHideCurrentPassword_MouseDown);
            this.pbShowOrHideCurrentPassword.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pbShowOrHideCurrentPassword_MouseUp);
            // 
            // pbShoworHideConfirmPassword
            // 
            this.pbShoworHideConfirmPassword.Image = global::HMS_Presontation_Layer.Properties.Resources.ShowPasswordIcon;
            this.pbShoworHideConfirmPassword.Location = new System.Drawing.Point(414, 70);
            this.pbShoworHideConfirmPassword.Name = "pbShoworHideConfirmPassword";
            this.pbShoworHideConfirmPassword.Size = new System.Drawing.Size(20, 20);
            this.pbShoworHideConfirmPassword.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbShoworHideConfirmPassword.TabIndex = 7;
            this.pbShoworHideConfirmPassword.TabStop = false;
            this.pbShoworHideConfirmPassword.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pbShoworHideConfirmPassword_MouseDown);
            this.pbShoworHideConfirmPassword.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pbShoworHideConfirmPassword_MouseUp);
            // 
            // CtrlChangePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pbShowOrHideCurrentPassword);
            this.Controls.Add(this.tbCurrentPassword);
            this.Controls.Add(this.grbChangePassword);
            this.Controls.Add(this.label1);
            this.Name = "CtrlChangePassword";
            this.Size = new System.Drawing.Size(449, 287);
            this.grbChangePassword.ResumeLayout(false);
            this.grbChangePassword.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbShowOrHideNewPassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbShowOrHideCurrentPassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbShoworHideConfirmPassword)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grbChangePassword;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbCurrentPassword;
        private System.Windows.Forms.PictureBox pbShowOrHideCurrentPassword;
        private System.Windows.Forms.TextBox tbNewPassword;
        private System.Windows.Forms.PictureBox pbShowOrHideNewPassword;
        private System.Windows.Forms.TextBox tbConfirmPassword;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.PictureBox pbShoworHideConfirmPassword;
    }
}
