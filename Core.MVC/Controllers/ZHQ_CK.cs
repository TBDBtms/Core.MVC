using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Core.MVC.Controllers
{
    public class ZHQ_CK : Controller
    {
        public IActionResult CKSQ(int id)
        {
            ViewBag.id = id;
            return View();
        }
        public IActionResult CKSQJC()
        {
           
            return View();
        }
        public IActionResult CK()
        {
            return View();
        }
        public IActionResult CKJU()
        {
            return View();
        }
        public IActionResult CKTG()
        {
            return View();
        }
    }
}
