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
        public int GetPass(int id, int academic,int subject)
        {
            int total = 0;
            int res = 0;
            int cu = 0;
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("select * from mark_mid where studentrollno_id=" + id + " and academic_id=" + academic+" and subject_id="+subject, conn);

                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        int mark = Convert.ToInt32(reader["mark"]);
                        total += (100 / mark) * 80;
                    }
                }

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
    }
}
