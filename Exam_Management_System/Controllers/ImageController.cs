using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Exam_Management_System.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;

namespace Exam_Management_System.Controllers
{
    public class ImageController : Controller
    {
        private readonly IHostingEnvironment hostingEnvironment;
        public ImageController(IHostingEnvironment hostingEnvironment)
        {
            this.hostingEnvironment = hostingEnvironment;
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public string AddImage(TestImg test)
        {
            if(test.Photo!=null)
            {
                string uploadFolder=Path.Combine(hostingEnvironment.WebRootPath, "student_img");
                string img_name=Guid.NewGuid().ToString() + "_" + test.Photo.FileName;
                string filePath = Path.Combine(uploadFolder, img_name);
                test.Photo.CopyTo(new FileStream(filePath, FileMode.Create));

                return filePath;
            }
            return "OK";
        }
    }
}