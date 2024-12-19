using ClassLibrary1;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business_Layer
{
    public class clsRoom
    {
        public enum enMode { AddNew = 0, Update = 1 };
        public enMode Mode = enMode.AddNew;

        public int RoomID { set; get;}
        public int RoomNumber { set; get;}
        public string RoomType { set; get;}
      
        public string Description { set; get;}
        public float Price { set; get; }
        public bool IsActive { set; get; }
        public bool IsBooked { set; get; }

        public clsRoom()

        {
            this.RoomID = -1;
            this.RoomNumber = -1;
            this.RoomType = "";
            this.Description = "";
            this.Price = -1;
            this.IsActive = false;
            this.IsBooked =false;
            Mode = enMode.AddNew;
        }

        private clsRoom(int RoomID, int RoomNumber, string RoomType, string Description, float Price, bool IsActive,bool IsBooked)

        {
            this.RoomID = RoomID;
            this.RoomNumber = RoomNumber;
            this.RoomType = RoomType;
            this.Description = Description;
            this.Price= Price;
            this.IsActive = IsActive;
            this.IsBooked = IsBooked;
  
            Mode = enMode.Update;
        }

        private clsRoom(string RoomType, string Description, float Price)

        {
            
            this.RoomType = RoomType;
            this.Description = Description;
            this.Price = Price;
           

            
        }


        private bool _AddNewRoom()
        {
            //call DataAccess Layer 
            this.RoomID = clsRoomsData.AddNewRoom(this.RoomNumber,this.RoomType,this.Price,this.IsActive,this.IsBooked,this.Description);
            return (this.RoomID != -1);
        }

        private bool _UpdateRoom()
        {
            //call DataAccess Layer 

            return clsRoomsData.UpdateRoom(this.RoomID,this.RoomNumber,this.RoomType,this.Price,this.IsActive,this.IsBooked,this.Description);
        }

        public static clsRoom GetRoomInfoByID(int RoomID)
        {
            int RoomNumber = 0;
            string RoomType = "", Description = "";
            float Price = 0;
            bool IsActive = false, IsBooked = false;

            bool IsFound = clsRoomsData.GetRoomInfoByID(RoomID,ref RoomNumber,ref RoomType,ref Description,ref Price,ref IsActive,ref IsBooked);
            if (IsFound)
                //we return new object of that Employee with the right data
                return new clsRoom(RoomID,RoomNumber,RoomType,Description,Price,IsActive,IsBooked);
            else
                return null;
        }

        public static clsRoom GetRoomPriceAndDescreptionByRoomType(string RoomType)
        {
          string Description = "";
            float Price = 0;
  

            bool IsFound = clsRoomsData.GetRoomPricAndDescreptionByRoomType( RoomType, ref Description, ref Price);
            if (IsFound)
                //we return new object of that Employee with the right data
                return new clsRoom( RoomType, Description, Price);
            else
                return null;
        }



        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:
                    if (_AddNewRoom())
                    {

                        Mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                case enMode.Update:

                    return _UpdateRoom();

            }

            return false;
        }

        public bool CancelBookingRoom()
        {

             return clsRoomsData.CancelBookingRoom(this.RoomID);
        }
        public static bool CancelBookingRoom(int RoomID)
        {

            return clsRoomsData.CancelBookingRoom(RoomID);
        }

        public bool ChangeRoomPrice(float NewPrice)
        {
            return clsRoomsData.ChangeRoomPrice(this.RoomID, NewPrice);
        }
        public static int IsRoomNumberExists(int RoomNumber) 
        {
            return clsRoomsData.IsRoomNumberExists(RoomNumber);
        }

        public static bool ChangeRoomPrice(int RoomID,float NewPrice)
        {
            return clsRoomsData.ChangeRoomPrice(RoomID, NewPrice);
        }


     


        public static DataTable GetAllActiveRooms()
        {

            return clsRoomsData.GetAllActiveRooms();

        }

        public static DataTable GetAllInactiveRooms()
        {

            return clsRoomsData.GetAllInactiveRooms();

        }

  
        public static DataTable GetAllBookedRooms()
        {

            return clsRoomsData.GetAllBookedRooms();

        }

        public static DataTable GetAllNotBookedRooms()
        {
            return clsRoomsData.GetAllNotBookedRooms();

        }

      public static DataTable  GetAllActiveAndBookedRooms()
        {

            return clsRoomsData.GetAllActiveAndBookedRooms();
        }

        public static DataTable GetAllActiveAndNotBookedRooms()
        {
            return clsRoomsData.GetAllActiveAndNotBookedRooms();
        }

        public static DataTable GetAllNotActiveAndNotBookedRooms()
        {
            return clsRoomsData.GetAllNotActiveAndNotBookedRooms();
        }
        public static DataTable GetAllNotActiveAndBookedRooms()
        {
            return clsRoomsData.GetAllNotActiveAndBookedRooms();
        }


        public static DataTable GetRoomsTypeByActiveAndBooked(string RoomType, bool IsActive, bool IsBooked)
        {

            return clsRoomsData.GetRoomsTypeByActiveAndBooked(RoomType,IsActive,IsBooked);
        }
        public static DataTable GetAllRooms()
        {

            return clsRoomsData.GetAllRooms();

        }

     

        public static bool ResrveARoom(int RoomID, int GuesID, DateTime CheckInDate, DateTime CheckOutDate, double Price)
        {

            return clsRoomsData.ResrveARoom(RoomID,GuesID,CheckInDate,CheckOutDate,Price);
        }

    }
}
