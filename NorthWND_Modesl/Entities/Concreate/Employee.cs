using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthWND_Models.Entities.Concreate
{
    public class Employee
    {

        public int EmployeeId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Title { get; set; }
        public DateTime? BirthDate { get; set; }
        public DateTime? HireDate { get; set; }
        
        public string? City { get; set; }
        public string? Country { get; set; }
     
        public string? PhotoPath { get; set; }
        public string? UserName { get; set; }
        public string? Password { get; set; }

        public int? ReportsTo { get; set; }
        // 
        public Employee? Manager { get; set; }
        // Alt Çalışanlar
        public List<Employee> SubEmployees { get; set; }
    }
}
