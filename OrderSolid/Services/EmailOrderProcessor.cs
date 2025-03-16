using OrderSolid.Interfaces;
using OrderSolid.Models;

namespace OrderSolid.Services
{
    public class EmailOrderProcessor : IOrderProcessor
    {
        public string ProcessOrder(Order order)
        {
            return $"Email sent for Order ID: {order.Id}";
        }
    }
}
