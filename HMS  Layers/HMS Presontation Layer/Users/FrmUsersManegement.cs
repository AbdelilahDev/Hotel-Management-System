using Business_Layer;
using HMS_Presontation_Layer.CurrentUser;
using HMS_Presontation_Layer.Guests;
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
    public partial class FrmUsersManegement : Form
    {
        DataTable _AllUsers;

        clsUser _User;
        public FrmUsersManegement()
        {
            InitializeComponent();


        }
        private void _OrganizeDataInDataGridView()
        {

            //Check id Data Grid View is Epmty
            if (dgvAllUsers.Rows.Count == 0)
            {
              
                lblTotalUsers.Text = "0";
                lblNoRecord.Visible = true;
                return;
            }

            lblNoRecord.Visible = false;

            //Orgineze Columns Of DataGridView One By One
            dgvAllUsers.Columns[0].HeaderText = "User ID";
            dgvAllUsers.Columns[0].Width = 100;

            dgvAllUsers.Columns[1].HeaderText = "Full Name";
            dgvAllUsers.Columns[1].Width = 275;


            dgvAllUsers.Columns[2].HeaderText = "User Name";
            dgvAllUsers.Columns[2].Width = 205;

            dgvAllUsers.Columns[3].HeaderText = "User Type";
            dgvAllUsers.Columns[3].Width = 130;


            dgvAllUsers.Columns[4].HeaderText = "Active";
            dgvAllUsers.Columns[4].Width = 100;



           lblTotalUsers.Text = (dgvAllUsers.Rows.Count - 1).ToString();



        }


        private void _ShowAllActiveAndNormalUsers()

        {
            _AllUsers = clsUser.GetAllActiveAndNormalUsers();
            dgvAllUsers.DataSource = _AllUsers;
         

        }

        private void _ShowAllActiveAndAdminUsers()

        {
            _AllUsers = clsUser.GetAllActiveAndAdminUsers();
            dgvAllUsers.DataSource = _AllUsers;

        }

        private void _ShowAllNotNotActiveAndNormalUsers()

        {
            _AllUsers = clsUser.GetAllNotActiveAndNormalUsers();
            dgvAllUsers.DataSource = _AllUsers;

        }

        private void _ShowAllNotActiveAndAdminUsers()

        {
            _AllUsers = clsUser.GetAllNotActiveAndAdminUsers();
            dgvAllUsers.DataSource = _AllUsers;

        }

        private void FrmUsersManegement_Load(object sender, EventArgs e)
        {
            cmbFilter.SelectedIndex = 0;
            _AllUsers = clsUser.GetAllUsers();
            dgvAllUsers.DataSource = _AllUsers;
            _OrganizeDataInDataGridView();
           
        }

        private void btnAddGuest_Click(object sender, EventArgs e) 
        {
            frmAddUpdateEmployee frm = new frmAddUpdateEmployee();

            frm.ShowDialog();
        }

        private void cmbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Clear textBox of search GuestID Or Phone Number
            tbFilter.Clear();

            //Case if Select None Column
            if (cmbFilter.Text == "None")
            {


                //Hide text box of searching
                tbFilter.Visible = false;


            }

            else
            {
                //Hide text box of searching
                tbFilter.Visible = true;




            }
        }

        private void tbFilter_TextChanged(object sender, EventArgs e)
        {
            string FilterColumn = "";
            //Map Selected Filter to real Column name 
            switch (cmbFilter.Text)
            {
                case "UserID":
                    FilterColumn = "UserID";
                    break;

                case "UserName":
                    FilterColumn = "UserName";
                    break;


                default:
                    FilterColumn = "None";
                    break;

            }

            //Reset the filters in case nothing selected or filter value conains nothing.
            if (tbFilter.Text.Trim() == "" || FilterColumn == "None")
            {
                _AllUsers.DefaultView.RowFilter = "";
                lblTotalUsers.Text = dgvAllUsers.Rows.Count.ToString();
                return;
            }

            else if (FilterColumn == "UserName")

                _AllUsers.DefaultView.RowFilter = string.Format("[{0}] LIKE '{1}%'", FilterColumn, tbFilter.Text.Trim());


            else
                _AllUsers.DefaultView.RowFilter = string.Format("[{0}] ={1}", FilterColumn, tbFilter.Text.Trim());


            lblTotalUsers.Text = (dgvAllUsers.Rows.Count - 1).ToString();
        }

        private void tbFilter_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cmbFilter.Text == "UserID")

            {
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                {
                    e.Handled = true;
                }

            }
         
        }

        private void rdbActive_CheckedChanged(object sender, EventArgs e)
        {
            tbFilter.Visible = false;
            cmbFilter.SelectedIndex = 0;

            if(rdbAdminUser.Checked&&rdbActive.Checked)
            {
                _ShowAllActiveAndAdminUsers();

            }

            else if(rdbAdminUser.Checked && rdbNotActive.Checked)
            {
                _ShowAllNotActiveAndAdminUsers();

            }
            else if (rdbNormalUser.Checked && rdbActive.Checked)
            {
                _ShowAllActiveAndNormalUsers();

            }

            else if (rdbNormalUser.Checked && rdbNotActive.Checked)
            {
                _ShowAllNotNotActiveAndNormalUsers();

            }

            _OrganizeDataInDataGridView();
           
        }

        private void showUserInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int UsertID = (int)dgvAllUsers.CurrentRow.Cells[0].Value;
            frmShowCurrentUserInformation fr = new frmShowCurrentUserInformation(UsertID);
            fr.ShowDialog();
        }

        private void updateUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int UsertID = (int)dgvAllUsers.CurrentRow.Cells[0].Value;
            frmAddUpdateEmployee fr = new frmAddUpdateEmployee(clsUser.FindByUserID(UsertID).EmployeeID,UsertID);
            fr.ShowDialog();
            FrmUsersManegement_Load(null,null);
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
            int UsertID = (int)dgvAllUsers.CurrentRow.Cells[0].Value;
            _User = clsUser.FindByUserID(UsertID);

            if (_User == null)
            {
                MessageBox.Show("This Row You Selected Is Empty Choose Another One", "Wrong Row", MessageBoxButtons.OK, MessageBoxIcon.Error);
                contextMenuStrip1.Enabled = false;
                return;
            }

            contextMenuStrip1.Enabled = true;
            if (_User.IsActive)
            {
                makeUserActiveToolStripMenuItem.Enabled = false;
                makeUserInActiveToolStripMenuItem.Enabled = true;
            }

            if(!_User.IsActive)
            {
                makeUserActiveToolStripMenuItem.Enabled = true;
                makeUserInActiveToolStripMenuItem.Enabled = false;

            }

             if(_User.UserType==clsUser.enUserType.Normal)
            {
                makeUserNormalToolStripMenuItem.Enabled = false;
                makeUserAdminToolStripMenuItem.Enabled = true;
            }

           if(_User.UserType == clsUser.enUserType.Admin)
            {

                makeUserNormalToolStripMenuItem.Enabled = true;
                makeUserAdminToolStripMenuItem.Enabled = false;
            }

        }

        private void makeUserActiveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(clsUser.ChangeUserToActive(_User.UserID))
            {

                MessageBox.Show("The User Is Active Now", "Active User", MessageBoxButtons.OK);

                FrmUsersManegement_Load(null, null);
            }

            else
            {
                MessageBox.Show("The User Is Not Changed", "Active User", MessageBoxButtons.OK,MessageBoxIcon.Error);

            }
        }

        private void makeUserInActiveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (clsUser.ChangeUserToInActive(_User.UserID))
            {

                MessageBox.Show("The User Is InActive Now", "InActive User", MessageBoxButtons.OK);
                FrmUsersManegement_Load(null, null);
            }

            else
            {
                MessageBox.Show("The User Is still Active", "InActive User", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void makeUserAdminToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (clsUser.ChangeUserFromNormalToAdmine(_User.UserID))
            {

                MessageBox.Show("The User Is Admin Now", "Admin User", MessageBoxButtons.OK);
                FrmUsersManegement_Load(null, null);
            }

            else
            {
                MessageBox.Show("The User Is still Normal Try Again", "Admin User", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void makeUserNormalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (clsUser.ChangeUserFromAdminToNormal(_User.UserID))
            {

                MessageBox.Show("The User Is Normal Now", "Normal User", MessageBoxButtons.OK);
                FrmUsersManegement_Load(null, null);
            }

            else
            {
                MessageBox.Show("The User Is still Admin Try Again", "Normal User", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int UsertID = (int)dgvAllUsers.CurrentRow.Cells[0].Value;
            frmChangePassword frm = new frmChangePassword(UsertID);
            frm.ShowDialog();
        }
    }
}
