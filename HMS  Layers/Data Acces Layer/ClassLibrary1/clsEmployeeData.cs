using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class clsEmployeeData
    {
        public static bool GetEmployeeInfoByID(int EmployeeID, ref string NationalNumber, ref string   FirstName,
       ref string LastName, ref string Phone, ref string Address, ref string Email,ref int DepartmentID,ref float Salary,ref float Bonus,ref int PerformanceRate)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "SELECT * FROM Employees WHERE EmployeeID = @EmployeeID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@EmployeeID", EmployeeID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    // The record was found
                    isFound = true;

                   NationalNumber = (string)reader["NationalNumber"];
                    FirstName = (string)reader["FirstName"];
                    LastName = (string)reader["LastName"];

                    Address = (string)reader["Address"];
                    Phone = (string)reader["Phone"];
                    Email = (string)reader["Email"];
                    DepartmentID = (int)reader["DepartmentID"];
                    Salary = Convert.ToSingle(reader["Salary"]);

                    //Bonus: allows null in database so we should handle null

                    if (reader["Bonus"] != DBNull.Value)
                    {
                        Bonus = Convert.ToSingle(reader["Bonus"]);
                    }
                    else
                    {
                        Bonus =0;
                    }

                    PerformanceRate = (int)reader["PerformanceRate"];

                }
                else
                {
                    // The record was not found
                    isFound = false;
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                //Console.WriteLine("Error: " + ex.Message);

                isFound = false;
            }
            finally
            {
                connection.Close();
            }

            return isFound;
        }

         
        public static bool GetEmployeeInfoByNationalNo(string NationalNo, ref int EmployeeID, ref string FirstName, ref string LastName,
          ref string Address, ref string Phone, ref string Email, ref int DepartmentID, ref float Salary, ref float Bonus, ref int PerformanceRate
       )
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "SELECT * FROM Employees WHERE NationalNumber = @NationalNo";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@NationalNo", NationalNo);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    // The record was found
                    isFound = true;

                    EmployeeID = (int)reader["EmployeeID"];
                    FirstName = (string)reader["FirstName"];
                    LastName = (string)reader["LastName"];

                    Address = (string)reader["Address"];
                    Phone = (string)reader["Phone"];
                    Email = (string)reader["Email"];
                    DepartmentID = (int)reader["DepartmentID"];
                    Salary = (float)reader["Salary"];

                    //Bonus: allows null in database so we should handle null

                    if (reader["Bonus"] != DBNull.Value)
                    {
                        Bonus = (float)reader["Bonus"];
                    }
                    else
                    {
                        Bonus = 0;
                    }

                    PerformanceRate = (int)reader["PerformanceRate"];

                }
                else
                {
                    // The record was not found
                    isFound = false;
                }

                reader.Close();


            }
            catch (Exception ex)
            {
                //Console.WriteLine("Error: " + ex.Message);
                isFound = false;
            }
            finally
            {
                connection.Close();
            }

            return isFound;
        }



        public static int AddNewEmployee(string FirstName, string LastName,
           string NationalNo, string Address, string Phone, string Email,int DepartmentID,  float Salary, float Bonus, int PerformanceRate
           )
        {
            //this function will return the new person id if succeeded and -1 if not.
            int PersonID = -1;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"INSERT INTO Employees (NationalNumber,FirstName, LastName,Phone,Address,Email,DepartmentID,Salary,Bonus,PerformanceRate)
                             VALUES (@NationalNumber, @FirstName,@LastName, @Phone, @Address,
                                    @Email,@DepartmentID, @Salary,@Bonus,@PerformanceRate);
                             SELECT SCOPE_IDENTITY();";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@NationalNumber",NationalNo);
            command.Parameters.AddWithValue("@FirstName",FirstName);
            command.Parameters.AddWithValue("@LastName", LastName);
            command.Parameters.AddWithValue("@Phone",Phone);
            command.Parameters.AddWithValue("@Address", Address);
            command.Parameters.AddWithValue("@Email", Email);
            command.Parameters.AddWithValue("@DepartmentID", DepartmentID);
            command.Parameters.AddWithValue("@Salary",Salary);

         
                command.Parameters.AddWithValue("@Bonus",Bonus);


            command.Parameters.AddWithValue("@PerformanceRate", PerformanceRate);

         
            try
            {
                connection.Open();

                object result = command.ExecuteScalar();

                if (result != null && int.TryParse(result.ToString(), out int insertedID))
                {
                    PersonID = insertedID;
                }
            }

            catch (Exception ex)
            {
                //Console.WriteLine("Error: " + ex.Message);

            }

            finally
            {
                connection.Close();
            }

            return PersonID;
        }



        public static bool UpdateEmployee(int EmployeeID, string NationalNo, string FirstName, string LastName,
          string Address, string Phone, string Email, int DepartmentID,float Salary, float Bonus,int PerformanceRate)
        {

            int rowsAffected = 0;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
        
            string query = @"Update  Employees 
                            set
                                NationalNumber=@NationalNumber,
                                FirstName = @FirstName,
                                LastName = @LastName, 
                                
                                Phone   = @Phone,
                                Address = @Address,  
                                
                                  Email = @Email, 
                                  DepartmentID= @DepartmentID,
                                    Salary =@Salary,
                                     Bonus=@Bonus,
                                PerformanceRate=@PerformanceRate
                                where EmployeeID = @EmployeeID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@EmployeeID", EmployeeID);
            command.Parameters.AddWithValue("@FirstName", FirstName);
            command.Parameters.AddWithValue("@LastName", LastName);
            command.Parameters.AddWithValue("@NationalNumber", NationalNo);
            command.Parameters.AddWithValue("@Address", Address);
            command.Parameters.AddWithValue("@Phone", Phone);
            command.Parameters.AddWithValue("@Email", Email);
            command.Parameters.AddWithValue("@DepartmentID", DepartmentID);
            command.Parameters.AddWithValue("@Salary",Salary);
            command.Parameters.AddWithValue("@Bonus",Bonus);
            command.Parameters.AddWithValue("@PerformanceRate", PerformanceRate);

            try
            {
                connection.Open();
                rowsAffected = command.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                //Console.WriteLine("Error: " + ex.Message);
                return false;
            }

            finally
            {
                connection.Close();
            }

            return (rowsAffected > 0);
        }


        public static bool UpdateEmployee(int EmployeeID, string FirstName, string LastName,
          string Address, string Phone, string Email)
        {

            int rowsAffected = 0;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"Update  Employees 
                            set
                       
                                FirstName = @FirstName,
                                LastName = @LastName, 
                                
                                Phone   = @Phone,
                                Address = @Address,  
                                
                                Email = @Email 
                           
                                where EmployeeID = @EmployeeID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@EmployeeID", EmployeeID);
            command.Parameters.AddWithValue("@FirstName", FirstName);
            command.Parameters.AddWithValue("@LastName", LastName);
 
            command.Parameters.AddWithValue("@Address", Address);
            command.Parameters.AddWithValue("@Phone", Phone);
            command.Parameters.AddWithValue("@Email", Email);


            try
            {
                connection.Open();
                rowsAffected = command.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                //Console.WriteLine("Error: " + ex.Message);
                return false;
            }

            finally
            {
                connection.Close();
            }

            return (rowsAffected > 0);
        }


        public static DataTable GetAllEmployees()
        {

            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query =
              @"SELECT  Employees.EmployeeID, Employees.NationalNumber, Employees.FirstName, Employees.LastName, Employees.Phone, Employees.Address, Employees.Email,Departments.Name as DepartementName, Employees.Salary, Employees.Bonus, 
                         Employees.PerformanceRate
FROM            Departments INNER JOIN
                         Employees ON Departments.DepartmentID = Employees.DepartmentID";




            SqlCommand command = new SqlCommand(query, connection);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)

                {
                    dt.Load(reader);
                }

                reader.Close();


            }

            catch (Exception ex)
            {
                // Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }

            return dt;

        }

        public static bool DeleteEmployee(int EmployeeID)
        {

            int rowsAffected = 0;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"Delete Employees 
                                where EmployeeID = @EmployeeID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@EmployeeID", EmployeeID);

            try
            {
                connection.Open();

                rowsAffected = command.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                // Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {

                connection.Close();

            }

            return (rowsAffected > 0);

        }

        public static bool IsEmployeeExist(int EmployeeID)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "SELECT Found=1 FROM Employees where EmployeeID = @EmployeeID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@EmployeeID", EmployeeID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                isFound = reader.HasRows;

                reader.Close();
            }
            catch (Exception ex)
            {
                //Console.WriteLine("Error: " + ex.Message);
                isFound = false;
            }
            finally
            {
                connection.Close();
            }

            return isFound;
        }

        public static bool IsEmployeeExist(string NationalNo)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "SELECT Found=1 FROM  Employees where NationalNumber = @NationalNumber";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@NationalNumber", NationalNo);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                isFound = reader.HasRows;

                reader.Close();
            }
            catch (Exception ex)
            {
                //Console.WriteLine("Error: " + ex.Message);
                isFound = false;
            }
            finally
            {
                connection.Close();
            }

            return isFound;
        }
    }
}
