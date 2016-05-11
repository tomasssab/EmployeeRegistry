using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeesRegister.DataAccessLayer
{
    class EmployeesContext : DbContext
    {

        public EmployeesContext() : base("DefaultConnection")
        {
        }

        public DbSet<Models.Employee> Employees { get; set; }
    }
}
