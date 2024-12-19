namespace HMS_Presontation_Layer.Users
{
    partial class frmAddUpdateEmployee
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddUpdateEmployee));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tbEmployeeInfo = new System.Windows.Forms.TabPage();
            this.ctrAddUpdateEmployee1 = new HMS_Presontation_Layer.Users.CtrAddUpdateEmployee();
            this.tbUserInfo = new System.Windows.Forms.TabPage();
            this.ctrlAddUpdateUser1 = new HMS_Presontation_Layer.Users.CtrlAddUpdateUser();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tbEmployeeInfo.SuspendLayout();
            this.tbUserInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tbEmployeeInfo);
            this.tabControl1.Controls.Add(this.tbUserInfo);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(4, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(858, 675);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tbEmployeeInfo
            // 
            this.tbEmployeeInfo.Controls.Add(this.ctrAddUpdateEmployee1);
            this.tbEmployeeInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbEmployeeInfo.Location = new System.Drawing.Point(4, 38);
            this.tbEmployeeInfo.Name = "tbEmployeeInfo";
            this.tbEmployeeInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tbEmployeeInfo.Size = new System.Drawing.Size(850, 633);
            this.tbEmployeeInfo.TabIndex = 0;
            this.tbEmployeeInfo.Text = "Employee Information";
            this.tbEmployeeInfo.UseVisualStyleBackColor = true;
            // 
            // ctrAddUpdateEmployee1
            // 
            this.ctrAddUpdateEmployee1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctrAddUpdateEmployee1.Location = new System.Drawing.Point(25, 8);
            this.ctrAddUpdateEmployee1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ctrAddUpdateEmployee1.Name = "ctrAddUpdateEmployee1";
            this.ctrAddUpdateEmployee1.Size = new System.Drawing.Size(772, 704);
            this.ctrAddUpdateEmployee1.TabIndex = 0;
            this.ctrAddUpdateEmployee1.OnEmployeeSelected += new System.Action<int>(this.ctrAddUpdateEmployee1_OnEmployeeSelected);
            // 
            // tbUserInfo
            // 
            this.tbUserInfo.Controls.Add(this.ctrlAddUpdateUser1);
            this.tbUserInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbUserInfo.Location = new System.Drawing.Point(4, 38);
            this.tbUserInfo.Name = "tbUserInfo";
            this.tbUserInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tbUserInfo.Size = new System.Drawing.Size(850, 633);
            this.tbUserInfo.TabIndex = 1;
            this.tbUserInfo.Text = "User Information";
            this.tbUserInfo.UseVisualStyleBackColor = true;
            // 
            // ctrlAddUpdateUser1
            // 
            this.ctrlAddUpdateUser1.EmployeeID = "???";
            this.ctrlAddUpdateUser1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctrlAddUpdateUser1.Location = new System.Drawing.Point(4, 1);
            this.ctrlAddUpdateUser1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ctrlAddUpdateUser1.Name = "ctrlAddUpdateUser1";
            this.ctrlAddUpdateUser1.Size = new System.Drawing.Size(772, 627);
            this.ctrlAddUpdateUser1.TabIndex = 0;
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Image = global::HMS_Presontation_Layer.Properties.Resources.BackIcon;
            this.btnBack.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBack.Location = new System.Drawing.Point(173, 677);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(111, 37);
            this.btnBack.TabIndex = 4;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnNext
            // 
            this.btnNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.Image = global::HMS_Presontation_Layer.Properties.Resources.NextIcon;
            this.btnNext.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNext.Location = new System.Drawing.Point(492, 678);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(116, 37);
            this.btnNext.TabIndex = 3;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // frmAddUpdateEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(862, 722);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmAddUpdateEmployee";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = " Add  Update  Employee";
            this.Load += new System.EventHandler(this.frmAddUpdateEmployee_Load);
            this.tabControl1.ResumeLayout(false);
            this.tbEmployeeInfo.ResumeLayout(false);
            this.tbUserInfo.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tbEmployeeInfo;
        private System.Windows.Forms.TabPage tbUserInfo;
        private CtrAddUpdateEmployee ctrAddUpdateEmployee1;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnNext;
        private CtrlAddUpdateUser ctrlAddUpdateUser1;
    }
}