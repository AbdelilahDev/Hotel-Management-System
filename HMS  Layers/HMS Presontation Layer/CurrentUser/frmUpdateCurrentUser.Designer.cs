namespace HMS_Presontation_Layer.CurrentUser
{
    partial class frmUpdateCurrentUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUpdateCurrentUser));
            this.ctrAddAndUpdateNewGuest1 = new HMS_Presontation_Layer.Guests.CtrAddAndUpdateNewGuest();
            this.SuspendLayout();
            // 
            // ctrAddAndUpdateNewGuest1
            // 
            this.ctrAddAndUpdateNewGuest1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ctrAddAndUpdateNewGuest1.Location = new System.Drawing.Point(3, 3);
            this.ctrAddAndUpdateNewGuest1.Name = "ctrAddAndUpdateNewGuest1";
            this.ctrAddAndUpdateNewGuest1.Size = new System.Drawing.Size(423, 710);
            this.ctrAddAndUpdateNewGuest1.TabIndex = 0;
            // 
            // frmUpdateCurrentUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(429, 726);
            this.Controls.Add(this.ctrAddAndUpdateNewGuest1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmUpdateCurrentUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Update Current  User";
            this.ResumeLayout(false);

        }

        #endregion

        private Guests.CtrAddAndUpdateNewGuest ctrAddAndUpdateNewGuest1;
    }
}