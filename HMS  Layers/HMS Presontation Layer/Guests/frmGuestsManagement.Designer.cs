namespace HMS_Presontation_Layer.Guests
{
    partial class frmGuestsManagement
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGuestsManagement));
            this.dgvAllGuests = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.label1 = new System.Windows.Forms.Label();
            this.lblcountAllGuests = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbFilter = new System.Windows.Forms.ComboBox();
            this.tbFilter = new System.Windows.Forms.TextBox();
            this.lblNoGuestsYet = new System.Windows.Forms.Label();
            this.btnAddGuest = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.showAGuestInformatiomToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateAGuestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reserveARoomToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changeTheRoomToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllGuests)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvAllGuests
            // 
            this.dgvAllGuests.BackgroundColor = System.Drawing.Color.White;
            this.dgvAllGuests.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAllGuests.ContextMenuStrip = this.contextMenuStrip1;
            this.dgvAllGuests.Location = new System.Drawing.Point(14, 310);
            this.dgvAllGuests.Name = "dgvAllGuests";
            this.dgvAllGuests.RowTemplate.DividerHeight = 1;
            this.dgvAllGuests.RowTemplate.Height = 32;
            this.dgvAllGuests.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAllGuests.Size = new System.Drawing.Size(974, 273);
            this.dgvAllGuests.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showAGuestInformatiomToolStripMenuItem,
            this.toolStripSeparator1,
            this.updateAGuestToolStripMenuItem,
            this.toolStripSeparator2,
            this.reserveARoomToolStripMenuItem,
            this.toolStripSeparator3,
            this.toolStripSeparator4,
            this.changeTheRoomToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(439, 308);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(435, 6);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(435, 6);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(435, 6);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(435, 6);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 584);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 33);
            this.label1.TabIndex = 1;
            this.label1.Text = "All Guests:  ";
            // 
            // lblcountAllGuests
            // 
            this.lblcountAllGuests.AutoSize = true;
            this.lblcountAllGuests.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcountAllGuests.Location = new System.Drawing.Point(179, 590);
            this.lblcountAllGuests.Name = "lblcountAllGuests";
            this.lblcountAllGuests.Size = new System.Drawing.Size(48, 25);
            this.lblcountAllGuests.TabIndex = 2;
            this.lblcountAllGuests.Text = "???";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(306, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(402, 42);
            this.label2.TabIndex = 4;
            this.label2.Text = "Guests Managements";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(18, 279);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 24);
            this.label3.TabIndex = 5;
            this.label3.Text = "Filter By";
            // 
            // cmbFilter
            // 
            this.cmbFilter.FormattingEnabled = true;
            this.cmbFilter.Items.AddRange(new object[] {
            "None",
            "GuestID",
            "Phone"});
            this.cmbFilter.Location = new System.Drawing.Point(104, 276);
            this.cmbFilter.Name = "cmbFilter";
            this.cmbFilter.Size = new System.Drawing.Size(121, 28);
            this.cmbFilter.TabIndex = 6;
            this.cmbFilter.SelectedIndexChanged += new System.EventHandler(this.cmbFilter_SelectedIndexChanged);
            // 
            // tbFilter
            // 
            this.tbFilter.Location = new System.Drawing.Point(231, 277);
            this.tbFilter.Name = "tbFilter";
            this.tbFilter.Size = new System.Drawing.Size(155, 26);
            this.tbFilter.TabIndex = 7;
            this.tbFilter.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbFilter.TextChanged += new System.EventHandler(this.tbFilter_TextChanged);
            this.tbFilter.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbFilter_KeyPress);
            // 
            // lblNoGuestsYet
            // 
            this.lblNoGuestsYet.AutoSize = true;
            this.lblNoGuestsYet.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoGuestsYet.Location = new System.Drawing.Point(39, 386);
            this.lblNoGuestsYet.Name = "lblNoGuestsYet";
            this.lblNoGuestsYet.Size = new System.Drawing.Size(920, 108);
            this.lblNoGuestsYet.TabIndex = 9;
            this.lblNoGuestsYet.Text = "No Guests Exist Yet";
            // 
            // btnAddGuest
            // 
            this.btnAddGuest.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.btnAddGuest.FlatAppearance.BorderSize = 3;
            this.btnAddGuest.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Blue;
            this.btnAddGuest.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue;
            this.btnAddGuest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddGuest.Image = global::HMS_Presontation_Layer.Properties.Resources.AddNewPerson;
            this.btnAddGuest.Location = new System.Drawing.Point(902, 215);
            this.btnAddGuest.Name = "btnAddGuest";
            this.btnAddGuest.Size = new System.Drawing.Size(84, 89);
            this.btnAddGuest.TabIndex = 8;
            this.btnAddGuest.UseVisualStyleBackColor = true;
            this.btnAddGuest.Click += new System.EventHandler(this.btnAddGuest_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::HMS_Presontation_Layer.Properties.Resources.GuestManagement;
            this.pictureBox1.Location = new System.Drawing.Point(389, 53);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(254, 202);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // showAGuestInformatiomToolStripMenuItem
            // 
            this.showAGuestInformatiomToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showAGuestInformatiomToolStripMenuItem.Image = global::HMS_Presontation_Layer.Properties.Resources.personal_information64;
            this.showAGuestInformatiomToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.showAGuestInformatiomToolStripMenuItem.Name = "showAGuestInformatiomToolStripMenuItem";
            this.showAGuestInformatiomToolStripMenuItem.Size = new System.Drawing.Size(438, 70);
            this.showAGuestInformatiomToolStripMenuItem.Text = "Show A Guest Informatiom";
            this.showAGuestInformatiomToolStripMenuItem.Click += new System.EventHandler(this.showAGuestInformatiomToolStripMenuItem_Click);
            // 
            // updateAGuestToolStripMenuItem
            // 
            this.updateAGuestToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateAGuestToolStripMenuItem.Image = global::HMS_Presontation_Layer.Properties.Resources.Update64;
            this.updateAGuestToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.updateAGuestToolStripMenuItem.Name = "updateAGuestToolStripMenuItem";
            this.updateAGuestToolStripMenuItem.Size = new System.Drawing.Size(438, 70);
            this.updateAGuestToolStripMenuItem.Text = "Update A Guest ";
            this.updateAGuestToolStripMenuItem.Click += new System.EventHandler(this.updateAGuestToolStripMenuItem_Click);
            // 
            // reserveARoomToolStripMenuItem
            // 
            this.reserveARoomToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reserveARoomToolStripMenuItem.Image = global::HMS_Presontation_Layer.Properties.Resources.rate;
            this.reserveARoomToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.reserveARoomToolStripMenuItem.Name = "reserveARoomToolStripMenuItem";
            this.reserveARoomToolStripMenuItem.Size = new System.Drawing.Size(438, 70);
            this.reserveARoomToolStripMenuItem.Text = "Reserve A Room";
            this.reserveARoomToolStripMenuItem.Click += new System.EventHandler(this.reserveARoomToolStripMenuItem_Click);
            // 
            // changeTheRoomToolStripMenuItem
            // 
            this.changeTheRoomToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changeTheRoomToolStripMenuItem.Image = global::HMS_Presontation_Layer.Properties.Resources.room;
            this.changeTheRoomToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.changeTheRoomToolStripMenuItem.Name = "changeTheRoomToolStripMenuItem";
            this.changeTheRoomToolStripMenuItem.Size = new System.Drawing.Size(438, 70);
            this.changeTheRoomToolStripMenuItem.Text = "Update The Reservation";
            this.changeTheRoomToolStripMenuItem.Click += new System.EventHandler(this.changeTheRoomToolStripMenuItem_Click);
            // 
            // frmGuestsManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(998, 636);
            this.Controls.Add(this.lblNoGuestsYet);
            this.Controls.Add(this.btnAddGuest);
            this.Controls.Add(this.tbFilter);
            this.Controls.Add(this.cmbFilter);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblcountAllGuests);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvAllGuests);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmGuestsManagement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Guests   Management";
            this.Load += new System.EventHandler(this.frmGuestsManagement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllGuests)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAllGuests;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblcountAllGuests;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbFilter;
        private System.Windows.Forms.TextBox tbFilter;
        private System.Windows.Forms.Button btnAddGuest;
        private System.Windows.Forms.Label lblNoGuestsYet;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem showAGuestInformatiomToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem updateAGuestToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem reserveARoomToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem changeTheRoomToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
    }
}