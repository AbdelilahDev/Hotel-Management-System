using ClassLibrary1;
using System.Data;

namespace Business_Layer
{
    public class clsGuest
    {
        public enum enMode { AddNew = 0, Update = 1 };
        public enMode Mode = enMode.AddNew;

        public int GuestID { set; get; }
        public string FirstName { set; get; }
        public string LastName { set; get; }
        public string FullName
        {
            get { return FirstName + " " + LastName; }

        }
        public string NationalNo { set; get; }
        public string Address { set; get; }
        public string Phone { set; get; }
        public string Email { set; get; }



        public clsGuest()

        {
            this.GuestID = -1;
            this.FirstName = "";
            this.LastName = "";
            this.Address = "";
            this.Phone = "";
            this.Email = "";

            Mode = enMode.AddNew;
        }

        private clsGuest(int GeustID, string FirstName, string LastName,
             string Address, string Phone, string Email)

        {
            this.GuestID = GeustID;
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.NationalNo = NationalNo;
            this.Address = Address;
            this.Phone = Phone;
            this.Email = Email;
            Mode = enMode.Update;
        }

        private bool _AddNewGuest()
        {
            //call DataAccess Layer 

            this.GuestID = clsGuestsData.AddNewGuest(this.FirstName,this.LastName,this.Email,this.Phone,this.Address);

            return (this.GuestID != -1);
        }

        private bool _UpdateGuest()
        {
            //call DataAccess Layer 

            return clsGuestsData.UpdateGuest(this.GuestID,this.FirstName,this.LastName,this.Email,this.Phone,this.Address);
        }

        public static clsGuest FindGuestByID(int GuestID)
        {

            string FirstName = "", LastName = "", Email = "", Phone = "", Address = "";



            bool IsFound = clsGuestsData.GetGuestInfoByID(GuestID,ref FirstName,ref LastName,ref Email,ref Phone,ref Address);

            if (IsFound)
                //we return new object of that Guest with the right data
                return new clsGuest(GuestID, FirstName, LastName, Address, Phone, Email
                    );
            else
                return null;
        }

   

        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:
                    if (_AddNewGuest())
                    {

                        Mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                case enMode.Update:

                    return _UpdateGuest();

            }

            return false;
        }

        public static DataTable GuestInHotel()
        {
            return clsGuestsData.GuestInHotel();
        }

        public static DataTable ReservationGuests()
        {

            return clsGuestsData.ReservationGuests();
        }

        public static DataTable GetAllGuests()
        {
            return clsGuestsData.GetAllGuests();
        }
        public static DataTable GetAllGuestsForPayment()
        {
            return clsGuestsData.GetAllPaymentGuests();

        }

        public static DataTable AllGuestsNotPaid()
        {
            return clsGuestsData.AllGuestsNotPaid();
        }

        public static DataTable AllGuestsPaid()
        {
            return clsGuestsData.AllGuestsPaid();
        }

        public static int CalculateRentDays(int GuestID, int RoomID)
        {

            return clsGuestsData.CalculateRentDays(GuestID, RoomID);
        }


    }
}
