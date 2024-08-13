using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hi_TechDistributionInc.BLL;
using System.Data.SqlClient;

namespace Hi_TechDistributionInc.DAL
{
    public static class CustomerDB
    {

        public static List<Customer> GetAllRecords()
        {
            List<Customer> listS = new List<Customer>();

            SqlConnection conn = UtilityDB.ConnectDB();
            SqlCommand cmdSelectAll = new SqlCommand("Select * FROM Customers", conn);
            SqlDataReader reader = cmdSelectAll.ExecuteReader();
            Customer aCustomer;
            while (reader.Read())
            {
                aCustomer = new Customer();
                aCustomer.CustomerId = Convert.ToInt32(reader["CustomerID"]);
                aCustomer.CustomerName = reader["CustomerName"].ToString();
                aCustomer.StreetAddress = reader["StreetAddress"].ToString();
                aCustomer.City = reader["City"].ToString();
                aCustomer.PostalCode = reader["PostalCode"].ToString();
                aCustomer.PhoneNumber = reader["PhoneNumber"].ToString();
                aCustomer.FaxNumber = reader["FaxNumber"].ToString();
                aCustomer.CreditLimit = reader["CreditLimit"].ToString();
                aCustomer.Email = reader["Email"].ToString();
                listS.Add(aCustomer);
            }

            return listS;

        }
        public static bool IsDuplicateId(int id)
        {
            if (CustomerDB.SearchRecord(id) != null)
            {
                return true;
            }
            return false;
        }
        public static Customer SearchRecord(int id)
        {
            Customer cust = new Customer();
            //your code here

            // connect the database
            SqlConnection conn = UtilityDB.ConnectDB();

            try
            {
                // create and customize an object of type SqlCommand
                SqlCommand cmdSearchById = new SqlCommand();
                cmdSearchById.Connection = conn;
                cmdSearchById.CommandText = "SELECT * FROM Customers " +
                                            "WHERE CustomerId = @CustomerID";
                cmdSearchById.Parameters.AddWithValue("@CustomerID", id);
                SqlDataReader reader = cmdSearchById.ExecuteReader();
                if (reader.Read())
                {
                    cust.CustomerId = Convert.ToInt32(reader["CustomerID"]);
                    cust.CustomerName = reader["CustomerName"].ToString();
                    cust.StreetAddress = reader["StreetAddress"].ToString();
                    cust.City = reader["City"].ToString();
                    cust.PostalCode = reader["PostalCode"].ToString();
                    cust.PhoneNumber = reader["PhoneNumber"].ToString();
                    cust.FaxNumber = reader["FaxNumber"].ToString();
                    cust.CreditLimit = reader["CreditLimit"].ToString();
                    cust.Email = reader["Email"].ToString();
                }
                else
                {
                    cust = null;
                }

            }
            catch (SqlException ex)
            {

                throw ex;
            }

            finally
            {
                // close the database
                conn.Close();
                conn.Dispose();

            }

            return cust;
        }
    }
}
