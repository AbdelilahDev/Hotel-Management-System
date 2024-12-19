namespace HMS_Presontation_Layer.Guests
{
    partial class frmAddAndUpdateGuest
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddAndUpdateGuest));
            this.ctrAddAndUpdateNewGuest1 = new HMS_Presontation_Layer.Guests.CtrAddAndUpdateNewGuest();
            this.SuspendLayout();
            // 
            // ctrAddAndUpdateNewGuest1
            // 
            this.ctrAddAndUpdateNewGuest1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ctrAddAndUpdateNewGuest1.Location = new System.Drawing.Point(0, -1);
            this.ctrAddAndUpdateNewGuest1.Name = "ctrAddAndUpdateNewGuest1";
            this.ctrAddAndUpdateNewGuest1.Size = new System.Drawing.Size(453, 723);
            this.ctrAddAndUpdateNewGuest1.TabIndex = 0;
//            this.ctrAddAndUpdateNewGuest1.Load += new System.EventHandler(this.ctrAddAndUpdateNewGuest1_Load);
            // 
            // frmAddAndUpdateGuest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.ClientSize = new System.Drawing.Size(453, 722);
            this.Controls.Add(this.ctrAddAndUpdateNewGuest1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmAddAndUpdateGuest";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Add And Update Guest";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmAddAndUpdateGuest_FormClosed);
            this.ResumeLayout(false);

        }

        #endregion

        private CtrAddAndUpdateNewGuest ctrAddAndUpdateNewGuest1;
    }
}