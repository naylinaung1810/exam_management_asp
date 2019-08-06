using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Exam_Management_System.Models;
using Microsoft.AspNetCore.Mvc;
using MySql.Data.MySqlClient;

namespace Exam_Management_System.Controllers
{
    public class StudentController : Controller
    {
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
        public string PostNewStudent()
        {
            return "OK";
        }
    }
}