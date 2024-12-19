namespace HMS_Presontation_Layer.Rooms
{
    partial class frmAddNewRoom
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddNewRoom));
            this.ctrAddAndUpdateRoom1 = new HMS_Presontation_Layer.Rooms.CtrAddAndUpdateRoom();
            this.SuspendLayout();
            // 
            // ctrAddAndUpdateRoom1
            // 
            this.ctrAddAndUpdateRoom1.Location = new System.Drawing.Point(1, 2);
            this.ctrAddAndUpdateRoom1.Name = "ctrAddAndUpdateRoom1";
            this.ctrAddAndUpdateRoom1.Size = new System.Drawing.Size(552, 725);
            this.ctrAddAndUpdateRoom1.TabIndex = 0;
            this.ctrAddAndUpdateRoom1.Load += new System.EventHandler(this.ctrAddAndUpdateRoom1_Load);
            // 
            // frmAddNewRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(558, 739);
            this.Controls.Add(this.ctrAddAndUpdateRoom1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmAddNewRoom";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Add New Room";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmAddNewRoom_FormClosed);
            this.ResumeLayout(false);

        }

        #endregion

        private CtrAddAndUpdateRoom ctrAddAndUpdateRoom1;
    }
}