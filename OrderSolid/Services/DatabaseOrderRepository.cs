using System;
using OrderSolid.Interfaces;
using OrderSolid.Models;

namespace OrderSolid.Services
{
    public class DatabaseOrderRepository : IOrderRepository
    {
        public string SaveOrder(Order order)
        {
            return $"Order ID {order.Id} saved to database.";
        }
    }
}