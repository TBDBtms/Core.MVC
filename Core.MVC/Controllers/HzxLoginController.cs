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

        public IActionResult Index(string Qma="")
        {
            ViewBag.Qma = Qma;
            return View();
        }
        //登录
        public IActionResult Login()
        {
            
            return View();
        }
       //添加员工
        public IActionResult Zhu()
        {

            return View();
        }
        /// <summary>
        /// 显示角色列表
        /// </summary>
        /// <returns></returns>
        public IActionResult Addroleinfo()
        {

            return View();
        }
        /// <summary>
        /// 给角色添加权限
        /// </summary>
        /// <param name="Rid"></param>
        /// <returns></returns>
        public IActionResult AddQuan(int Rid)
        {
            ViewBag.Rid = Rid;
            return View();
        }
        /// <summary>
        /// 修改角色
        /// </summary>
        /// <param name="Uid"></param>
        /// <returns></returns>
        public IActionResult updUser(int Uid=0)
        {
            ViewBag.Uid = Uid;
            return View();
        }
        /// <summary>
        /// 修改密码
        /// </summary>
        /// <param name="Rid"></param>
        /// <returns></returns>
        public IActionResult UpdPass( )
        {
            
            return View();
        }
        /// <summary>
        /// 找回密码
        /// </summary>
        /// <returns></returns>
        public IActionResult zhao(string Uname="")
        {
            ViewBag.Uname = Uname;

            return View();
        }
        /// <summary>
        /// 科室列表
        /// </summary>
        /// <returns></returns>
        public IActionResult keshi()
        {
           

            return View();
        }
        /// <summary>
        /// 添加科室
        /// </summary>
        /// <returns></returns>
        public IActionResult Addkeshi()
        {


            return View();
        }

        /// <summary>
        /// 添加角色
        /// </summary>
        /// <returns></returns>
        public IActionResult AddRole()
        {


            return View();
        }
        /// <summary>
        /// 添加挂号
        /// </summary>
        /// <returns></returns>
        public IActionResult Addguahao()
        {


            return View();
        }
        /// <summary>
        /// 显示所有挂号信息
        /// </summary>
        /// <returns></returns>
        public IActionResult Showgua()
        {


            return View();
        }
        /// <summary>
        /// 修改所有挂号信息
        /// </summary>
        /// <returns></returns>
        public IActionResult Updguahao(int Gid=0)
        {

            ViewBag.Gid = Gid;
            return View();
        }









    }
}
