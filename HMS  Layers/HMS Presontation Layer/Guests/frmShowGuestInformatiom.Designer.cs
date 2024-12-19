namespace HMS_Presontation_Layer.Guests
{
    partial class frmShowGuestInformatiom
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmShowGuestInformatiom));
            this.ctrShowPersonInformation1 = new HMS_Presontation_Layer.General_UserControls.CtrShowPersonInformation();
            this.SuspendLayout();
            // 
            // ctrShowPersonInformation1
            // 
            this.ctrShowPersonInformation1.Location = new System.Drawing.Point(5, 5);
            this.ctrShowPersonInformation1.Name = "ctrShowPersonInformation1";
            this.ctrShowPersonInformation1.Size = new System.Drawing.Size(424, 545);
            this.ctrShowPersonInformation1.TabIndex = 0;
            // 
            // frmShowGuestInformatiom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(433, 560);
            this.Controls.Add(this.ctrShowPersonInformation1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmShowGuestInformatiom";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Guest Informatiom";
            this.ResumeLayout(false);

        }

        #endregion

        private General_UserControls.CtrShowPersonInformation ctrShowPersonInformation1;
    }
}