namespace HMS_Presontation_Layer.CurrentUser
{
    partial class frmChangePassword
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmChangePassword));
            this.ctrlUserInformation1 = new HMS_Presontation_Layer.CurrentUser.CtrlUserInformation();
            this.ctrlChangePassword1 = new HMS_Presontation_Layer.CurrentUser.CtrlChangePassword();
            this.SuspendLayout();
            // 
            // ctrlUserInformation1
            // 
            this.ctrlUserInformation1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ctrlUserInformation1.Location = new System.Drawing.Point(2, 27);
            this.ctrlUserInformation1.Name = "ctrlUserInformation1";
            this.ctrlUserInformation1.Size = new System.Drawing.Size(490, 203);
            this.ctrlUserInformation1.TabIndex = 0;
            // 
            // ctrlChangePassword1
            // 
            this.ctrlChangePassword1.Location = new System.Drawing.Point(2, 251);
            this.ctrlChangePassword1.Name = "ctrlChangePassword1";
            this.ctrlChangePassword1.Size = new System.Drawing.Size(490, 287);
            this.ctrlChangePassword1.TabIndex = 1;
            // 
            // frmChangePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.ClientSize = new System.Drawing.Size(498, 565);
            this.Controls.Add(this.ctrlChangePassword1);
            this.Controls.Add(this.ctrlUserInformation1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmChangePassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Change   Password";
            this.ResumeLayout(false);

        }

        #endregion

        private CtrlUserInformation ctrlUserInformation1;
        private CtrlChangePassword ctrlChangePassword1;
    }
}