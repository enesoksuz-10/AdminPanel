using Microsoft.EntityFrameworkCore;
using NorthWND_DataAccessLayer.Context;
using NorthWND_Models.Entities.Concreate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthWND_DataAccessLayer.Repository
{
    public  class EmployeeRepository
    {
        public List<Employee> GetAllEmployees(params string[] includeList)
        {
            using (NorthwndContext cnt = new NorthwndContext())
            {
                IQueryable<Employee> dbSet = cnt.Employees;
              
                if (includeList != null && includeList.Length > 0)
                {
                    for (int i = 0; i < includeList.Length; i++)
                    {
                        dbSet = dbSet.Include(includeList[i]);
                    }
                }

                var list = dbSet.ToList();
                return list;
            }

        }
        public Employee GetById(int id)
        {
            using (NorthwndContext cnt = new NorthwndContext())
            {
                var emp = cnt.Employees.SingleOrDefault(x => x.EmployeeId == id);
                return emp;
            }

        }


        //public List<Employee> GetByCountry(string country)
        //{
        //    using (NorthwndContext cnt = new NorthwndContext())
        //    {
        //        var list = cnt.Employees.Where(x => x.Country == country).ToList();
        //        return list;
        //    }

        //}
        public Employee GetUserNamePassword(string uName, string pass)
        {
            using (NorthwndContext cnt = new NorthwndContext())
            {
                var emp = cnt.Employees.SingleOrDefault(x => x.UserName == uName && x.Password == pass);
                return emp;
            }

        }
        public Employee Add(Employee employee)
        {
            using (NorthwndContext cnt = new NorthwndContext())
            {
                var emp = cnt.Employees.Add(employee);
                cnt.SaveChanges();
                return emp.Entity;
            }

        }

    }
}
