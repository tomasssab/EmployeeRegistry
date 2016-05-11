namespace EmployeesRegister.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<EmployeesRegister.DataAccessLayer.EmployeesContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(EmployeesRegister.DataAccessLayer.EmployeesContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            context.Employees.AddOrUpdate(
                p => p.FirstName,
                new Models.Employee { FirstName = "Kalle" ,  LastName = "Anka", Salary = 70000, Position = "Manager",   Department="It",      Company="Acme Inc"},
                new Models.Employee { FirstName = "Lennart", LastName = "Anka", Salary = 70000, Position = "Developer", Department = "Sport", Company = "Acme Inc"},
                new Models.Employee { FirstName = "Kajsa",   LastName = "Anka", Salary = 65000, Position = "Manager",   Department = "Sport", Company = "Acme Inc" }

            );
        }
    }
}
