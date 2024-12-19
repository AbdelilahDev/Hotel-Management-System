using Business_Layer;
using HMS_Presontation_Layer.Global_Classes;
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
    public partial class CtrlAddUpdatePayment : UserControl
    {
        clsRoom _Room;
        int _GuestID;
        public enum enMode { AddNew = 0, Update = 1 };
        public enMode Mode = enMode.AddNew;
        public CtrlAddUpdatePayment()
        {
            InitializeComponent();
        }

        private int _CalculateRentDaysOfARoom()
        {
            int RentDays = 0;

            RentDays = clsGuest.CalculateRentDays(_GuestID, _Room.RoomID);
            return RentDays;

        }
        private void _AddNewPayment()
        {
            clsPayment Payment = new clsPayment();

            Payment.GuestID = _GuestID;
            Payment.PaymentMethod = (clsPayment.enMothodPayment)(cmbPaymentMethod.SelectedIndex+1);
            Payment.RoomID = _Room.RoomID;
            Payment.UserIDCreatedPayment = clsGlobal.CurrentUser.UserID;
            Payment.TotalAmount = _Room.Price * _CalculateRentDaysOfARoom();
            Payment.PaymentDate = DateTime.Now;

            if(Payment.Save())
            {
                lblPaymentID.Text = Payment.PaymentID.ToString();
                MessageBox.Show("The Payment Seccessed", "Payment", MessageBoxButtons.OK);
            }
            else 
            {
                MessageBox.Show("The Payment Not Complete Try Again", "Error Payment", MessageBoxButtons.OK,MessageBoxIcon.Error);

            }
        }
        public void AddNewPayment(int GuestID,int RoomID)
        {
            Mode = enMode.AddNew;
            lblTitle.Text = "New Payment";
            _Room = clsRoom.GetRoomInfoByID(RoomID);
            _GuestID = GuestID;

            tbGuestID.Text = GuestID.ToString();

            tbRoomID.Text = RoomID.ToString();

            tbRoomType.Text = _Room.RoomType;

            tbRentDays.Text = clsGuest.CalculateRentDays(GuestID, RoomID).ToString();

            tbUserCreatePayment.Text = clsGlobal.CurrentUser.EmployeeInfo.FullName;

            tbAmount.Text = (_Room.Price * _CalculateRentDaysOfARoom()).ToString();
            cmbPaymentMethod.SelectedIndex = 0;

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(Mode==enMode.AddNew)
            {
                _AddNewPayment();
            }
        }
    }
}
