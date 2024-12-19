namespace HMS_Presontation_Layer
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.guestsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewGuestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.guestsInToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.guestManagementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.reservationGuestsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.roomsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.currentUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.userInformationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changePasswordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usersManagementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.paymentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewPaymentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.paymentManagementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statisticsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.employeesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.guestsToolStripMenuItem,
            this.roomsToolStripMenuItem,
            this.currentUserToolStripMenuItem,
            this.usersToolStripMenuItem,
            this.paymentToolStripMenuItem,
            this.statisticsToolStripMenuItem,
            this.employeesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1065, 102);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // guestsToolStripMenuItem
            // 
            this.guestsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewGuestToolStripMenuItem,
            this.toolStripSeparator1,
            this.guestsInToolStripMenuItem,
            this.toolStripSeparator2,
            this.guestManagementToolStripMenuItem,
            this.toolStripSeparator3,
            this.reservationGuestsToolStripMenuItem});
            this.guestsToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guestsToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("guestsToolStripMenuItem.Image")));
            this.guestsToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.guestsToolStripMenuItem.Margin = new System.Windows.Forms.Padding(0, 0, 14, 0);
            this.guestsToolStripMenuItem.Name = "guestsToolStripMenuItem";
            this.guestsToolStripMenuItem.Size = new System.Drawing.Size(90, 98);
            this.guestsToolStripMenuItem.Text = "Guests";
            this.guestsToolStripMenuItem.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            this.guestsToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // addNewGuestToolStripMenuItem
            // 
            this.addNewGuestToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addNewGuestToolStripMenuItem.Image = global::HMS_Presontation_Layer.Properties.Resources.newGuest64;
            this.addNewGuestToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.addNewGuestToolStripMenuItem.Name = "addNewGuestToolStripMenuItem";
            this.addNewGuestToolStripMenuItem.Size = new System.Drawing.Size(335, 70);
            this.addNewGuestToolStripMenuItem.Text = "Add New Guest";
            this.addNewGuestToolStripMenuItem.Click += new System.EventHandler(this.addNewGuestToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(332, 6);
            // 
            // guestsInToolStripMenuItem
            // 
            this.guestsInToolStripMenuItem.Image = global::HMS_Presontation_Layer.Properties.Resources.GuestsInHotel64;
            this.guestsInToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.guestsInToolStripMenuItem.Name = "guestsInToolStripMenuItem";
            this.guestsInToolStripMenuItem.Size = new System.Drawing.Size(335, 70);
            this.guestsInToolStripMenuItem.Text = "Guests In the Hotel";
            this.guestsInToolStripMenuItem.Click += new System.EventHandler(this.guestsInToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(332, 6);
            // 
            // guestManagementToolStripMenuItem
            // 
            this.guestManagementToolStripMenuItem.Image = global::HMS_Presontation_Layer.Properties.Resources.GuestsManagement64;
            this.guestManagementToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.guestManagementToolStripMenuItem.Name = "guestManagementToolStripMenuItem";
            this.guestManagementToolStripMenuItem.Size = new System.Drawing.Size(335, 70);
            this.guestManagementToolStripMenuItem.Text = "Guests Management";
            this.guestManagementToolStripMenuItem.Click += new System.EventHandler(this.guestManagementToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(332, 6);
            // 
            // reservationGuestsToolStripMenuItem
            // 
            this.reservationGuestsToolStripMenuItem.Image = global::HMS_Presontation_Layer.Properties.Resources.Reservationicon64;
            this.reservationGuestsToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.reservationGuestsToolStripMenuItem.Name = "reservationGuestsToolStripMenuItem";
            this.reservationGuestsToolStripMenuItem.Size = new System.Drawing.Size(335, 70);
            this.reservationGuestsToolStripMenuItem.Text = "Reservation Guests";
            this.reservationGuestsToolStripMenuItem.Click += new System.EventHandler(this.reservationGuestsToolStripMenuItem_Click);
            // 
            // roomsToolStripMenuItem
            // 
            this.roomsToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roomsToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("roomsToolStripMenuItem.Image")));
            this.roomsToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.roomsToolStripMenuItem.Margin = new System.Windows.Forms.Padding(0, 0, 14, 0);
            this.roomsToolStripMenuItem.Name = "roomsToolStripMenuItem";
            this.roomsToolStripMenuItem.Size = new System.Drawing.Size(92, 98);
            this.roomsToolStripMenuItem.Text = "Rooms";
            this.roomsToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.roomsToolStripMenuItem.Click += new System.EventHandler(this.roomsToolStripMenuItem_Click);
            // 
            // currentUserToolStripMenuItem
            // 
            this.currentUserToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.userInformationToolStripMenuItem,
            this.updateUserToolStripMenuItem,
            this.changePasswordToolStripMenuItem});
            this.currentUserToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentUserToolStripMenuItem.Image = global::HMS_Presontation_Layer.Properties.Resources.currentUser64;
            this.currentUserToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.currentUserToolStripMenuItem.Margin = new System.Windows.Forms.Padding(0, 0, 14, 0);
            this.currentUserToolStripMenuItem.Name = "currentUserToolStripMenuItem";
            this.currentUserToolStripMenuItem.Size = new System.Drawing.Size(148, 98);
            this.currentUserToolStripMenuItem.Text = "Current User";
            this.currentUserToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // userInformationToolStripMenuItem
            // 
            this.userInformationToolStripMenuItem.Image = global::HMS_Presontation_Layer.Properties.Resources.personal_information64;
            this.userInformationToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.userInformationToolStripMenuItem.Name = "userInformationToolStripMenuItem";
            this.userInformationToolStripMenuItem.Size = new System.Drawing.Size(306, 70);
            this.userInformationToolStripMenuItem.Text = "User Information";
            this.userInformationToolStripMenuItem.Click += new System.EventHandler(this.userInformationToolStripMenuItem_Click);
            // 
            // updateUserToolStripMenuItem
            // 
            this.updateUserToolStripMenuItem.Image = global::HMS_Presontation_Layer.Properties.Resources.Update64;
            this.updateUserToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.updateUserToolStripMenuItem.Name = "updateUserToolStripMenuItem";
            this.updateUserToolStripMenuItem.Size = new System.Drawing.Size(306, 70);
            this.updateUserToolStripMenuItem.Text = "Update User";
            this.updateUserToolStripMenuItem.Click += new System.EventHandler(this.updateUserToolStripMenuItem_Click);
            // 
            // changePasswordToolStripMenuItem
            // 
            this.changePasswordToolStripMenuItem.Image = global::HMS_Presontation_Layer.Properties.Resources.ChangePassword64;
            this.changePasswordToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.changePasswordToolStripMenuItem.Name = "changePasswordToolStripMenuItem";
            this.changePasswordToolStripMenuItem.Size = new System.Drawing.Size(306, 70);
            this.changePasswordToolStripMenuItem.Text = "Change Password";
            this.changePasswordToolStripMenuItem.Click += new System.EventHandler(this.changePasswordToolStripMenuItem_Click);
            // 
            // usersToolStripMenuItem
            // 
            this.usersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewUserToolStripMenuItem,
            this.usersManagementToolStripMenuItem});
            this.usersToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usersToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("usersToolStripMenuItem.Image")));
            this.usersToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.usersToolStripMenuItem.Margin = new System.Windows.Forms.Padding(0, 0, 14, 0);
            this.usersToolStripMenuItem.Name = "usersToolStripMenuItem";
            this.usersToolStripMenuItem.Size = new System.Drawing.Size(77, 98);
            this.usersToolStripMenuItem.Text = "Users";
            this.usersToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // addNewUserToolStripMenuItem
            // 
            this.addNewUserToolStripMenuItem.Image = global::HMS_Presontation_Layer.Properties.Resources.AddNewUser64;
            this.addNewUserToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.addNewUserToolStripMenuItem.Name = "addNewUserToolStripMenuItem";
            this.addNewUserToolStripMenuItem.Size = new System.Drawing.Size(322, 70);
            this.addNewUserToolStripMenuItem.Text = "Add New User";
            this.addNewUserToolStripMenuItem.Click += new System.EventHandler(this.addNewUserToolStripMenuItem_Click);
            // 
            // usersManagementToolStripMenuItem
            // 
            this.usersManagementToolStripMenuItem.Image = global::HMS_Presontation_Layer.Properties.Resources.UserMangementIcon64;
            this.usersManagementToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.usersManagementToolStripMenuItem.Name = "usersManagementToolStripMenuItem";
            this.usersManagementToolStripMenuItem.Size = new System.Drawing.Size(322, 70);
            this.usersManagementToolStripMenuItem.Text = "Users Management";
            this.usersManagementToolStripMenuItem.Click += new System.EventHandler(this.usersManagementToolStripMenuItem_Click);
            // 
            // paymentToolStripMenuItem
            // 
            this.paymentToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewPaymentToolStripMenuItem,
            this.toolStripSeparator4,
            this.paymentManagementToolStripMenuItem});
            this.paymentToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paymentToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("paymentToolStripMenuItem.Image")));
            this.paymentToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.paymentToolStripMenuItem.Margin = new System.Windows.Forms.Padding(0, 0, 14, 0);
            this.paymentToolStripMenuItem.Name = "paymentToolStripMenuItem";
            this.paymentToolStripMenuItem.Size = new System.Drawing.Size(110, 98);
            this.paymentToolStripMenuItem.Text = "Payment";
            this.paymentToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // addNewPaymentToolStripMenuItem
            // 
            this.addNewPaymentToolStripMenuItem.Image = global::HMS_Presontation_Layer.Properties.Resources.AddNewPayment;
            this.addNewPaymentToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.addNewPaymentToolStripMenuItem.Name = "addNewPaymentToolStripMenuItem";
            this.addNewPaymentToolStripMenuItem.Size = new System.Drawing.Size(355, 70);
            this.addNewPaymentToolStripMenuItem.Text = "Add New Payment";
            this.addNewPaymentToolStripMenuItem.Click += new System.EventHandler(this.addNewPaymentToolStripMenuItem_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(352, 6);
            // 
            // paymentManagementToolStripMenuItem
            // 
            this.paymentManagementToolStripMenuItem.Image = global::HMS_Presontation_Layer.Properties.Resources.PaymentMangement;
            this.paymentManagementToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.paymentManagementToolStripMenuItem.Name = "paymentManagementToolStripMenuItem";
            this.paymentManagementToolStripMenuItem.Size = new System.Drawing.Size(355, 70);
            this.paymentManagementToolStripMenuItem.Text = "Payment Management";
            this.paymentManagementToolStripMenuItem.Click += new System.EventHandler(this.paymentManagementToolStripMenuItem_Click);
            // 
            // statisticsToolStripMenuItem
            // 
            this.statisticsToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statisticsToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("statisticsToolStripMenuItem.Image")));
            this.statisticsToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.statisticsToolStripMenuItem.Margin = new System.Windows.Forms.Padding(0, 0, 14, 0);
            this.statisticsToolStripMenuItem.Name = "statisticsToolStripMenuItem";
            this.statisticsToolStripMenuItem.Size = new System.Drawing.Size(109, 98);
            this.statisticsToolStripMenuItem.Text = "statistics";
            this.statisticsToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // employeesToolStripMenuItem
            // 
            this.employeesToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employeesToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("employeesToolStripMenuItem.Image")));
            this.employeesToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.employeesToolStripMenuItem.Name = "employeesToolStripMenuItem";
            this.employeesToolStripMenuItem.Size = new System.Drawing.Size(129, 98);
            this.employeesToolStripMenuItem.Text = "Employees";
            this.employeesToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::HMS_Presontation_Layer.Properties.Resources.HotelBackground;
            this.pictureBox1.Location = new System.Drawing.Point(0, 102);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1065, 608);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1065, 710);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hotel Management System";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem guestsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem roomsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem paymentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem statisticsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem employeesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem currentUserToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem addNewGuestToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem guestsInToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem guestManagementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem userInformationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateUserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changePasswordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewUserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usersManagementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reservationGuestsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem addNewPaymentToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem paymentManagementToolStripMenuItem;
    }
}