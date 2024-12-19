namespace HMS_Presontation_Layer.Payments
{
    partial class FormAllGuestsNotPay
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAllGuestsNotPay));
            this.label1 = new System.Windows.Forms.Label();
            this.dgvGuestNotPay = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.lblTotalGuest = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.paymentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGuestNotPay)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(272, 1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(349, 55);
            this.label1.TabIndex = 1;
            this.label1.Text = "Guest Not Pay";
            // 
            // dgvGuestNotPay
            // 
            this.dgvGuestNotPay.BackgroundColor = System.Drawing.Color.White;
            this.dgvGuestNotPay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGuestNotPay.ContextMenuStrip = this.contextMenuStrip1;
            this.dgvGuestNotPay.Location = new System.Drawing.Point(9, 303);
            this.dgvGuestNotPay.Name = "dgvGuestNotPay";
            this.dgvGuestNotPay.ReadOnly = true;
            this.dgvGuestNotPay.RowTemplate.DividerHeight = 1;
            this.dgvGuestNotPay.RowTemplate.Height = 32;
            this.dgvGuestNotPay.RowTemplate.ReadOnly = true;
            this.dgvGuestNotPay.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvGuestNotPay.Size = new System.Drawing.Size(837, 255);
            this.dgvGuestNotPay.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 570);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(183, 31);
            this.label2.TabIndex = 3;
            this.label2.Text = "Total Guest: ";
            // 
            // lblTotalGuest
            // 
            this.lblTotalGuest.AutoSize = true;
            this.lblTotalGuest.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalGuest.Location = new System.Drawing.Point(201, 577);
            this.lblTotalGuest.Name = "lblTotalGuest";
            this.lblTotalGuest.Size = new System.Drawing.Size(43, 24);
            this.lblTotalGuest.TabIndex = 4;
            this.lblTotalGuest.Text = "???";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.paymentToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(246, 96);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
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
            this.pictureBox1.Image = global::HMS_Presontation_Layer.Properties.Resources.NotPay;
            this.pictureBox1.Location = new System.Drawing.Point(315, 57);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(274, 239);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // FormAllGuestsNotPay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(854, 612);
            this.Controls.Add(this.lblTotalGuest);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvGuestNotPay);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormAllGuestsNotPay";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "All  Guests Not  Pay";
            this.Load += new System.EventHandler(this.FormAllGuestsNotPay_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGuestNotPay)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvGuestNotPay;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblTotalGuest;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem paymentToolStripMenuItem;
    }
}