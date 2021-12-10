using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CCPM.Models;
namespace CCPM.Controllers
{
    public class AccountsController : Controller
    {
        public IActionResult Index()
        {
            List<Account>
    accounts = new List<Account>
        ();
            accounts.Add(new Account
            {
                AccountId = 321564,
                Username = "sieu din thoai o' 🙂",
                Password = "3453431",
                Status = true,
                
            });

            accounts.Add(new Account
            {
                AccountId = 321564,
                Username = "sieu din thoai o' 🙂",
                Password = "3453431",
                Status = true,
            });

            accounts.Add(new Account
            {
                AccountId = 321564,
                Username = "sieu din thoai o' 🙂",
                Password = "3453431",
                Status = true,
            });
  
            return View(accounts);
        }
    }
}

