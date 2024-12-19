namespace HMS_Presontation_Layer.Rooms
{
    partial class CtrAddAndUpdateRoom
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.grbIsBooked = new System.Windows.Forms.GroupBox();
            this.rdbNotBooked = new System.Windows.Forms.RadioButton();
            this.rdbBooked = new System.Windows.Forms.RadioButton();
            this.rgbIsActive = new System.Windows.Forms.GroupBox();
            this.rdbNotActive = new System.Windows.Forms.RadioButton();
            this.rdbActive = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.lblRoomID = new System.Windows.Forms.Label();
            this.cmbRoomType = new System.Windows.Forms.ComboBox();
            this.tbRoomNumber = new System.Windows.Forms.TextBox();
            this.tbPrice = new System.Windows.Forms.TextBox();
            this.tbDescription = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnSave = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.grbIsBooked.SuspendLayout();
            this.rgbIsActive.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(185, 305);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "RoomID:  ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(19, 359);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(174, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Room Number: ";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.Red;
            this.lblTitle.Location = new System.Drawing.Point(155, 15);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(215, 31);
            this.lblTitle.TabIndex = 3;
            this.lblTitle.Text = "Add New Room";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(46, 412);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Room Type:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(111, 467);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 25);
            this.label4.TabIndex = 5;
            this.label4.Text = "Price: ";
            // 
            // grbIsBooked
            // 
            this.grbIsBooked.Controls.Add(this.rdbNotBooked);
            this.grbIsBooked.Controls.Add(this.rdbBooked);
            this.grbIsBooked.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbIsBooked.Location = new System.Drawing.Point(427, 76);
            this.grbIsBooked.Name = "grbIsBooked";
            this.grbIsBooked.Size = new System.Drawing.Size(122, 100);
            this.grbIsBooked.TabIndex = 6;
            this.grbIsBooked.TabStop = false;
            this.grbIsBooked.Text = "IsBooked";
            // 
            // rdbNotBooked
            // 
            this.rdbNotBooked.AutoSize = true;
            this.rdbNotBooked.Checked = true;
            this.rdbNotBooked.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbNotBooked.Location = new System.Drawing.Point(6, 64);
            this.rdbNotBooked.Name = "rdbNotBooked";
            this.rdbNotBooked.Size = new System.Drawing.Size(106, 22);
            this.rdbNotBooked.TabIndex = 1;
            this.rdbNotBooked.TabStop = true;
            this.rdbNotBooked.Text = "Not Booked";
            this.rdbNotBooked.UseVisualStyleBackColor = true;
            // 
            // rdbBooked
            // 
            this.rdbBooked.AutoSize = true;
            this.rdbBooked.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbBooked.Location = new System.Drawing.Point(6, 28);
            this.rdbBooked.Name = "rdbBooked";
            this.rdbBooked.Size = new System.Drawing.Size(78, 22);
            this.rdbBooked.TabIndex = 0;
            this.rdbBooked.Text = "Booked";
            this.rdbBooked.UseVisualStyleBackColor = true;
            // 
            // rgbIsActive
            // 
            this.rgbIsActive.Controls.Add(this.rdbNotActive);
            this.rgbIsActive.Controls.Add(this.rdbActive);
            this.rgbIsActive.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rgbIsActive.Location = new System.Drawing.Point(9, 76);
            this.rgbIsActive.Name = "rgbIsActive";
            this.rgbIsActive.Size = new System.Drawing.Size(122, 100);
            this.rgbIsActive.TabIndex = 7;
            this.rgbIsActive.TabStop = false;
            this.rgbIsActive.Text = "IsActive";
            // 
            // rdbNotActive
            // 
            this.rdbNotActive.AutoSize = true;
            this.rdbNotActive.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbNotActive.Location = new System.Drawing.Point(14, 64);
            this.rdbNotActive.Name = "rdbNotActive";
            this.rdbNotActive.Size = new System.Drawing.Size(89, 22);
            this.rdbNotActive.TabIndex = 3;
            this.rdbNotActive.Text = "NotActive";
            this.rdbNotActive.UseVisualStyleBackColor = true;
            // 
            // rdbActive
            // 
            this.rdbActive.AutoSize = true;
            this.rdbActive.Checked = true;
            this.rdbActive.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbActive.Location = new System.Drawing.Point(14, 30);
            this.rdbActive.Name = "rdbActive";
            this.rdbActive.Size = new System.Drawing.Size(65, 22);
            this.rdbActive.TabIndex = 2;
            this.rdbActive.TabStop = true;
            this.rdbActive.Text = "Active";
            this.rdbActive.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(46, 522);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(152, 25);
            this.label5.TabIndex = 8;
            this.label5.Text = "Description:  ";
            // 
            // lblRoomID
            // 
            this.lblRoomID.AutoSize = true;
            this.lblRoomID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoomID.Location = new System.Drawing.Point(288, 308);
            this.lblRoomID.Name = "lblRoomID";
            this.lblRoomID.Size = new System.Drawing.Size(36, 20);
            this.lblRoomID.TabIndex = 9;
            this.lblRoomID.Text = "???";
            // 
            // cmbRoomType
            // 
            this.cmbRoomType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.cmbRoomType.Location = new System.Drawing.Point(190, 412);
            this.cmbRoomType.Name = "cmbRoomType";
            this.cmbRoomType.Size = new System.Drawing.Size(220, 28);
            this.cmbRoomType.TabIndex = 10;
            this.cmbRoomType.SelectedIndexChanged += new System.EventHandler(this.cmbRoomType_SelectedIndexChanged);
            this.cmbRoomType.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbRoomType_KeyPress);
            // 
            // tbRoomNumber
            // 
            this.tbRoomNumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbRoomNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbRoomNumber.Location = new System.Drawing.Point(190, 359);
            this.tbRoomNumber.Name = "tbRoomNumber";
            this.tbRoomNumber.Size = new System.Drawing.Size(220, 26);
            this.tbRoomNumber.TabIndex = 11;
            this.tbRoomNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbRoomNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbRoomNumber_KeyPress);
            this.tbRoomNumber.Validating += new System.ComponentModel.CancelEventHandler(this.tbRoomNumber_Validating);
            // 
            // tbPrice
            // 
            this.tbPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPrice.Location = new System.Drawing.Point(190, 466);
            this.tbPrice.Name = "tbPrice";
            this.tbPrice.ReadOnly = true;
            this.tbPrice.Size = new System.Drawing.Size(220, 26);
            this.tbPrice.TabIndex = 12;
            this.tbPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbDescription
            // 
            this.tbDescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDescription.Location = new System.Drawing.Point(190, 523);
            this.tbDescription.Multiline = true;
            this.tbDescription.Name = "tbDescription";
            this.tbDescription.ReadOnly = true;
            this.tbDescription.Size = new System.Drawing.Size(349, 110);
            this.tbDescription.TabIndex = 13;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // btnSave
            // 
            this.btnSave.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.btnSave.FlatAppearance.BorderSize = 3;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Image = global::HMS_Presontation_Layer.Properties.Resources.Saveicon50;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(221, 648);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(154, 58);
            this.btnSave.TabIndex = 14;
            this.btnSave.Text = "      Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::HMS_Presontation_Layer.Properties.Resources.RoomsImage;
            this.pictureBox1.Location = new System.Drawing.Point(143, 54);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(267, 251);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // CtrAddAndUpdateRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.tbDescription);
            this.Controls.Add(this.tbPrice);
            this.Controls.Add(this.tbRoomNumber);
            this.Controls.Add(this.cmbRoomType);
            this.Controls.Add(this.lblRoomID);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.rgbIsActive);
            this.Controls.Add(this.grbIsBooked);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "CtrAddAndUpdateRoom";
            this.Size = new System.Drawing.Size(552, 717);
            this.Load += new System.EventHandler(this.CtrAddAndUpdateRoom_Load);
            this.grbIsBooked.ResumeLayout(false);
            this.grbIsBooked.PerformLayout();
            this.rgbIsActive.ResumeLayout(false);
            this.rgbIsActive.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox grbIsBooked;
        private System.Windows.Forms.GroupBox rgbIsActive;
        private System.Windows.Forms.RadioButton rdbNotBooked;
        private System.Windows.Forms.RadioButton rdbBooked;
        private System.Windows.Forms.RadioButton rdbNotActive;
        private System.Windows.Forms.RadioButton rdbActive;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblRoomID;
        private System.Windows.Forms.ComboBox cmbRoomType;
        private System.Windows.Forms.TextBox tbRoomNumber;
        private System.Windows.Forms.TextBox tbPrice;
        private System.Windows.Forms.TextBox tbDescription;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}
