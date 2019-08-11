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
    }
}
