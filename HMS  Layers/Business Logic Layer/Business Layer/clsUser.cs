using ClassLibrary1;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business_Layer
{
    public class clsUser
    {
        public enum enMode { AddNew = 0, Update = 1 };
        public enMode Mode = enMode.AddNew;

        public enum enUserType { Normal = 1, Admin = 2 };

        public enUserType UserType;
        
        public enUserType SetAndGetUserType
        {
            set { UserType = value; }
            get { return UserType;  }
        }
        public int UserID { set; get; }
        public int EmployeeID { set; get; }
        public clsEmployee EmployeeInfo;
        public string UserName { set; get; }
        public string Password { set; get; }
        public bool IsActive { set; get; }


        public clsUser(enUserType UserType)

        {
            this.EmployeeID = -1;
            this.UserID = -1;
            this.UserName = "";
            this.Password = "";
            this.UserType = UserType;
            this.IsActive = false;
            Mode = enMode.AddNew;
        }

        private clsUser(int UserID,int EmployeeID, string Username, string Password,enUserType UserType,bool IsActive)
            

        {
            this.UserID = UserID;
            this.EmployeeID=EmployeeID;
            this.EmployeeInfo = clsEmployee.FindEmployeeByID(EmployeeID);
            this.UserName = Username;
            this.Password = Password;
            this.UserType = UserType;
            this.IsActive = IsActive;
            Mode = enMode.Update;
        }

        private bool _AddNewUser()
        {
            //call DataAccess Layer 

            this.UserID = clsUserData.AddNewUser(this.EmployeeID, this.UserName,
                this.Password,(int) this.UserType,this.IsActive);

            return (this.UserID != -1);
        }
        private bool _UpdateUser()
        {
            //call DataAccess Layer 

            return clsUserData.UpdateUser(this.UserID, this.EmployeeID, this.UserName,
                this.Password,(int) this.UserType,this.IsActive);
        }

        public static clsUser FindByUserID(int UserID)
        {
            int EmployeeID = -1;
            string UserName = "", Password = "";
            int userType=-1;
            bool IsActive = false;

            bool IsFound = clsUserData.GetUserInfoByUserID
                                (UserID, ref EmployeeID, ref UserName, ref Password, ref  userType,ref IsActive);

            if (IsFound)
                //we return new object of that User with the right data
                return new clsUser(UserID, EmployeeID, UserName, Password,(enUserType)userType,IsActive);
            else
                return null;
        }

        public static clsUser FindByUsernameAndPassword(string UserName, string Password)
        {
            int EmployeeID = -1,UserID=-1, userType = -1;
            bool IsActive = false;

            bool IsFound = clsUserData.GetUserInfoByUsernameAndPassword
                                (UserName,Password,ref UserID,ref EmployeeID,ref userType,ref IsActive);

            if (IsFound)
                //we return new object of that User with the right data
                return new clsUser(UserID, EmployeeID, UserName, Password, (enUserType)userType, IsActive);
            else
                return null;
        }

        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:
                    if (_AddNewUser())
                    {

                        Mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                case enMode.Update:

                    return _UpdateUser();

            }

            return false;
        }

        public static DataTable GetAllUsers()
        {
            return clsUserData.GetAllUsers();
        }
        public static DataTable  GetAllActiveAndNormalUsers()
        {
            return clsUserData.GetAllActiveAndNormalUsers();

        }
        public static DataTable GetAllNotActiveAndNormalUsers()
        {
            return clsUserData.GetAllNotActiveAndNormalUsers();

        }

        public static DataTable GetAllActiveAndAdminUsers()
        {
            return clsUserData.GetAllActiveAndAdminUsers();
        }

        public static DataTable GetAllNotActiveAndAdminUsers()
        {
            return clsUserData.GetAllNotActiveAndAdminUsers();
        }
        public static bool DeleteUser(int UserID)
        {
            return clsUserData.DeleteUser(UserID);
        }

        public static bool isUserExist(int UserID)
        {
            return clsUserData.IsUserExist(UserID);
        }

        public static bool isUserExist(string UserName)
        {
            return clsUserData.IsUserExist(UserName);
        }


        public static bool ChangeUserToActive(int UserID)
        {

            return clsUserData.ChangeUserToActive(UserID);
        }


        public static bool ChangeUserToInActive(int UserID)
        {
            return clsUserData.ChangeUserToInActive(UserID);
        }

        public static bool ChangeUserFromNormalToAdmine(int UserID)
        {
            return clsUserData.ChangeUserFromNormalToAdmine(UserID);

        }

        public static bool ChangeUserFromAdminToNormal(int UserID)
        {
            return clsUserData.ChangeUserFromAdminToNormal(UserID);

        }




    }
}
