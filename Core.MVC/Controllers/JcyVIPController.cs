using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.MVC.Controllers
{
    public class JcyVIPController : Controller
    {
        /// <summary>
        /// 会员信息
        /// </summary>
        /// <returns></returns>
        public IActionResult Index()
        {
            return View();
        }
        /// <summary>
        /// 储值管理
        /// </summary>
        /// <returns></returns>
        public IActionResult SValuemage()
        {
            return View();
        }
        public IActionResult ShowCZ(int id)
        {
            ViewBag.id = id;
            return View();
        }
        /// <summary>
        /// 积分管理
        /// </summary>
        /// <returns></returns>
        public IActionResult Pointmanage()
        {
            return View();
        }
        /// <summary>
        /// 会员设置
        /// </summary>
        /// <returns></returns>
        public IActionResult MemberSet()
        {
            return View();
        }
    }
}
