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

namespace HMS_Presontation_Layer.Rooms
{
    public partial class frmManagementRooms : Form
    {
        //determine Data Table for put Data into it
        private DataTable _dtAllRooms;
        public frmManagementRooms()
        {
            InitializeComponent();
        }




        // Function that return if radio bottun of Active Rooms is checked or not
        private bool _IsActiveRooms()

        {
            return rdbActive.Checked;

        }



        //Get Specific Data when you choose different Controls
        private void _GetSpecificDataWhenChangeControlsMode()
        {

            //if comboBox Of Rooms Type is visible
            if (cmbRoomType.Visible)
            {
                cmbRoomType_SelectedIndexChanged(null, null);
            }

            // if radio button of Active rooms  checked and radio button booked  checked
            else if (_IsActiveRooms() && _IsBookedRooms())
            {
                _dtAllRooms = _GetAllActiveAndBookedRooms();
                dgvRoomManagement.DataSource = _dtAllRooms;
            }

            // if radio button of Active rooms  checked and radio button Notbooked  checked
            else if (_IsActiveRooms() && !_IsBookedRooms())
            {

                _dtAllRooms = _GetAllActiveAndNotBookedRooms();
                dgvRoomManagement.DataSource = _dtAllRooms;
            }

            // if radio button of NotActive rooms  checked and radio button Notbooked  checked
            else if (!_IsActiveRooms() && !_IsBookedRooms())
            {

                _dtAllRooms = _GetAllNotActiveAndNotBookedRooms();
                dgvRoomManagement.DataSource = _dtAllRooms;
            }
            else if (!_IsActiveRooms() && _IsBookedRooms())
            {

                _dtAllRooms = _GetAllNotActiveAndBookedRooms();
                dgvRoomManagement.DataSource = _dtAllRooms;
            }

            //Other Cases That Means no data
            else
            {
                lblNorecordFound.Visible = true;
            }

            //Finally organize Data inside Data grid View
            _OrganizeDataInDataGridView();
        }

        /*Function that Return Specific Rooms type and if this Rooms Active or not ACtive
         and if Booked or not into DataTable*/
        private DataTable _GetRoomsTypeByActiveAndBooked(string RoomType, bool IsActive, bool IsBooked)
        {
            DataTable dtRooms = clsRoom.GetRoomsTypeByActiveAndBooked(RoomType, IsActive, IsBooked);

            return dtRooms;

        }



        // Function that return if radio bottun of Active Rooms is checked or not
        private bool _IsBookedRooms()

        {
            return rdbBooked.Checked;

        }


        //Function That Make Data Organized in the Data Grid View
        private void _OrganizeDataInDataGridView()
        {

            //Check id Data Grid View is Epmty
            if (dgvRoomManagement.Rows.Count == 0)
            {
                lblNorecordFound.Visible = true;
                return;
            }

            //Hide label That That Contain No records 
            lblNorecordFound.Visible = false;

            //Orgineze Columns Of DataGridView One By One
            dgvRoomManagement.Columns[0].HeaderText = "RoomID";
            dgvRoomManagement.Columns[0].Width = 80;

            dgvRoomManagement.Columns[1].HeaderText = "Room Number";
            dgvRoomManagement.Columns[1].Width = 140;

            dgvRoomManagement.Columns[2].HeaderText = "Room Type";
            dgvRoomManagement.Columns[2].Width = 160;

            dgvRoomManagement.Columns[3].HeaderText = "Descreption";
            dgvRoomManagement.Columns[3].Width = 270;


            dgvRoomManagement.Columns[4].HeaderText = "Price";
            dgvRoomManagement.Columns[4].Width = 90;

            dgvRoomManagement.Columns[5].HeaderText = "Is Active";
            dgvRoomManagement.Columns[5].Width = 80;

            dgvRoomManagement.Columns[6].HeaderText = "Is Booked";
            dgvRoomManagement.Columns[6].Width = 100;
        }



        // Function that return All Active Rooms And Booked Into DataTable
        private DataTable _GetAllActiveAndBookedRooms()

        {
            DataTable dtAllActiveAndBookedRooms = clsRoom.GetAllActiveAndBookedRooms();

            return dtAllActiveAndBookedRooms;

        }


        // Function that return All Active Rooms And Not Booked Into DataTable
        private DataTable _GetAllActiveAndNotBookedRooms()

        {
            DataTable dtAllActiveAndNotBookedRooms = clsRoom.GetAllActiveAndNotBookedRooms();

            return dtAllActiveAndNotBookedRooms;

        }


        // // Function that return All Not Active Rooms And Not Booked Into DataTable
        private DataTable _GetAllNotActiveAndNotBookedRooms()

        {
            DataTable dtAllNotActiveAndNotBookedRooms = clsRoom.GetAllNotActiveAndNotBookedRooms();

            return dtAllNotActiveAndNotBookedRooms;

        }
        private DataTable _GetAllNotActiveAndBookedRooms()

        {
            DataTable dtAllNotActiveAndNotBookedRooms = clsRoom.GetAllNotActiveAndBookedRooms();

            return dtAllNotActiveAndNotBookedRooms;

        }




