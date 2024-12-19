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
    public partial class frmAddNewRoom : Form
    {
        // Declare a delegate
        public delegate void RefreshDataAfterAddAGuest(object sender, EventArgs e);

        // Declare an event using the delegate
        public event RefreshDataAfterAddAGuest RefreshData;
        public frmAddNewRoom()
        {
            InitializeComponent();
            ctrAddAndUpdateRoom1.AddNewRoom();
        }

        private void ctrAddAndUpdateRoom1_Load(object sender, EventArgs e)
        {

        }

        private void frmAddNewRoom_FormClosed(object sender, FormClosedEventArgs e)
        {
            RefreshData?.Invoke(null, null);
        }
    }
}
