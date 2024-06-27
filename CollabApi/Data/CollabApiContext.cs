using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CollabApi.Model;

namespace CollabApi.Data
{
    public class CollabApiContext : DbContext
    {
        public CollabApiContext (DbContextOptions<CollabApiContext> options)
            : base(options)
        {
        }

        public DbSet<Customer> Customer { get; set; } = default!;
        public DbSet<Employee> Employee { get; set; } = default!;
    }
}
