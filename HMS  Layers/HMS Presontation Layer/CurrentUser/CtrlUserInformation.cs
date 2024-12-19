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

namespace HMS_Presontation_Layer.CurrentUser
{
    public partial class CtrlUserInformation : UserControl
    {
        clsUser _User;
        public CtrlUserInformation()
        {
            InitializeComponent();
        }

        public void ShowUserInformation()
        {

            if (clsGlobal.CurrentUser == null)
            {

                MessageBox.Show("This User is not found try Another One", "Error Find User", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            lblNationalNumber.Text = clsGlobal.CurrentUser.EmployeeInfo.NationalNo;
            lblUserName.Text = clsGlobal.CurrentUser.UserName;
            if(clsGlobal.CurrentUser.UserType==clsUser.enUserType.Normal)
            {
                lblUserType.Text = "Normal User";
            }
            else
            {
                lblUserType.Text = "Admin User";

            }

            lblPerformanceRate.Text = clsGlobal.CurrentUser.EmployeeInfo.PerformanceRate.ToString();

        }

        public void ShowUserInformation(int UserID)
        {
            _User = clsUser.FindByUserID(UserID);
           
            if (_User== null)
            {

                MessageBox.Show("This User is not found try Another One", "Error Find User", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            lblNationalNumber.Text = _User.EmployeeInfo.NationalNo;
            lblUserName.Text = _User.UserName;
            if (_User.UserType == clsUser.enUserType.Normal)
            {
                lblUserType.Text = "Normal User";
            }
            else
            {
                lblUserType.Text = "Admin User";

            }

            lblPerformanceRate.Text = _User.EmployeeInfo.PerformanceRate.ToString();

        }
    }
}
