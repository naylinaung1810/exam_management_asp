using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Exam_Management_System.Models;
using Microsoft.AspNetCore.Mvc;
using MySql.Data.MySqlClient;

namespace Exam_Management_System.Controllers
{
    public class AttendenceController : Controller
    {
        public IActionResult Index(int id,int major,int class_id)
        {
            ViewBag.classes = GetClass(id, major);
            ViewBag.year_id = id;
            ViewBag.major_id = major;
            ViewBag.class_id = class_id;
           
            return View();
        }
        public IActionResult Print(int id,int major,int class_id)
        {
            ViewBag.year_id = id;
            ViewBag.major_id = major;
            ViewBag.class_id = class_id;
            return View();
        }
        public JsonResult GetAttendence(int id,int major,int class_id)
        {
            SystemContext context = HttpContext.RequestServices.GetService(typeof(Exam_Management_System.Models.SystemContext)) as SystemContext;
            List<Attendence> list = new List<Attendence>();
            using (MySqlConnection conn = context.GetConnection())
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("SELECT sum(total),sum(current),rollno,student_name,major_name,year_name,class_name,attendance.id FROM student,studentrollno,student_detail,major,class,year,attendance where student.id=studentrollno.student_id and studentrollno.id=student_detail.studentrollno_id and student_detail.year_id=year.id and student_detail.major_id=major.id and student_detail.class_id=class.id and studentrollno.id=attendance.studentrollno_id and student_detail.year_id=" + id + " and student_detail.major_id=" + major + " and student_detail.class_id=" + class_id+ " group by studentrollno.id", conn);

                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        ViewBag.year = reader["year_name"].ToString();
                        ViewBag.major = reader["major_name"].ToString();
                        list.Add(new Attendence()
                        {
                            Id = Convert.ToInt32(reader["id"]),
                            Name = reader["student_name"].ToString(),
                            Rollno = reader["rollno"].ToString(),
                            Current = Convert.ToInt32(reader["sum(current)"]),
                            Total = Convert.ToInt32(reader["sum(total)"]),
                           // Month = reader["month"].ToString(),
                            Major = reader["major_name"].ToString(),
                            Year = reader["year_name"].ToString(),
                            Class = reader["class_name"].ToString(),
                        });
                    }
                }
            }
            return Json(list);
        }
        public IActionResult AddAttendence()
        {
            ViewBag.year = GetYear();
            ViewBag.rollno = GetRollNo();
            return View();
        }

        [HttpPost]
        public void PostAddAttendence(Attendence attendence)
        {
            int student_id = 0;
            SystemContext context = HttpContext.RequestServices.GetService(typeof(Exam_Management_System.Models.SystemContext)) as SystemContext;
            int academic_id = context.GetAcademic().Id;
            using (MySqlConnection conn1 = context.GetConnection())
            {
                conn1.Open();
                MySqlCommand cmd1 = new MySqlCommand("SELECT * FROM studentrollno where rollno='"+attendence.Rollno+"' and academic_id="+academic_id, conn1);

                using (var reader = cmd1.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        student_id = Convert.ToInt32(reader["id"]);                      
                    }
                }
                conn1.Close();
            }
            using (MySqlConnection conn = context.GetConnection())
            {
                conn.Open();
                string sql = $"Insert Into attendance (studentrollno_id,month,total,current,academic_id) Values ('{student_id}','{attendence.Month}','{attendence.Total}','{attendence.Current}','{academic_id}')";
                using (MySqlCommand command = new MySqlCommand(sql, conn))
                {
                    command.ExecuteNonQuery();
                    conn.Close();
                }
            }
            //return Redirect("/attendence/addAttendence");
        }

      
        public List<Year> GetYear()
        {
            SystemContext context = HttpContext.RequestServices.GetService(typeof(Exam_Management_System.Models.SystemContext)) as SystemContext;
            List<Year> list = new List<Year>();
            using (MySqlConnection conn = context.GetConnection())
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM year ", conn);

                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        int id = Convert.ToInt32(reader["id"]);
                        String name = reader["year_name"].ToString();
                        list.Add(new Year()
                        {
                            Id = id,
                            Name = name,

                        });
                    }
                }
            }
            return list;
        }
        public List<Rollno> GetRollNo()
        {
            SystemContext context = HttpContext.RequestServices.GetService(typeof(Exam_Management_System.Models.SystemContext)) as SystemContext;
            int academic_id = context.GetAcademic().Id;
            List<Rollno> list = new List<Rollno>();
            using (MySqlConnection conn = context.GetConnection())
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM studentrollno where academic_id="+academic_id, conn);

                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new Rollno()
                        {
                            Id = Convert.ToInt32(reader["id"]),
                            Roll = reader["rollno"].ToString(),
                        });
                    }
                }
            }
            return list;
        }
        public List<Class> GetClass(int id, int major)
        {
            SystemContext context = HttpContext.RequestServices.GetService(typeof(Exam_Management_System.Models.SystemContext)) as SystemContext;
            int academic_id = context.GetAcademic().Id;
            List<Class> list = new List<Class>();
            using (MySqlConnection conn = context.GetConnection())
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM class where year_id=" + id + " and major_id=" + major, conn);

                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new Class()
                        {
                            Id = Convert.ToInt32(reader["id"]),
                            Name = reader["class_name"].ToString(),
                        });
                    }
                }
            }
            return list;
        }
    }
}