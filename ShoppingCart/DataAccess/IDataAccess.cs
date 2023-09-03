using ShoppingCart.Models;

namespace ShoppingCart.DataAccess
{
  public interface IDataAccess
  {
    public Task<Cart> CreateCartAsync(string userId);
    public Task<Cart> GetCartAsync(int cartId);
    public Task<Cart> AddItemToCartAsync(int cartId, int itemId, int quantity);
    public Task<Cart> RemoveItemFromCartAsync(int cartId, int itemId);
    public Task<Cart> UpdateItemQuantityAsync(int cartId, int itemId, int quantity);
    public Task<Cart> EmptyCartAsync(int cartId);
    public Task<Cart> DeleteCartAsync(int cartId);
  }
}
