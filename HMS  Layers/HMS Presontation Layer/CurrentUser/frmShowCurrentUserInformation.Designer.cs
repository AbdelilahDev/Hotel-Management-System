namespace HMS_Presontation_Layer.CurrentUser
{
    partial class frmShowCurrentUserInformation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmShowCurrentUserInformation));
            this.ctrShowPersonInformation1 = new HMS_Presontation_Layer.General_UserControls.CtrShowPersonInformation();
            this.ctrlUserInformation1 = new HMS_Presontation_Layer.CurrentUser.CtrlUserInformation();
            this.SuspendLayout();
            // 
            // ctrShowPersonInformation1
            // 
            this.ctrShowPersonInformation1.Location = new System.Drawing.Point(7, 4);
            this.ctrShowPersonInformation1.Name = "ctrShowPersonInformation1";
            this.ctrShowPersonInformation1.Size = new System.Drawing.Size(490, 530);
            this.ctrShowPersonInformation1.TabIndex = 0;
            // 
            // ctrlUserInformation1
            // 
            this.ctrlUserInformation1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ctrlUserInformation1.Location = new System.Drawing.Point(7, 543);
            this.ctrlUserInformation1.Name = "ctrlUserInformation1";
            this.ctrlUserInformation1.Size = new System.Drawing.Size(490, 203);
            this.ctrlUserInformation1.TabIndex = 1;
            // 
            // frmShowCurrentUserInformation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(501, 761);
            this.Controls.Add(this.ctrlUserInformation1);
            this.Controls.Add(this.ctrShowPersonInformation1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmShowCurrentUserInformation";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Show Current User Information";
            this.ResumeLayout(false);

        }

        #endregion

        private General_UserControls.CtrShowPersonInformation ctrShowPersonInformation1;
        private CtrlUserInformation ctrlUserInformation1;
    }
}