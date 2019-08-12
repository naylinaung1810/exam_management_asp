using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Exam_Management_System.Models;
using Microsoft.AspNetCore.Mvc;
using MySql.Data.MySqlClient;

namespace Exam_Management_System.Controllers
{
    public class ExamController : Controller
    {
        public IActionResult Index(int id,int major)
        {

            return View(GetExamDetail(1,id,major));
        }
        public IActionResult Index2(int id,int major)
        {
            return View(GetExamDetail(2,id,major));
        }
        public IActionResult AddExam()
        {
            return View();
        }
        public List<Exam> GetExamDetail(int title,int id,int major)
        {
            SystemContext context = HttpContext.RequestServices.GetService(typeof(Exam_Management_System.Models.SystemContext)) as SystemContext;
            int academic_id = context.GetAcademic().Id;
            List<Exam> list = new List<Exam>();
            using (MySqlConnection conn = context.GetConnection())
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("select * from exam,examtitle,subject,year where exam.examtitle_id=examtitle.id and exam.subject_id=subject.id and exam.year_id=year.id and exam.year_id=" + id+" and exam.academic_id="+academic_id+" and exam.examtitle_id="+title, conn);

                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        ViewBag.year = reader["year_name"].ToString();
                        list.Add(new Exam()
                        {
                            Id = Convert.ToInt32(reader["id"]),
                            Examtile = reader["examtitle_name"].ToString(),
                            Subject = reader["subject_name"].ToString(),
                            Date = reader["date"].ToString(),
                            Start_time = reader["start"].ToString(),
                            End_time = reader["end"].ToString(),
                            Year = reader["year_name"].ToString(),
                        });
                    }
                }
            }
            return list;
        }
        [HttpPost]
        public string PostAddExam(Exam exam)
        {
            SystemContext context = HttpContext.RequestServices.GetService(typeof(Exam_Management_System.Models.SystemContext)) as SystemContext;
            int academic_id = context.GetAcademic().Id;
            using (MySqlConnection conn = context.GetConnection())
            {
                conn.Open();
                string sql = null;
  
                    sql = $"Insert Into exam (examtitle_id,subject_id,year_id,academic_id,start,end,date) Values ('{exam.Exam_id}','{exam.Subject_id}','{exam.Year_id}','{academic_id}','{exam.Start_time}','{exam.End_time}','{exam.Date}')";
                
                using (MySqlCommand command = new MySqlCommand(sql, conn))
                {
                    command.ExecuteNonQuery();
                    conn.Close();
                }
            }
            return "OK";
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
    }
}