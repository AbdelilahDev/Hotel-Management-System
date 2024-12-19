namespace HMS_Presontation_Layer.Payments
{
    partial class frmPayment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPayment));
            this.ctrlAddUpdatePayment1 = new HMS_Presontation_Layer.Payments.CtrlAddUpdatePayment();
            this.SuspendLayout();
            // 
            // ctrlAddUpdatePayment1
            // 
            this.ctrlAddUpdatePayment1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctrlAddUpdatePayment1.Location = new System.Drawing.Point(0, 2);
            this.ctrlAddUpdatePayment1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ctrlAddUpdatePayment1.Name = "ctrlAddUpdatePayment1";
            this.ctrlAddUpdatePayment1.Size = new System.Drawing.Size(885, 710);
            this.ctrlAddUpdatePayment1.TabIndex = 0;
            // 
            // frmPayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(887, 722);
            this.Controls.Add(this.ctrlAddUpdatePayment1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmPayment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Payment";
            this.ResumeLayout(false);

        }

        #endregion

        private CtrlAddUpdatePayment ctrlAddUpdatePayment1;
    }
}