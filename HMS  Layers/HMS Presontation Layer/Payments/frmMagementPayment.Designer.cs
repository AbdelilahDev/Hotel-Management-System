namespace HMS_Presontation_Layer.Payments
{
    partial class frmMagementPayment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMagementPayment));
            this.dgvGuests = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.lblTotalGuest = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.grbPayOrNotPay = new System.Windows.Forms.GroupBox();
            this.rdbPay = new System.Windows.Forms.RadioButton();
            this.rdbNotPay = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbFilterGuests = new System.Windows.Forms.ComboBox();
            this.tbFilterGuests = new System.Windows.Forms.TextBox();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.paymentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.rdbAllGuests = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGuests)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.grbPayOrNotPay.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvGuests
            // 
            this.dgvGuests.BackgroundColor = System.Drawing.Color.White;
            this.dgvGuests.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGuests.ContextMenuStrip = this.contextMenuStrip1;
            this.dgvGuests.Location = new System.Drawing.Point(9, 304);
            this.dgvGuests.Name = "dgvGuests";
            this.dgvGuests.ReadOnly = true;
            this.dgvGuests.RowTemplate.DividerHeight = 1;
            this.dgvGuests.RowTemplate.Height = 32;
            this.dgvGuests.RowTemplate.ReadOnly = true;
            this.dgvGuests.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvGuests.Size = new System.Drawing.Size(934, 255);
            this.dgvGuests.TabIndex = 7;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.paymentToolStripMenuItem,
            this.toolStripSeparator1});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(246, 80);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(251, -3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(552, 55);
            this.label1.TabIndex = 6;
            this.label1.Text = "Manegement Payments";
            // 
            // lblTotalGuest
            // 
            this.lblTotalGuest.AutoSize = true;
            this.lblTotalGuest.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalGuest.Location = new System.Drawing.Point(201, 573);
            this.lblTotalGuest.Name = "lblTotalGuest";
            this.lblTotalGuest.Size = new System.Drawing.Size(43, 24);
            this.lblTotalGuest.TabIndex = 9;
            this.lblTotalGuest.Text = "???";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 566);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(183, 31);
            this.label2.TabIndex = 8;
            this.label2.Text = "Total Guest: ";
            // 
            // grbPayOrNotPay
            // 
            this.grbPayOrNotPay.Controls.Add(this.rdbAllGuests);
            this.grbPayOrNotPay.Controls.Add(this.rdbNotPay);
            this.grbPayOrNotPay.Controls.Add(this.rdbPay);
            this.grbPayOrNotPay.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbPayOrNotPay.Location = new System.Drawing.Point(18, 55);
            this.grbPayOrNotPay.Name = "grbPayOrNotPay";
            this.grbPayOrNotPay.Size = new System.Drawing.Size(207, 197);
            this.grbPayOrNotPay.TabIndex = 10;
            this.grbPayOrNotPay.TabStop = false;
            this.grbPayOrNotPay.Text = "Payment Etat";
            // 
            // rdbPay
            // 
            this.rdbPay.AutoSize = true;
            this.rdbPay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbPay.Location = new System.Drawing.Point(27, 95);
            this.rdbPay.Name = "rdbPay";
            this.rdbPay.Size = new System.Drawing.Size(119, 24);
            this.rdbPay.TabIndex = 0;
            this.rdbPay.Text = "Guests Pay";
            this.rdbPay.UseVisualStyleBackColor = true;
            this.rdbPay.CheckedChanged += new System.EventHandler(this.rdbPay_CheckedChanged);
            // 
            // rdbNotPay
            // 
            this.rdbNotPay.AutoSize = true;
            this.rdbNotPay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbNotPay.Location = new System.Drawing.Point(27, 140);
            this.rdbNotPay.Name = "rdbNotPay";
            this.rdbNotPay.Size = new System.Drawing.Size(157, 24);
            this.rdbNotPay.TabIndex = 1;
            this.rdbNotPay.Text = "Guests  Not Pay";
            this.rdbNotPay.UseVisualStyleBackColor = true;
            this.rdbNotPay.CheckedChanged += new System.EventHandler(this.rdbNotPay_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 270);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 29);
            this.label3.TabIndex = 11;
            this.label3.Text = "Filter By : ";
            // 
            // cmbFilterGuests
            // 
            this.cmbFilterGuests.FormattingEnabled = true;
            this.cmbFilterGuests.Items.AddRange(new object[] {
            "None",
            "GuestID",
            "FirstName"});
            this.cmbFilterGuests.Location = new System.Drawing.Point(125, 271);
            this.cmbFilterGuests.Name = "cmbFilterGuests";
            this.cmbFilterGuests.Size = new System.Drawing.Size(121, 28);
            this.cmbFilterGuests.TabIndex = 12;
            this.cmbFilterGuests.SelectedIndexChanged += new System.EventHandler(this.cmbFilterGuests_SelectedIndexChanged);
            // 
            // tbFilterGuests
            // 
            this.tbFilterGuests.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbFilterGuests.Location = new System.Drawing.Point(254, 272);
            this.tbFilterGuests.Name = "tbFilterGuests";
            this.tbFilterGuests.Size = new System.Drawing.Size(129, 26);
            this.tbFilterGuests.TabIndex = 13;
            this.tbFilterGuests.TextChanged += new System.EventHandler(this.tbFilterGuests_TextChanged);
            this.tbFilterGuests.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbFilterGuests_KeyPress);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(242, 6);
            // 
            // paymentToolStripMenuItem
            // 
            this.paymentToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paymentToolStripMenuItem.Image = global::HMS_Presontation_Layer.Properties.Resources.payment64;
            this.paymentToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.paymentToolStripMenuItem.Name = "paymentToolStripMenuItem";
            this.paymentToolStripMenuItem.Size = new System.Drawing.Size(245, 70);
            this.paymentToolStripMenuItem.Text = "Payment";
            this.paymentToolStripMenuItem.Click += new System.EventHandler(this.paymentToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::HMS_Presontation_Layer.Properties.Resources.ManegementPayment;
            this.pictureBox1.Location = new System.Drawing.Point(416, 55);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(263, 243);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // rdbAllGuests
            // 
            this.rdbAllGuests.AutoSize = true;
            this.rdbAllGuests.Checked = true;
            this.rdbAllGuests.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbAllGuests.Location = new System.Drawing.Point(27, 47);
            this.rdbAllGuests.Name = "rdbAllGuests";
            this.rdbAllGuests.Size = new System.Drawing.Size(110, 24);
            this.rdbAllGuests.TabIndex = 2;
            this.rdbAllGuests.Text = "All Guests";
            this.rdbAllGuests.UseVisualStyleBackColor = true;
            this.rdbAllGuests.CheckedChanged += new System.EventHandler(this.rdbAllGuests_CheckedChanged);
            // 
            // frmMagementPayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(955, 600);
            this.Controls.Add(this.tbFilterGuests);
            this.Controls.Add(this.cmbFilterGuests);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.grbPayOrNotPay);
            this.Controls.Add(this.dgvGuests);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTotalGuest);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmMagementPayment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Magement Payment";
            this.Load += new System.EventHandler(this.frmMagementPayment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGuests)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.grbPayOrNotPay.ResumeLayout(false);
            this.grbPayOrNotPay.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvGuests;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem paymentToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTotalGuest;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox grbPayOrNotPay;
        private System.Windows.Forms.RadioButton rdbNotPay;
        private System.Windows.Forms.RadioButton rdbPay;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbFilterGuests;
        private System.Windows.Forms.TextBox tbFilterGuests;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.RadioButton rdbAllGuests;
    }
}