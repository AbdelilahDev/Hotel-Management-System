using Business_Layer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace HMS_Presontation_Layer.Users
{
    public partial class CtrlAddUpdateUser : UserControl
    {

        clsUser _User;
        int _EmployeeID;


        public enum enMode { New = 0, Update = 1 }

        public enMode Mode;

        public string EmployeeID 
        {
            set { lblEmployeeID.Text = value; }
            get { return lblEmployeeID.Text; }

        
        }
        public CtrlAddUpdateUser()
        {
            InitializeComponent();

            pbShowOrHideCurrentPassword.Image = Properties.Resources.HidePasswordIcon; // Set your eye icon image
            pbShowOrHideCurrentPassword.Location = new Point(140, 2); // Adjust the position
            pbShowOrHideCurrentPassword.BackColor = Color.Transparent;

            // Set the password TextBox to use system password char initially
            tbPassword.UseSystemPasswordChar = true;

           tbPassword.Controls.Add(pbShowOrHideCurrentPassword);
        }

        private int _UserType()
        {
            if (rdbNormalUser.Checked)
                return 1;
            else
                return 2;

        }
        public void AddNewUser(int EmployeeID)
        {
            Mode = enMode.New;
            lblTitle.Text = "Add New User";
            _EmployeeID = EmployeeID;


        }


        private void _AddNewUser()
        {
            clsUser user = new clsUser((clsUser.enUserType)_UserType());

            user.EmployeeID = _EmployeeID;
            user.UserName = tbUserName.Text;
            user.Password = tbPassword.Text;
            user.IsActive = rdbActive.Checked;
         
            if(user.Save())
            {
                lblUserID.Text = user.UserID.ToString();
             
                _User = user;
                MessageBox.Show("New User Added Seccessfully", "Add New User", MessageBoxButtons.OK);
            }

            else
            {
                MessageBox.Show("User Is not Saved try Again", "Add New User", MessageBoxButtons.OK,MessageBoxIcon.Error);

            }

        }


        public void UpdateUser(int UserID)
        {
            Mode = enMode.Update;
            lblTitle.Text = "   Upadte User";

            lblUserID.Text = UserID.ToString();
          
            _User = clsUser.FindByUserID(UserID);

            lblEmployeeID.Text = _User.EmployeeID.ToString();
            tbUserName.Text = _User.UserName;

            tbPassword.Text = _User.Password;

            rdbActive.Checked = _User.IsActive;

            rdbNotActive.Checked = !(rdbActive.Checked);

         if(_User.UserType==clsUser.enUserType.Normal)
            
            {
                rdbNormalUser.Checked=true;

            }

            else
            {
                rdbAdminUser.Checked = true;
            }


        }

        private void _UpdateUser()
        {
            _User.UserName = tbUserName.Text;

            _User.Password = tbPassword.Text;


            _User.IsActive = rdbActive.Checked;

            if(rdbNormalUser.Checked)
            {
                _User.UserType = clsUser.enUserType.Normal;

            }

            else

            {
                _User.UserType = clsUser.enUserType.Admin;

            }

            if (_User.Save())
            {
            
                MessageBox.Show("New User Updated Seccessfully", "Update User", MessageBoxButtons.OK);
            }

            else
            {
                MessageBox.Show("User Is not Update try Again", "Update User", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void pbShowOrHideCurrentPassword_MouseDown(object sender, MouseEventArgs e)
        {
            // Show the password when the mouse button is pressed
            pbShowOrHideCurrentPassword.Image = Properties.Resources.ShowPasswordIcon; // Set your eye icon image

            tbPassword.UseSystemPasswordChar = false;
        }

        private void pbShowOrHideCurrentPassword_MouseUp(object sender, MouseEventArgs e)
        {

            pbShowOrHideCurrentPassword.Image = Properties.Resources.HidePasswordIcon;
            tbPassword.UseSystemPasswordChar = true;
        }

        private void tbUserName_Validating(object sender, CancelEventArgs e)
        {
            System.Windows.Forms.TextBox textBox = sender as System.Windows.Forms.TextBox;
            if (string.IsNullOrEmpty(textBox.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(textBox, "This field is required!");
            }
            else
            {
                //e.Cancel = false;
                errorProvider1.SetError(textBox, null);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!this.ValidateChildren())
            {
                //Here we dont continue becuase the form is not valid
                MessageBox.Show("Some fileds are not valide!, put the mouse over the red icon(s) to see the erro", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }
            if (Mode == enMode.New)
            {
                Mode = enMode.Update;
                _AddNewUser();

                return;
      

            }

            if (Mode == enMode.Update)
            {
                _UpdateUser();
           
            }
        }
    }
}
