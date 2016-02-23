using System;
using System.Data.Entity;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ASP.NETTest0001.Models
{
    public class BarContext : DbContext
    {
        public BarContext() : base("ProductTest")
        {
        }

        public DbSet<Product> Products { get; set; }
        public object ProductType { get; internal set; }
        public DbSet<ProductType> ProductTypes { get; set; }
    }
}