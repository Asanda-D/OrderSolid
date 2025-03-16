using Microsoft.AspNetCore.Mvc;
using OrderSolid.Interfaces;
using OrderSolid.Models;

namespace OrderSolid.Controllers
{
    public class OrderController : Controller
    {
        private readonly IOrderProcessor _orderProcessor;
        private readonly IOrderRepository _orderRepository;

        public OrderController(IOrderProcessor orderProcessor, IOrderRepository orderRepository)
        {
            _orderProcessor = orderProcessor;
            _orderRepository = orderRepository;
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateOrder(string ProductName, decimal Price)
        {
            if (string.IsNullOrEmpty(ProductName) || Price <= 0)
            {
                ViewBag.Message = "Invalid input! Please enter valid product details.";
                return View("Create");
            }

            var order = new Order { Id = new Random().Next(1, 1000) };
            order.Products.Add(new Product { Id = new Random().Next(1, 1000), Name = ProductName, Price = Price });

            ViewBag.Email = _orderProcessor.ProcessOrder(order);
            ViewBag.Database = _orderRepository.SaveOrder(order);
            ViewBag.Message = "Order for " + ProductName + " has been placed successfully!";
            return View("Create");
        }
    }
}
