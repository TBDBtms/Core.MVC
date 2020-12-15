using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.MVC.Controllers
{
    public class Zzh_PatientController : Controller
    {
        public IActionResult GetPatient()
        {
            return View();
        }
        public IActionResult AddPatient()
        {
            return View();
        }
        public IActionResult UpdPatient(int pid)
        {
            ViewBag.pid = pid;
            return View();
        }
        public IActionResult GetPatientSource()
        {
            return View();
        }
        public IActionResult GetEducation()
        {
            return View();
        }
        public IActionResult GetPosition()
        {
            return View();
        }
        public IActionResult UpdPatientSource(int id)
        {
            ViewBag.pid = id;
            return View();
        }
        public IActionResult UpdEducation(int id)
        {
            ViewBag.pid = id;
            return View();
        }
        public IActionResult UpdPosition(int id)
        {
            ViewBag.pid = id;
            return View();
        }

    }
}
