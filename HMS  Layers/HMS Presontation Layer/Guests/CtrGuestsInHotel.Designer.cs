namespace HMS_Presontation_Layer.Guests
{
    partial class CtrGuestsInHotel
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvGuestsInHotel = new System.Windows.Forms.DataGridView();
            this.lblTitle = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblTotalGuests = new System.Windows.Forms.Label();
            this.lblNoGuestinTheHotel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGuestsInHotel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvGuestsInHotel
            // 
            this.dgvGuestsInHotel.BackgroundColor = System.Drawing.Color.LightSteelBlue;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvGuestsInHotel.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvGuestsInHotel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGuestsInHotel.Location = new System.Drawing.Point(2, 338);
            this.dgvGuestsInHotel.Name = "dgvGuestsInHotel";
            this.dgvGuestsInHotel.ReadOnly = true;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvGuestsInHotel.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvGuestsInHotel.RowTemplate.DividerHeight = 1;
            this.dgvGuestsInHotel.RowTemplate.Height = 32;
            this.dgvGuestsInHotel.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvGuestsInHotel.Size = new System.Drawing.Size(950, 236);
            this.dgvGuestsInHotel.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(300, 7);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(342, 39);
            this.lblTitle.TabIndex = 2;
            this.lblTitle.Text = "Guests In The Hotel";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 589);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(220, 33);
            this.label2.TabIndex = 3;
            this.label2.Text = "Total Guests:  ";
            // 
            // lblTotalGuests
            // 
            this.lblTotalGuests.AutoSize = true;
            this.lblTotalGuests.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalGuests.Location = new System.Drawing.Point(209, 589);
            this.lblTotalGuests.Name = "lblTotalGuests";
            this.lblTotalGuests.Size = new System.Drawing.Size(75, 33);
            this.lblTotalGuests.TabIndex = 4;
            this.lblTotalGuests.Text = "??? ";
            // 
            // lblNoGuestinTheHotel
            // 
            this.lblNoGuestinTheHotel.AutoSize = true;
            this.lblNoGuestinTheHotel.BackColor = System.Drawing.Color.White;
            this.lblNoGuestinTheHotel.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoGuestinTheHotel.Location = new System.Drawing.Point(70, 414);
            this.lblNoGuestinTheHotel.Name = "lblNoGuestinTheHotel";
            this.lblNoGuestinTheHotel.Size = new System.Drawing.Size(594, 73);
            this.lblNoGuestinTheHotel.TabIndex = 5;
            this.lblNoGuestinTheHotel.Text = "The Hotel Is Empty";
            this.lblNoGuestinTheHotel.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::HMS_Presontation_Layer.Properties.Resources.guestsInHotel;
            this.pictureBox1.Location = new System.Drawing.Point(280, 54);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(384, 278);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // CtrGuestsInHotel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Controls.Add(this.lblNoGuestinTheHotel);
            this.Controls.Add(this.lblTotalGuests);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dgvGuestsInHotel);
            this.Name = "CtrGuestsInHotel";
            this.Size = new System.Drawing.Size(955, 630);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGuestsInHotel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvGuestsInHotel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblTotalGuests;
        private System.Windows.Forms.Label lblNoGuestinTheHotel;
    }
}
