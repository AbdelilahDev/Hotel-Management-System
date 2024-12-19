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
    public partial class frmAddAndUpdateGuest : Form
    {
        // Declare a delegate
        public delegate void RefreshDataAfterAddAGuest(object sender, EventArgs e);

        // Declare an event using the delegate
        public event RefreshDataAfterAddAGuest RefreshData;
        public frmAddAndUpdateGuest()
        {
            InitializeComponent();
            ctrAddAndUpdateNewGuest1.AddNewGuest();
        }
        public frmAddAndUpdateGuest(int GuestID)
        {
            InitializeComponent();
            ctrAddAndUpdateNewGuest1.UpdateGuest(GuestID);
        }

        private void frmAddAndUpdateGuest_FormClosed(object sender, FormClosedEventArgs e)
        {
            RefreshData?.Invoke(null, null);
        }

       
    }
}
