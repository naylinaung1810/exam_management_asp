using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Exam_Management_System.Models;
using Microsoft.AspNetCore.Mvc;

namespace Exam_Management_System.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            SystemContext context = HttpContext.RequestServices.GetService(typeof(Exam_Management_System.Models.SystemContext)) as SystemContext;
            ViewBag.academic = context.GetAcademic().Name;
            return View();
        }
        public IActionResult OldForm()
        {
            SystemContext context = HttpContext.RequestServices.GetService(typeof(Exam_Management_System.Models.SystemContext)) as SystemContext;
            ViewBag.academic = context.GetAcademic().Name;
            return View();
        }
        public IActionResult Home()
        {
            SystemContext context = HttpContext.RequestServices.GetService(typeof(Exam_Management_System.Models.SystemContext)) as SystemContext;
            ViewBag.academic = context.GetAcademic().Name;
            return View();
        }
    }
}