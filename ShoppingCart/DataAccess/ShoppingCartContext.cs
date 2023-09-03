﻿using Microsoft.EntityFrameworkCore;
using ShoppingCart.Models;

namespace ShoppingCart.DataAccess
{
  public class ShoppingCartContext : DbContext
  {
    public DbSet<Cart> Cart { get; set; }
    public DbSet<Item> Item { get; set; }
    public DbSet<CartItem> CartItem { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
      optionsBuilder.UseSqlServer(Environment.GetEnvironmentVariable("ConnectionStrings__ShoppingCart"));
    }



  }
}
