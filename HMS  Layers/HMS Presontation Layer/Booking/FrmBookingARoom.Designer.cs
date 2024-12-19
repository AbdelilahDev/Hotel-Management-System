namespace HMS_Presontation_Layer.Booking
{
    partial class FrmBookingARoom
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBookingARoom));
            this.ctrBooking1 = new HMS_Presontation_Layer.Booking.CtrBooking();
            this.SuspendLayout();
            // 
            // ctrBooking1
            // 
            this.ctrBooking1.Location = new System.Drawing.Point(2, 2);
            this.ctrBooking1.Name = "ctrBooking1";
            this.ctrBooking1.Size = new System.Drawing.Size(350, 704);
            this.ctrBooking1.TabIndex = 0;
            // 
            // FrmBookingARoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(347, 713);
            this.Controls.Add(this.ctrBooking1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmBookingARoom";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Booking A Room";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmBookingARoom_FormClosed);
//            this.Load += new System.EventHandler(this.FrmBookingARoom_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CtrBooking ctrBooking1;
    }
}