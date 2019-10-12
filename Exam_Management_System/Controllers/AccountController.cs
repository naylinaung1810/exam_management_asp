using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Exam_Management_System.Models;
using MySql.Data.MySqlClient;

namespace Exam_Management_System.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Index()
        {
           
            return View();
        }
        public IActionResult Register()
        {

            return View();
        }
        [HttpPost]
        public string Signup(Account account)
        {
            SystemContext context = HttpContext.RequestServices.GetService(typeof(Exam_Management_System.Models.SystemContext)) as SystemContext;
            using (MySqlConnection conn = context.GetConnection())
            {
                conn.Open();
                string sql = $"Insert Into user (user_name,email,password) Values ('{account.User_Name}','{account.Email}','{account.Password}')";
                using (MySqlCommand command = new MySqlCommand(sql, conn))
                {
                    command.ExecuteNonQuery();
                    conn.Close();
                }
            }
            return "OK";
        }
        [HttpPost]
        public string Login(Account user)
        {
            SystemContext context = HttpContext.RequestServices.GetService(typeof(Exam_Management_System.Models.SystemContext)) as SystemContext;
            using (MySqlConnection conn = context.GetConnection())
            {
                conn.Open();
                string sql = $"SELECT count(*) FROM user where user_name='{user.User_Name}' and password='{user.Password}'";
                using (MySqlCommand command = new MySqlCommand(sql, conn))
                {
                    int count = Convert.ToInt32(command.ExecuteScalar());
                    conn.Close();
                    if (count == 1)
                        return "OK";
                }
            }
            return "NO";
        }

        public IActionResult Logout()
        {
            return Redirect("/account/Index");
        }
    }

}