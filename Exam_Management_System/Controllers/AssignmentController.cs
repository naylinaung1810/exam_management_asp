using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Exam_Management_System.Models;
using Microsoft.AspNetCore.Mvc;
using MySql.Data.MySqlClient;

namespace Exam_Management_System.Controllers
{
    public class AssignmentController : Controller
    {
        public IActionResult Index(int id,int major)
        {
            ViewBag.subject = GetSubject(id);
            ViewBag.classes = GetClass(id,major);
            ViewBag.year_id = id;
            ViewBag.major_id = major;
            return View();
        }
        public JsonResult GetAssignment(int id,int major,int classes,int subject)
        {
            SystemContext context = HttpContext.RequestServices.GetService(typeof(Exam_Management_System.Models.SystemContext)) as SystemContext;
            int academic_id = context.GetAcademic().Id;
            List<Assignment> list = new List<Assignment>();
            using (MySqlConnection conn = context.GetConnection())
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("select * from assignment,studentrollno,student,subject,student_detail,year,major,class where assignment.studentrollno_id=studentrollno.id and studentrollno.student_id=student.id and assignment.subject_id=subject.id and  student_detail.studentrollno_id=studentrollno.id and student_detail.year_id=year.id and student_detail.major_id=major.id and student_detail.class_id=class.id and student_detail.year_id=" + id+ " and student_detail.major_id="+major+" and assignment.academic_id="+academic_id+ " and student_detail.class_id="+classes+" and assignment.subject_id="+subject, conn);

                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new Assignment()
                        {
                            Id = Convert.ToInt32(reader["id"]),
                            Name = reader["student_name"].ToString(),
                            Rollno=reader["rollno"].ToString(),
                            Subject=reader["subject_name"].ToString(),
                            Mark=Convert.ToInt32(reader["mark"]),
                            Year=reader["year_name"].ToString(),
                            Major=reader["major_name"].ToString(),
                            Class=reader["class_name"].ToString(),
                        });
                    }
                }
            }
            return Json(list);
        }

        public IActionResult AddAssignment()
        {
            return View();
        }
        [HttpPost]
        public void PostAddAssignment(Assignment assignment)
        {
            SystemContext context = HttpContext.RequestServices.GetService(typeof(Exam_Management_System.Models.SystemContext)) as SystemContext;
            int academic_id = context.GetAcademic().Id;
            int student_id = context.GetStudentId(assignment.Rollno, academic_id);
            using (MySqlConnection conn = context.GetConnection())
            {
                conn.Open();
                string sql = $"Insert Into assignment (studentrollno_id,subject_id,mark,academic_id) Values ('{student_id}','{assignment.Subject_id}','{assignment.Mark}','{academic_id}')";
                using (MySqlCommand command = new MySqlCommand(sql, conn))
                {
                    command.ExecuteNonQuery();
                    conn.Close();
                }
            }
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
        public List<Class> GetClass(int id,int major)
        {
            SystemContext context = HttpContext.RequestServices.GetService(typeof(Exam_Management_System.Models.SystemContext)) as SystemContext;
            int academic_id = context.GetAcademic().Id;
            List<Class> list = new List<Class>();
            using (MySqlConnection conn = context.GetConnection())
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM class where year_id=" + id+" and major_id="+major, conn);

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