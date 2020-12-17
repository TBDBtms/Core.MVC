using Microsoft.AspNetCore.Mvc;

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
        /// 会员充值
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet]
        public IActionResult VIPCZ(int id)
        {
            ViewBag.id = id;
            return View();
        }
        /// <summary>
        /// 会员等级设置
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet]
        public IActionResult VIPDJ(int id)
        {
            ViewBag.id = id;
            return View();
        }
        /// <summary>
        /// 会员积分变动
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public IActionResult VIPBD(int id)
        {
            ViewBag.id = id;
            return View();
        }
        /// <summary>
        /// 会员退款
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public IActionResult VIPTK(int id)
        {
            ViewBag.id = id;
            return View();
        }
        /// <summary>
        /// 设置会员等级
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet]
        public IActionResult SetVIP(int id)
        {
            ViewBag.id = id;
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
        /// <summary>
        /// 储值-充值
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public IActionResult ShowCZ(int id)
        {
            ViewBag.id = id;
            return View();
        }
        /// <summary>
        /// 退款
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public IActionResult ShowTK(int id)
        {
            ViewBag.id = id;
            return View();
        }
        /// <summary>
        /// 记录
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public IActionResult ShowJL(int id)
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
        /// 积分变动
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public IActionResult PoinBD(int id)
        {
            ViewBag.id = id;
            return View();
        }
        /// <summary>
        /// 变更记录
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public IActionResult PoinJL(int id)
        {
            ViewBag.id = id;
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
        /// <summary>
        /// 添加会员类型
        /// </summary>
        /// <returns></returns>
        public IActionResult VIPSet()
        {
            return View();
        }
        /// <summary>
        /// 编辑
        /// </summary>
        /// <returns></returns>
        public IActionResult VIPUpds()
        {
            return View();
        }
        /// <summary>
        /// 会员条件设置
        /// </summary>
        /// <returns></returns>
        public IActionResult AddVIPType()
        {
            return View();
        }
    }
}
