using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using EmployeeManage.Models;

namespace EmployeeManage.Data
{
    public class EmployeeManageContext : DbContext
    {
        public EmployeeManageContext (DbContextOptions<EmployeeManageContext> options)
            : base(options)
        {
        }

        public DbSet<EmployeeManage.Models.Employee> Employee { get; set; } = default!;
    }
}
