using NorthWND_DataAccessLayer.Repository;
using NorthWND_Models.Entities.Concreate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthWND_BusinessLayer.Concreate
{
    public class EmployeeBS
    {
        public Employee LogIn(string uName, string pass)
        {
            var repo = new EmployeeRepository();
            var emp = repo.GetUserNamePassword(uName, pass);
            return emp;
        }


        // GETALL

        public List<Employee> GetAll(params string[] includeList)
        {
            var repo = new EmployeeRepository();
            var listEmployee = repo.GetAllEmployees(includeList);
            return listEmployee;
        }
        public Employee AddEmployee(Employee employee)
        {
            var repo = new EmployeeRepository();
            var employees = repo.Add(employee);
            return employees;
        }

    }
}
