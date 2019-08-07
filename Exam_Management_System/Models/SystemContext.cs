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
    }
}
