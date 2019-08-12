using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exam_Management_System.Models
{
    public class Exam
    {
        public int Id { get; set; }
        public int Exam_id { get; set; }
        public string Examtile { get; set; }
        public string Subject { get; set; }
        public string Major { get; set; }
        public string Year { get; set; }
        public string Date { get; set; }
        public string Start_time { get; set; }
        public string End_time { get; set; }
        public int Subject_id { get; set; }
        public int Year_id { get; set; }
    }
}
