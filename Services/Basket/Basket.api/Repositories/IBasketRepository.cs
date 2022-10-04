using Basket.api.Entities;

namespace Basket.api.Repositories;

public interface IBasketRepository
{
    Task<ShoppingCart> GetBasket(string userName);
    
    Task<ShoppingCart> UpdateBasket(ShoppingCart basket);
    
    Task DeleteBasket(string userName);
}