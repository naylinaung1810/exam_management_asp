using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Exam_Management_System.Models;
using Microsoft.AspNetCore.Mvc;
using MySql.Data.MySqlClient;

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
            return View();
        }
        [HttpPost]
        public string PostAddSubject(Subject subject)
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
            return "Subject is successfully added!";
        }
    }
}