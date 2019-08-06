using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exam_Management_System.Models
{
    public class Subject
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Year { get; set; }
        public string Major { get; set; }
        public int Year_id { get; set; }
        public int Major_id { get; set; }
    }
}
