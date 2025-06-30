using BasicMvc;
using BasicMvc.Models;
using Microsoft.AspNetCore.Mvc;

namespace BasicMvc.Controllers
{
    public class CustomerOrdersController : Controller
    {
        public IActionResult Index()
        {
            var customer = new Customer
            {
                Id = 1,
                FirstName = "Ceku",
                LastName = "Barbie",
               Email = "ceku.barbie@outlook.com"


            };
            var orders = new List<Order>
            {
                new Order {Id = 101, ProductName = "Telefon" , Price = 9999 , Quantity = 1 },
                new Order {Id =102, ProductName = "Bilgisayar", Price = 15999, Quantity = 2},
            };
            var viewModel = new CustomerOrderViewModel
            {
                Customer = customer,
                Orders = orders,
            };

         return View(viewModel);

        }

    }
}
