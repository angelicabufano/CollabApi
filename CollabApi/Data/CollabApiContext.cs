using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CollabApi;

namespace CollabApi.Data
{
    public class CollabApiContext : DbContext
    {
        public CollabApiContext (DbContextOptions<CollabApiContext> options)
            : base(options)
        {
        }

        public DbSet<CollabApi.Customer> Customer { get; set; } = default!;
        public DbSet<CollabApi.Employee> Employee { get; set; } = default!;
    }
}
