﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Core.MVC.Controllers
{
    public class MBYController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
