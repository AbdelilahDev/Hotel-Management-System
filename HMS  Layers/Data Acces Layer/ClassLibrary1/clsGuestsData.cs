using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
     public class clsGuestsData
    {

        public static int AddNewGuest(string FirstName, string LastName,
            string Email, string Phone, string Address
          )
        {
            //this function will return the new person id if succeeded and -1 if not.
            int GuestID = -1;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"INSERT INTO Guests (FirstName,LastName,Email,Phone,Address,IsPaid)
                             VALUES (@FirstName,@LastName,@Email, @Phone, @Address,0);
                             SELECT SCOPE_IDENTITY();";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@FirstName", FirstName);
            command.Parameters.AddWithValue("@LastName", LastName);
            command.Parameters.AddWithValue("@Email", Email);
            command.Parameters.AddWithValue("@Phone", Phone);
            command.Parameters.AddWithValue("@Address", Address);
            try
            {
                connection.Open();

                object result = command.ExecuteScalar();

                if (result != null && int.TryParse(result.ToString(), out int insertedID))
                {
                    GuestID = insertedID;
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

            return GuestID;
        }

        public static bool GetGuestInfoByID(int GuestID, ref string FirstName, ref string LastName, ref string Email, ref string Phone, ref string Address)

        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "exec SP_GetGuestInformationByID @GuestID=@guestID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@guestID", GuestID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    // The record was found
                    isFound = true;

            
                    FirstName = (string)reader["FirstName"];
                    LastName = (string)reader["LastName"];

                    Address = (string)reader["Address"];
                    Phone = (string)reader["Phone"];
                    Email = (string)reader["Email"];


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

        public static bool UpdateGuest(int GuestID,string FirstName, string LastName,string Email,string Phone,string Address)
        {

            int rowsAffected = 0;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = @"exec  UpdateGuest  @GuestID=@Guestid, @FirstName=@Firstname, @LastName=@Lastname, @Email=@email,@Phone=@phone,@Address=@address";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@Guestid", GuestID);
            command.Parameters.AddWithValue("@Firstname", FirstName);
            command.Parameters.AddWithValue("@Lastname", LastName);
            command.Parameters.AddWithValue("@email", Email);
            command.Parameters.AddWithValue("@phone", Phone);
            command.Parameters.AddWithValue("@address", Address);

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

        public static DataTable GuestInHotel()
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
                    string query = @"exec SP_GeustsInHotel";

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

        public static DataTable ReservationGuests()
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
                    string query = @"exec SP_ReservationofGuest";

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
        public static DataTable GetAllGuests()
        {

            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"exec SP_GetAllGuests";




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

        public static DataTable GetAllPaymentGuests()
        {

            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"select GuestID,FirstName,LastName,RoomID,CheckInDate,CheckOutDate,TotalAmount,IsPaid  from Guests";




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

        public static DataTable AllGuestsNotPaid()
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
                    string query = @"select GuestID,FirstName,LastName,RoomID,CheckInDate,CheckOutDate,TotalAmount,IsPaid  from Guests where IsPaid=0";

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
        public static DataTable AllGuestsPaid()
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
                    string query = @"select GuestID,FirstName,LastName,RoomID,CheckInDate,CheckOutDate,TotalAmount,IsPaid  from Guests where IsPaid=1";

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

        public static int CalculateRentDays(int GuestID,int RoomID)
        {

            int RentDays = -1;
            try
            {
                // Create a SqlConnection object with the connection string.
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    // Open the database connection.
                    connection.Open();

                    // Define the SQL query to execute.
                    string query = @"SELECT [dbo].[CalculateRentDaysforAGuest] (@GuestID,@RoomID)";

                    // Create a SqlCommand object to execute the query and associate it with the SqlConnection.
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {

                        command.Parameters.AddWithValue("@GuestID", GuestID);
                        command.Parameters.AddWithValue("@RoomID", RoomID);
                       


                        object result = command.ExecuteScalar();

                        if (result != null && int.TryParse(result.ToString(), out int TotalDays))
                        {
                            RentDays = TotalDays;
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine("Database connection error: " + ex.Message);
            }






            return RentDays;
        }


    }
}
