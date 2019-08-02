using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace OjasITTimeSheet.Controllers
{
    public class AdminController : Controller
    {
        

        public IActionResult AdminDashboard()
        {
            return View();
        }

        public IActionResult AllTimeSheet()
        {
            return View();
        }
        public IActionResult AllExpense()
        {
            return View();
        }
        public IActionResult YourTeam()
        {
            return View();
        }
        public IActionResult TimeSheetExport()
        {
            return View();
        }
        public IActionResult ExpenseReport()
        {
            return View();
        }
    }
}