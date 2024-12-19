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

namespace HMS_Presontation_Layer.Rooms
{
    public partial class CtrAddAndUpdateRoom : UserControl
    {


        clsRoom _Room;
        public CtrAddAndUpdateRoom()
        {
            InitializeComponent();
        }
        public void AddNewRoom()
        {
             cmbRoomType.SelectedIndex = 0;
            _Room = clsRoom.GetRoomPriceAndDescreptionByRoomType(cmbRoomType.Text);
            tbPrice.Text = _Room.Price.ToString();
            tbDescription.Text = _Room.Description.ToString();

        }

        private void CtrAddAndUpdateRoom_Load(object sender, EventArgs e)
        {
        
        }

        private void cmbRoomType_SelectedIndexChanged(object sender, EventArgs e)
        {
            _Room = clsRoom.GetRoomPriceAndDescreptionByRoomType(cmbRoomType.Text);

                _Room = clsRoom.GetRoomPriceAndDescreptionByRoomType(cmbRoomType.Text);
                tbPrice.Text = _Room.Price.ToString();
                tbDescription.Text = _Room.Description.ToString();


     
        }

        private void cmbRoomType_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Prevent the character from being entered
            }
        }

        private void btnSave_Click(object sender, EventArgs e) 
        {
            if (!this.ValidateChildren())
            {
                //Here we dont continue becuase the form is not valid
                MessageBox.Show("Some fileds are not valide!, put the mouse over the red icon(s) to see the erro", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }
            int RoomNumber = Convert.ToInt32(tbRoomNumber.Text);

            if (clsRoom.IsRoomNumberExists(RoomNumber)==0)
            {
                clsRoom NewRoom = new clsRoom();
                NewRoom.RoomNumber = RoomNumber;
                NewRoom.Price = Convert.ToSingle(tbPrice.Text);
                NewRoom.Description = tbDescription.Text;
                NewRoom.RoomType = cmbRoomType.Text;
                NewRoom.IsBooked = rdbBooked.Checked;
                NewRoom.IsActive = rdbActive.Checked;
                NewRoom.Mode = clsRoom.enMode.AddNew;
                if(NewRoom.Save())
                {
                    lblRoomID.Text = NewRoom.RoomID.ToString();
               
                    MessageBox.Show("The Room Saved Seccessfully", "Saved Room", MessageBoxButtons.OK);
                }

                else
                {
                    MessageBox.Show("The Room Not Saved Seccessfully", "Saved Room", MessageBoxButtons.OK,MessageBoxIcon.Error);


                }

            }

            else 
            {
                    MessageBox.Show("This number Of Room already exist Choose Another Room Number", "Saved Room", MessageBoxButtons.OK,MessageBoxIcon.Error);

            }
        }

        private void tbRoomNumber_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(tbRoomNumber.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(tbRoomNumber, "This field is required!");
            }
            else
            {
                //e.Cancel = false;
                errorProvider1.SetError(tbRoomNumber, null);
            }
        }

        private void tbRoomNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) )
            {
                e.Handled = true;
            }
        }
    }
}
