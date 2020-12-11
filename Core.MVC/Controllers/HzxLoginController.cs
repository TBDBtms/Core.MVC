using Core.MVC.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.MVC.Controllers
{
    public class HzxLoginController : Controller
    {
        //public IActionResult Index(string Uname = null, string Qma = null,string Rname=null)
        //{

        //    ViewData["Uname"] = Uname;
        //    ViewData["Qma"] = Qma;
        //    ViewData["Rname"] = Rname;
        //    return View();
        //}

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Login()
        {
            
            return View();
        }
     

    }
}
