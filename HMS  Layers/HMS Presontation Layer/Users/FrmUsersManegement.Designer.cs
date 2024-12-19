namespace HMS_Presontation_Layer.Users
{
    partial class FrmUsersManegement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmUsersManegement));
            this.dgvAllUsers = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showUserInformationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.updateUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.makeUserActiveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.makeUserInActiveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.makeUserAdminToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.makeUserNormalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.changePasswordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblTotalUsers = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbFilter = new System.Windows.Forms.ComboBox();
            this.tbFilter = new System.Windows.Forms.TextBox();
            this.grbUserActive = new System.Windows.Forms.GroupBox();
            this.rdbNotActive = new System.Windows.Forms.RadioButton();
            this.rdbActive = new System.Windows.Forms.RadioButton();
            this.grbUserType = new System.Windows.Forms.GroupBox();
            this.rdbAdminUser = new System.Windows.Forms.RadioButton();
            this.rdbNormalUser = new System.Windows.Forms.RadioButton();
            this.lblNoRecord = new System.Windows.Forms.Label();
            this.btnAddGuest = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllUsers)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.grbUserActive.SuspendLayout();
            this.grbUserType.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvAllUsers
            // 
            this.dgvAllUsers.BackgroundColor = System.Drawing.Color.White;
            this.dgvAllUsers.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvAllUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAllUsers.ContextMenuStrip = this.contextMenuStrip1;
            this.dgvAllUsers.GridColor = System.Drawing.Color.Gray;
            this.dgvAllUsers.Location = new System.Drawing.Point(8, 295);
            this.dgvAllUsers.Name = "dgvAllUsers";
            this.dgvAllUsers.ReadOnly = true;
            this.dgvAllUsers.RowTemplate.DividerHeight = 1;
            this.dgvAllUsers.RowTemplate.Height = 32;
            this.dgvAllUsers.RowTemplate.ReadOnly = true;
            this.dgvAllUsers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAllUsers.Size = new System.Drawing.Size(851, 314);
            this.dgvAllUsers.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showUserInformationToolStripMenuItem,
            this.toolStripSeparator1,
            this.updateUserToolStripMenuItem,
            this.toolStripSeparator2,
            this.makeUserActiveToolStripMenuItem,
            this.toolStripSeparator3,
            this.makeUserInActiveToolStripMenuItem,
            this.toolStripSeparator4,
            this.makeUserAdminToolStripMenuItem,
            this.toolStripSeparator5,
            this.makeUserNormalToolStripMenuItem,
            this.toolStripSeparator6,
            this.changePasswordToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(394, 552);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // showUserInformationToolStripMenuItem
            // 
            this.showUserInformationToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showUserInformationToolStripMenuItem.Image = global::HMS_Presontation_Layer.Properties.Resources.personal_information64;
            this.showUserInformationToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.showUserInformationToolStripMenuItem.Name = "showUserInformationToolStripMenuItem";
            this.showUserInformationToolStripMenuItem.Size = new System.Drawing.Size(393, 70);
            this.showUserInformationToolStripMenuItem.Text = "Show User Information";
            this.showUserInformationToolStripMenuItem.Click += new System.EventHandler(this.showUserInformationToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(390, 6);
            // 
            // updateUserToolStripMenuItem
            // 
            this.updateUserToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateUserToolStripMenuItem.Image = global::HMS_Presontation_Layer.Properties.Resources.Update64;
            this.updateUserToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.updateUserToolStripMenuItem.Name = "updateUserToolStripMenuItem";
            this.updateUserToolStripMenuItem.Size = new System.Drawing.Size(393, 70);
            this.updateUserToolStripMenuItem.Text = "Update User";
            this.updateUserToolStripMenuItem.Click += new System.EventHandler(this.updateUserToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(390, 6);
            // 
            // makeUserActiveToolStripMenuItem
            // 
            this.makeUserActiveToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.makeUserActiveToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlText;
            this.makeUserActiveToolStripMenuItem.Image = global::HMS_Presontation_Layer.Properties.Resources.ActiveUserIcon64;
            this.makeUserActiveToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.makeUserActiveToolStripMenuItem.Name = "makeUserActiveToolStripMenuItem";
            this.makeUserActiveToolStripMenuItem.Size = new System.Drawing.Size(393, 70);
            this.makeUserActiveToolStripMenuItem.Text = "Make User Active";
            this.makeUserActiveToolStripMenuItem.Click += new System.EventHandler(this.makeUserActiveToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(390, 6);
            // 
            // makeUserInActiveToolStripMenuItem
            // 
            this.makeUserInActiveToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.makeUserInActiveToolStripMenuItem.Image = global::HMS_Presontation_Layer.Properties.Resources.InActiveUserIcon64;
            this.makeUserInActiveToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.makeUserInActiveToolStripMenuItem.Name = "makeUserInActiveToolStripMenuItem";
            this.makeUserInActiveToolStripMenuItem.Size = new System.Drawing.Size(393, 70);
            this.makeUserInActiveToolStripMenuItem.Text = "Make User InActive";
            this.makeUserInActiveToolStripMenuItem.Click += new System.EventHandler(this.makeUserInActiveToolStripMenuItem_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(390, 6);
            // 
            // makeUserAdminToolStripMenuItem
            // 
            this.makeUserAdminToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.makeUserAdminToolStripMenuItem.Image = global::HMS_Presontation_Layer.Properties.Resources.AdminUserIcon64;
            this.makeUserAdminToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.makeUserAdminToolStripMenuItem.Name = "makeUserAdminToolStripMenuItem";
            this.makeUserAdminToolStripMenuItem.Size = new System.Drawing.Size(393, 70);
            this.makeUserAdminToolStripMenuItem.Text = "Make User Admin";
            this.makeUserAdminToolStripMenuItem.Click += new System.EventHandler(this.makeUserAdminToolStripMenuItem_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(390, 6);
            // 
            // makeUserNormalToolStripMenuItem
            // 
            this.makeUserNormalToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.makeUserNormalToolStripMenuItem.Image = global::HMS_Presontation_Layer.Properties.Resources.NormalUser;
            this.makeUserNormalToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.makeUserNormalToolStripMenuItem.Name = "makeUserNormalToolStripMenuItem";
            this.makeUserNormalToolStripMenuItem.Size = new System.Drawing.Size(393, 70);
            this.makeUserNormalToolStripMenuItem.Text = "Make User Normal";
            this.makeUserNormalToolStripMenuItem.Click += new System.EventHandler(this.makeUserNormalToolStripMenuItem_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(390, 6);
            // 
            // changePasswordToolStripMenuItem
            // 
            this.changePasswordToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changePasswordToolStripMenuItem.Image = global::HMS_Presontation_Layer.Properties.Resources.ChangePassword64;
            this.changePasswordToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.changePasswordToolStripMenuItem.Name = "changePasswordToolStripMenuItem";
            this.changePasswordToolStripMenuItem.Size = new System.Drawing.Size(393, 70);
            this.changePasswordToolStripMenuItem.Text = "Change Password";
            this.changePasswordToolStripMenuItem.Click += new System.EventHandler(this.changePasswordToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(306, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(380, 42);
            this.label1.TabIndex = 2;
            this.label1.Text = "Users Managements";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 618);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(162, 29);
            this.label2.TabIndex = 3;
            this.label2.Text = "Total Users: ";
            // 
            // lblTotalUsers
            // 
            this.lblTotalUsers.AutoSize = true;
            this.lblTotalUsers.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalUsers.Location = new System.Drawing.Point(160, 622);
            this.lblTotalUsers.Name = "lblTotalUsers";
            this.lblTotalUsers.Size = new System.Drawing.Size(50, 24);
            this.lblTotalUsers.TabIndex = 4;
            this.lblTotalUsers.Text = "????";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(5, 250);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 29);
            this.label3.TabIndex = 5;
            this.label3.Text = "Filter By: ";
            // 
            // cmbFilter
            // 
            this.cmbFilter.FormattingEnabled = true;
            this.cmbFilter.Items.AddRange(new object[] {
            "None",
            "UserID",
            "UserName"});
            this.cmbFilter.Location = new System.Drawing.Point(120, 250);
            this.cmbFilter.Name = "cmbFilter";
            this.cmbFilter.Size = new System.Drawing.Size(138, 28);
            this.cmbFilter.TabIndex = 6;
            this.cmbFilter.SelectedIndexChanged += new System.EventHandler(this.cmbFilter_SelectedIndexChanged);
            // 
            // tbFilter
            // 
            this.tbFilter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbFilter.Location = new System.Drawing.Point(264, 249);
            this.tbFilter.Name = "tbFilter";
            this.tbFilter.Size = new System.Drawing.Size(110, 29);
            this.tbFilter.TabIndex = 7;
            this.tbFilter.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbFilter.TextChanged += new System.EventHandler(this.tbFilter_TextChanged);
            this.tbFilter.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbFilter_KeyPress);
            // 
            // grbUserActive
            // 
            this.grbUserActive.Controls.Add(this.rdbNotActive);
            this.grbUserActive.Controls.Add(this.rdbActive);
            this.grbUserActive.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbUserActive.Location = new System.Drawing.Point(10, 122);
            this.grbUserActive.Name = "grbUserActive";
            this.grbUserActive.Size = new System.Drawing.Size(176, 100);
            this.grbUserActive.TabIndex = 8;
            this.grbUserActive.TabStop = false;
            this.grbUserActive.Text = "User Active";
            // 
            // rdbNotActive
            // 
            this.rdbNotActive.AutoSize = true;
            this.rdbNotActive.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbNotActive.Location = new System.Drawing.Point(39, 68);
            this.rdbNotActive.Name = "rdbNotActive";
            this.rdbNotActive.Size = new System.Drawing.Size(99, 24);
            this.rdbNotActive.TabIndex = 1;
            this.rdbNotActive.Text = "Not Active";
            this.rdbNotActive.UseVisualStyleBackColor = true;
            this.rdbNotActive.CheckedChanged += new System.EventHandler(this.rdbActive_CheckedChanged);
            // 
            // rdbActive
            // 
            this.rdbActive.AutoSize = true;
            this.rdbActive.Checked = true;
            this.rdbActive.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbActive.Location = new System.Drawing.Point(39, 38);
            this.rdbActive.Name = "rdbActive";
            this.rdbActive.Size = new System.Drawing.Size(70, 24);
            this.rdbActive.TabIndex = 0;
            this.rdbActive.TabStop = true;
            this.rdbActive.Text = "Active";
            this.rdbActive.UseVisualStyleBackColor = true;
            this.rdbActive.CheckedChanged += new System.EventHandler(this.rdbActive_CheckedChanged);
            // 
            // grbUserType
            // 
            this.grbUserType.Controls.Add(this.rdbAdminUser);
            this.grbUserType.Controls.Add(this.rdbNormalUser);
            this.grbUserType.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbUserType.Location = new System.Drawing.Point(198, 122);
            this.grbUserType.Name = "grbUserType";
            this.grbUserType.Size = new System.Drawing.Size(176, 100);
            this.grbUserType.TabIndex = 9;
            this.grbUserType.TabStop = false;
            this.grbUserType.Text = "User Type";
            // 
            // rdbAdminUser
            // 
            this.rdbAdminUser.AutoSize = true;
            this.rdbAdminUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbAdminUser.Location = new System.Drawing.Point(39, 68);
            this.rdbAdminUser.Name = "rdbAdminUser";
            this.rdbAdminUser.Size = new System.Drawing.Size(72, 24);
            this.rdbAdminUser.TabIndex = 1;
            this.rdbAdminUser.Text = "Admin";
            this.rdbAdminUser.UseVisualStyleBackColor = true;
            this.rdbAdminUser.CheckedChanged += new System.EventHandler(this.rdbActive_CheckedChanged);
            // 
            // rdbNormalUser
            // 
            this.rdbNormalUser.AutoSize = true;
            this.rdbNormalUser.Checked = true;
            this.rdbNormalUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbNormalUser.Location = new System.Drawing.Point(39, 38);
            this.rdbNormalUser.Name = "rdbNormalUser";
            this.rdbNormalUser.Size = new System.Drawing.Size(77, 24);
            this.rdbNormalUser.TabIndex = 0;
            this.rdbNormalUser.TabStop = true;
            this.rdbNormalUser.Text = "Normal";
            this.rdbNormalUser.UseVisualStyleBackColor = true;
            this.rdbNormalUser.CheckedChanged += new System.EventHandler(this.rdbActive_CheckedChanged);
            // 
            // lblNoRecord
            // 
            this.lblNoRecord.AutoSize = true;
            this.lblNoRecord.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoRecord.Location = new System.Drawing.Point(146, 406);
            this.lblNoRecord.Name = "lblNoRecord";
            this.lblNoRecord.Size = new System.Drawing.Size(559, 108);
            this.lblNoRecord.TabIndex = 11;
            this.lblNoRecord.Text = "No Records";
            // 
            // btnAddGuest
            // 
            this.btnAddGuest.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.btnAddGuest.FlatAppearance.BorderSize = 3;
            this.btnAddGuest.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Blue;
            this.btnAddGuest.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue;
            this.btnAddGuest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddGuest.Image = global::HMS_Presontation_Layer.Properties.Resources.AddNewPerson;
            this.btnAddGuest.Location = new System.Drawing.Point(775, 190);
            this.btnAddGuest.Name = "btnAddGuest";
            this.btnAddGuest.Size = new System.Drawing.Size(84, 89);
            this.btnAddGuest.TabIndex = 10;
            this.btnAddGuest.UseVisualStyleBackColor = true;
            this.btnAddGuest.Click += new System.EventHandler(this.btnAddGuest_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::HMS_Presontation_Layer.Properties.Resources.users;
            this.pictureBox1.Location = new System.Drawing.Point(395, 61);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(218, 218);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // FrmUsersManegement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(863, 656);
            this.Controls.Add(this.lblNoRecord);
            this.Controls.Add(this.btnAddGuest);
            this.Controls.Add(this.grbUserType);
            this.Controls.Add(this.grbUserActive);
            this.Controls.Add(this.tbFilter);
            this.Controls.Add(this.cmbFilter);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblTotalUsers);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dgvAllUsers);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmUsersManegement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Users   Manegement";
            this.Load += new System.EventHandler(this.FrmUsersManegement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllUsers)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.grbUserActive.ResumeLayout(false);
            this.grbUserActive.PerformLayout();
            this.grbUserType.ResumeLayout(false);
            this.grbUserType.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAllUsers;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblTotalUsers;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbFilter;
        private System.Windows.Forms.TextBox tbFilter;
        private System.Windows.Forms.GroupBox grbUserActive;
        private System.Windows.Forms.RadioButton rdbNotActive;
        private System.Windows.Forms.RadioButton rdbActive;
        private System.Windows.Forms.GroupBox grbUserType;
        private System.Windows.Forms.RadioButton rdbAdminUser;
        private System.Windows.Forms.RadioButton rdbNormalUser;
        private System.Windows.Forms.Button btnAddGuest;
        private System.Windows.Forms.Label lblNoRecord;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem showUserInformationToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem updateUserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem makeUserActiveToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem makeUserInActiveToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem makeUserAdminToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem makeUserNormalToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripMenuItem changePasswordToolStripMenuItem;
    }
}