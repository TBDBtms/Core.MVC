using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace Core.MVC.Controllers
{
    public class JcyGYSController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult FindbyId(int id=0)
        {
            ViewBag.id = id;
            return View();
        }
        public IActionResult Add()
        {
            return View();
        }
    }
}
