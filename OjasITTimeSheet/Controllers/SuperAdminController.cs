using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace OjasITTimeSheet.Controllers
{
    public class SuperAdminController : Controller
    {
        

        public IActionResult Dashboard()
        {
            return View();
        }

        public IActionResult CreateUser()
        {
            return View();
        }

        public IActionResult CreateAdmin()
        {
            return View();
        }
        public IActionResult AssignRoles()
        {
            return View();
        }
        public IActionResult AllRoles()
        {
            return View();
        }
        public IActionResult AddProject()
        {
            return View();
        }

        public IActionResult ResetPassword()
        {
            return View();
        }
        public IActionResult ExportAllTimeSheets()
        {
            return View();
        }
        public IActionResult ExportAllExpense()
        {
            return View();
        }
        public IActionResult PushNotification()
        {
            return View();
        }
        
    }
}