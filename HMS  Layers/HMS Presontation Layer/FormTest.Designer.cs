namespace HMS_Presontation_Layer
{
    partial class FormTest
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
            this.ctrAddUpdateEmployee1 = new HMS_Presontation_Layer.Users.CtrAddUpdateEmployee();
            this.SuspendLayout();
            // 
            // ctrAddUpdateEmployee1
            // 
            this.ctrAddUpdateEmployee1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctrAddUpdateEmployee1.Location = new System.Drawing.Point(40, -88);
            this.ctrAddUpdateEmployee1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ctrAddUpdateEmployee1.Name = "ctrAddUpdateEmployee1";
            this.ctrAddUpdateEmployee1.Size = new System.Drawing.Size(772, 704);
            this.ctrAddUpdateEmployee1.TabIndex = 0;
            // 
            // FormTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(845, 639);
            this.Controls.Add(this.ctrAddUpdateEmployee1);
            this.Name = "FormTest";
            this.Text = "FormTest";
            this.Load += new System.EventHandler(this.FormTest_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Users.CtrAddUpdateEmployee ctrAddUpdateEmployee1;
    }
}