using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.MVC.Controllers
{
    public class DLH_Advice : Controller
    {
        public IActionResult AdviceShow()
        {
            return View();
        }

        public IActionResult AdviceAdd()
        {
            return View();
        }

        public IActionResult AdviceUpdate(int cid)
        {
            ViewBag.cases = cid;
            return View();
        }
    }
}