        private void frmManagementRooms_Load(object sender, EventArgs e)
        {
            //Call Function That Give Specific Data
            _GetSpecificDataWhenChangeControlsMode();

            //label Show Number Of Records
            lblCountRooms.Text = dgvRoomManagement.Rows.Count.ToString();

            //Call function That Make Organize Data
            _OrganizeDataInDataGridView();

            //Select First Item of ComboBox of Filter Column's DataGridView
            cmbFilter.SelectedIndex = 0;

            //Hide text box of searching
            tbFilter.Visible = false;

        }

        private void cmbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Clear textBox of search RoomID Or Room Number
                 tbFilter.Clear();

            //Case if Select None Column
            if (cmbFilter.Text == "None")
            {
                //Hide Combox of RoomsType
                cmbRoomType.Visible = false;

                //Hide text box of searching
                tbFilter.Visible = false;

                //Call Function That Give Specific Data
                _GetSpecificDataWhenChangeControlsMode();

            }
            // Filter Data By Room Types
           else if (cmbFilter.Text == "RoomType")
            {
                //Hide text box of searching
                tbFilter.Visible = false;
                //Select First Item of ComboBox of RoomsType Column's DataGridView
                cmbRoomType.SelectedIndex = 0;

                //Show Combox of RoomsType
                cmbRoomType.Visible = true;

                //Call Function to refresh 
                cmbRoomType_SelectedIndexChanged(null,null);

            }
          
            else 
            {
                tbFilter.Visible = true;
                cmbRoomType.Visible = false;
                _GetSpecificDataWhenChangeControlsMode();
               


            }
        }

        private void cmbRoomType_SelectedIndexChanged(object sender, EventArgs e)
        {
            string RoomsType = cmbRoomType.Text;
            if (_IsActiveRooms() && _IsBookedRooms())
            {
                _dtAllRooms = _GetRoomsTypeByActiveAndBooked(RoomsType, true, true);
                dgvRoomManagement.DataSource = _dtAllRooms;
            }
            else if (_IsActiveRooms() && !_IsBookedRooms())
            {

                _dtAllRooms = _GetRoomsTypeByActiveAndBooked(RoomsType, true, false);
                dgvRoomManagement.DataSource = _dtAllRooms;
            }
            else if (!_IsActiveRooms() && !_IsBookedRooms())
            {
                _dtAllRooms = _GetRoomsTypeByActiveAndBooked(RoomsType, false, false);
                dgvRoomManagement.DataSource = _dtAllRooms;
            }

            if (_dtAllRooms.Rows.Count == 0)
            {
                lblNorecordFound.Visible = true;
            }

            else
            {
                lblNorecordFound.Visible = false;
            }



        }

        private void tbFilter_TextChanged(object sender, EventArgs e)
        {
           

            string FilterColumn = "";
            //Map Selected Filter to real Column name 
            switch (cmbFilter.Text)
            {
                case "RoomID":
                    FilterColumn = "RoomID";
                    break;

                case "RoomNumber":
                    FilterColumn = "RoomNumber";
                    break;


                default:
                    FilterColumn = "None";
                    break;

            }

            //Reset the filters in case nothing selected or filter value conains nothing.
            if (tbFilter.Text.Trim() == "" || FilterColumn == "None")
            {
                _dtAllRooms.DefaultView.RowFilter = "";
                lblCountRooms.Text = dgvRoomManagement.Rows.Count.ToString();
                return;
            }


         
                //in this case we deal with numbers not string.
              //  _dtAllRooms.DefaultView.RowFilter = string.Format("[{0}] = {1}", FilterColumn, tbFilter.Text.Trim());

            if (_IsActiveRooms())
            {
                _dtAllRooms.DefaultView.RowFilter = string.Format("{0} = {1} AND {2} = '{3}'", FilterColumn, tbFilter.Text.Trim(), "IsActive", true);
                //_dtAllRooms.DefaultView.RowFilter = string.Format("IsActive = {0}", true);

            }
            else
            {
                _dtAllRooms.DefaultView.RowFilter = string.Format("{0} = {1} AND {2} = '{3}'", FilterColumn, tbFilter.Text.Trim(), "IsActive", false);

            }

            lblCountRooms.Text = (dgvRoomManagement.Rows.Count-1).ToString();
        }

        private void rdbActive_CheckedChanged(object sender, EventArgs e)
        {

       
            _GetSpecificDataWhenChangeControlsMode();
        }

        private void rdbNotActive_CheckedChanged(object sender, EventArgs e)
        {

            _GetSpecificDataWhenChangeControlsMode();
        }

        private void rdbNotBooking_CheckedChanged(object sender, EventArgs e)
        {
            //frmManagementRooms_Load(null, null);
            _GetSpecificDataWhenChangeControlsMode();
        }

        private void rdbBooked_CheckedChanged(object sender, EventArgs e)
        {
            // frmManagementRooms_Load(null, null);

            _GetSpecificDataWhenChangeControlsMode();

        }

        private void tbFilter_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnAddRoom_Click(object sender, EventArgs e)
        {
            frmAddNewRoom frm = new frmAddNewRoom();
            frm.RefreshData += frmManagementRooms_Load;

            frm.ShowDialog();
        }
    }
}
