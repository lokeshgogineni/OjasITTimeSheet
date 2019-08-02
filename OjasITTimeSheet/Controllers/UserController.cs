using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace OjasITTimeSheet.Controllers
{
    public class UserController : Controller
    {
        

        public IActionResult UserDashboard()
        {
            return View();
        }

        public IActionResult TimeSheet()
        {
            return View();
        }
        public IActionResult AllTimeSheet()
        {
            return View();
        }
        public IActionResult Expense()
        {
            return View();
        }
        public IActionResult AllExpense()
        {
            return View();
        }
        public IActionResult ChangePassword()
        {
            return View();
        }
    }
}