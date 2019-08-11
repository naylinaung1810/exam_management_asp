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
        public int Exam_id { get; set; }
        public string Examtile { get; set; }
        public string Name { get; set; }
        public string Grade { get; set; }
        public string Subject { get; set; }
        public string Major { get; set; }
        public string Year { get; set; }
        public int S_mark { get; set; }
        public string Subject_id { get; set; }
        public int Rollno_id { get; set; }
        public List<ResMark> ResMarks { get; set; }
    }
}
