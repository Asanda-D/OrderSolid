using OrderSolid.Models;

namespace OrderSolid.Interfaces
{
    public interface IOrderRepository
    {
        string SaveOrder(Order order);
    }
}
