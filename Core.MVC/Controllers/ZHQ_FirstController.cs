using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Core.MVC.Controllers
{
    public class ZHQ_FirstController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

    }
}
