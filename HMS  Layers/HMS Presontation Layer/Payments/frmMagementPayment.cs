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
    public partial class frmMagementPayment : Form
    {
        DataTable _Guests;

        clsGuest _Guest;
        public frmMagementPayment()
        {
            InitializeComponent();
        }

        private void _OrganizeDataInDataGridView()
        {

            //Check id Data Grid View is Epmty
            if (dgvGuests.Rows.Count == 0)
            {

                lblTotalGuest.Text = "0";
                return;
            }



            //Orgineze Columns Of DataGridView One By One
            dgvGuests.Columns[0].HeaderText = "Guest ID";
            dgvGuests.Columns[0].Width = 100;

            dgvGuests.Columns[1].HeaderText = "First Name";
            dgvGuests.Columns[1].Width = 135;


            dgvGuests.Columns[2].HeaderText = "Last Name";
            dgvGuests.Columns[2].Width = 135;

            dgvGuests.Columns[3].HeaderText = "Room ID";
            dgvGuests.Columns[3].Width = 100;

            dgvGuests.Columns[4].HeaderText = "Check In Date";
            dgvGuests.Columns[4].Width = 160;

            dgvGuests.Columns[5].HeaderText = "Check Out Date";
            dgvGuests.Columns[5].Width = 160;

            dgvGuests.Columns[6].HeaderText = "Total Amount";
            dgvGuests.Columns[6].Width = 100;

            dgvGuests.Columns[7].HeaderText = "Is Pay";
            dgvGuests.Columns[7].Width = 80;

            lblTotalGuest.Text = (dgvGuests.Rows.Count - 1).ToString();



        }

        private DataTable _GetAllGuests()
        {
            DataTable Guests = clsGuest.GetAllGuestsForPayment();

            return Guests;
        }

        private DataTable _GetAllPayGuest()
        {
            DataTable PayGuests = clsGuest.AllGuestsPaid();

            return PayGuests;
        }
        private DataTable _GetAllNotPayGuest()
        {
            DataTable PayGuests = clsGuest.AllGuestsNotPaid();

            return PayGuests;
        }

        private void frmMagementPayment_Load(object sender, EventArgs e)
        {
            _Guests = _GetAllGuests();
            dgvGuests.DataSource = _Guests;
            cmbFilterGuests.SelectedIndex = 0;

            _OrganizeDataInDataGridView();


        }

        private void cmbFilterGuests_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Clear textBox of search GuestID Or Phone Number
            tbFilterGuests.Clear();

            //Case if Select None Column
            if (cmbFilterGuests.Text == "None")
            {


                //Hide text box of searching
                tbFilterGuests.Visible = false;


            }

            else
            {
                //Hide text box of searching
                tbFilterGuests.Visible = true;




            }
        }

        private void tbFilterGuests_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(cmbFilterGuests.Text=="GuestID")
            {
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                {
                    e.Handled = true;
                }

            }
          
        }

        private void tbFilterGuests_TextChanged(object sender, EventArgs e)
        {
            string FilterColumn = "";
            //Map Selected Filter to real Column name 
            switch (cmbFilterGuests.Text)
            {
                case "GuestID":
                    FilterColumn = "GuestID";
                    break;

                case "FirstName":
                    FilterColumn = "FirstName";
                    break;


                default:
                    FilterColumn = "None";
                    break;

            }

            //Reset the filters in case nothing selected or filter value conains nothing.
            if (tbFilterGuests.Text.Trim() == "" || FilterColumn == "None")
            {
                _Guests.DefaultView.RowFilter = "";
                lblTotalGuest.Text = dgvGuests.Rows.Count.ToString();
                return;
            }

            else if (FilterColumn == "FirstName")

                _Guests.DefaultView.RowFilter = string.Format("[{0}] LIKE '{1}%'", FilterColumn, tbFilterGuests.Text.Trim());


            else
                _Guests.DefaultView.RowFilter = string.Format("[{0}] ={1}", FilterColumn, tbFilterGuests.Text.Trim());


            lblTotalGuest.Text = (dgvGuests.Rows.Count - 1).ToString();
        }

        private void rdbPay_CheckedChanged(object sender, EventArgs e)
        {
            cmbFilterGuests.SelectedIndex = 0;
            _Guests = _GetAllPayGuest();
            dgvGuests.DataSource = _Guests;
            _OrganizeDataInDataGridView();

        }

        private void rdbNotPay_CheckedChanged(object sender, EventArgs e)
        {
            cmbFilterGuests.SelectedIndex = 0; 
            _Guests = _GetAllNotPayGuest();
            dgvGuests.DataSource = _Guests;
            _OrganizeDataInDataGridView();
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
            int GuestID = (int)dgvGuests.CurrentRow.Cells[0].Value;

            _Guest = clsGuest.FindGuestByID(GuestID);

            if (_Guest == null)
            {
                MessageBox.Show("This Row You Selected Is Empty Choose Another One", "Wrong Row", MessageBoxButtons.OK, MessageBoxIcon.Error);
                contextMenuStrip1.Enabled = false;
                return;
            }
            bool IsPay = Convert.ToBoolean(dgvGuests.CurrentRow.Cells[7].Value);
            

            contextMenuStrip1.Enabled = true;

            if(IsPay)
            {
                paymentToolStripMenuItem.Enabled = false;
            }

            else
            {
                paymentToolStripMenuItem.Enabled = true;
            }

          

        }

        private void rdbAllGuests_CheckedChanged(object sender, EventArgs e)
        {
            cmbFilterGuests.SelectedIndex = 0;
            _Guests = _GetAllGuests();
            dgvGuests.DataSource = _Guests;
            _OrganizeDataInDataGridView();


        }

        private void paymentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int GuestID = (int)dgvGuests.CurrentRow.Cells[0].Value;
            int RoomID = (int)dgvGuests.CurrentRow.Cells[3].Value;

            frmPayment frm = new frmPayment(GuestID, RoomID);

            frm.ShowDialog();

            frmMagementPayment_Load(null, null);
        }
    }
}
