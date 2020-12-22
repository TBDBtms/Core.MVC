using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Core.MVC.Controllers
{
    public class ZHQ_RK : Controller
    {
        public IActionResult ShowKC()
        {
            return View();
        }
        public IActionResult RKSQJC()
        {
            return View();
        }
        public IActionResult RKSQ(int id)
        {
            ViewBag.id=id;
            return View();
        }
    }
}
