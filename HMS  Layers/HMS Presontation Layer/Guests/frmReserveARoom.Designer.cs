namespace HMS_Presontation_Layer.Guests
{
    partial class frmReserveARoom
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReserveARoom));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tbGuest = new System.Windows.Forms.TabPage();
            this.ctrShowPersonInformation1 = new HMS_Presontation_Layer.General_UserControls.CtrShowPersonInformation();
            this.tbRoom = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dgvRooms = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.reserveTheRoomToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tbGuest.SuspendLayout();
            this.tbRoom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRooms)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tbGuest);
            this.tabControl1.Controls.Add(this.tbRoom);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(5, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(682, 592);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tbGuest
            // 
            this.tbGuest.Controls.Add(this.ctrShowPersonInformation1);
            this.tbGuest.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbGuest.Location = new System.Drawing.Point(4, 33);
            this.tbGuest.Name = "tbGuest";
            this.tbGuest.Padding = new System.Windows.Forms.Padding(3);
            this.tbGuest.Size = new System.Drawing.Size(674, 555);
            this.tbGuest.TabIndex = 0;
            this.tbGuest.Text = "The Guest";
            this.tbGuest.UseVisualStyleBackColor = true;
            // 
            // ctrShowPersonInformation1
            // 
            this.ctrShowPersonInformation1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctrShowPersonInformation1.Location = new System.Drawing.Point(100, 15);
            this.ctrShowPersonInformation1.Margin = new System.Windows.Forms.Padding(6);
            this.ctrShowPersonInformation1.Name = "ctrShowPersonInformation1";
            this.ctrShowPersonInformation1.Size = new System.Drawing.Size(424, 531);
            this.ctrShowPersonInformation1.TabIndex = 0;
            // 
            // tbRoom
            // 
            this.tbRoom.Controls.Add(this.label1);
            this.tbRoom.Controls.Add(this.pictureBox1);
            this.tbRoom.Controls.Add(this.dgvRooms);
            this.tbRoom.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbRoom.Location = new System.Drawing.Point(4, 33);
            this.tbRoom.Name = "tbRoom";
            this.tbRoom.Padding = new System.Windows.Forms.Padding(3);
            this.tbRoom.Size = new System.Drawing.Size(674, 555);
            this.tbRoom.TabIndex = 1;
            this.tbRoom.Text = "The Room";
            this.tbRoom.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(219, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(284, 33);
            this.label1.TabIndex = 2;
            this.label1.Text = "Reserve The Room";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::HMS_Presontation_Layer.Properties.Resources.RoomsImage;
            this.pictureBox1.Location = new System.Drawing.Point(247, 51);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(247, 207);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // dgvRooms
            // 
            this.dgvRooms.BackgroundColor = System.Drawing.Color.White;
            this.dgvRooms.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRooms.ContextMenuStrip = this.contextMenuStrip1;
            this.dgvRooms.Location = new System.Drawing.Point(5, 273);
            this.dgvRooms.Name = "dgvRooms";
            this.dgvRooms.ReadOnly = true;
            this.dgvRooms.RowTemplate.DividerHeight = 1;
            this.dgvRooms.RowTemplate.Height = 32;
            this.dgvRooms.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRooms.Size = new System.Drawing.Size(662, 243);
            this.dgvRooms.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reserveTheRoomToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(371, 74);
            // 
            // reserveTheRoomToolStripMenuItem
            // 
            this.reserveTheRoomToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reserveTheRoomToolStripMenuItem.Image = global::HMS_Presontation_Layer.Properties.Resources.booking64;
            this.reserveTheRoomToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.reserveTheRoomToolStripMenuItem.Name = "reserveTheRoomToolStripMenuItem";
            this.reserveTheRoomToolStripMenuItem.Size = new System.Drawing.Size(370, 70);
            this.reserveTheRoomToolStripMenuItem.Text = "Reserve The Room";
            this.reserveTheRoomToolStripMenuItem.Click += new System.EventHandler(this.reserveTheRoomToolStripMenuItem_Click);
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Image = global::HMS_Presontation_Layer.Properties.Resources.BackIcon;
            this.btnBack.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBack.Location = new System.Drawing.Point(128, 642);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(111, 37);
            this.btnBack.TabIndex = 2;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnNext
            // 
            this.btnNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.Image = global::HMS_Presontation_Layer.Properties.Resources.NextIcon;
            this.btnNext.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNext.Location = new System.Drawing.Point(447, 642);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(116, 37);
            this.btnNext.TabIndex = 1;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // frmReserveARoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(691, 711);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmReserveARoom";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Reserve  A   Room";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmReserveARoom_FormClosed);
            this.Load += new System.EventHandler(this.frmReserveARoom_Load);
            this.tabControl1.ResumeLayout(false);
            this.tbGuest.ResumeLayout(false);
            this.tbRoom.ResumeLayout(false);
            this.tbRoom.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRooms)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tbGuest;
        private System.Windows.Forms.TabPage tbRoom;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnBack;
        private General_UserControls.CtrShowPersonInformation ctrShowPersonInformation1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dgvRooms;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem reserveTheRoomToolStripMenuItem;
    }
}