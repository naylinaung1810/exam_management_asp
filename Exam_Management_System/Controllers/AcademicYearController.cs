using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Exam_Management_System.Models;
using Microsoft.AspNetCore.Mvc;
using MySql.Data.MySqlClient;

namespace Exam_Management_System.Controllers
{
    public class AcademicYearController : Controller
    {
        public IActionResult Index()
        {
            SystemContext context = HttpContext.RequestServices.GetService(typeof(Exam_Management_System.Models.SystemContext)) as SystemContext;
            List<AcademicYear> list = new List<AcademicYear>();

            using (MySqlConnection conn =context.GetConnection())
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM academicyear", conn);

                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        int id = Convert.ToInt32(reader["id"]);
                        String name = reader["academic_name"].ToString();
                        list.Add(new AcademicYear()
                        {
                            Id = id,
                            Name = name
                        });
                    }
                }
            }
            return View(list);
        }
        [HttpPost]
        public IActionResult AddAcademic(AcademicYear academic)
        {
            SystemContext context = HttpContext.RequestServices.GetService(typeof(Exam_Management_System.Models.SystemContext)) as SystemContext;
            using (MySqlConnection conn = context.GetConnection())
            {
                conn.Open();
                string sql = $"Insert Into academicyear (academic_name) Values ('{academic.Name}')";
                using (MySqlCommand command = new MySqlCommand(sql, conn))
                {
                    command.ExecuteNonQuery();
                    conn.Close();
                }
            }
            return Redirect("/academicYear/index");
            // return "OK";
        }
        [HttpPost]
         public IActionResult EditAcademicYear(AcademicYear acy)
         {
            SystemContext context = HttpContext.RequestServices.GetService(typeof(Exam_Management_System.Models.SystemContext)) as SystemContext;
            using (MySqlConnection conn = context.GetConnection())
            {
                conn.Open();
                string sql = $"Update academicyear set academic_name='{acy.Name}' where id={acy.Id}";
                 using (MySqlCommand command = new MySqlCommand(sql, conn))
                {
                    command.ExecuteNonQuery();
                    conn.Close();
                }
            }
            return Redirect("/academicYear/index");
        }
      

        public IActionResult RemoveAcademic(int id)
        {
            SystemContext context = HttpContext.RequestServices.GetService(typeof(Exam_Management_System.Models.SystemContext)) as SystemContext;
            using (MySqlConnection conn = context.GetConnection())
            {
                conn.Open();
                string sql = $"Delete from academicyear where id={id}";
               
                using (MySqlCommand command = new MySqlCommand(sql, conn))
                {
                    command.ExecuteNonQuery();
                    conn.Close();
                }
            }
            return Redirect("/academicYear/index");
        }
    }
}