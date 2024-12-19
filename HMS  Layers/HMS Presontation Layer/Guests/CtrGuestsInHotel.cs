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

namespace HMS_Presontation_Layer.Guests
{
    public partial class CtrGuestsInHotel : UserControl
    {
        DataTable _Guests;
        public CtrGuestsInHotel()
        {
            InitializeComponent();
        }

        private void _OrganizeDataInDataGridView()
        {

            //Check id Data Grid View is Epmty
            if (dgvGuestsInHotel.Rows.Count == 0)
            {
               lblNoGuestinTheHotel.Visible = true;
                lblTotalGuests.Text = "0";
                return;
            }

            //Hide label That That Contain No records 
            lblNoGuestinTheHotel.Visible = false;

            //Orgineze Columns Of DataGridView One By One
            dgvGuestsInHotel.Columns[0].HeaderText = "GuestID";
            dgvGuestsInHotel.Columns[0].Width = 80;

            dgvGuestsInHotel.Columns[1].HeaderText = "FirstName";
            dgvGuestsInHotel.Columns[1].Width = 125;


            dgvGuestsInHotel.Columns[2].HeaderText = "LastName";
            dgvGuestsInHotel.Columns[2].Width = 125;

            dgvGuestsInHotel.Columns[3].HeaderText = "Email";
            dgvGuestsInHotel.Columns[3].Width = 150;

            dgvGuestsInHotel.Columns[4].HeaderText = "Phone";
            dgvGuestsInHotel.Columns[4].Width = 150;


            dgvGuestsInHotel.Columns[5].HeaderText = "Address";
            dgvGuestsInHotel.Columns[5].Width = 150;

           

            dgvGuestsInHotel.Columns[6].HeaderText = "RoomID";
            dgvGuestsInHotel.Columns[6].Width = 80;


            dgvGuestsInHotel.Columns[7].HeaderText = "CheckInDate";
            dgvGuestsInHotel.Columns[7].Width = 200;


            dgvGuestsInHotel.Columns[8].HeaderText = "CheckOutDate";
            dgvGuestsInHotel.Columns[8].Width = 200;



            dgvGuestsInHotel.Columns[9].HeaderText = "Total Amount";
            dgvGuestsInHotel.Columns[9].Width =110;



            lblTotalGuests.Text = (dgvGuestsInHotel.Rows.Count - 1).ToString();


        }

        public void AllGuestInHotel()
        {
            _Guests = clsGuest.GuestInHotel();
            dgvGuestsInHotel.DataSource = _Guests;
            lblTitle.Text = "Guests in Hotel";

            _OrganizeDataInDataGridView();
        }

        public void ReservationGuests()
        {
            _Guests = clsGuest.ReservationGuests();
            dgvGuestsInHotel.DataSource = _Guests;
            lblTitle.Text = "Reservation Guests";

            _OrganizeDataInDataGridView();
        }
    }
}
