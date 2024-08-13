using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration; 
using System.Data.SqlClient;

namespace Hi_TechDistributionInc.DAL
{
    public static class UtilityDB
    {
        //Connecting to DB ADO CONNECTED MODE
        public static SqlConnection ConnectDB()
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = ConfigurationManager.ConnectionStrings["ConnectHiTechDB"].ConnectionString;
            conn.Open();
            return conn;

        }

    }
}
