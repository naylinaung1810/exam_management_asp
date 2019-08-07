using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Exam_Management_System.Models;
//using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MySql.Data.MySqlClient;
using Microsoft.AspNetCore.Session;
using Microsoft.AspNetCore.Http;

namespace Exam_Management_System.Controllers
{
    public class SubjectController : Controller
    {
        public IActionResult Index()
        {
            SystemContext context = HttpContext.RequestServices.GetService(typeof(Exam_Management_System.Models.SystemContext)) as SystemContext;
            List<Subject> list = new List<Subject>();

            using (MySqlConnection conn = context.GetConnection())
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM subject,year,major where subject.year_id=year.id and subject.major_id=major.id", conn);

                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        int id = Convert.ToInt32(reader["id"]);
                        String name = reader["subject_name"].ToString();
                        list.Add(new Subject()
                        {
                            Id = id,
                            Name = name,
                            Year = reader["year_name"].ToString(),
                            Major= reader["major_name"].ToString(),
                        });
                    }
                }
            }
           
            return View(list);
        }
        public IActionResult AddSubject(Subject subject)
        {
            ViewBag.session = HttpContext.Session.GetString("info");
            ViewBag.major = GetMajor();
            ViewBag.year = GetYear();
            return View();
        }
        [HttpPost]
        public IActionResult PostAddSubject(Subject subject)
        {
            SystemContext context = HttpContext.RequestServices.GetService(typeof(Exam_Management_System.Models.SystemContext)) as SystemContext;
            using (MySqlConnection conn = context.GetConnection())
            {
                conn.Open();
                string sql = $"Insert Into subject (subject_name,year_id,major_id) Values ('{subject.Name}','{subject.Year_id}','{subject.Major_id}')";
                using (MySqlCommand command = new MySqlCommand(sql, conn))
                {
                    command.ExecuteNonQuery();
                    conn.Close();
                }
            }
            HttpContext.Session.SetString("info", "add successfully");
           
            ViewBag.data = "haaha";
            return Redirect("/subject/addSubject");
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
        public List<Major> GetMajor()
        {
            SystemContext context = HttpContext.RequestServices.GetService(typeof(Exam_Management_System.Models.SystemContext)) as SystemContext;
            List<Major> list = new List<Major>();
            using (MySqlConnection conn = context.GetConnection())
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM major", conn);

                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        String name = reader["major_name"].ToString();
                        list.Add(new Major()
                        {
                            Id = Convert.ToInt32(reader["id"]),
                            Name = name,
                        });
                    }
                }
            }
            return list;
        }

    }
}