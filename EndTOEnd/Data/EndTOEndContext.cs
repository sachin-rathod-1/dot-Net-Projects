using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using EndTOEnd.Models.WebApplication3.Models;

namespace EndTOEnd.Data
{
    public class EndTOEndContext : DbContext
    {
        public EndTOEndContext (DbContextOptions<EndTOEndContext> options)
            : base(options)
        {
        }

        public DbSet<EndTOEnd.Models.WebApplication3.Models.Department> Department { get; set; } = default!;

        public DbSet<EndTOEnd.Models.WebApplication3.Models.Employee> Employee { get; set; }
    }
}
