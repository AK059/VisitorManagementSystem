using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using VisitorManagementSystem.Models;

namespace VisitorManagementSystem.Data
{
    public class VisitorManagementSystemContext : DbContext
    {
        public VisitorManagementSystemContext (DbContextOptions<VisitorManagementSystemContext> options)
            : base(options)
        {
        }

        public DbSet<VisitorManagementSystem.Models.Visitors> Visitors { get; set; }

        public DbSet<VisitorManagementSystem.Models.StaffNames> StaffNames { get; set; }
    }
}
