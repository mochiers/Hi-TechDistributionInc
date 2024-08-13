using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hi_TechDistributionInc.DAL;

namespace Hi_TechDistributionInc.BLL
{
    public class Employee
    {

        public int EmployeeID { get; set; } 
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public int JobID { get; set; }
        public int StatusID { get; set; }
        public void SaveEmployee(Employee emp)
        {
            EmployeeDB.SaveRecord(emp);
        }
        public bool IsDuplicateEmpId(int empId)
        {
            return EmployeeDB.IsDuplicateId(empId);
        }
        public List<Employee> GetAllEmployees()
        {
            return EmployeeDB.GetAllRecords();
        }
        public Employee SearchEmployee(int empId)
        {
            return EmployeeDB.SearchRecord(empId);
        }
        public List<Employee> SearchEmployee(string input, int option)
        {
            return EmployeeDB.SearchRecord(input, option);
        }
    }
}
