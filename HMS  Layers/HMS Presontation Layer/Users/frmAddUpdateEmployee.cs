using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HMS_Presontation_Layer.Users
{
    public partial class frmAddUpdateEmployee : Form
    {
        
        int _EmployeeID=-1;
        public frmAddUpdateEmployee()
        {
            InitializeComponent();
            ctrAddUpdateEmployee1.AddNewEmployee();
          //  ctrlAddUpdateUser1.AddNewUser(_EmployeeID);
            btnBack.Enabled = false;
        }

        public frmAddUpdateEmployee(int EmployeeID,int UserID)
        {
            InitializeComponent();
            ctrAddUpdateEmployee1.UpdateEmployee(EmployeeID);
             ctrlAddUpdateUser1.UpdateUser(UserID);
            _EmployeeID = EmployeeID;
            btnBack.Enabled = false;
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if(_EmployeeID==-1)
            {
                tabControl1.SelectedTab = tbEmployeeInfo;
                MessageBox.Show("You Need to Enter Employee information", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            tabControl1.SelectedTab = tbUserInfo;
            btnBack.Enabled = true;
            btnNext.Enabled = false;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab =tbEmployeeInfo;
            btnBack.Enabled = false;
            btnNext.Enabled = true;
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedTab == tbUserInfo && _EmployeeID == -1)
            {
                tabControl1.SelectedTab = tbEmployeeInfo;
                MessageBox.Show("You Need to Enter Employee information", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (tabControl1.SelectedTab == tbEmployeeInfo)
            {
                btnBack.Enabled = false;
                btnNext.Enabled = true;
            }

            else
            {
                btnBack.Enabled = true;
                btnNext.Enabled = false;
            }
        }

        private void ctrAddUpdateEmployee1_OnEmployeeSelected(int obj)
        {
            _EmployeeID = obj;
            
          //  ctrlAddUpdateUser1.AddNewUser(_EmployeeID);
            ctrlAddUpdateUser1.EmployeeID = _EmployeeID.ToString();

        }

        private void frmAddUpdateEmployee_Load(object sender, EventArgs e)
        {

        }
    }
}
