using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Exam_Management_System.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using MySql.Data.MySqlClient;

namespace Exam_Management_System.Controllers
{
    public class StudentController : Controller
    {
        private readonly IHostingEnvironment hostingEnvironment;
        public StudentController(IHostingEnvironment hostingEnvironment)
        {
            this.hostingEnvironment = hostingEnvironment;
        }
        public IActionResult Index(int id,int major,int class_id)
        {
            ViewBag.classes = GetClass(id, major);
            ViewBag.year_id = id;
            ViewBag.major_id = major;
            return View();
        }

        public IActionResult AddNewStudent()
        {
            return View();
        }
        public IActionResult AddOldStudent()
        {

            return View();
        }
        public IActionResult GenerateRollno()
        {
           
            SystemContext context = HttpContext.RequestServices.GetService(typeof(Exam_Management_System.Models.SystemContext)) as SystemContext;
            int academic = context.GetAcademic().Id;
            List<Student> list = new List<Student>();
            using (MySqlConnection conn = context.GetConnection())
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("select * from student,old_student,year where old_student.student_id=student.id and old_student.student_year_id=year.id and old_student.academic_id=" + academic, conn);

                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        int Id = Convert.ToInt32(reader["id"]);
                        String name = reader["student_name"].ToString();
                        list.Add(new Student()
                        {
                            Id = Id,
                            Name = name,
                            
                            Year = reader["year_name"].ToString(),
                            Sex = reader["gender"].ToString(),
                            Father_name = reader["father_name"].ToString(),
                            Mother_name = reader["mother_name"].ToString(),
                            Phone = reader["phone"].ToString(),
                           Address = reader["address"].ToString(),
                           Mark = Convert.ToInt32(reader["mark"])
                        });
                    }
                }
            }
            return View(list);
        }

        public Student GetOneStudent(int id)
        {
            SystemContext context = HttpContext.RequestServices.GetService(typeof(Exam_Management_System.Models.SystemContext)) as SystemContext;
            Student student = new Student();
            using (MySqlConnection conn = context.GetConnection())
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("select * from student,old_student,studentrollno,attendance where attendance.studentrollno_id=studentrollno.id and old_student.student_id=student.id and studentrollno.student_id=student.id and studentrollno.id=" + id, conn);

                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        ;
                        int Id = Convert.ToInt32(reader["id"]);
                        String name = reader["student_name"].ToString();

                        student.Id = Id;
                        student.Name = name;
                        student.Rollno= reader["rollno"].ToString();
                        student.Phone = reader["phone"].ToString();
                        student.Address = reader["address"].ToString();
                        student.Email = reader["email"].ToString();
                        student.Total= Convert.ToInt32(reader["total"]);
                        student.Current = Convert.ToInt32(reader["current"]);

                    }
                }
            }
            return student;
        }
        public IActionResult EditStudent(int id)
        {
            SystemContext context = HttpContext.RequestServices.GetService(typeof(Exam_Management_System.Models.SystemContext)) as SystemContext;
            Student student = new Student();
            using (MySqlConnection conn = context.GetConnection())
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("select * from student,old_student,studentrollno where old_student.student_id=student.id and studentrollno.student_id=student.id and studentrollno.id=" + id, conn);

                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        
                        int Id = Convert.ToInt32(reader["id"]);
                        String name = reader["student_name"].ToString();

                        student.Id = Id;
                        student.Name = name;
                        student.Sex = reader["gender"].ToString();
                        student.Reg_date = reader["reg_date"].ToString();
                        student.Reg_no = reader["reg_no"].ToString();
                        student.Father_name = reader["father_name"].ToString();
                        student.Father_job = reader["father_job"].ToString();
                        student.Father_city = reader["father_city"].ToString();
                        student.Father_nationality = reader["father_nationality"].ToString();
                        student.Father_nrc = reader["father_nrc"].ToString();
                        student.Father_phone = reader["father_phone"].ToString();
                        student.Father_religion = reader["father_religion"].ToString();
                        student.Mother_city = reader["mother_city"].ToString();
                        student.Mother_job = reader["mother_job"].ToString();
                        student.Mother_name = reader["mother_name"].ToString();
                        student.Mother_nationality = reader["mother_nationality"].ToString();
                        student.Mother_nrc = reader["mother_nrc"].ToString();
                        student.Mother_phone = reader["mother_phone"].ToString();
                        student.Mother_religion = reader["mother_religion"].ToString();
                        student.Religion = reader["religion"].ToString();
                        student.Phone = reader["phone"].ToString();
                        student.Address = reader["address"].ToString();
                        student.City = reader["city"].ToString();
                        student.DOB = reader["dob"].ToString();
                        student.Email = reader["email"].ToString();
                        student.Nationality = reader["nationality"].ToString();
                        student.Nrc = reader["nrc"].ToString();
                        student.Mark = Convert.ToInt32(reader["mark"]);

                    }
                }
            }
            ViewBag.student = student;
            return View();
        }
        [HttpPost]
        public IActionResult PostEditStudent(Student student)
        {
            SystemContext context = HttpContext.RequestServices.GetService(typeof(Exam_Management_System.Models.SystemContext)) as SystemContext;
            
            using (MySqlConnection conn = context.GetConnection())
            {
                conn.Open();
                string sql = $"UPDATE student SET student_name={student.Name},gender={student.Sex},reg_date={student.Reg_date},father_name={student.Father_name},father_job={student.Father_job},father_nrc={student.Father_nrc},father_city={student.Father_city},father_phone={student.Father_phone},father_religion={student.Father_religion},father_nationality={student.Father_nationality},mother_name={student.Mother_name},mother_job={student.Mother_job},mother_nrc={student.Mother_nrc},mother_city={student.Mother_city},mother_phone={student.Mother_phone},mother_religion={student.Mother_religion},mother_nationality={student.Mother_nationality},religion={student.Religion},nationality={student.Nationality} where student.id={student.Id}";
                using (MySqlCommand command1 = new MySqlCommand(sql, conn))
                {
                    command1.ExecuteNonQuery();
                }
            }
            return Redirect("/Student/Index");
        }

        public void Generate()
        { 
            SystemContext context = HttpContext.RequestServices.GetService(typeof(Exam_Management_System.Models.SystemContext)) as SystemContext;
            int academic = context.GetAcademic().Id;
            List<Year> years = new List<Year>();
            List<Student> list = new List<Student>();
            List<Student> oldstudent = new List<Student>();
            int roll = 1;
            int roll2 = 1;int ct_roll2 = 1;
            int roll3 = 1; int ct_roll3 = 1;
            int roll4 = 1; int ct_roll4 = 1;
            int roll5 = 1; int ct_roll5 = 1;
            using (MySqlConnection conn = context.GetConnection())
            {
                conn.Open();
                MySqlCommand cmd1 = new MySqlCommand("select * from year", conn);

                using (var reader = cmd1.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        years.Add(new Year()
                        {
                            Id = Convert.ToInt32(reader["id"]),                            
                            Name = reader["year_name"].ToString(),
                        });
                    }
                }
                foreach(var year in years)
                {
                    list.Clear();
                    MySqlCommand cmd = new MySqlCommand("select * from old_student where academic_id=" + academic + " and student_year_id="+year.Id+" order by mark desc ", conn);

                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            list.Add(new Student()
                            {
                                Id = Convert.ToInt32(reader["id"]),
                                Student_id = Convert.ToInt32(reader["student_id"]),
                                //Name = reader["student_name"].ToString(),
                                Year_id = Convert.ToInt32(reader["student_year_id"]),
                                Major_id = Convert.ToInt32(reader["major_id"])
                            });
                        }
                    }
                    foreach (var student in list)
                    {
                        int studentrollno_id = 0;
                        int class_id = 0;
                        string rollno1 = null;
                       
                            if (student.Year_id == 1)
                            {
                                rollno1 = "1CST-" + roll;
                            class_id = context.GetClassStudent(student.Year_id, student.Major_id, roll);
                                roll++;
                               
                            }
                            else if (student.Year_id == 2)
                            {
                            if(student.Major_id==2)
                            {
                                rollno1 = "2CS-" + roll2;
                                class_id = context.GetClassStudent(student.Year_id, student.Major_id, roll2);
                                roll2++;
                            }
                            else
                            {
                                rollno1 = "2CT-" + ct_roll2;
                                class_id = context.GetClassStudent(student.Year_id, student.Major_id, roll2);
                                ct_roll2++;
                                
                            }                                                          
                            }
                            else if (student.Year_id == 3)
                            {
                            if (student.Major_id == 2)
                            {
                                rollno1 = "3CS-" + roll3;
                                class_id = context.GetClassStudent(student.Year_id, student.Major_id, roll3);
                                roll3++;
                            }
                            else
                            {
                                rollno1 = "3CT-" + ct_roll3;
                                class_id = context.GetClassStudent(student.Year_id, student.Major_id, roll3);
                                ct_roll3++;
                            }
                        }
                            else if (student.Year_id == 4)
                            {
                            if (student.Major_id == 2)
                            {
                                rollno1 = "4CS-" + roll4;
                                class_id = context.GetClassStudent(student.Year_id, student.Major_id, roll4);
                                roll4++;
                            }
                            else
                            {
                                rollno1 = "4CT-" + ct_roll4;
                                class_id = context.GetClassStudent(student.Year_id, student.Major_id, roll4);
                                ct_roll4++;
                            }
                        }else
                        {
                            if (student.Major_id == 2)
                            {
                                rollno1 = "5CS-" + roll5;
                                class_id = context.GetClassStudent(student.Year_id, student.Major_id, roll5);
                                roll5++;
                            }
                            else
                            {
                                rollno1 = "5CT-" + ct_roll5;
                                class_id = context.GetClassStudent(student.Year_id, student.Major_id, roll5);
                                ct_roll5++;
                            }
                        }
                        
                       
                        string sql = $"Insert Into studentrollno (student_id,academic_id,rollno) Values ('{student.Student_id}','{academic}','{rollno1}')";

                        using (MySqlCommand command = new MySqlCommand(sql, conn))
                        {
                            command.ExecuteNonQuery();
                            studentrollno_id = context.GetlastId();
                        }
                        string sql1 = $"Insert Into student_detail (studentrollno_id,year_id,major_id,class_id,academic_id) Values ('{studentrollno_id}','{student.Year_id}','{student.Year_id}','{class_id}','{academic}')";
                        using (MySqlCommand command1 = new MySqlCommand(sql1, conn))
                        {
                            command1.ExecuteNonQuery();
                        }
                    }
                }
               //////////////////////////////////////////////////////////////////////////////////////              

            }
        }
        public JsonResult GetStudent(int id,int major,int class_id)
        {
            SystemContext context = HttpContext.RequestServices.GetService(typeof(Exam_Management_System.Models.SystemContext)) as SystemContext;
            List<Student> list = new List<Student>();
            int academic = context.GetAcademic().Id;
            using (MySqlConnection conn = context.GetConnection())
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM studentrollno,student,student_detail,class,year,major WHERE student.id=studentrollno.student_id and studentrollno.id=student_detail.studentrollno_id and student_detail.year_id=year.id and student_detail.class_id=class.id and student_detail.year_id="+id+" and student_detail.major_id=major.id and student_detail.major_id=" + major+" and student_detail.class_id="+class_id+" and student_detail.academic_id="+academic, conn);

                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        ViewData["year"] = reader["year_name"].ToString();
                        ViewData["year_id"] = Convert.ToInt32(reader["year_id"]);
                        int Id = Convert.ToInt32(reader["id"]);
                        String name = reader["student_name"].ToString();
                        list.Add(new Student()
                        {
                            Id = Id,
                            Name = name,
                            Year = reader["year_name"].ToString(),
                            Class_id = Convert.ToInt32(reader["class_id"]),
                            Class = reader["class_name"].ToString(),
                            Year_id = Convert.ToInt32(reader["year_id"]),
                            Major_id = Convert.ToInt32(reader["major_id"]),
                            Major = reader["major_name"].ToString(),
                            Rollno = reader["rollno"].ToString(),

                        });
                    }
                }
            }
            return Json(list);
        }
        [HttpPost("newstudent")]
        public IActionResult PostNewStudent(Student student)
        {
            int student_id = 0;
            string img_name = null;
            if (student.Photo != null)
            {
                string uploadFolder = Path.Combine(hostingEnvironment.WebRootPath, "student_img");
                img_name = Guid.NewGuid().ToString() + "_" + student.Photo.FileName;
                string filePath = Path.Combine(uploadFolder, img_name);
                student.Photo.CopyTo(new FileStream(filePath, FileMode.Create));
            }
            SystemContext context = HttpContext.RequestServices.GetService(typeof(Exam_Management_System.Models.SystemContext)) as SystemContext;
            using (MySqlConnection conn = context.GetConnection())
            {
                conn.Open();
                string sql = $"Insert Into student (student_name,reg_no,reg_date,father_name,father_job,mother_name,mother_job,father_religion,mother_religion,religion,father_nrc,mother_nrc,nrc,gender,city,father_city,mother_city,nationality,father_nationality,mother_nationality,dob,academicyear_id,img) Values ('{student.Name}','{student.Reg_no}','{student.Reg_date}','{student.Father_name}','{student.Father_job}','{student.Mother_name}','{student.Mother_job}','{student.Father_religion}','{student.Mother_religion}','{student.Religion}','{student.Father_nrc}','{student.Mother_nrc}','{student.Nrc}','{student.Sex}','{student.City}','{student.Father_city}','{student.Mother_city}','{student.Nationality}','{student.Father_nationality}','{student.Mother_nationality}','{student.DOB}','{student.Academic_id}','{img_name}')";
                using (MySqlCommand command = new MySqlCommand(sql, conn))
                {
                    command.ExecuteNonQuery();
                    student_id = context.GetLastStudentId();
                }
                string sql1 = $"Insert Into old_student (student_year_id,address,phone,father_phone,mother_phone,email,academic_id,major_id,student_id,mark) Values ('1','{student.Address}','{student.Phone}','{student.Father_phone}','{student.Mother_phone}','{student.Email}','{student.Academic_id}',1,'{student_id}','{student.Mark}')";
                using (MySqlCommand command1 = new MySqlCommand(sql1, conn))
                {
                    command1.ExecuteNonQuery();
                }
            }
            return Redirect("/Student/AddNewStudent");
        }

        [HttpPost]
        public IActionResult PostOldStudent(Student student)
        {
            int student_id = student.Student_id;
            
            SystemContext context = HttpContext.RequestServices.GetService(typeof(Exam_Management_System.Models.SystemContext)) as SystemContext;
            int mark = context.GetMark(student_id);
            using (MySqlConnection conn = context.GetConnection())
            {
                conn.Open();              
                string sql1 = $"Insert Into old_student (student_year_id,address,phone,father_phone,mother_phone,email,academic_id,major_id,student_id,mark) Values ('{student.Year_id}','{student.Address}','{student.Phone}','{student.Father_phone}','{student.Mother_phone}','{student.Email}','{student.Academic_id}','{student.Major_id}','{student_id}','{mark}')";
                using (MySqlCommand command1 = new MySqlCommand(sql1, conn))
                {
                    command1.ExecuteNonQuery();
                }
            }
            return Redirect("/Student/AddOldStudent");
        }
        public JsonResult GetAcademic()
        {
            SystemContext context = HttpContext.RequestServices.GetService(typeof(Exam_Management_System.Models.SystemContext)) as SystemContext;
            List<AcademicYear> list = new List<AcademicYear>();
            using (MySqlConnection conn = context.GetConnection())
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM academicyear ", conn);

                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    { 
                        list.Add(new AcademicYear()
                        {
                           Id=Convert.ToInt32(reader["id"]),
                           Name=reader["academic_name"].ToString(),
                        });
                    }
                }
            }
            return Json(list);
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
        public List<Student> GetStudentYear(int id)
        {
            SystemContext context = HttpContext.RequestServices.GetService(typeof(Exam_Management_System.Models.SystemContext)) as SystemContext;
            int academic_id = context.GetAcademic().Id;
            List<Student> list = new List<Student>();
            using (MySqlConnection conn = context.GetConnection())
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("select * from studentrollno,student,old_student,result,major,year where result.studentrollno_id=studentrollno.id and studentrollno.student_id=student.id and old_student.student_id=student.id and studentrollno.id='"+id+"' and old_student.major_id=major.id and old_student.student_year_id=year.id order by result.academic_id", conn);

                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new Student()
                        {
                            Id = Convert.ToInt32(reader["id"]),
                            Rollno = reader["rollno"].ToString(),
                            Name = reader["student_name"].ToString(),
                            Major = reader["major_name"].ToString(),
                            Major_id =Convert.ToInt32(reader["major_id"]),
                            Year = reader["year_name"].ToString(),
                            Year_id = Convert.ToInt32(reader["student_year_id"]),
                           Pass= Convert.ToInt32(reader["pass"]),
                           Father_name= reader["father_name"].ToString(),
                           Mother_name= reader["mother_name"].ToString(),
                        });
                    }
                }
            }
            return list;
        }
        public List<Rollno> GetRollNo()
        {
            SystemContext context = HttpContext.RequestServices.GetService(typeof(Exam_Management_System.Models.SystemContext)) as SystemContext;
            int academic_id = context.GetAcademic().Id;
            List<Rollno> list = new List<Rollno>();
            using (MySqlConnection conn = context.GetConnection())
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM student,studentrollno,student_detail where student.id=studentrollno.student_id and studentrollno.id=student_detail.studentrollno_id and studentrollno.academic_id=" + academic_id, conn);

                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new Rollno()
                        {
                            Id = Convert.ToInt32(reader["id"]),
                            Roll = reader["rollno"].ToString(),
                            Name = reader["student_name"].ToString(),
                        });
                    }
                }
            }
            return list;
        }

        public List<Rollno> GetOldRollNo()
        {
            SystemContext context = HttpContext.RequestServices.GetService(typeof(Exam_Management_System.Models.SystemContext)) as SystemContext;
            int academic_id = context.GetAcademicSecond().Id;
            List<Rollno> list = new List<Rollno>();
            using (MySqlConnection conn = context.GetConnection())
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM student,studentrollno,student_detail where student.id=studentrollno.student_id and studentrollno.id=student_detail.studentrollno_id and studentrollno.academic_id=" + academic_id, conn);

                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new Rollno()
                        {
                            Id = Convert.ToInt32(reader["id"]),
                            Roll = reader["rollno"].ToString(),
                            Name = reader["student_name"].ToString(),
                        });
                    }
                }
            }
            return list;
        }

    }
}