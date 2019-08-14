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
    public class StudentController : Controller
    {
        private readonly IHostingEnvironment hostingEnvironment;
        public StudentController(IHostingEnvironment hostingEnvironment)
        {
            this.hostingEnvironment = hostingEnvironment;
        }
        public IActionResult Index(int id,int major)
        {           
            return View(StudentWithYear(id,major));
        }

        public IActionResult AddNewStudent()
        {
            return View();
        }
        public IActionResult AddOldStudent()
        {
            return View();
        }
        public string test(int id,int major_id)
        {
            return id + "/" + major_id;
        }
        public List<Student> StudentWithYear(int id,int major)
        {
            SystemContext context = HttpContext.RequestServices.GetService(typeof(Exam_Management_System.Models.SystemContext)) as SystemContext;
            List<Student> list = new List<Student>();
            using (MySqlConnection conn = context.GetConnection())
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM studentrollno,student,student_detail,class,year,major WHERE student.id=studentrollno.student_id and studentrollno.id=student_detail.studentrollno_id and student_detail.year_id=year.id and student_detail.class_id=class.id and student_detail.year_id="+id+" and student_detail.major_id=major.id and student_detail.major_id=" + major, conn);

                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        ViewData["year"] = reader["year_name"].ToString();
                        ViewData["year_id"] = Convert.ToInt32(reader["year_id"]);
                        int Id = Convert.ToInt32(reader["id"]);
                        String name = reader["student_name"].ToString();
                        list.Add(new Student()
                        {
                            Id = Id,
                            Name = name,
                            Year = reader["year_name"].ToString(),
                            Class_id = Convert.ToInt32(reader["class_id"]),
                            Class = reader["class_name"].ToString(),
                            Year_id = Convert.ToInt32(reader["year_id"]),
                            Major_id = Convert.ToInt32(reader["major_id"]),
                            Major = reader["major_name"].ToString(),
                            Rollno = reader["rollno"].ToString(),

                        });
                    }
                }
            }
            return list;
        }
        [HttpPost("newstudent")]
        public IActionResult PostNewStudent(Student student)
        {
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
                string sql = $"Insert Into student (student_name,reg_no,reg_date,phone,father_name,father_job,father_phone,mother_name,mother_job,mother_phone,father_religion,mother_religion,religion,father_nrc,mother_nrc,nrc,gender,city,father_city,mother_city,nationality,father_nationality,mother_nationality,dob,address,email,academicyear_id,mark,img) Values ('{student.Name}','{student.Reg_no}','{student.Reg_date}','{student.Phone}','{student.Father_name}','{student.Father_job}','{student.Father_phone}','{student.Mother_name}','{student.Mother_job}','{student.Mother_phone}','{student.Father_religion}','{student.Mother_religion}','{student.Religion}','{student.Father_nrc}','{student.Mother_nrc}','{student.Nrc}','{student.Sex}','{student.City}','{student.Father_city}','{student.Mother_city}','{student.Nationality}','{student.Father_nationality}','{student.Mother_nationality}','{student.DOB}','{student.Address}','{student.Email}','{student.Academic_id}','{student.Mark}','{img_name}')";
                using (MySqlCommand command = new MySqlCommand(sql, conn))
                {
                    command.ExecuteNonQuery();
                    conn.Close();
                }
            }
            return Redirect("/Student/AddNewStudent");
        }

        public JsonResult GetAcademic()
        {
            SystemContext context = HttpContext.RequestServices.GetService(typeof(Exam_Management_System.Models.SystemContext)) as SystemContext;
            List<AcademicYear> list = new List<AcademicYear>();
            using (MySqlConnection conn = context.GetConnection())
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM academicyear ", conn);

                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    { 
                        list.Add(new AcademicYear()
                        {
                           Id=Convert.ToInt32(reader["id"]),
                           Name=reader["academic_name"].ToString(),
                        });
                    }
                }
            }
            return Json(list);
        }
    }
}