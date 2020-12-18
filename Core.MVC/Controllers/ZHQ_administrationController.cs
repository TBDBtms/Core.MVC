using System;
using System.Collections.Generic;
using System.IO;
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
        /// <summary>
        /// 新增药品调价视图
        /// </summary>
        /// <returns></returns>
        public IActionResult AddPricing()
        {
            return View();
        }
        public IActionResult lx()
        {
            return View();
        }
        public IActionResult UpdPrice(int id =0)
        {
            ViewBag.id = id;
            return View();
        }
        public IActionResult TJMingXi()
        {
            return View();
        }
        public IActionResult GetFirstDrug(int id=0)
        {
            ViewBag.id = id;
            return View();
        }
        public class uploadResult
        {
            public string fileName { get; set; }
            public string error { get; set; }
        }
        public JsonResult UploadFile()
        {
            //下面自定义的Model,实例化一下
            uploadResult result = new uploadResult();
            try
            {
                var oFile = Request.Form.Files["txt_file"];
                Stream sm = oFile.OpenReadStream();
                result.fileName = DateTime.Now.ToString("MMddHHmmss") + ".jpg";
                string path = Path.GetFullPath("wwwroot/Image/");
                var fileName = Path.Combine(path, result.fileName);
                if (!Directory.Exists(path))
                {
                    Directory.CreateDirectory(path);
                }
                // string filename = AppContext.BaseDirectory + "/Image/" + DateTime.Now.ToString("yyyymmddhhMMssss") + Guid.NewGuid().ToString() + ".png";
                FileStream fs = new FileStream(fileName, FileMode.Create);
                byte[] buffer = new byte[sm.Length];
                sm.Read(buffer, 0, buffer.Length);
                fs.Write(buffer, 0, buffer.Length);
                fs.Dispose();
            }
            catch (Exception ex)
            {
                result.error = ex.Message;
            }
            return Json(result);

        }
    }
}
