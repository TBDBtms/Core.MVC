using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.MVC.Controllers
{
    public class DLH_CaseController : Controller
    {
        public IActionResult CaseShow()
        {
            return View();
        }

        public IActionResult CaseAdd()
        {
            return View();
        }

        public IActionResult CaseUpdate(int cid)
        {
            ViewBag.cases = cid;
            return View();
        }
    }
}
