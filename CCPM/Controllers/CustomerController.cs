using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CCPM.Models;
namespace CCPM.Controllers
{
    public class CustomersController : Controller
    {
        public IActionResult Index()
        {
            List<Customer>
    customer = new List<Customer>
        ();
            customer.Add(new Customer
            {
                Id = 321564,
                Fullname = "sieu din thoai o' 🙂",
                Email = "3453431",
                Status = true,

            });

            customer.Add(new Customer
            {
                Id = 321564,
                Fullname = "sieu din thoai o' 🙂",
                Email = "3453431",
                Status = true,
            });

            customer.Add(new Customer
            {
                Id = 321564,
                Fullname = "sieu din thoai o' 🙂",
                Email = "3453431",
                Status = true,
            });

            return View(customer);
        }
    }
}


