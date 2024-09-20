using Microsoft.AspNetCore.Mvc;
using WebApplication4.Models;
using WebApplication4.ViewModels;
using System.Collections.Generic;

namespace WebApplication4.Controllers
{
    public class CustomerOrdersController : Controller
    {
        public IActionResult Index()
        {
            // Örnek müşteri oluşturma
            var customer = new Customer
            {
                Id = 1,
                FirstName = "John",
                LastName = "Doe",
                Email = "john.doe@example.com"
            };

            // Örnek siparişler oluşturma
            var orders = new List<Order>
            {
                new Order { Id = 1, ProductName = "Laptop", Price = 1000.00M, Quantity = 1 },
                new Order { Id = 2, ProductName = "Mouse", Price = 25.99M, Quantity = 2 },
                new Order { Id = 3, ProductName = "Keyboard", Price = 45.50M, Quantity = 1 }
            };

            // CustomerOrderViewModel oluşturma
            var viewModel = new CustomerOrderViewModel
            {
                Customer = customer,
                Orders = orders
            };

            // View'a CustomerOrderViewModel nesnesini iletme
            return View(viewModel);
        }
    }
}
        
    

