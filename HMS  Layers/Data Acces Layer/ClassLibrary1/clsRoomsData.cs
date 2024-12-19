using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class clsRoomsData
    {

        public static int AddNewRoom(int RoomNumber, string RoomType,float Price, bool IsActive,bool IsBooked, string Description) 
        {
            //this function will return the new person id if succeeded and -1 if not.
            int RoomID = -1;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"INSERT INTO Rooms (RoomNumber,RoomType,Description,Price,IsActive,IsBooked)
                             VALUES (@RoomNumber, @RoomType,@Description, @Price, @IsActive,@Booked);
                             SELECT SCOPE_IDENTITY();";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@RoomNumber", RoomNumber);
            command.Parameters.AddWithValue("@RoomType", RoomType);
            command.Parameters.AddWithValue("@Description", Description);
            command.Parameters.AddWithValue("@Price", Price);
            command.Parameters.AddWithValue("@IsActive", IsActive);
            command.Parameters.AddWithValue("@Booked", IsBooked);

            try
            {
                connection.Open();

                object result = command.ExecuteScalar();

                if (result != null && int.TryParse(result.ToString(), out int insertedID))
                {
                    RoomID = insertedID;
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

            return RoomID;
        }

        public static bool GetRoomInfoByID(int RoomID,ref int RoomNumber, ref string RoomType,ref string Description, ref float Price,ref bool IsActive, ref bool IsBooked)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "SELECT * FROM Rooms WHERE RoomID = @RoomID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@RoomID", RoomID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    // The record was found
                    isFound = true;

                    RoomNumber = (int)reader["RoomNumber"];
                    RoomType = (string)reader["RoomType"];
                    Description = (string)reader["Description"];

                    Price = Convert.ToSingle(reader["Price"]);
                    IsActive = (bool)reader["IsActive"];
                    IsBooked = (bool)reader["IsBooked"];
              

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



        public static bool GetRoomPricAndDescreptionByRoomType(string RoomType, ref string Description, ref float Price)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "SELECT * FROM Rooms WHERE RoomType = @RoomType";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@RoomType", RoomType);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    // The record was found
                    isFound = true;

                  
                    Description = (string)reader["Description"];

                    Price = Convert.ToSingle(reader["Price"]);
                


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

        public static bool UpdateRoom(int RoomID, int RoomNumber, string RoomType, float Price, bool IsActive, bool IsBooked, string Description)
        {

            int rowsAffected = 0;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = @"Update  Rooms
                            set
                                RoomNumber=@RoomNumber,
                                RoomType = @RoomType,
                                Description = @Description, 
                                     Price  = @Price,
                                   IsActive = @IsActive,  
                                     Booked = @Booked 
                              
                                where RoomID = @RoomID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@RoomID", RoomID);
            command.Parameters.AddWithValue("@RoomNumber", RoomNumber);
            command.Parameters.AddWithValue("@RoomType", RoomType);
            command.Parameters.AddWithValue("@Description", Description);
            command.Parameters.AddWithValue("@Price", Price);
            command.Parameters.AddWithValue("@IsActive", IsActive);
            command.Parameters.AddWithValue("@Booked", IsBooked);
         
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

        public static bool MakeRoomActive(int RoomID)
        {

            int rowsAffected = 0;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = @"Update  Rooms
                            set
                                   IsActive =1                            
                                where RoomID = @RoomID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@RoomID", RoomID);


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

        public static int IsRoomNumberExists(int RoomNumber)
        {

            //this function will return the new person id if succeeded and -1 if not.
            int RoomNumbers = -1;
          
            string storedProcedureName = "IsRoomNumberExist"; // Replace with your actual stored procedure name

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                connection.Open();

                using (SqlCommand cmd = new SqlCommand(storedProcedureName, connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    // Add any input parameters (if needed)
                    cmd.Parameters.AddWithValue("@RoomNumber", RoomNumber); // Example value

                    // Add a parameter to capture the return value
                    SqlParameter returnValueParam = new SqlParameter("@RETURN_VALUE", SqlDbType.Int);
                    returnValueParam.Direction = ParameterDirection.ReturnValue;
                    cmd.Parameters.Add(returnValueParam);

                    // Execute the stored procedure
                    cmd.ExecuteNonQuery();

                    // Retrieve the return value
                   RoomNumbers = (int)cmd.Parameters["@RETURN_VALUE"].Value;

                    return RoomNumbers;
                }
            }
        }
        public static bool MakeRoomNotActive(int RoomID)
        {

            int rowsAffected = 0;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = @"Update  Rooms
                            set
                                   IsActive =0                             
                                where RoomID = @RoomID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@RoomID", RoomID);


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

        public static bool ResrveARoom(int RoomID,int GuesID,DateTime CheckInDate,DateTime CheckOutDate,double Price)
        {

            int rowsAffected = 0;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = @" exec SP_MakeBooking @RoomID=@RmID, @GuestID=@GstID,@CheckInDate=@CheInDate,@CheckOutDate=@ChOutDate,@TotalPrice=@Price";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@RmID", RoomID);
            command.Parameters.AddWithValue("@GstID", GuesID);
            command.Parameters.AddWithValue("@CheInDate", CheckInDate);
            command.Parameters.AddWithValue("@ChOutDate", CheckOutDate);
            command.Parameters.AddWithValue("@Price",Price);







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

        public static bool CancelBookingRoom(int RoomID)
        {

            int rowsAffected = 0;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = @"Update  Rooms
                            set
                                   IsBooked =0                            
                                where RoomID = @RoomID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@RoomID", RoomID);


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
        public static bool ChangeRoomPrice(int RoomID,float Price)
        {

            int rowsAffected = 0;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = @"Update  Rooms
                            set
                                   Price=@Price                         
                                where RoomID = @RoomID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@RoomID", RoomID);
            command.Parameters.AddWithValue("@Price", Price);



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
        public static DataTable GetAllActiveRooms()
        {

            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"select * from Rooms
                              where IsActive=1";




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

        public static DataTable GetAllActiveAndBookedRooms()
        {

            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"select * from Rooms
                              where IsActive=1 and IsBooked=1";




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
        public static DataTable GetAllActiveAndNotBookedRooms()
        {

            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"select * from Rooms
                              where IsActive=1 and IsBooked=0";




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
        public static DataTable GetAllNotActiveAndNotBookedRooms()
        {

            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"select * from Rooms
                              where IsActive=0 and IsBooked=0";




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

        public static DataTable GetAllNotActiveAndBookedRooms()
        {

            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"select * from Rooms
                              where IsActive=0 and IsBooked=1";




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

        public static DataTable GetAllInactiveRooms()
        {

            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"select * from Rooms
                              where IsActive=0";




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

        public static DataTable GetAllBookedRooms()
        {

            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"select * from Rooms
                            where IsBooked=1";




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

        public static DataTable GetAllNotBookedRooms()
        {

            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"select * from Rooms
                            where IsBooked=0";




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

        public static DataTable GetRoomsTypeByActiveAndBooked(string RoomType,bool IsActive,bool IsBooked)
        {

            //exec  GetRoomsTypeByActiveAndBooked @RoomsType='Standard', @IsActive=0, @IsBooked=0

            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"exec  GetRoomsTypeByActiveAndBooked @RoomsType=@RoomType, @IsActive=@IsActve, @IsBooked=@IsBook";




            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@RoomType", RoomType);
            command.Parameters.AddWithValue("@IsActve", IsActive);
            command.Parameters.AddWithValue("@IsBook", IsBooked);


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


        public static DataTable GetAllRooms()
        {

            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query =@"select * from Rooms";




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
  









    }
}
