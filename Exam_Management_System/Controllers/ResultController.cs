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
            ViewBag.subject = GetSubject(id,major);
            ViewBag.classes = GetClass(id, major);
            ViewBag.year_id = id;
            ViewBag.major_id = major;
           // ViewBag.class_id = class_id;

            return View();
        }
        public IActionResult Index2(int id, int major)
        {
            ViewBag.subject = GetSubject(id,major);
            ViewBag.classes = GetClass(id, major);
            ViewBag.year_id = id;
            ViewBag.major_id = major;
            
            //ViewBag.class_id = class_id;
            return View();
        }

        public IActionResult AddMark()
        {
            ViewBag.year = GetYear();
            return View();
        }

        public JsonResult GetStudentResult(int id)
        {
            List<Mark> list = new List<Mark>();

            SystemContext context = HttpContext.RequestServices.GetService(typeof(Exam_Management_System.Models.SystemContext)) as SystemContext;
            int academic_id = context.GetAcademic().Id;
            using (MySqlConnection conn1 = context.GetConnection())
            {
                conn1.Open();
                MySqlCommand cmd1 = new MySqlCommand("select * from mark_mid,subject,studentrollno,student_detail,student,year,major,class,old_student where old_student.student_id=student.id and student_detail.class_id=class.id and mark_mid.subject_id=subject.id and mark_mid.studentrollno_id=studentrollno.id and student_detail.studentrollno_id=studentrollno.id and studentrollno.student_id=student.id and student_detail.year_id=year.id and student_detail.major_id=major.id and studentrollno.id=" + id + " and mark_mid.academic_id=" + academic_id, conn1);

                using (var reader = cmd1.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new Mark()
                        {
                            Id = Convert.ToInt32(reader["id"]),
                            Rollno = reader["rollno"].ToString(),
                            Name = reader["student_name"].ToString(),
                            S_mark = Convert.ToInt32(reader["mark"]),
                            Year = reader["year_name"].ToString(),
                            Major = reader["major_name"].ToString(),
                            Grade = context.Grade(Convert.ToInt32(reader["mark"])),
                            Rollno_id = Convert.ToInt32(reader["studentrollno_id"]),
                            Subject= reader["subject_name"].ToString(),
                             Phone= reader["phone"].ToString(),
                             Email= reader["email"].ToString(),
                             Address= reader["address"].ToString(),
                            Class = reader["class_name"].ToString(),
                            Img= reader["img"].ToString(),
                        });
                    }
                }
                conn1.Close();
            }
            return Json(list);
        }
        public JsonResult ResultMarkMid(int id,int major,int class_id)
        {
            List<Mark> list = new List<Mark>();
           
            SystemContext context = HttpContext.RequestServices.GetService(typeof(Exam_Management_System.Models.SystemContext)) as SystemContext;
            int academic_id = context.GetAcademic().Id;
            using (MySqlConnection conn1 = context.GetConnection())
            {
                conn1.Open();
                MySqlCommand cmd1 = new MySqlCommand("select * from mark_mid,subject,studentrollno,student_detail,student,year,major,class where student_detail.class_id=class.id and mark_mid.subject_id=subject.id and mark_mid.studentrollno_id=studentrollno.id and student_detail.studentrollno_id=studentrollno.id and studentrollno.student_id=student.id and student_detail.year_id=year.id and student_detail.major_id=major.id and student_detail.major_id=" + major+" and student_detail.year_id="+id+" and mark_mid.academic_id=" + academic_id+" and student_detail.class_id="+class_id, conn1);

                using (var reader = cmd1.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new Mark()
                        {
                            Id = Convert.ToInt32(reader["id"]),
                            Rollno = reader["rollno"].ToString(),
                            Name = reader["student_name"].ToString(),
                            S_mark = Convert.ToInt32(reader["mark"]),
                            Year= reader["year_name"].ToString(),
                            Major= reader["major_name"].ToString(),
                            Grade=context.Grade(Convert.ToInt32(reader["mark"])),
                            Rollno_id = Convert.ToInt32(reader["studentrollno_id"]),
                            Subject = reader["subject_name"].ToString(),
                            Class= reader["class_name"].ToString(),
                             
                            Pass =context.GetPass(Convert.ToInt32(reader["studentrollno_id"]),academic_id,Convert.ToInt32(reader["subject_id"]),Convert.ToInt32(reader["mark"])),
                        });
                    }
                }
                conn1.Close();
            }
            return Json(list);
        }

        public IActionResult PrintMid(int id,int major,int class_id)
        {
            ViewBag.subject = GetSubject(id,major);
            ViewBag.c =GetClassOne(class_id);
            ViewBag.year = GetYearOne(id);
            ViewBag.year_id = id;
            ViewBag.major_id = major;
            ViewBag.class_id = class_id;
            
            return View();
        }
        public IActionResult PrintFinal(int id, int major, int class_id)
        {
            ViewBag.subject = GetSubject(id, major);
            ViewBag.classes = GetClass(id, major);
            ViewBag.c = GetClassOne(class_id);
            ViewBag.year = GetYearOne(id);
            ViewBag.year_id = id;
            ViewBag.major_id = major;
            ViewBag.class_id = class_id;
            return View();
        }
        public JsonResult ResultMarkFinal(int id, int major,int class_id)
        {
            List<Mark> list = new List<Mark>();
            SystemContext context = HttpContext.RequestServices.GetService(typeof(Exam_Management_System.Models.SystemContext)) as SystemContext;
            int academic_id = context.GetAcademic().Id;
            using (MySqlConnection conn1 = context.GetConnection())
            {
                conn1.Open();
                MySqlCommand cmd1 = new MySqlCommand("select * from mark_final,result,subject,studentrollno,student_detail,student,year,major,class where student_detail.class_id=class.id and mark_final.subject_id=subject.id and studentrollno.id=result.studentrollno_id and mark_final.studentrollno_id=studentrollno.id and student_detail.studentrollno_id=studentrollno.id and studentrollno.student_id=student.id and student_detail.year_id=year.id and student_detail.major_id=major.id and student_detail.major_id=" + major+" and student_detail.year_id="+id+" and mark_final.academic_id="+academic_id+" and student_detail.class_id=" + class_id, conn1);

                using (var reader = cmd1.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new Mark()
                        {
                            Id = Convert.ToInt32(reader["id"]),
                            Rollno = reader["rollno"].ToString(),
                            Name = reader["student_name"].ToString(),
                            S_mark = Convert.ToInt32(reader["mark"]),
                            Year = reader["year_name"].ToString(),
                            Major = reader["major_name"].ToString(),
                            Grade = context.Grade(Convert.ToInt32(reader["mark"])),
                            Rollno_id = Convert.ToInt32(reader["studentrollno_id"]),
                            Subject = reader["subject_name"].ToString(),
                            Pass=Convert.ToInt32(reader["pass"]),
                            Class = reader["class_name"].ToString(),
                        });
                    }
                }
                conn1.Close();
            }
            return Json(list);
        }

        [HttpPost]
        public string PostAddMark(Mark mark)
        {
            
            SystemContext context = HttpContext.RequestServices.GetService(typeof(Exam_Management_System.Models.SystemContext)) as SystemContext;
            int academic_id = context.GetAcademic().Id;
            int student_id = context.GetStudentId(mark.Rollno,academic_id);
            using (MySqlConnection conn = context.GetConnection())
            {
                conn.Open();
                string sql = null;
                if (mark.Exam_id==1)
                {
                    sql = $"Insert Into mark_mid (studentrollno_id,mark,subject_id,academic_id) Values ('{student_id}','{mark.S_mark}','{mark.Subject_id}','{academic_id}')";
                    using (MySqlCommand command = new MySqlCommand(sql, conn))
                    {
                        command.ExecuteNonQuery();
                        conn.Close();
                    }
                }
                else
                {
                    
                    sql = $"Insert Into mark_final (studentrollno_id,mark,subject_id,academic_id) Values ('{student_id}','{mark.S_mark}','{mark.Subject_id}','{academic_id}')";
                    using (MySqlCommand command = new MySqlCommand(sql, conn))
                    {
                        command.ExecuteNonQuery();
                        //conn.Close();
                    }
                    int mid_mark = context.GetMid_Mark(student_id, academic_id);
                    int assignment = context.GetAss_Mark(student_id, academic_id);
                    int pass = context.GetPass(student_id, academic_id, mark.Subject_id,mark.S_mark);
                    int final_mark = context.GetFinal_Mark(student_id, academic_id);
                    if (context.CheckResult(student_id,academic_id)==0)
                    {
                        sql = $"Insert Into result (studentrollno_id,mid_mark,final_mark,assigment_mark,pass,academic_id) Values ('{student_id}','{mid_mark}','{final_mark}','{assignment}','{pass}','{academic_id}')";
                    }
                    else
                    {
                        sql = $"UPDATE result SET final_mark={final_mark},pass={pass},attendence_mark={context.tt} where studentrollno_id={student_id} and academic_id={academic_id}";
                    }                    
                    using (MySqlCommand command = new MySqlCommand(sql, conn))
                    {
                        command.ExecuteNonQuery();
                        conn.Close();
                    }
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
        public List<Subject> GetSubject(int id,int major)
        {
            SystemContext context = HttpContext.RequestServices.GetService(typeof(Exam_Management_System.Models.SystemContext)) as SystemContext;
            int academic_id = context.GetAcademic().Id;
            List<Subject> list = new List<Subject>();
            using (MySqlConnection conn = context.GetConnection())
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("select * from subject,subject_major where subject_major.subject_id=subject.id and subject_major.major_id="+major+" and year_id=" + id, conn);

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
        public string GetClassOne(int id)
        {
            SystemContext context = HttpContext.RequestServices.GetService(typeof(Exam_Management_System.Models.SystemContext)) as SystemContext;
            int academic_id = context.GetAcademic().Id;
            string class_name = null;
            using (MySqlConnection conn = context.GetConnection())
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM class where id=" + id , conn);

                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        class_name = reader["class_name"].ToString();
                    }
                }
            }
            return class_name;
        }
        public string GetYearOne(int id)
        {
            SystemContext context = HttpContext.RequestServices.GetService(typeof(Exam_Management_System.Models.SystemContext)) as SystemContext;
            int academic_id = context.GetAcademic().Id;
            string year_name = null;
            using (MySqlConnection conn = context.GetConnection())
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM year where id=" + id, conn);

                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        year_name = reader["year_name"].ToString();
                    }
                }
            }
            return year_name;
        }
    }
}