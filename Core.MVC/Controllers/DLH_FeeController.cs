using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.MVC.Controllers
{
    public class DLH_FeeController : Controller
    {
        #region 新增附加费
        public IActionResult Show()
        {
            return View();
        }
        public IActionResult FJAdd()
        {
            return View();
        }
        public IActionResult FJModify(int cid)
        {
            ViewBag.id = cid;
            return View();
        }
        #endregion


        #region 诊疗费设置
        public IActionResult ZLAdd()
        {
            return View();
        }

        public IActionResult ZLModify(int cid)
        {
            ViewBag.id = cid;
            return View();
        }
        #endregion
    }
}
