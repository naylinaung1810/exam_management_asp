using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exam_Management_System.Models
{
    public class SystemContext
    {
        public string ConnectionString { get; set; }

        public SystemContext(string connectionString)
        {
            this.ConnectionString = connectionString;
        }

        public MySqlConnection GetConnection()
        {
            return new MySqlConnection(ConnectionString);
        }

        ///////////////////////////////////////////////////////
        public int GetLastStudentId()
        {
            int id = 0;
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM student ORDER BY  id DESC LIMIT 1", conn);

                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        id = Convert.ToInt32(reader["id"]);
                    }
                }
            }
            return id;
        }
        public int GetlastId()
        {
            int id = 0;
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM studentrollno ORDER BY  id DESC LIMIT 1", conn);

                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        id = Convert.ToInt32(reader["id"]);
                    }
                }
            }
            return id;
        }
        public int GetMark(int student_id)
        {
            int mark = 0;          
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("select * from result,studentrollno where studentrollno.id=result.studentrollno_id and studentrollno.student_id=" + student_id+" ORDER BY  result.academic_id DESC LIMIT 1", conn);

                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        int mid = Convert.ToInt32(reader["mid_mark"]);
                        int final = Convert.ToInt32(reader["final_mark"]);
                        int ass = Convert.ToInt32(reader["assigment_mark"]);
                        mark = (mid + final) * 80 / 200;
                    }
                }
            }
            return mark;
        }
        public int GetClassStudent(int year_id,int major_id,int rollno)
        {
            int class_id=0;
            int academic = GetAcademic().Id;
            int count = 0;
            int p = 0;
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("SELECT COUNT(*) FROM old_student where student_year_id="+year_id+" and major_id="+major_id+" and academic_id="+academic, conn);
                count = Convert.ToInt32(cmd.ExecuteScalar());
                p = count*100 / 300;
            }
            if(count<3)
            {
                switch (year_id)
                {
                    case 1: class_id = 1; break;
                    case 2: class_id = 4; break;
                    case 3: class_id = 7; break;
                    case 4: class_id = 10; break;
                    default: class_id = 13; break;
                }
            }
            else
            {
                if (major_id == 1)
                {
                    if (rollno <= p)
                    {
                        class_id = 1;
                    }
                    else if (p < rollno && (p * 2) >= rollno)
                    {
                        class_id = 2;
                    }
                    else if(rollno>(p*2))
                    {
                        class_id = 3;
                    }
                }
                else if (major_id == 2)
                {
                    if (rollno <= count / 2)
                    {
                        switch (year_id)
                        {
                            case 1: class_id = 1; break;
                            case 2: class_id = 4; break;
                            case 3: class_id = 7; break;
                            case 4: class_id = 10; break;
                            default: class_id = 13; break;
                        }
                    }
                    else
                    {
                        switch (year_id)
                        {
                            case 1: class_id = 2; break;
                            case 2: class_id = 5; break;
                            case 3: class_id = 8; break;
                            case 4: class_id = 11; break;
                            default: class_id = 14; break;
                        }
                    }
                }
                else
                {
                    switch (year_id)
                    {
                        case 1: class_id = 3; break;
                        case 2: class_id = 5; break;
                        case 3: class_id = 9; break;
                        case 4: class_id = 12; break;
                        default: class_id = 15; break;
                    }
                }
            }
           
            return class_id;
        }
        public AcademicYear GetAcademic()
        {
            //List<AcademicYear> list = new List<AcademicYear>();
            AcademicYear academicYear = new AcademicYear();
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM academicyear ORDER BY  id DESC LIMIT 1", conn);

                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        academicYear.Id = Convert.ToInt32(reader["id"]);
                        academicYear.Name = reader["academic_name"].ToString();
                    }
                }
            }
            return academicYear;
        }
        public String Grade(int mark)
        {
            string grade = null;
            if (mark >= 81)
            {
                grade = "A";
            }
            else if (mark >= 61 && mark <= 80)
            {
                grade = "B";
            }
            else if (mark >= 41 && mark <= 60)
            {
                grade = "C";
            }

            else if (mark >= 21 && mark <= 40)
            {
                grade = "D";

            }
            else
            { grade = "E"; }
            return grade;
        }

        public int CheckResult(int id, int academic)
        {
            int total = 0;
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("select count(*) from result where studentrollno_id=" + id + " and academic_id=" + academic , conn);

                total = Convert.ToInt32(cmd.ExecuteScalar());
                conn.Close();
            }
            return total;
        }
      public  int tt = 0;
        public int GetPass(int id, int academic,int subject,int mark)
        {
            int total = mark;
            int res = 0;
            int cu = 1;
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("select * from mark_mid where studentrollno_id=" + id + " and academic_id=" + academic+" and subject_id="+subject, conn);

                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        int m = Convert.ToInt32(reader["mark"]);
                        total += m;
                    }
                }
                total = (total*80)/200;
                
                MySqlCommand cmd1 = new MySqlCommand("select * from assignment where studentrollno_id=" + id + " and academic_id=" + academic + " and subject_id=" + subject, conn);

                using (var reader = cmd1.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        total += Convert.ToInt32(reader["mark"]);
                    }
                }
                MySqlCommand cmd2 = new MySqlCommand("select * from result where studentrollno_id=" + id + " and academic_id=" + academic , conn);

                using (var reader = cmd2.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        cu= Convert.ToInt32(reader["pass"]);
                    }
                }
                tt = total;
                if (total<40)
                {
                    res = 0;
                   
                }else
                {
                    res = 1;
                   
                }
            }
            return res*cu;
        }
        public int GetMid_Mark(int id,int academic)
        {
            int total = 0;
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("select *,sum(mark) from mark_mid where studentrollno_id="+id+" and academic_id="+academic+" group by studentrollno_id", conn);

                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        total = Convert.ToInt32(reader["SUM(mark)"]);
                    }
                }
               
            }
            return total;
        }
        public int GetFinal_Mark(int id, int academic)
        {
            int total = 0;
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("select *,sum(mark) from mark_final where studentrollno_id=" + id + " and academic_id=" + academic + " group by studentrollno_id", conn);

                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        total = Convert.ToInt32(reader["SUM(mark)"]);
                    }
                }
            }
            return total;
        }
        public int GetAss_Mark(int id, int academic)
        {
            int total = 0;
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("select *,sum(mark) from assignment where studentrollno_id=" + id + " and academic_id=" + academic + " group by studentrollno_id", conn);

                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        total = Convert.ToInt32(reader["SUM(mark)"]);
                    }
                }
            }
            return total;
        }

        public int GetStudentId(string rollno,int academic)
        {
            int student_id = 0;
            using (MySqlConnection conn1 = GetConnection())
            {
                conn1.Open();

                MySqlCommand cmd1 = new MySqlCommand("SELECT * FROM studentrollno where rollno='" + rollno + "' and academic_id=" + academic, conn1);

                using (var reader = cmd1.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        student_id = Convert.ToInt32(reader["id"]);
                    }
                }
                conn1.Close();
            }
            return student_id;
        }
    }
}
