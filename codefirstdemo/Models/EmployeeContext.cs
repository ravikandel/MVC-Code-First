using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace codefirstdemo.Models
{
    public class EmployeeContext : DbContext
    {
        public EmployeeContext()
            : base("myconnection")
        {
        }

        public DbSet<Employee> Employees { get; set; }

    }
}