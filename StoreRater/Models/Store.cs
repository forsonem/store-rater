using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace StoreRater.Models
{
    public class Store
    {
        public int StoreID { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public int Rating { get; set; }
    }

    public class StoreDbContext : DbContext
    {
        public DbSet<Store> Stores { get; set; }

    }
}