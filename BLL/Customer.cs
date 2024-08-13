using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hi_TechDistributionInc.DAL;

namespace Hi_TechDistributionInc.BLL
{
    public class Customer
    {

        public int CustomerId { get; set; }
        public string CustomerName { get; set; }
        public string StreetAddress { get; set; }
        public string City { get; set; }
        public string PostalCode { get; set; }
        public string PhoneNumber { get; set; }
        public string FaxNumber { get; set; }
        public string CreditLimit { get; set; }
        public string Email { get; set; }

        public List<Customer> GetCustomerList()
        {
            return CustomerDB.GetAllRecords();
        }
        public bool IsDuplicateCustId(int custId)
        {
            return CustomerDB.IsDuplicateId(custId);
        }
    }
}
