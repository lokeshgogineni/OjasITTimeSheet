using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Ojas.TimeSheet.BusinessLayer;
using Ojas.TimeSheet.BusinessModel;

namespace OjasITTimeSheet.Controllers
{
    public class SuperAdminController : Controller
    {
        private IRegistrationBL _businessLayer;

        public SuperAdminController(IRegistrationBL businessLayer)
        {
            _businessLayer = businessLayer;
        }

        public IActionResult Dashboard()
        {
            return View();
        }

        public IActionResult CreateUser()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateUser(UserRegistrationModel model)
        {
            try
            {
                _businessLayer.RegisterUser(model);
                return View(true);
            }
            catch(Exception ex)
            {
                return View(ex);
            }
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