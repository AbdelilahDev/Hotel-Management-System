using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class clsUserData
    {

        public static bool GetUserInfoByUserID(int UserID, ref int EmployeeID, ref string UserName,
            ref string Password,ref int UserType,ref bool IsActive)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "SELECT * FROM Users WHERE UserID = @UserID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@UserID", UserID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    // The record was found
                    isFound = true;

                    EmployeeID = (int)reader["EmployeeID"];
                    UserName = (string)reader["UserName"];
                    Password = (string)reader["Password"];
                    UserType = (int)reader["UserType"];
                    IsActive = (bool)reader["IsActive"];

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


        public static bool GetUserInfoByPersonID(int EmployeeID, ref int UserID, ref string UserName,
          ref string Password, ref int UserType)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "SELECT * FROM Users WHERE EmployeeID = @EmployeeID";

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

                    UserID = (int)reader["UserID"];
                    UserName = (string)reader["UserName"];
                    Password = (string)reader["Password"];
                    UserType = (int)reader["UserType"];


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

        public static bool GetUserInfoByUsernameAndPassword(string UserName, string Password,
            ref int UserID, ref int EmployeeID, ref int UserType,ref bool IsActive)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "SELECT * FROM Users WHERE UserName = @Username and Password=@Password;";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@Username", UserName);
            command.Parameters.AddWithValue("@Password", Password);


            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    // The record was found
                    isFound = true;
                    UserID = (int)reader["UserID"];
                    EmployeeID = (int)reader["EmployeeID"];
                    UserName = (string)reader["UserName"];
                    Password = (string)reader["Password"];
                    UserType = (int)reader["UserType"];
                    IsActive = (bool)reader["IsActive"];



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

        public static int AddNewUser(int EmployeeID, string UserName,
             string Password, int UserType,bool IsActive)
        {
            //this function will return the new person id if succeeded and -1 if not.
            int UserID = -1;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"INSERT INTO Users (EmployeeID,UserName,Password,UserType,IsActive)
                             VALUES (@EmployeeID, @UserName,@Password,@UserType,@IsActive);
                             SELECT SCOPE_IDENTITY();";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@EmployeeID", EmployeeID);
            command.Parameters.AddWithValue("@UserName", UserName);
            command.Parameters.AddWithValue("@Password", Password);
            command.Parameters.AddWithValue("@UserType",UserType);
            command.Parameters.AddWithValue("@IsActive",IsActive);



            try
            {
                connection.Open();

                object result = command.ExecuteScalar();

                if (result != null && int.TryParse(result.ToString(), out int insertedID))
                {
                    UserID = insertedID;
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

            return UserID;
        }


        public static bool UpdateUser(int UserID, int EmployeeID, string UserName,
             string Password,int UserType,bool IsActive)
        {

            int rowsAffected = 0;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"Update  Users  
                            set EmployeeID = @EmployeeID,
                                UserName = @UserName,
                                Password = @Password,
                                UserType =@UserType,
                                IsActive=@IsActive
                                where UserID = @UserID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@EmployeeID", EmployeeID);
            command.Parameters.AddWithValue("@UserName", UserName);
            command.Parameters.AddWithValue("@Password", Password);
            command.Parameters.AddWithValue("@UserType", UserType);
            command.Parameters.AddWithValue("@UserID", UserID);
            command.Parameters.AddWithValue("@IsActive",IsActive);



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


        public static DataTable GetAllUsers()
        {

            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"SELECT  Users.UserID,FullName = Employees.FirstName +' ' + Employees.LastName,Users.UserName,
                              UserType=
                                  case 
                                 when Users.UserType=1 then 'Normal' 
                                  when Users.UserType=2 then 'Admin' 
                                  END,
                                  Users.IsActive
                                   FROM  Users INNER JOIN
                                   Employees ON Users.EmployeeID = Employees.EmployeeID";

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

        public static DataTable GetAllActiveAndNormalUsers()
        {
            DataTable dt = new DataTable();
            try
            {
                // Create a SqlConnection object with the connection string.
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    // Open the database connection.
                    connection.Open();

                    // Define the SQL query to execute.
                    string query = @"SELECT  Users.UserID,FullName = Employees.FirstName +' ' + Employees.LastName,Users.UserName,
                              UserType=
                                  case 
                                 when Users.UserType=1 then 'Normal' 
                                  when Users.UserType=2 then 'Admin' 
                                  END,
                                  Users.IsActive
                                   FROM  Users INNER JOIN
                                   Employees ON Users.EmployeeID = Employees.EmployeeID

								   where Users.IsActive=1 and Users.UserType=1";

                    // Create a SqlCommand object to execute the query and associate it with the SqlConnection.
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Execute the query and obtain a SqlDataReader.
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                           

                            if (reader.HasRows)

                            {
                                dt.Load(reader);
                            }
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine("Database connection error: " + ex.Message);
            }



            return dt;

        }

        public static DataTable GetAllNotActiveAndNormalUsers()
        {
            DataTable dt = new DataTable();
            try
            {
                // Create a SqlConnection object with the connection string.
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    // Open the database connection.
                    connection.Open();

                    // Define the SQL query to execute.
                    string query = @"SELECT  Users.UserID,FullName = Employees.FirstName +' ' + Employees.LastName,Users.UserName,
                              UserType=
                                  case 
                                 when Users.UserType=1 then 'Normal' 
                                  when Users.UserType=2 then 'Admin' 
                                  END,
                                  Users.IsActive
                                   FROM  Users INNER JOIN
                                   Employees ON Users.EmployeeID = Employees.EmployeeID

								   where Users.IsActive=0 and Users.UserType=1";

                    // Create a SqlCommand object to execute the query and associate it with the SqlConnection.
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Execute the query and obtain a SqlDataReader.
                        using (SqlDataReader reader = command.ExecuteReader())
                        {


                            if (reader.HasRows)

                            {
                                dt.Load(reader);
                            }
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine("Database connection error: " + ex.Message);
            }



            return dt;

        }


        public static DataTable GetAllActiveAndAdminUsers()
        {
            DataTable dt = new DataTable();
            try
            {
                // Create a SqlConnection object with the connection string.
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    // Open the database connection.
                    connection.Open();

                    // Define the SQL query to execute.
                    string query = @"SELECT  Users.UserID,FullName = Employees.FirstName +' ' + Employees.LastName,Users.UserName,
                              UserType=
                                  case 
                                 when Users.UserType=1 then 'Normal' 
                                  when Users.UserType=2 then 'Admin' 
                                  END,
                                  Users.IsActive
                                   FROM  Users INNER JOIN
                                   Employees ON Users.EmployeeID = Employees.EmployeeID

								   where Users.IsActive=1 and Users.UserType=2";

                    // Create a SqlCommand object to execute the query and associate it with the SqlConnection.
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Execute the query and obtain a SqlDataReader.
                        using (SqlDataReader reader = command.ExecuteReader())
                        {


                            if (reader.HasRows)

                            {
                                dt.Load(reader);
                            }
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine("Database connection error: " + ex.Message);
            }



            return dt;

        }


        public static DataTable GetAllNotActiveAndAdminUsers()
        {
            DataTable dt = new DataTable();
            try
            {
                // Create a SqlConnection object with the connection string.
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    // Open the database connection.
                    connection.Open();

                    // Define the SQL query to execute.
                    string query = @"SELECT  Users.UserID,FullName = Employees.FirstName +' ' + Employees.LastName,Users.UserName,
                              UserType=
                                  case 
                                 when Users.UserType=1 then 'Normal' 
                                  when Users.UserType=2 then 'Admin' 
                                  END,
                                  Users.IsActive
                                   FROM  Users INNER JOIN
                                   Employees ON Users.EmployeeID = Employees.EmployeeID

								   where Users.IsActive=0 and Users.UserType=2";

                    // Create a SqlCommand object to execute the query and associate it with the SqlConnection.
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Execute the query and obtain a SqlDataReader.
                        using (SqlDataReader reader = command.ExecuteReader())
                        {


                            if (reader.HasRows)

                            {
                                dt.Load(reader);
                            }
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine("Database connection error: " + ex.Message);
            }



            return dt;

        }
        public static bool DeleteUser(int UserID)
        {

            int rowsAffected = 0;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"Delete Users 
                                    where UserID = @UserID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@UserID", UserID);

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

        public static bool IsUserExist(int UserID)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "SELECT Found=1 FROM Users WHERE UserID = @UserID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@UserID", UserID);

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

        public static bool IsUserExist(string UserName)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "SELECT Found=1 FROM Users WHERE UserName = @UserName";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@UserName", UserName);

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

        public static bool IsUserExistForPersonID(int EmployeeID)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "SELECT Found=1 FROM Users WHERE EmployeeID = @EmployeeID";

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

        public static bool ChangeUserToActive(int UserID)
        {
            int rowsAffected = 0;
            try
            {
                // Create a SqlConnection object with the connection string.
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    // Open the database connection.
                    connection.Open();

                    // Define the SQL query to execute.
                    string query = @"Update  Users  
                            set 
                                IsActive=1
                                where UserID = @UserID";

                    // Create a SqlCommand object to execute the query and associate it with the SqlConnection.
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@UserID", UserID);
                        // Execute the query and obtain a SqlDataReader.
                        rowsAffected = command.ExecuteNonQuery();
                    }
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine("Database connection error: " + ex.Message);
            }



            return rowsAffected>0;

        }

        public static bool ChangeUserToInActive(int UserID)
        {
            int rowsAffected = 0;
            try
            {
                // Create a SqlConnection object with the connection string.
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    // Open the database connection.
                    connection.Open();

                    // Define the SQL query to execute.
                    string query = @"Update  Users  
                            set 
                                IsActive=0
                                where UserID = @UserID";

                    // Create a SqlCommand object to execute the query and associate it with the SqlConnection.
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@UserID", UserID);
                        // Execute the query and obtain a SqlDataReader.
                        rowsAffected = command.ExecuteNonQuery();
                    }
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine("Database connection error: " + ex.Message);
            }



            return rowsAffected > 0;

        }

        public static bool ChangeUserFromNormalToAdmine(int UserID)
        {
            int rowsAffected = 0;
            try
            {
                // Create a SqlConnection object with the connection string.
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    // Open the database connection.
                    connection.Open();

                    // Define the SQL query to execute.
                    string query = @"Update  Users  
                            set 
                                UserType =2
                                where UserID = @UserID";

                    // Create a SqlCommand object to execute the query and associate it with the SqlConnection.
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@UserID", UserID);
                        // Execute the query and obtain a SqlDataReader.
                        rowsAffected = command.ExecuteNonQuery();
                    }
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine("Database connection error: " + ex.Message);
            }



            return rowsAffected > 0;

        }


        public static bool ChangeUserFromAdminToNormal(int UserID)
        {
            int rowsAffected = 0;
            try
            {
                // Create a SqlConnection object with the connection string.
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    // Open the database connection.
                    connection.Open();

                    // Define the SQL query to execute.
                    string query = @"Update  Users  
                            set 
                                UserType =1
                                where UserID = @UserID";

                    // Create a SqlCommand object to execute the query and associate it with the SqlConnection.
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@UserID", UserID);
                        // Execute the query and obtain a SqlDataReader.
                        rowsAffected = command.ExecuteNonQuery();
                    }
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine("Database connection error: " + ex.Message);
            }



            return rowsAffected > 0;

        }


        public static bool ChangePassword(int UserID, string NewPassword)
        {

            int rowsAffected = 0;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"Update  Users  
                                set Password = @Password
                                where UserID = @UserID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@UserID", UserID);
            command.Parameters.AddWithValue("@Password", NewPassword);


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

    }
}
