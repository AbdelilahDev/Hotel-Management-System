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

namespace HMS_Presontation_Layer.Payments
{
    public partial class FormAllGuestsNotPay : Form
    {
        DataTable _AllGuestNotPay;

        clsGuest _Guest;
        public FormAllGuestsNotPay()
        {
            InitializeComponent();

       
        }

        private void _OrganizeDataInDataGridView()
        {

            //Check id Data Grid View is Epmty
            if (dgvGuestNotPay.Rows.Count == 0)
            {
               
                lblTotalGuest.Text = "0";
                return;
            }



            //Orgineze Columns Of DataGridView One By One
            dgvGuestNotPay.Columns[0].HeaderText = "Guest ID";
            dgvGuestNotPay.Columns[0].Width = 100;

            dgvGuestNotPay.Columns[1].HeaderText = "First Name";
            dgvGuestNotPay.Columns[1].Width = 135;


            dgvGuestNotPay.Columns[2].HeaderText = "Last Name";
            dgvGuestNotPay.Columns[2].Width = 135;

            dgvGuestNotPay.Columns[3].HeaderText = "Room ID";
            dgvGuestNotPay.Columns[3].Width = 100;

            dgvGuestNotPay.Columns[4].HeaderText = "Check In Date";
            dgvGuestNotPay.Columns[4].Width = 180;

            dgvGuestNotPay.Columns[5].HeaderText = "Check Out Date";
            dgvGuestNotPay.Columns[5].Width = 180;
            dgvGuestNotPay.Columns[6].HeaderText = "Total Amount";
            dgvGuestNotPay.Columns[6].Width = 100;

            lblTotalGuest.Text = (dgvGuestNotPay.Rows.Count - 1).ToString();



        }

        private void FormAllGuestsNotPay_Load(object sender, EventArgs e)
        {

            _AllGuestNotPay = clsGuest.AllGuestsNotPaid();
            dgvGuestNotPay.DataSource = _AllGuestNotPay;
            _OrganizeDataInDataGridView();
         
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
            int GuestID = (int)dgvGuestNotPay.CurrentRow.Cells[0].Value;
             _Guest= clsGuest.FindGuestByID(GuestID);

            if (_Guest == null)
            {
                MessageBox.Show("This Row You Selected Is Empty Choose Another One", "Wrong Row", MessageBoxButtons.OK, MessageBoxIcon.Error);
                contextMenuStrip1.Enabled = false;
                return;
            }

            contextMenuStrip1.Enabled = true;
        }

        private void paymentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int GuestID = (int)dgvGuestNotPay.CurrentRow.Cells[0].Value;
            int RoomID = (int)dgvGuestNotPay.CurrentRow.Cells[3].Value;

            frmPayment frm = new frmPayment(GuestID, RoomID);

            frm.ShowDialog();

            FormAllGuestsNotPay_Load(null, null);


        }
    }
}
