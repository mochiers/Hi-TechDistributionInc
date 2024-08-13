using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hi_TechDistributionInc.DAL;
using Hi_TechDistributionInc.BLL;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Hi_TechDistributionInc.DAL
{
    public static class EmployeeDB
    {
        public static bool IsDuplicateId(int id)
        {
            if (EmployeeDB.SearchRecord(id) != null)
            {
                return true;
            }
            return false;
        }
        public static Employee SearchRecord(int id)
        {
            Employee emp = new Employee();
            //your code here

            // connect the database
            SqlConnection conn = UtilityDB.ConnectDB();

            try
            {
                // create and customize an object of type SqlCommand
                SqlCommand cmdSearchById = new SqlCommand();
                cmdSearchById.Connection = conn;
                cmdSearchById.CommandText = "SELECT * FROM Employees " +
                                            "WHERE EmployeeId = @EmployeeId";
                cmdSearchById.Parameters.AddWithValue("@EmployeeId", id);
                SqlDataReader reader = cmdSearchById.ExecuteReader();
                if (reader.Read())
                {
                    emp.EmployeeID = Convert.ToInt32(reader["EmployeeID"]);
                    emp.FirstName = reader["FirstName"].ToString();
                    emp.LastName = reader["LastName"].ToString();
                    emp.PhoneNumber = reader["PhoneNumber"].ToString();
                    emp.Email = reader["Email"].ToString();
                    emp.JobID = Convert.ToInt32(reader["JobID"]);
                    emp.StatusID = Convert.ToInt32(reader["StatusID"]);

                }
                else
                {
                    emp = null;
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

            return emp;
        }
        public static void SaveRecord(Employee emp)

        {
            SqlConnection conn = UtilityDB.ConnectDB();
            // create and customize an object of type SqlCommand
            SqlCommand cmdInsert = new SqlCommand();
            cmdInsert.Connection = conn;
            cmdInsert.CommandText = "INSERT INTO Employees (EmployeeID,FirstName,LastName,PhoneNumber,Email,JobID,StatusID)" +
                                    " VALUES (@EmployeeId,@FirstName,@LastName,@PhoneNumber,@Email,@JobID,@StatusID)";
            cmdInsert.Parameters.AddWithValue("@EmployeeId", emp.EmployeeID);
            cmdInsert.Parameters.AddWithValue("@FirstName", emp.FirstName);
            cmdInsert.Parameters.AddWithValue("@LastName", emp.LastName);
            cmdInsert.Parameters.AddWithValue("@PhoneNumber", emp.PhoneNumber);
            cmdInsert.Parameters.AddWithValue("@Email", emp.Email);
            cmdInsert.Parameters.AddWithValue("@JobID", emp.JobID);
            cmdInsert.Parameters.AddWithValue("@StatusID", emp.StatusID);
            cmdInsert.ExecuteNonQuery();
            // close the database
            conn.Close();



        }
        public static List<Employee> GetAllRecords()
        {
            SqlConnection conn = UtilityDB.ConnectDB();

            List<Employee> listE = new List<Employee>();

            try
            {
                SqlCommand cmdSelectAll = new SqlCommand("SELECT * FROM Employees", conn);
                SqlDataReader reader = cmdSelectAll.ExecuteReader();
                Employee emp;
                while (reader.Read())
                {
                    emp = new Employee();
                    emp.EmployeeID = Convert.ToInt32(reader["EmployeeId"]);
                    emp.FirstName = reader["FirstName"].ToString();
                    emp.LastName = reader["LastName"].ToString();
                    emp.PhoneNumber = reader["PhoneNumber"].ToString();
                    emp.Email = reader["Email"].ToString();
                    emp.JobID = Convert.ToInt32(reader["JobID"]);
                    emp.StatusID = Convert.ToInt32(reader["StatusID"]);
                    listE.Add(emp);
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

            return listE;
        }
        public static List<Employee> SearchRecord(string input, int option)
        {
            // Note option : 1 and 2(Search by firstname/lastName); 3(search by Job Id); 4(search by status id)
            List<Employee> listE = new List<Employee>();
            SqlConnection conn = UtilityDB.ConnectDB();
            if (option == 1)
            {
                try
                {
                    // create and customize an object of type SqlCommand
                    SqlCommand cmdSearchById = new SqlCommand();
                    cmdSearchById.Connection = conn;
                    cmdSearchById.CommandText = "SELECT * FROM Employees " +
                                                "WHERE FirstName = @FirstName";
                    cmdSearchById.Parameters.AddWithValue("@FirstName", input);
                    SqlDataReader reader = cmdSearchById.ExecuteReader();
                    Employee emp;

                    while (reader.Read())
                    {
                        emp = new Employee();
                        emp.EmployeeID = Convert.ToInt32(reader["EmployeeId"]);
                        emp.FirstName = reader["FirstName"].ToString();
                        emp.LastName = reader["LastName"].ToString();
                        emp.PhoneNumber = reader["PhoneNumber"].ToString();
                        emp.Email = reader["Email"].ToString();
                        emp.JobID = Convert.ToInt32(reader["JobID"]);
                        emp.StatusID = Convert.ToInt32(reader["StatusID"]);
                        listE.Add(emp);
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
            }
            else if (option == 2)
            {
                try
                {
                    // create and customize an object of type SqlCommand
                    SqlCommand cmdSearchById = new SqlCommand();
                    cmdSearchById.Connection = conn;
                    cmdSearchById.CommandText = "SELECT * FROM Employees " +
                                                "WHERE LastName = @LastName";
                    cmdSearchById.Parameters.AddWithValue("@LastName", input);
                    SqlDataReader reader = cmdSearchById.ExecuteReader();
                    Employee emp;

                    while (reader.Read())
                    {
                        emp = new Employee();
                        emp.EmployeeID = Convert.ToInt32(reader["EmployeeId"]);
                        emp.FirstName = reader["FirstName"].ToString();
                        emp.LastName = reader["LastName"].ToString();
                        emp.PhoneNumber = reader["PhoneNumber"].ToString();
                        emp.Email = reader["Email"].ToString();
                        emp.JobID = Convert.ToInt32(reader["JobID"]);
                        emp.StatusID = Convert.ToInt32(reader["StatusID"]);
                        listE.Add(emp);
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
            }
            else if (option == 3)
            {
                try
                {
                    // create and customize an object of type SqlCommand
                    SqlCommand cmdSearchById = new SqlCommand();
                    cmdSearchById.Connection = conn;
                    cmdSearchById.CommandText = "SELECT * FROM Employees " +
                                                "WHERE JobID = @JobID";
                    cmdSearchById.Parameters.AddWithValue("@JobID", input);
                    SqlDataReader reader = cmdSearchById.ExecuteReader();
                    Employee emp;

                    while (reader.Read())
                    {
                        emp = new Employee();
                        emp.EmployeeID = Convert.ToInt32(reader["EmployeeId"]);
                        emp.FirstName = reader["FirstName"].ToString();
                        emp.LastName = reader["LastName"].ToString();
                        emp.PhoneNumber = reader["PhoneNumber"].ToString();
                        emp.Email = reader["Email"].ToString();
                        emp.JobID = Convert.ToInt32(reader["JobID"]);
                        emp.StatusID = Convert.ToInt32(reader["StatusID"]);
                        listE.Add(emp);
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
            }
            else if (option == 4)
            {
                try
                {
                    // create and customize an object of type SqlCommand
                    SqlCommand cmdSearchById = new SqlCommand();
                    cmdSearchById.Connection = conn;
                    cmdSearchById.CommandText = "SELECT * FROM Employees " +
                                                "WHERE StatusID = @StatusID";
                    cmdSearchById.Parameters.AddWithValue("@StatusID", input);
                    SqlDataReader reader = cmdSearchById.ExecuteReader();
                    Employee emp;

                    while (reader.Read())
                    {
                        emp = new Employee();
                        emp.EmployeeID = Convert.ToInt32(reader["EmployeeId"]);
                        emp.FirstName = reader["FirstName"].ToString();
                        emp.LastName = reader["LastName"].ToString();
                        emp.PhoneNumber = reader["PhoneNumber"].ToString();
                        emp.Email = reader["Email"].ToString();
                        emp.JobID = Convert.ToInt32(reader["JobID"]);
                        emp.StatusID = Convert.ToInt32(reader["StatusID"]);
                        listE.Add(emp);
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
            }

            return listE;

        }
        
    }
}
