﻿namespace ShoppingCart.Models
{
  public class Cart
  {
    public int Id { get; set; }
    public string UserId { get; set; }
    public List<CartItem> Items { get; set; }
    public decimal TotalPrice { get; set; }
  }
}
