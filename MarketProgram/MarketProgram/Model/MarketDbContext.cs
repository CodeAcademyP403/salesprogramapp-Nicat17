using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketProgram.Model
{
    public class MarketDbContext : DbContext
    {
        public MarketDbContext() : base("connect") { }
        
        public DbSet<Buyer> Buyers { get; set; }
        public DbSet<ShopProduct> ShopProducts { get; set; }
        public DbSet<TopSellingStation> TopSellingStations { get; set; }
    }
}
