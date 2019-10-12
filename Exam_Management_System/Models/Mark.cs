using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exam_Management_System.Models
{
    public class Mark
    {
        public int Id { get; set; }
        public string Rollno { get; set; }
        public string Img { get; set; }
        public int Exam_id { get; set; }
        public string Examtile { get; set; }
        public string Name { get; set; }
        public string Grade { get; set; }
        public string Subject { get; set; }
        public string Major { get; set; }
        public string Year { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string Class { get; set; }
        public int S_mark { get; set; }
        public int Subject_id { get; set; }
        public int Rollno_id { get; set; }
        public int Total_mark { get; set; }
        public int Pass { get; set; }

        //public List<ResMark> ResMarks { get; set; }
    }
}
