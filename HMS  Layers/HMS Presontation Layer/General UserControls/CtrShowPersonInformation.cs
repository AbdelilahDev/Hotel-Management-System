using Business_Layer;
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

namespace HMS_Presontation_Layer.General_UserControls
{
    public partial class CtrShowPersonInformation : UserControl
    {
        clsGuest _Guest;

        clsUser _User;

     
        public CtrShowPersonInformation()
        {
            InitializeComponent();
        }

        public void ShowGuestInformation(int GuestID)
        {
        
            _Guest = clsGuest.FindGuestByID(GuestID);
            if (_Guest== null)
            {

                MessageBox.Show("This guest is niot found try Another One", "Error Find Guest", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            lblID.Text = _Guest.GuestID.ToString();
            lblFirstName.Text = _Guest.FirstName;
            lblLastName.Text = _Guest.LastName;
            lblPhone.Text = _Guest.Phone;
            lblEmail.Text = _Guest.Email;
            lblAddress.Text = _Guest.Address;


        }
        public void ShowCurrentUserInformation()
        {

           
            if (clsGlobal.CurrentUser == null)
            {

                MessageBox.Show("This User is niot found try Another One", "Error Find User", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            lblID.Text = clsGlobal.CurrentUser.UserID.ToString();
            lblFirstName.Text = clsGlobal.CurrentUser.EmployeeInfo.FirstName;
            lblLastName.Text = clsGlobal.CurrentUser.EmployeeInfo.LastName;
            lblPhone.Text = clsGlobal.CurrentUser.EmployeeInfo.Phone;
            lblEmail.Text = clsGlobal.CurrentUser.EmployeeInfo.Email;
            lblAddress.Text = clsGlobal.CurrentUser.EmployeeInfo.Address;


        }

        public void ShowCurrentUserInformation(int UserID)
        {
            _User = clsUser.FindByUserID(UserID);

            if (_User == null)
            {

                MessageBox.Show("This User is niot found try Another One", "Error Find User", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            lblID.Text = _User.UserID.ToString();
            lblFirstName.Text = _User.EmployeeInfo.FirstName;
            lblLastName.Text = _User.EmployeeInfo.LastName;
            lblPhone.Text = _User.EmployeeInfo.Phone;
            lblEmail.Text = _User.EmployeeInfo.Email;
            lblAddress.Text = _User.EmployeeInfo.Address;


        }
    }
}
