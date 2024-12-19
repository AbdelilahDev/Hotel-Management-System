namespace HMS_Presontation_Layer.Rooms
{
    partial class frmManagementRooms
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmManagementRooms));
            this.label1 = new System.Windows.Forms.Label();
            this.dgvRoomManagement = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbFilter = new System.Windows.Forms.ComboBox();
            this.tbFilter = new System.Windows.Forms.TextBox();
            this.cmbRoomType = new System.Windows.Forms.ComboBox();
            this.gbActivity = new System.Windows.Forms.GroupBox();
            this.rdbNotActive = new System.Windows.Forms.RadioButton();
            this.rdbActive = new System.Windows.Forms.RadioButton();
            this.gbBooking = new System.Windows.Forms.GroupBox();
            this.rdbBooked = new System.Windows.Forms.RadioButton();
            this.rdbNotBooking = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.lblCountRooms = new System.Windows.Forms.Label();
            this.lblNorecordFound = new System.Windows.Forms.Label();
            this.btnAddRoom = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRoomManagement)).BeginInit();
            this.gbActivity.SuspendLayout();
            this.gbBooking.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(293, 174);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(401, 37);
            this.label1.TabIndex = 1;
            this.label1.Text = "Hotel Room Management";
            // 
            // dgvRoomManagement
            // 
            this.dgvRoomManagement.BackgroundColor = System.Drawing.Color.White;
            this.dgvRoomManagement.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRoomManagement.Location = new System.Drawing.Point(12, 314);
            this.dgvRoomManagement.Name = "dgvRoomManagement";
            this.dgvRoomManagement.ReadOnly = true;
            this.dgvRoomManagement.RowTemplate.DividerHeight = 1;
            this.dgvRoomManagement.RowTemplate.Height = 32;
            this.dgvRoomManagement.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRoomManagement.Size = new System.Drawing.Size(971, 261);
            this.dgvRoomManagement.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(7, 282);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Filter By ";
            // 
            // cmbFilter
            // 
            this.cmbFilter.FormattingEnabled = true;
            this.cmbFilter.Items.AddRange(new object[] {
            "None",
            "RoomID",
            "RoomNumber",
            "RoomType"});
            this.cmbFilter.Location = new System.Drawing.Point(113, 280);
            this.cmbFilter.Name = "cmbFilter";
            this.cmbFilter.Size = new System.Drawing.Size(121, 28);
            this.cmbFilter.TabIndex = 4;
            this.cmbFilter.SelectedIndexChanged += new System.EventHandler(this.cmbFilter_SelectedIndexChanged);
            // 
            // tbFilter
            // 
            this.tbFilter.Location = new System.Drawing.Point(253, 280);
            this.tbFilter.Name = "tbFilter";
            this.tbFilter.Size = new System.Drawing.Size(121, 26);
            this.tbFilter.TabIndex = 5;
            this.tbFilter.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbFilter.TextChanged += new System.EventHandler(this.tbFilter_TextChanged);
            this.tbFilter.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbFilter_KeyPress);
            // 
            // cmbRoomType
            // 
            this.cmbRoomType.FormattingEnabled = true;
            this.cmbRoomType.Items.AddRange(new object[] {
            "Standard",
            "Deluxe",
            "Suite",
            "Executive",
            "Family",
            "Connecting Rooms",
            "Accessible",
            "Penthouse"});
            this.cmbRoomType.Location = new System.Drawing.Point(246, 279);
            this.cmbRoomType.Name = "cmbRoomType";
            this.cmbRoomType.Size = new System.Drawing.Size(121, 28);
            this.cmbRoomType.TabIndex = 6;
            this.cmbRoomType.Visible = false;
            this.cmbRoomType.SelectedIndexChanged += new System.EventHandler(this.cmbRoomType_SelectedIndexChanged);
            // 
            // gbActivity
            // 
            this.gbActivity.Controls.Add(this.rdbNotActive);
            this.gbActivity.Controls.Add(this.rdbActive);
            this.gbActivity.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbActivity.ForeColor = System.Drawing.Color.Blue;
            this.gbActivity.Location = new System.Drawing.Point(409, 227);
            this.gbActivity.Name = "gbActivity";
            this.gbActivity.Size = new System.Drawing.Size(135, 80);
            this.gbActivity.TabIndex = 7;
            this.gbActivity.TabStop = false;
            this.gbActivity.Text = "Activity";
            // 
            // rdbNotActive
            // 
            this.rdbNotActive.AutoSize = true;
            this.rdbNotActive.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbNotActive.Location = new System.Drawing.Point(6, 58);
            this.rdbNotActive.Name = "rdbNotActive";
            this.rdbNotActive.Size = new System.Drawing.Size(99, 24);
            this.rdbNotActive.TabIndex = 1;
            this.rdbNotActive.Text = "Not Active";
            this.rdbNotActive.UseVisualStyleBackColor = true;
            this.rdbNotActive.CheckedChanged += new System.EventHandler(this.rdbNotActive_CheckedChanged);
            // 
            // rdbActive
            // 
            this.rdbActive.AutoSize = true;
            this.rdbActive.Checked = true;
            this.rdbActive.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbActive.Location = new System.Drawing.Point(6, 28);
            this.rdbActive.Name = "rdbActive";
            this.rdbActive.Size = new System.Drawing.Size(70, 24);
            this.rdbActive.TabIndex = 0;
            this.rdbActive.TabStop = true;
            this.rdbActive.Text = "Active";
            this.rdbActive.UseVisualStyleBackColor = true;
            this.rdbActive.CheckedChanged += new System.EventHandler(this.rdbActive_CheckedChanged);
            // 
            // gbBooking
            // 
            this.gbBooking.Controls.Add(this.rdbBooked);
            this.gbBooking.Controls.Add(this.rdbNotBooking);
            this.gbBooking.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbBooking.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.gbBooking.Location = new System.Drawing.Point(588, 227);
            this.gbBooking.Name = "gbBooking";
            this.gbBooking.Size = new System.Drawing.Size(135, 82);
            this.gbBooking.TabIndex = 8;
            this.gbBooking.TabStop = false;
            this.gbBooking.Text = "Booking";
            // 
            // rdbBooked
            // 
            this.rdbBooked.AutoSize = true;
            this.rdbBooked.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbBooked.Location = new System.Drawing.Point(10, 53);
            this.rdbBooked.Name = "rdbBooked";
            this.rdbBooked.Size = new System.Drawing.Size(82, 24);
            this.rdbBooked.TabIndex = 3;
            this.rdbBooked.Text = "Booked";
            this.rdbBooked.UseVisualStyleBackColor = true;
            this.rdbBooked.CheckedChanged += new System.EventHandler(this.rdbBooked_CheckedChanged);
            // 
            // rdbNotBooking
            // 
            this.rdbNotBooking.AutoSize = true;
            this.rdbNotBooking.Checked = true;
            this.rdbNotBooking.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbNotBooking.Location = new System.Drawing.Point(12, 25);
            this.rdbNotBooking.Name = "rdbNotBooking";
            this.rdbNotBooking.Size = new System.Drawing.Size(114, 24);
            this.rdbNotBooking.TabIndex = 2;
            this.rdbNotBooking.TabStop = true;
            this.rdbNotBooking.Text = "Not Booking";
            this.rdbNotBooking.UseVisualStyleBackColor = true;
            this.rdbNotBooking.CheckedChanged += new System.EventHandler(this.rdbNotBooking_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 591);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(220, 25);
            this.label3.TabIndex = 9;
            this.label3.Text = "Number of Rooms:  ";
            // 
            // lblCountRooms
            // 
            this.lblCountRooms.AutoSize = true;
            this.lblCountRooms.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCountRooms.Location = new System.Drawing.Point(216, 594);
            this.lblCountRooms.Name = "lblCountRooms";
            this.lblCountRooms.Size = new System.Drawing.Size(36, 20);
            this.lblCountRooms.TabIndex = 10;
            this.lblCountRooms.Text = "???";
            // 
            // lblNorecordFound
            // 
            this.lblNorecordFound.AutoSize = true;
            this.lblNorecordFound.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNorecordFound.Location = new System.Drawing.Point(95, 382);
            this.lblNorecordFound.Name = "lblNorecordFound";
            this.lblNorecordFound.Size = new System.Drawing.Size(798, 108);
            this.lblNorecordFound.TabIndex = 11;
            this.lblNorecordFound.Text = "No Record Found";
            this.lblNorecordFound.Visible = false;
            // 
            // btnAddRoom
            // 
            this.btnAddRoom.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.btnAddRoom.FlatAppearance.BorderSize = 3;
            this.btnAddRoom.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Blue;
            this.btnAddRoom.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue;
            this.btnAddRoom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddRoom.Image = global::HMS_Presontation_Layer.Properties.Resources.AddRoom64;
            this.btnAddRoom.Location = new System.Drawing.Point(892, 215);
            this.btnAddRoom.Name = "btnAddRoom";
            this.btnAddRoom.Size = new System.Drawing.Size(84, 89);
            this.btnAddRoom.TabIndex = 12;
            this.btnAddRoom.UseVisualStyleBackColor = true;
            this.btnAddRoom.Click += new System.EventHandler(this.btnAddRoom_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::HMS_Presontation_Layer.Properties.Resources.RoomsImage;
            this.pictureBox1.Location = new System.Drawing.Point(409, 7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(175, 161);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // frmManagementRooms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(988, 630);
            this.Controls.Add(this.btnAddRoom);
            this.Controls.Add(this.lblNorecordFound);
            this.Controls.Add(this.lblCountRooms);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.gbBooking);
            this.Controls.Add(this.gbActivity);
            this.Controls.Add(this.cmbRoomType);
            this.Controls.Add(this.tbFilter);
            this.Controls.Add(this.cmbFilter);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvRoomManagement);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmManagementRooms";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Management   Rooms";
            this.Load += new System.EventHandler(this.frmManagementRooms_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRoomManagement)).EndInit();
            this.gbActivity.ResumeLayout(false);
            this.gbActivity.PerformLayout();
            this.gbBooking.ResumeLayout(false);
            this.gbBooking.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvRoomManagement;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbFilter;
        private System.Windows.Forms.TextBox tbFilter;
        private System.Windows.Forms.ComboBox cmbRoomType;
        private System.Windows.Forms.GroupBox gbActivity;
        private System.Windows.Forms.GroupBox gbBooking;
        private System.Windows.Forms.RadioButton rdbNotActive;
        private System.Windows.Forms.RadioButton rdbActive;
        private System.Windows.Forms.RadioButton rdbBooked;
        private System.Windows.Forms.RadioButton rdbNotBooking;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblCountRooms;
        private System.Windows.Forms.Label lblNorecordFound;
        private System.Windows.Forms.Button btnAddRoom;
    }
}