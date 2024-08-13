using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hi_TechDistributionInc.DAL;

namespace Hi_TechDistributionInc.BLL
{
    public class UserAccount
    {
        public int UserID { get; set; }
        public string Password { get; set; }
        public int EmployeeID { get; set; }

        public void SaveUser(UserAccount ua)
        {
            UserAccountDB.SaveRecord(ua);
        }
        public List<UserAccount> GetAllEmployees()
        {
            return UserAccountDB.GetAllRecords();
        }

    }
}
