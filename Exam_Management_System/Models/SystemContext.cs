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
        public string AddAcademic(AcademicYear academic)
        {
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                string sql = $"Insert Into academicyear (academic_name) Values ('{academic.Name}')";
                using (MySqlCommand command = new MySqlCommand(sql, conn))
                {
                    command.ExecuteNonQuery();
                    conn.Close();
                }
            }
             return "Acadmic Year is Added successful!";
        }
    }
}
