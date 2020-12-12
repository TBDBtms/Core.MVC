using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Core.MVC.Controllers
{
    public class ZHQ_administrationController : Controller
    {
        /// <summary>
        /// 查询所有药品视图
        /// </summary>
        /// <returns></returns>
        public IActionResult Showadministration()
        {
            return View();
        }
        /// <summary>
        /// 新增药品视图
        /// </summary>
        /// <returns></returns>
        public IActionResult Addadministration()
        {
            return View();
        }
    }
}
