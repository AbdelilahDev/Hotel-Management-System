using HMS_Presontation_Layer.CurrentUser;
using HMS_Presontation_Layer.Guests;
using HMS_Presontation_Layer.Payments;
using HMS_Presontation_Layer.Rooms;
using HMS_Presontation_Layer.Users;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HMS_Presontation_Layer
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void roomsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmManagementRooms fr = new frmManagementRooms();
            fr.ShowDialog();
        }

        private void addNewGuestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddAndUpdateGuest fr = new frmAddAndUpdateGuest();
            fr.ShowDialog();
        }

        private void guestsInToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmallGuestsInHotel fr = new frmallGuestsInHotel();
            fr.ShowDialog();
        
        }

        private void guestManagementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmGuestsManagement fr = new frmGuestsManagement();
            fr.ShowDialog();
        }

        private void userInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmShowCurrentUserInformation frm = new frmShowCurrentUserInformation();
            frm.ShowDialog();
        }

        private void updateUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUpdateCurrentUser frm = new frmUpdateCurrentUser();

            frm.ShowDialog();
        }

        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmChangePassword frm = new frmChangePassword();
            frm.ShowDialog();
        }

        private void addNewUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddUpdateEmployee frm = new frmAddUpdateEmployee();

            frm.ShowDialog();
        }

        private void usersManagementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmUsersManegement frm = new FrmUsersManegement();

            frm.ShowDialog();
        }

        private void reservationGuestsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmReservationGuests frm = new frmReservationGuests();

            frm.ShowDialog();
        }

        private void addNewPaymentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAllGuestsNotPay frm = new FormAllGuestsNotPay();
            frm.ShowDialog();
        }

        private void paymentManagementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMagementPayment frm = new frmMagementPayment();
            frm.ShowDialog();
        }
    }
}
