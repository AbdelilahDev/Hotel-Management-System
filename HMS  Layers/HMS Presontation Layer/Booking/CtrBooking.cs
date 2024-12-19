using Business_Layer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HMS_Presontation_Layer.Booking
{
    public partial class CtrBooking : UserControl
    {
        //// Declare a delegate
        //public delegate void DataBackEventHandler(object sender, int PersonID);

        //// Declare an event using the delegate
        //public event DataBackEventHandler DataBack;
        private clsRoom  _Room;
        private clsGuest _Guest;
        public CtrBooking()
        {
            InitializeComponent();
        }
        private TimeSpan _GetDateDifference(DateTime date1, DateTime date2)
        {
            TimeSpan ts = date2 - date1;
            return ts;
        }
        private double _CalculateTotalPrice()
        {
            // Calculate Deffrence Between start Date And End Date of Booking
           double daysDifference = (dtpCheckOutDate.Value - dtpCheckInDate.Value).TotalDays;

            //Calculate The price

            return  daysDifference * _Room.Price;
        }

     

        public void MakeBooking(int GuestID,int RoomID)
        {

          
            
            _Guest = clsGuest.FindGuestByID(GuestID);

            _Room = clsRoom.GetRoomInfoByID(RoomID);

            //  Booking Date Start From Current Date
            dtpCheckInDate.MinDate = DateTime.Now;
            dtpCheckInDate.Value = DateTime.Now;

            //End Booking Date End At least After One Day From Booking Date
            dtpCheckOutDate.MinDate = DateTime.Now.AddDays(1);
            dtpCheckOutDate.Value = DateTime.Now.AddDays(1);



            if (_Guest == null || _Room == null)

            {
                MessageBox.Show("The Data Of Room or Guest is wrong try again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            //Fill data From Objects To Controls

            tbPrice.Text = _CalculateTotalPrice().ToString();

            tbGuestID.Text = _Guest.GuestID.ToString();
            tbGuestName.Text = _Guest.FirstName + "  " + _Guest.LastName;
            tbRoomID.Text = _Room.RoomID.ToString();
            tbRoomNumber.Text = _Room.RoomNumber.ToString();


        }


        private void btnSave_Click(object sender, EventArgs e) 
        {
            if (clsRoom.ResrveARoom(_Room.RoomID, _Guest.GuestID, dtpCheckInDate.Value, dtpCheckOutDate.Value, _CalculateTotalPrice()))
            {
                MessageBox.Show("The booking seccessfully ", "Booking", MessageBoxButtons.OK);

            }
            else
            {
                MessageBox.Show("The booking Not seccessfully ", "Error Booking", MessageBoxButtons.OK, MessageBoxIcon.Error);


            }
        }

        private void dtpCheckInDate_ValueChanged(object sender, EventArgs e)
        {

            //Get Difference Between Two Dates
            TimeSpan difference = _GetDateDifference(dtpCheckInDate.Value, dtpCheckOutDate.Value);

            // Get Difference Days Between Two Dates 
            int differenceInDays = difference.Days;

            if (differenceInDays < 0)
            {
                MessageBox.Show("Date Value You Entred is Wrong Try Another Values", "Error Date", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dtpCheckInDate.Value = DateTime.Now;
                dtpCheckOutDate.Value = DateTime.Now.AddDays(1);
                return;

            }
            tbPrice.Text =Convert.ToInt32(_CalculateTotalPrice()).ToString();
        }
    }
}
