﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Exam_Management_System.Models;
using Microsoft.AspNetCore.Mvc;
using MySql.Data.MySqlClient;

namespace Exam_Management_System.Controllers
{
    public class YearController : Controller
    {
        public IActionResult Index()
        {
            SystemContext context = HttpContext.RequestServices.GetService(typeof(Exam_Management_System.Models.SystemContext)) as SystemContext;
            List<Year> list = new List<Year>();

            using (MySqlConnection conn = context.GetConnection())
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM grade", conn);

                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        int id = Convert.ToInt32(reader["id"]);
                        String name = reader["grade_name"].ToString();
                        list.Add(new Year()
                        {
                            Id = id,
                            Name = name
                        });
                    }
                }
            }
            return View(list);
        }
        public string AddYear(Year year)
        {
            SystemContext context = HttpContext.RequestServices.GetService(typeof(Exam_Management_System.Models.SystemContext)) as SystemContext;
            using (MySqlConnection conn = context.GetConnection())
            {
                conn.Open();
                string sql = $"Insert Into grade (grade_name) Values ('{year.Name}')";
                using (MySqlCommand command = new MySqlCommand(sql, conn))
                {
                    command.ExecuteNonQuery();
                    conn.Close();
                }
            }
            return "Year is successfully added!";
        }
    }
}