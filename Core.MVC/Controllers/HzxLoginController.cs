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
        

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Login()
        {
            
            return View();
        }
        public IActionResult Zhu()
        {

            return View();
        }


    }
}
