namespace HMS_Presontation_Layer.Guests
{
    partial class frmallGuestsInHotel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmallGuestsInHotel));
            this.ctrGuestsInHotel1 = new HMS_Presontation_Layer.Guests.CtrGuestsInHotel();
            this.SuspendLayout();
            // 
            // ctrGuestsInHotel1
            // 
            this.ctrGuestsInHotel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ctrGuestsInHotel1.Location = new System.Drawing.Point(1, 0);
            this.ctrGuestsInHotel1.Name = "ctrGuestsInHotel1";
            this.ctrGuestsInHotel1.Size = new System.Drawing.Size(962, 642);
            this.ctrGuestsInHotel1.TabIndex = 0;
            // 
            // frmallGuestsInHotel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(964, 643);
            this.Controls.Add(this.ctrGuestsInHotel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmallGuestsInHotel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Guests In  Hotel";
            this.ResumeLayout(false);

        }

        #endregion

        private CtrGuestsInHotel ctrGuestsInHotel1;
    }
}