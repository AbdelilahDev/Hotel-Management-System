using Business_Layer;
using HMS_Presontation_Layer.Booking;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HMS_Presontation_Layer.Guests
{
    public partial class frmGuestsManagement : Form
    {

        DataTable _AllGuests;

        clsGuest _Guest;
        public frmGuestsManagement()
        {
            InitializeComponent();
        }
        private void _OrganizeDataInDataGridView()
        {

            //Check id Data Grid View is Epmty
            if(dgvAllGuests.Rows.Count == 0)
            {
                lblNoGuestsYet.Visible = true;
                lblcountAllGuests.Text = "0";
                return;
            }

            //Hide label That That Contain No records 
            lblNoGuestsYet.Visible = false;

            //Orgineze Columns Of DataGridView One By One
            dgvAllGuests.Columns[0].HeaderText = "Guest ID";
            dgvAllGuests.Columns[0].Width = 100;

            dgvAllGuests.Columns[1].HeaderText = "First Name";
            dgvAllGuests.Columns[1].Width = 135;


            dgvAllGuests.Columns[2].HeaderText = "Last Name";
            dgvAllGuests.Columns[2].Width = 135;

            dgvAllGuests.Columns[3].HeaderText = "Email";
            dgvAllGuests.Columns[3].Width = 150;


            dgvAllGuests.Columns[4].HeaderText = "Phone";
            dgvAllGuests.Columns[4].Width = 100;

      

            dgvAllGuests.Columns[5].HeaderText = "Address";
            dgvAllGuests.Columns[5].Width = 150;

            dgvAllGuests.Columns[6].HeaderText = "Room ID";
            dgvAllGuests.Columns[6].Width = 100;

            dgvAllGuests.Columns[7].HeaderText = "Check In Date";
            dgvAllGuests.Columns[7].Width = 180;

            dgvAllGuests.Columns[8].HeaderText = "Check Out Date";
            dgvAllGuests.Columns[8].Width = 180;
            dgvAllGuests.Columns[9].HeaderText = "Total Amount";
            dgvAllGuests.Columns[9].Width = 100;

            lblcountAllGuests.Text = (dgvAllGuests.Rows.Count - 1).ToString();



        }

        private void frmGuestsManagement_Load(object sender, EventArgs e)
        {
            _AllGuests = clsGuest.GetAllGuests();
            dgvAllGuests.DataSource = _AllGuests;

            _OrganizeDataInDataGridView();

            cmbFilter.SelectedIndex = 0;
            tbFilter.Visible = false;
        }

        private void btnAddGuest_Click(object sender, EventArgs e)
        {
            frmAddAndUpdateGuest fr = new frmAddAndUpdateGuest();
            fr.RefreshData += frmGuestsManagement_Load;
            fr.ShowDialog();
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

        private void tbFilter_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void tbFilter_TextChanged(object sender, EventArgs e)
        {
            string FilterColumn = "";
            //Map Selected Filter to real Column name 
            switch (cmbFilter.Text)
            {
                case "GuestID":
                    FilterColumn = "GuestID";
                    break;

                case "Phone":
                    FilterColumn = "Phone";
                    break;


                default:
                    FilterColumn = "None";
                    break;

            }

            //Reset the filters in case nothing selected or filter value conains nothing.
            if (tbFilter.Text.Trim() == "" || FilterColumn == "None")
            {
                _AllGuests.DefaultView.RowFilter = "";
                lblcountAllGuests.Text = dgvAllGuests.Rows.Count.ToString();
                return;
            }

            else if(FilterColumn == "Phone")

                _AllGuests.DefaultView.RowFilter = string.Format("[{0}] LIKE '{1}%'", FilterColumn, tbFilter.Text.Trim());

        
            else
                _AllGuests.DefaultView.RowFilter = string.Format("[{0}] ={1}", FilterColumn, tbFilter.Text.Trim());


            lblcountAllGuests.Text = (dgvAllGuests.Rows.Count - 1).ToString();
        }

        private void showAGuestInformatiomToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int GuestID = (int)dgvAllGuests.CurrentRow.Cells[0].Value;
            frmShowGuestInformatiom fr = new frmShowGuestInformatiom(GuestID);
            fr.ShowDialog();
        }

        private void updateAGuestToolStripMenuItem_Click(object sender, EventArgs e)
        {

            int GuestID = (int)dgvAllGuests.CurrentRow.Cells[0].Value;
            frmAddAndUpdateGuest fr = new frmAddAndUpdateGuest(GuestID);
            fr.RefreshData += frmGuestsManagement_Load;
            fr.ShowDialog();
        }

        private void reserveARoomToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int GuestID = (int)dgvAllGuests.CurrentRow.Cells[0].Value;
            frmReserveARoom fr = new frmReserveARoom(GuestID);
            fr.DataRefresh += frmGuestsManagement_Load;

            fr.ShowDialog();
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

            string Room = dgvAllGuests.CurrentRow.Cells[6].FormattedValue as string;

            //Check If Guest Reserve A Room Or Not To show Some items of contex menu strip
            if (string.IsNullOrEmpty(Room))
            {
             
                changeTheRoomToolStripMenuItem.Enabled = false;
                reserveARoomToolStripMenuItem.Enabled = true;
            }
            else
            {
            
                changeTheRoomToolStripMenuItem.Enabled = true;
                reserveARoomToolStripMenuItem.Enabled = false;
            }
         



        }

        private void changeDateOfReservationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int GuestID = (int)dgvAllGuests.CurrentRow.Cells[0].Value;
            int RoomID = (int)dgvAllGuests.CurrentRow.Cells[6].Value;
            FrmBookingARoom frm = new FrmBookingARoom(GuestID, RoomID);
            frm.DataRefresh += frmGuestsManagement_Load;
            frm.ShowDialog();
        }

        private void changeTheRoomToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int GuestID = (int)dgvAllGuests.CurrentRow.Cells[0].Value;
            frmReserveARoom fr = new frmReserveARoom(GuestID);
            fr.DataRefresh += frmGuestsManagement_Load;

            fr.ShowDialog();
        }
    }
}
