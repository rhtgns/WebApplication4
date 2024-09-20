using WebApplication4.Models;
using System.Collections.Generic;

namespace WebApplication4.ViewModels { 

    public class CustomerOrderViewModel
    {
        public Customer Customer { get; set; }    // Müşteri bilgileri
        public List<Order> Orders { get; set; }   // Siparişlerin listesi
    }
}
