using HMS_Presontation_Layer.Global_Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TextBox = System.Windows.Forms.TextBox;

namespace HMS_Presontation_Layer.CurrentUser
{
    public partial class CtrlChangePassword : UserControl
    {

        private void _OrganizeIconShowOrHidePassowrdInsideTextBox(TextBox textBox,PictureBox pictureBox)
        {
            // Create a PictureBox with an eye icon (you can set the image path)

            pictureBox.Image = Properties.Resources.HidePasswordIcon; // Set your eye icon image
            pictureBox.Location = new Point(180, 2); // Adjust the position
            pictureBox.BackColor = Color.Transparent;

            // Set the password TextBox to use system password char initially
            textBox.UseSystemPasswordChar = true;

            textBox.Controls.Add(pictureBox);



        }
        public CtrlChangePassword()
        {
            InitializeComponent();

            grbChangePassword.Enabled = false;

            btnSave.Enabled = false;

            _OrganizeIconShowOrHidePassowrdInsideTextBox(tbCurrentPassword, pbShowOrHideCurrentPassword);


            _OrganizeIconShowOrHidePassowrdInsideTextBox(tbConfirmPassword, pbShoworHideConfirmPassword);

            _OrganizeIconShowOrHidePassowrdInsideTextBox(tbNewPassword, pbShowOrHideNewPassword);

        }







        private void pbShowOrHideCurrentPassword_MouseDown(object sender, MouseEventArgs e)
        {
            // Show the password when the mouse button is pressed
            pbShowOrHideCurrentPassword.Image = Properties.Resources.ShowPasswordIcon; // Set your eye icon image

            tbCurrentPassword.UseSystemPasswordChar = false;
        }

        private void pbShowOrHideCurrentPassword_MouseUp(object sender, MouseEventArgs e)
        {

           pbShowOrHideCurrentPassword.Image = Properties.Resources.HidePasswordIcon;
            tbCurrentPassword.UseSystemPasswordChar = true;
        }

        private void pbShowOrHideNewPassword_MouseDown(object sender, MouseEventArgs e)
        {
            pbShowOrHideNewPassword.Image = Properties.Resources.ShowPasswordIcon;
            tbNewPassword.UseSystemPasswordChar = false;
        }

        private void pbShowOrHideNewPassword_MouseUp(object sender, MouseEventArgs e)
        {
            pbShowOrHideNewPassword.Image = Properties.Resources.HidePasswordIcon;
            tbNewPassword.UseSystemPasswordChar = true;
        }

        private void pbShoworHideConfirmPassword_MouseDown(object sender, MouseEventArgs e)
        {
            pbShoworHideConfirmPassword.Image = Properties.Resources.ShowPasswordIcon;
            tbConfirmPassword.UseSystemPasswordChar = false;

        }

        private void pbShoworHideConfirmPassword_MouseUp(object sender, MouseEventArgs e)
        {
            pbShoworHideConfirmPassword.Image = Properties.Resources.HidePasswordIcon;
            tbConfirmPassword.UseSystemPasswordChar = true;
        }

        private void tbCurrentPassword_Validating(object sender, CancelEventArgs e)
        {
            // First: set AutoValidate property of your Form to EnableAllowFocusChange in designer 
            TextBox Temp = ((TextBox)sender);
            if (string.IsNullOrEmpty(Temp.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(Temp, "This field is required!");
            }
            else
            {
                //e.Cancel = false;
                errorProvider1.SetError(Temp, null);
            }
        }

        private void tbCurrentPassword_TextChanged(object sender, EventArgs e)
        {
            if(clsGlobal.CurrentUser.Password==tbCurrentPassword.Text)
            {
                grbChangePassword.Enabled = true;
                btnSave.Enabled = true;
                tbCurrentPassword.Enabled = false;

            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(tbNewPassword.Text==tbConfirmPassword.Text)
            {
                clsGlobal.CurrentUser.Password = tbNewPassword.Text;

                if (clsGlobal.CurrentUser.Save()) 
                {

                    MessageBox.Show("The Password changed Seccessfully", "Change Password", MessageBoxButtons.OK);
                }
                else
                {
                    MessageBox.Show("The  Password is Not changed Seccessfully", "Error Change Password", MessageBoxButtons.OK,MessageBoxIcon.Error);


                }

            }

            else
            {
                MessageBox.Show("Verify The Match Password", "Error Match Password", MessageBoxButtons.OK, MessageBoxIcon.Error);


            }
        }
    }
}
