using OrderSolid.Models;

namespace OrderSolid.Interfaces
{
    public interface IOrderProcessor
    {
        string ProcessOrder(Order order);
    }
}