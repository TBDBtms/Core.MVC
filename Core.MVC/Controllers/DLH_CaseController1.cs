﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.MVC.Controllers
{
    public class DLH_CaseController1 : Controller
    {
        public IActionResult CaseShow()
        {
            return View();
        }
    }
}