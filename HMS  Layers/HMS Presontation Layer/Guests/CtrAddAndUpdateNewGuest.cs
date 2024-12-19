using Business_Layer;
using HMS_Presontation_Layer.Global_Classes;
using HMS_Presontation_Layer.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static HMS_Presontation_Layer.Guests.CtrAddAndUpdateNewGuest;
using static System.Net.Mime.MediaTypeNames;

namespace HMS_Presontation_Layer.Guests
{
    public partial class CtrAddAndUpdateNewGuest : UserControl
    {

        //// Declare a delegate
        //public delegate void RefreshDataAfterAddAGuest(object sender, EventArgs e);

        //// Declare an event using the delegate
        //public event RefreshDataAfterAddAGuest RefreshData;
        clsGuest _Guest;
        int GuestID;
       
        int UserID;
        
        public enum enMode { AddNew = 0, Update = 1 };
        public enMode Mode = enMode.AddNew;

        public enum enUserOrGuest { Guest = 0, User = 1 };
        public enUserOrGuest UserOrGuest ;
        public CtrAddAndUpdateNewGuest()
        {
            InitializeComponent();
        }


        public void AddNewGuest()
        {
            Mode = enMode.AddNew;
            UserOrGuest = enUserOrGuest.Guest;
            pictureBox1.Image = Resources.NewGuest;
            lblTitle.Text = "Add A New  Guest";
        }
        public void UpdateGuest(int GuestID)
        {
            Mode = enMode.Update;
            pictureBox1.Image = Resources.NewGuest;
            UserOrGuest = enUserOrGuest.Guest;
            lblTitle.Text = "Update A Guest";
            this.GuestID = GuestID;
            _Guest = clsGuest.FindGuestByID(GuestID);
            tbFirstName.Text =  _Guest.FirstName;
            tbLastName.Text =  _Guest.LastName;
            tbPhone.Text =     _Guest.Phone;
            tbEmail.Text =     _Guest.Email;
            tbAddress.Text =   _Guest.Address;
            lblGuestID.Text = _Guest.GuestID.ToString();
        }
     
        public void UpdateCurrentUser()
        {
            Mode = enMode.Update;
            UserOrGuest = enUserOrGuest.User;
            pictureBox1.Image = Resources.UpdateUser;

            lblTitle.Text = "Update Current User";
            this.UserID =clsGlobal.CurrentUser.UserID;
            tbFirstName.Text = clsGlobal.CurrentUser.EmployeeInfo.FirstName;
            tbLastName.Text = clsGlobal.CurrentUser.EmployeeInfo.LastName;
            tbPhone.Text = clsGlobal.CurrentUser.EmployeeInfo.Phone;
            tbEmail.Text = clsGlobal.CurrentUser.EmployeeInfo.Email;
            tbAddress.Text = clsGlobal.CurrentUser.EmployeeInfo.Address;
            lblGuestID.Text = clsGlobal.CurrentUser.UserID.ToString();
        }
        private void _UpdateCurrentUser()
        {
            Mode = enMode.Update;
            UserOrGuest = enUserOrGuest.User;


           
            clsEmployee employee = clsEmployee.FindEmployeeByID(clsGlobal.CurrentUser.EmployeeID);
            employee.FirstName = tbFirstName.Text;
            employee.LastName = tbLastName.Text;
            employee.Phone = tbPhone.Text;
            employee.Email = tbEmail.Text;
            employee.Address = tbAddress.Text;


            if (clsEmployee.UpdateEmployee(employee.EmployeeID,employee.FirstName,employee.LastName,employee.Address,employee.Phone,employee.Email))
            {
                MessageBox.Show("The User Updated seccefully", "Update User", MessageBoxButtons.OK);
               
            }
            else
            {
                MessageBox.Show("The User Not Updated", "Update User", MessageBoxButtons.OK, MessageBoxIcon.Error); ;
            }




        }

        private void _AddNewGuest()
        {
            Mode = enMode.AddNew;
            _Guest = new clsGuest();
            _Guest.FirstName = tbFirstName.Text;
            _Guest.LastName = tbLastName.Text;
            _Guest.Phone = tbPhone.Text;
            _Guest.Email = tbEmail.Text;
            _Guest.Address = tbAddress.Text;

            if (_Guest.Save())
            {
                MessageBox.Show("The guest Saved seccefully", "Save Guest", MessageBoxButtons.OK);
                lblGuestID.Text = _Guest.GuestID.ToString();
            }
            else
            {
                MessageBox.Show("The guest Not Saved", "Save Guest", MessageBoxButtons.OK, MessageBoxIcon.Error); ;
            }


        }
        private void _UpdateGuest(int GuestID)
        {
            Mode = enMode.Update;
            _Guest = clsGuest.FindGuestByID(GuestID);
                
            _Guest.FirstName = tbFirstName.Text;
            _Guest.LastName  = tbLastName.Text;
            _Guest.Phone     =   tbPhone.Text;
            _Guest.Email     = tbEmail.Text;
            _Guest.Address   = tbAddress.Text;

            if (_Guest.Save())
            {
                MessageBox.Show("The guest Updated seccefully", "Update Guest", MessageBoxButtons.OK);
                lblGuestID.Text = _Guest.GuestID.ToString();
            }
            else
            {
                MessageBox.Show("The guest Not Updated", "Update Guest", MessageBoxButtons.OK, MessageBoxIcon.Error); ;
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

            //UserOrGuest = enUserOrGuest.User;
          
            if (UserOrGuest ==enUserOrGuest.User)
            {
                _UpdateCurrentUser();
            }

            else 
            {
                if (Mode == enMode.AddNew)
                {
                    _AddNewGuest();
                  //   RefreshData?.Invoke(null, null);
                }
                else
                {

                    _UpdateGuest(this.GuestID);
                   //RefreshData?.Invoke(null, null);
                }
            }
         
            
        }

        private void tbFirstName_Validating(object sender, CancelEventArgs e)
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

        private void tbEmail_Validating(object sender, CancelEventArgs e)
        {
            //no need to validate the email incase it's empty.
            if ( tbEmail.Text.Trim() == "")
                return;

            //validate email format
            if (!clsValidation.ValidateEmail(tbEmail.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(tbEmail, "Invalid Email Address Format!");
            }
            else
            {
                errorProvider1.SetError(tbEmail, null);
            };
        }

        private void tbPhone_Validating(object sender, CancelEventArgs e)
        {
            //no need to validate the phone incase it's empty.
            if (tbPhone.Text.Trim() == "")
                return;

            //validate email format
            if (!clsValidation.ValidMoroccoNumberPhone(tbPhone.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(tbPhone, "Enter Exactly 10 digits!");
            }
            else
            {
                errorProvider1.SetError(tbEmail, null);
            };
        }
    }
}
