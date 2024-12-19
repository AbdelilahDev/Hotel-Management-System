using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HMS_Presontation_Layer.Booking
{
    public partial class FrmBookingARoom : Form
    {
        // Declare a delegate
        public delegate void DataRefreshEventHandler(object sender, EventArgs e);

        // Declare an event using the delegate
        public event DataRefreshEventHandler DataRefresh;
        public FrmBookingARoom(int GuestID,int RoomID)
        {
            InitializeComponent();
            ctrBooking1.MakeBooking(GuestID, RoomID);
        }

      

        private void FrmBookingARoom_FormClosed(object sender, FormClosedEventArgs e)
        {
            DataRefresh?.Invoke(null, null);
        }
    }
}
