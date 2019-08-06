using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Exam_Management_System.Models;
using Microsoft.AspNetCore.Mvc;
using MySql.Data.MySqlClient;

namespace Exam_Management_System.Controllers
{
    public class ClassController : Controller
    {
        public IActionResult Index()
        {
            SystemContext context = HttpContext.RequestServices.GetService(typeof(Exam_Management_System.Models.SystemContext)) as SystemContext;
            List<Class> list = new List<Class>();
            using (MySqlConnection conn = context.GetConnection())
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM class,grade where grade_id=grade.id ", conn);

                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        int id = Convert.ToInt32(reader["id"]);
                        String name = reader["class_name"].ToString();
                        list.Add(new Class()
                        {
                            Id = id,
                            Name = name,
                            Year = reader["grade_name"].ToString(),                          
                        });
                    }
                }
            }
            return View(list);
        }
        [HttpPost]
        public string AddYear(Class classes)
        {
            SystemContext context = HttpContext.RequestServices.GetService(typeof(Exam_Management_System.Models.SystemContext)) as SystemContext;
            using (MySqlConnection conn = context.GetConnection())
            {
                conn.Open();
                string sql = $"Insert Into class (class_name,grade_id) Values ('{classes.Name}','{classes.Year_id}')";
                using (MySqlCommand command = new MySqlCommand(sql, conn))
                {
                    command.ExecuteNonQuery();
                    conn.Close();
                }
            }
            return "New Class is successfully added!";
        }
    }
}