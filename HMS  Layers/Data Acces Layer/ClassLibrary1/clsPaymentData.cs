using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class clsPaymentData
    {
        public static int AddNewPaymant(int GuestID, int RoomID,float TotalAmount,
        int PaymentMethod,int UserIDCreatedPayment
      )
        {

            int PaymentID = -1;
            try
            {
                // Create a SqlConnection object with the connection string.
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    // Open the database connection.
                    connection.Open();

                    // Define the SQL query to execute.
                    string query = @"INSERT INTO Payments ( GuestID,RoomID,PaymentDate,TotalAmount,PaymentMethod,UserIDCreatedPayment)
                             VALUES (@GuestID,@RoomID,getdate(),@TotalAmount,@PaymentMethod, @UserIDCreatedPayment);
                             SELECT SCOPE_IDENTITY();";

                    // Create a SqlCommand object to execute the query and associate it with the SqlConnection.
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {

                        command.Parameters.AddWithValue("@GuestID", GuestID);
                        command.Parameters.AddWithValue("@RoomID", RoomID);
                        command.Parameters.AddWithValue("@TotalAmount", TotalAmount);
                        command.Parameters.AddWithValue("@PaymentMethod",PaymentMethod);
                        command.Parameters.AddWithValue("@UserIDCreatedPayment",UserIDCreatedPayment);
                     

                        object result = command.ExecuteScalar();

                        if (result != null && int.TryParse(result.ToString(), out int insertedID))
                        {
                            PaymentID = insertedID;
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine("Database connection error: " + ex.Message);
            }



           
         

            return PaymentID;
        }


        public static bool UpdatePayment(int PaymentID, int GuestID,int RoomID, float TotalAmount,
        int PaymentMethod, int UserIDCreatedPayment)
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
                    string query = @"update Payments 

                                 set
                                GuestID=@GuestID,
                                RoomID=@RoomID,
                                PaymentDate=GETDATE(),
                                TotalAmount=@TotalAmount,
                                PaymentMethod=@PaymentMethod,
                               UserIDCreatedPayment=@UserIDCreatedPayment

                                where PaymentID=@PaymentID";

                    // Create a SqlCommand object to execute the query and associate it with the SqlConnection.
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {

                        command.Parameters.AddWithValue("@GuestID", GuestID);
                        command.Parameters.AddWithValue("@RoomID", RoomID);

                        command.Parameters.AddWithValue("@TotalAmount", TotalAmount);
                        command.Parameters.AddWithValue("@PaymentMethod", PaymentMethod);
                        command.Parameters.AddWithValue("@UserIDCreatedPayment", UserIDCreatedPayment);
                        command.Parameters.AddWithValue("@PaymentID", PaymentID);


                        object result = command.ExecuteScalar();

                        if (result != null && int.TryParse(result.ToString(), out int insertedID))
                        {
                            PaymentID = insertedID;
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine("Database connection error: " + ex.Message);
            }




            return (rowsAffected > 0);
        }



        public static DataTable AllPayments()
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
                    string query = @"select * from Payments";

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

    
    }
}
