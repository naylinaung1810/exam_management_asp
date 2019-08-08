using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Exam_Management_System.Models;
using Microsoft.AspNetCore.Mvc;
using MySql.Data.MySqlClient;

namespace Exam_Management_System.Controllers
{
    public class ResultController : Controller
    {
        public IActionResult Index(int id,int major)
        {
            return View();
        }
        public IActionResult Index2(int id, int major)
        {
            ViewBag.subject = GetSubject(id);
            SystemContext context = HttpContext.RequestServices.GetService(typeof(Exam_Management_System.Models.SystemContext)) as SystemContext;
           
            return View();
        }

        public IActionResult AddMark()
        {
            ViewBag.year = GetYear();
            return View();
        }

        [HttpPost]
        public string PostAddMark(Mark mark)
        {
            int student_id = 0;
            SystemContext context = HttpContext.RequestServices.GetService(typeof(Exam_Management_System.Models.SystemContext)) as SystemContext;
            int academic_id = context.GetAcademic().Id;
            using (MySqlConnection conn1 = context.GetConnection())
            {
                conn1.Open();
                MySqlCommand cmd1 = new MySqlCommand("SELECT * FROM studentrollno where rollno='" + mark.Rollno + "' and academic_id=" + academic_id, conn1);

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
                string sql = $"Insert Into mark_mid (studentrollno_id,mark,subject_id,academic_id) Values ('{student_id}','{mark.S_mark}','{mark.Subject_id}','{academic_id}')";
                using (MySqlCommand command = new MySqlCommand(sql, conn))
                {
                    command.ExecuteNonQuery();
                    conn.Close();
                }
            }
            return "OK";
        }
        public List<Rollno> GetRollNo(int id)
        {
            SystemContext context = HttpContext.RequestServices.GetService(typeof(Exam_Management_System.Models.SystemContext)) as SystemContext;
            int academic_id = context.GetAcademic().Id;
            List<Rollno> list = new List<Rollno>();
            using (MySqlConnection conn = context.GetConnection())
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM student,studentrollno,student_detail where student.id=studentrollno.student_id and studentrollno.id=student_detail.studentrollno_id and student_detail.year_id="+id+" and studentrollno.academic_id="+academic_id, conn);

                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new Rollno()
                        {
                            Id = Convert.ToInt32(reader["id"]),
                            Roll = reader["rollno"].ToString(),
                            Name=reader["student_name"].ToString(),
                        });
                    }
                }
            }
            return list;
        }
        public List<Subject> GetSubject(int id)
        {
            SystemContext context = HttpContext.RequestServices.GetService(typeof(Exam_Management_System.Models.SystemContext)) as SystemContext;
            int academic_id = context.GetAcademic().Id;
            List<Subject> list = new List<Subject>();
            using (MySqlConnection conn = context.GetConnection())
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM subject where year_id=" + id, conn);

                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new Subject()
                        {
                            Id = Convert.ToInt32(reader["id"]),                           
                            Name = reader["subject_name"].ToString(),
                        });
                    }
                }
            }
            return list;
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
    }
}