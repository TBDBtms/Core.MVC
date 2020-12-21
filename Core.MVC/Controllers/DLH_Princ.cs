using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.MVC.Controllers
{
    public class DLH_Princ : Controller
    {
        public IActionResult PrincShow()
        {
            return View();
        }
    }
}
