using ClassLibrary1;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business_Layer
{
    public class clsEmployee
    {
        public enum enMode { AddNew = 0, Update = 1 };
        public enMode Mode = enMode.AddNew;

        public int EmployeeID { set; get; }
        public string FirstName { set; get; }
        public string LastName { set; get; }
        public string FullName
        {
            get { return FirstName +  " " + LastName; }

        }
        public string NationalNo { set; get; }
        public string Address { set; get; }
        public string Phone { set; get; }
        public string Email { set; get; }

        
        public int DepartmentID { set; get; }

        public float Salary { set; get; }

        public float Bonus { set; get; }

        //PerformanceRate

        public int PerformanceRate { set; get; } 
        public clsEmployee()

        {
            this.EmployeeID = -1;
            this.NationalNo = "";
            this.FirstName = "";
            this.LastName = "";
            this.Address = "";
            this.Phone = "";
            this.Email = "";
            this.DepartmentID = -1;
            this.Salary = 0;
            this.Bonus = 0;
            this.PerformanceRate = 0;

            Mode = enMode.AddNew;
        }

        private clsEmployee(int EmployeeID, string NationalNo, string FirstName,string LastName,
             string Address, string Phone, string Email,int DepartmentID,float Salary,float Bonus,int PerformanceRate)

        {
            this.EmployeeID = EmployeeID;
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.NationalNo = NationalNo;
            this.Address = Address;
            this.Phone = Phone;
            this.Email = Email;
            this.DepartmentID = DepartmentID;
            this.Salary = Salary;
            this.Bonus = Bonus;
            this.PerformanceRate = PerformanceRate;
            Mode = enMode.Update;
        }

        private bool _AddNewEmployee()
        {
            //call DataAccess Layer 

            this.EmployeeID = clsEmployeeData.AddNewEmployee(this.FirstName, this.LastName, this.NationalNo, this.Address, this.Phone, this.Email, this.DepartmentID, this.Salary, this.Bonus, this.PerformanceRate);

            return (this.EmployeeID != -1);
        }

        private bool _UpdatePerson()
        {
            //call DataAccess Layer 

            return clsEmployeeData.UpdateEmployee(this.EmployeeID, this.NationalNo, this.FirstName, this.LastName,
                this.Address, this.Phone, this.Email, this.DepartmentID, this.Salary, this.Bonus, this.PerformanceRate);
        }

        public static clsEmployee FindEmployeeByID(int EmployeeID)
        {

            string FirstName = "", LastName = "", NationalNo = "", Email = "", Phone = "", Address = "";
            float Salary = 0, Bonus = 0;
            int PerformanceRate = 0, DepartementID = 0;
           

            bool IsFound = clsEmployeeData.GetEmployeeInfoByID
                                (
                                    EmployeeID, ref NationalNo, ref FirstName, ref LastName, ref Phone, ref Address, ref Email,
                                   ref DepartementID,ref Salary,ref Bonus,ref PerformanceRate
                                );

            if (IsFound)
                //we return new object of that Employee with the right data
                return new clsEmployee(EmployeeID, NationalNo, FirstName, LastName, Address
                    , Phone,Email, DepartementID, Salary, Bonus, PerformanceRate
                    );
            else
                return null;
        }

        public static clsEmployee FindEmployeeByNationalNumber(string NationalNo)
        {
            string FirstName = "", LastName = "", Email = "", Phone = "", Address = "";
            float Salary = 0, Bonus = 0;
            int PerformanceRate = 0, DepartementID = 0,EmployeeID=-1;

            bool IsFound = clsEmployeeData.GetEmployeeInfoByNationalNo
                                          (
                                              NationalNo,ref EmployeeID, ref FirstName, ref LastName, ref Phone, ref Address, ref Email,
                                             ref DepartementID, ref Salary, ref Bonus, ref PerformanceRate
                                          );

            if (IsFound)
                //we return new object of that Employee with the right data
                return new clsEmployee(EmployeeID, NationalNo, FirstName, LastName, Address
                    , Phone, Email, DepartementID, Salary, Bonus, PerformanceRate
                    );
            else
                return null;
        }

        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:
                    if (_AddNewEmployee())
                    {

                        Mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                case enMode.Update:

                    return _UpdatePerson();

            }

            return false;
        }

        public static DataTable GetAllEmployees()
        {
            return clsEmployeeData.GetAllEmployees();
        }

        public static bool DeleteEmployee(int ID)
        {
            return clsEmployeeData.DeleteEmployee(ID);
        }

        public static bool IsEmployeeExistByID(int ID)
        {
            return clsEmployeeData.IsEmployeeExist(ID);
        }

        public static bool isEmployeeExistByNationalNumber(string NationlNo)
        {
            return clsEmployeeData.IsEmployeeExist(NationlNo);
        }

        public static bool UpdateEmployee(int EmployeeID, string FirstName, string LastName,
          string Address, string Phone, string Email)
        {
            return clsEmployeeData.UpdateEmployee(EmployeeID,FirstName,LastName,Address,Phone,Email);

        }

    }
}
