using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Text;

namespace TesteEntityFramework
{
    public class DataBaseContext : DbContext
    {
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Product> Products { get; set; }
    }
}
