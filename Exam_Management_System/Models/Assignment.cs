using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exam_Management_System.Models
{
    public class Assignment
    {
        public int Id { get; set; }
        public string Rollno { get; set; }
      
        public string Name { get; set; }
        public string Grade { get; set; }
        public string Subject { get; set; }
        public string Major { get; set; }
        public string Year { get; set; }
        public string Class { get; set; }
        public int Mark { get; set; }
        public int Subject_id { get; set; }
        public int Rollno_id { get; set; }
    }
}
