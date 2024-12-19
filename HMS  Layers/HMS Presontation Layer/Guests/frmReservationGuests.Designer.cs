namespace HMS_Presontation_Layer.Guests
{
    partial class frmReservationGuests
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReservationGuests));
            this.ctrGuestsInHotel1 = new HMS_Presontation_Layer.Guests.CtrGuestsInHotel();
            this.SuspendLayout();
            // 
            // ctrGuestsInHotel1
            // 
            this.ctrGuestsInHotel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ctrGuestsInHotel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctrGuestsInHotel1.Location = new System.Drawing.Point(2, 2);
            this.ctrGuestsInHotel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ctrGuestsInHotel1.Name = "ctrGuestsInHotel1";
            this.ctrGuestsInHotel1.Size = new System.Drawing.Size(950, 630);
            this.ctrGuestsInHotel1.TabIndex = 0;
            // 
            // frmReservationGuests
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(953, 634);
            this.Controls.Add(this.ctrGuestsInHotel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmReservationGuests";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Reservation   Guests";
            this.ResumeLayout(false);

        }

        #endregion

        private CtrGuestsInHotel ctrGuestsInHotel1;
    }
}