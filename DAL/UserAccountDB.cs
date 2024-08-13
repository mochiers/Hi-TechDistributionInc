using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hi_TechDistributionInc.BLL;
using System.Data.SqlClient;

namespace Hi_TechDistributionInc.DAL
{
    public static class UserAccountDB
    {
        public static void SaveRecord(UserAccount ua)

        {
            SqlConnection conn = UtilityDB.ConnectDB();
            // create and customize an object of type SqlCommand
            SqlCommand cmdInsert = new SqlCommand();
            cmdInsert.Connection = conn;
            cmdInsert.CommandText = "INSERT INTO UsersAccount (UserID, Password, EmployeeID)" +
                                    " VALUES (@UserID,@Password,@EmployeeID)";
            cmdInsert.Parameters.AddWithValue("@UserID", ua.UserID);
            cmdInsert.Parameters.AddWithValue("@Password", ua.Password);
            cmdInsert.Parameters.AddWithValue("@EmployeeID", ua.EmployeeID);
            cmdInsert.ExecuteNonQuery();
            // close the database
            conn.Close();

        }
        public static List<UserAccount> GetAllRecords()
        {
            SqlConnection conn = UtilityDB.ConnectDB();

            List<UserAccount> listUA = new List<UserAccount>();

            try
            {
                SqlCommand cmdSelectAll = new SqlCommand("SELECT * FROM UsersAccount", conn);
                SqlDataReader reader = cmdSelectAll.ExecuteReader();
                UserAccount ua;
                while (reader.Read())
                {
                    ua = new UserAccount();
                    ua.UserID = Convert.ToInt32(reader["UserID"]);
                    ua.Password = reader["Password"].ToString();
                    ua.EmployeeID = Convert.ToInt32(reader["EmployeeID"]);
                    listUA.Add(ua);
                }

            }
            catch (SqlException ex)
            {

                throw ex;
            }

            finally
            {
                conn.Close();
                conn.Dispose();
            }

            return listUA;
        }
    }
}
