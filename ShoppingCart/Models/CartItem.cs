namespace ShoppingCart.Models
{
  public class CartItem
  {
    public int Id { get; set; }
    public int CartId { get; set; }
    public int ItemId { get; set; }
    public int Quantity { get; set; }
    public decimal Price { get; set; }
  }
}
