using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace learn.az.redis.cache.api
{
    public class DatabaseRepository
    {
        private static readonly IEnumerable<Employee> Employees = new List<Employee>()
        {
            new Employee(){Id=1, FirstName="A1", LastName="B1", DateOfBirth= DateTime.Now.AddDays(-20) , Role = Role.Developer},
            new Employee(){Id=2, FirstName="A2", LastName="B2", DateOfBirth= DateTime.Now.AddDays(-30), Role = Role.Developer },
            new Employee(){Id=3, FirstName="A3", LastName="B3", DateOfBirth= DateTime.Now.AddDays(-40) , Role = Role.Developer},
            new Employee(){Id=4, FirstName="A4", LastName="B4", DateOfBirth= DateTime.Now.AddDays(-50) , Role = Role.Director},
            new Employee(){Id=5, FirstName="A5", LastName="B5", DateOfBirth= DateTime.Now.AddDays(-70) , Role = Role.Developer},
            new Employee(){Id=6, FirstName="A6", LastName="B6", DateOfBirth= DateTime.Now.AddDays(-20) , Role = Role.QA},
            new Employee(){Id=7, FirstName="A7", LastName="B7", DateOfBirth= DateTime.Now.AddDays(-30), Role = Role.Developer },
            new Employee(){Id=8, FirstName="A8", LastName="B8", DateOfBirth= DateTime.Now.AddDays(-40) , Role = Role.Developer},
            new Employee(){Id=9, FirstName="A9", LastName="B9", DateOfBirth= DateTime.Now.AddDays(-50) , Role = Role.HR},
            new Employee(){Id=10, FirstName="A10", LastName="B10", DateOfBirth= DateTime.Now.AddDays(-70) , Role = Role.Manager},
            new Employee(){Id=10, FirstName="A11", LastName="B11", DateOfBirth= DateTime.Now.AddDays(-65) , Role = Role.Manager}
        };


        public IEnumerable<Employee> GetAllEmployees()
        {
            // Simulating delay in DB call
            Thread.Sleep(4000);

            return Employees;
        }
    }
}
