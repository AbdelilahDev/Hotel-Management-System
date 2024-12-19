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
    public partial class frmReserveARoom : Form

    
    {

        // Declare a delegate
        public delegate void DataRefreshEventHandler(object sender, EventArgs e);

        // Declare an event using the delegate
        public event DataRefreshEventHandler DataRefresh;


        DataTable _AllRoomNotbnookedAndActive;
        int _GuestID = -1;
        public frmReserveARoom(int GuestID)
        {
            InitializeComponent();
            ctrShowPersonInformation1.ShowGuestInformation(GuestID);
            _GuestID = GuestID;
        }

        private void frmReserveARoom_Load(object sender, EventArgs e)
        {
         _AllRoomNotbnookedAndActive = clsRoom.GetAllActiveAndNotBookedRooms();
            dgvRooms.DataSource = _AllRoomNotbnookedAndActive;

            btnNext.Enabled = true;
            btnBack.Enabled = !btnNext.Enabled;
    
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tbRoom;
            btnBack.Enabled = true;
            btnNext.Enabled = false;
            
        }

        private void btnBack_Click(object sender, EventArgs e)
        {

            tabControl1.SelectedTab = tbGuest;
            btnBack.Enabled = false;
            btnNext.Enabled = true;

        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(tabControl1.SelectedTab==tbGuest)
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

        private void reserveTheRoomToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int RoomID = (int)dgvRooms.CurrentRow.Cells[0].Value;
            FrmBookingARoom frm = new FrmBookingARoom(_GuestID,RoomID);
            frm.DataRefresh += frmReserveARoom_Load;
            frm.ShowDialog();
        }

        private void frmReserveARoom_FormClosed(object sender, FormClosedEventArgs e)
        {
            DataRefresh?.Invoke(this, null);

        }

     
    }
}
