using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.MVC.Controllers
{
    public class DLH_FeeController : Controller
    {
        
        public IActionResult Show()
        {
            return View();
        }
        #region 新增附加费
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
            ViewBag.ZLId = cid;
            return View();
        }
        #endregion

        #region 挂号费设置
        public IActionResult GHAdd()
        {
            return View();
        }

        public IActionResult GHModify(int cid)
        {
            ViewBag.GHId = cid;
            return View();
        }
        #endregion
    }
}
