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

        public DbSet<Customer> Customers { get; set; } = default!;
        public DbSet<Employee> Employees { get; set; } = default!;
        
        public DbSet<Item> Items { get; set; } = default!;

        public DbSet<Order> Orders { get; set; } = default!;
        public DbSet<CollabApi.Model.OrderLine> OrderLine { get; set; } = default!;
    }
}
