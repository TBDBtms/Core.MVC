using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.MVC.Controllers
{
    public class Zzh_ChargeController : Controller
    {
        /// <summary>
        /// 门诊日志
        /// </summary>
        /// <returns></returns>
        public IActionResult GetCharge()
        {
            return View();
        }
    }
}
