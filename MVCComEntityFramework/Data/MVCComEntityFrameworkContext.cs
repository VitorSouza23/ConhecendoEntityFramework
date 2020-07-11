using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MVCComEntityFramework.Models;

namespace MVCComEntityFramework.Data
{
    public class MVCComEntityFrameworkContext : DbContext
    {
        public MVCComEntityFrameworkContext (DbContextOptions<MVCComEntityFrameworkContext> options)
            : base(options)
        {
        }

        public DbSet<Customer> Customer { get; set; }
    }
}
