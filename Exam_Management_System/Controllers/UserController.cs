using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Exam_Management_System.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using MySql.Data.MySqlClient;

namespace Exam_Management_System.Controllers
{
    public class UserController : Controller
    {
        private readonly IHostingEnvironment hostingEnvironment;
        public UserController(IHostingEnvironment hostingEnvironment)
        {
            this.hostingEnvironment = hostingEnvironment;
        }
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

        [HttpPost]
        public IActionResult PostNewStudent(Student student)
        {
            int student_id = 0;
            string img_name = null;
            if (student.Photo != null)
            {
                string uploadFolder = Path.Combine(hostingEnvironment.WebRootPath, "student_img");
                img_name = Guid.NewGuid().ToString() + "_" + student.Photo.FileName;
                string filePath = Path.Combine(uploadFolder, img_name);
                student.Photo.CopyTo(new FileStream(filePath, FileMode.Create));
            }
            SystemContext context = HttpContext.RequestServices.GetService(typeof(Exam_Management_System.Models.SystemContext)) as SystemContext;
            using (MySqlConnection conn = context.GetConnection())
            {
                conn.Open();
                string sql = $"Insert Into student (student_name,reg_no,reg_date,father_name,father_job,mother_name,mother_job,father_religion,mother_religion,religion,father_nrc,mother_nrc,nrc,gender,city,father_city,mother_city,nationality,father_nationality,mother_nationality,dob,academicyear_id,img) Values ('{student.Name}','{student.Reg_no}','{student.Reg_date}','{student.Father_name}','{student.Father_job}','{student.Mother_name}','{student.Mother_job}','{student.Father_religion}','{student.Mother_religion}','{student.Religion}','{student.Father_nrc}','{student.Mother_nrc}','{student.Nrc}','{student.Sex}','{student.City}','{student.Father_city}','{student.Mother_city}','{student.Nationality}','{student.Father_nationality}','{student.Mother_nationality}','{student.DOB}','{student.Academic_id}','{img_name}')";
                using (MySqlCommand command = new MySqlCommand(sql, conn))
                {
                    command.ExecuteNonQuery();
                    student_id = context.GetLastStudentId();
                }
                string sql1 = $"Insert Into old_student (student_year_id,address,phone,father_phone,mother_phone,email,academic_id,major_id,student_id,mark) Values ('1','{student.Address}','{student.Phone}','{student.Father_phone}','{student.Mother_phone}','{student.Email}','{student.Academic_id}',1,'{student_id}','{student.Mark}')";
                using (MySqlCommand command1 = new MySqlCommand(sql1, conn))
                {
                    command1.ExecuteNonQuery();
                }
            }
            return Redirect("/User/Index");
        }

        [HttpPost]
        public void PostOldStudent(Student student)
        {


            SystemContext context = HttpContext.RequestServices.GetService(typeof(Exam_Management_System.Models.SystemContext)) as SystemContext;
            int academic = context.GetAcademicSecond().Id;
            int student_id = context.GetStudentId(student.Rollno, academic);
            int mark = context.GetMark(student_id);
            using (MySqlConnection conn = context.GetConnection())
            {
                conn.Open();
                string sql1 = $"Insert Into old_student (student_year_id,address,phone,father_phone,mother_phone,email,academic_id,major_id,student_id,mark) Values ('{student.Year_id}','{student.Address}','{student.Phone}','{student.Father_phone}','{student.Mother_phone}','{student.Email}','{student.Academic_id}','{student.Major_id}','{student_id}','{mark}')";
                using (MySqlCommand command1 = new MySqlCommand(sql1, conn))
                {
                    command1.ExecuteNonQuery();
                }
            }
            // return Redirect("/Student/AddOldStudent");
        }
    }
}