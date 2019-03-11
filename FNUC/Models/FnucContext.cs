using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace FNUC.Models
{
    public class FnucContext : DbContext
    {
        public FnucContext() : base("name = fnuc")
        {
            this.Database.CommandTimeout = 180;
        }
        public DbSet<ProductDetail> productDetails { get; set; }
        public DbSet<Categorie> categories { get; set; }
        public DbSet<ShoppingBasket> shoppingBaskets { get; set; }
        public DbSet<ShoppingProduct> shoppingProducts { get; set; }
    }
}