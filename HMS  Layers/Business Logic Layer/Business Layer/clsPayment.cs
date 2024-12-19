using ClassLibrary1;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business_Layer
{
    public class clsPayment
    {
        public enum enMode { AddNew = 0, Update = 1 };
        public enMode Mode = enMode.AddNew;

        public enum enMothodPayment { Cash=1,PayPal=2,BankTransfer=3 }

        public enMothodPayment PaymentMethod;

        public int PaymentID { set; get; }
        public int GuestID { set; get; }
        public int RoomID { set; get; }
        public DateTime PaymentDate { set; get; }
        public float TotalAmount { set; get; }
       
        public int UserIDCreatedPayment { set; get; }

        public  clsPayment()

        {
            this.PaymentID = -1;
            this.GuestID = -1;
            this.RoomID = -1;
            this.PaymentDate = DateTime.Now;
            this.TotalAmount = 0;
            this.UserIDCreatedPayment= -1;
            this.PaymentMethod = enMothodPayment.Cash;
         

            Mode = enMode.AddNew;
        }
        public clsPayment(int PaymentID,int GuestID,int RoomID,DateTime PaymentDate,float TotalAmount,int UserCreatedPayment,enMothodPayment PayMethod)

        {
            this.PaymentID = PaymentID;
            this.GuestID = GuestID;
            this.RoomID = RoomID;
            this.PaymentDate = PaymentDate;
            this.TotalAmount = TotalAmount;
            this.UserIDCreatedPayment = UserIDCreatedPayment;
            this.PaymentMethod = PayMethod;


            Mode = enMode.Update;
        }

        private bool _AddNewPayment()
        {
            //call DataAccess Layer 

            this.PaymentID = clsPaymentData.AddNewPaymant(this.GuestID,this.RoomID,this.TotalAmount,(int)this.PaymentMethod, this.UserIDCreatedPayment);

            return (this.PaymentID != -1);
        }

        private bool _UpdatePayment()
        {
            //call DataAccess Layer 

            return clsPaymentData.UpdatePayment(this.PaymentID,this.GuestID,this.RoomID, this.TotalAmount,(int) this.PaymentMethod, this.UserIDCreatedPayment);
        }

        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:
                    if (_AddNewPayment())
                    {

                        Mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                case enMode.Update:

                    return _UpdatePayment();

            }

            return false;
        }

        public static DataTable AllPayments()
        {
            return clsPaymentData.AllPayments(); 
        }

    }
}
