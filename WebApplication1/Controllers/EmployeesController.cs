using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using ClassLibrary1;

namespace WebApplication1.Controllers
{
    public class EmployeesController : ApiController
    {
        public IEnumerable<Employee> Get() 
        {
            using (EmployeeDbEntities Entities = new EmployeeDbEntities())
            {
               return Entities.Employees.ToList();
            } 
        }

        public Employee Get( int Id)
        {
            using (EmployeeDbEntities Entities = new EmployeeDbEntities())
            {
                return Entities.Employees.FirstOrDefault(e => e.ID == Id);
            }
        }
    }
}
