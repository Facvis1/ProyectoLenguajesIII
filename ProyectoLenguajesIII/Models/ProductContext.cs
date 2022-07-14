using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using ProyectoLenguajesIII.Models;

namespace ProyectoLenguajesIII.Models
{
    public class ProductContext : DbContext
    {
        public ProductContext() : base("ProyectoLenguajesIII")
        {
        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<CartItem> ShoppingCartItems { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
        public DbSet<Cards> Card { get; set; }
    }
}