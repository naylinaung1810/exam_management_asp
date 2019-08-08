using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exam_Management_System.Models
{
    public class Attendence
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Rollno { get; set; }
        public string Month { get; set; }
        public int Total { get; set; }
        public int Current { get; set; }
        public string Year { get; set; }
        public int Year_id { get; set; }
        public string Class { get; set; }
        public string Major { get; set; }
    }
}
