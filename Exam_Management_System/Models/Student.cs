using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exam_Management_System.Models
{
    public class Student
    {
        public int Id { get; set; }
        public int Student_id { get; set; }
        public string Name { get; set; }
        public string Rollno { get; set; }
        public string Year { get; set; }
        public string Class { get; set; }
        public string Major { get; set; }
        public int Year_id { get; set; }
        public int Class_id { get; set; }
        public int Major_id { get; set; }
        public int Academic_id { get; set; }
        public int Mark { get; set; }
        public int Pass { get; set; }
        public int Total { get; set; }
        public int Current { get; set; }
        public IFormFile Photo { get; set; }


        public string Reg_no { get; set; }
        public string Reg_date { get; set; }
        public string DOB { get; set; }
        public string Sex { get; set; }
        public string Nationality { get; set; }
        public string Father_nationality { get; set; }
        public string Mother_nationality { get; set; }
        public string Nrc { get; set; }
     
        public string Father_name { get; set; }
        public string Father_nrc { get; set; }
        public string Father_job { get; set; }
        public string Father_phone { get; set; }
        public string Mother_name { get; set; }
        public string Mother_nrc { get; set; }
        public string Mother_job { get; set; }
        public string Mother_phone { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string City { get; set; }
        public string Father_city { get; set; }
        public string Mother_city { get; set; }
        public string Religion { get; set; }
        public string Father_religion { get; set; }
        public string Mother_religion { get; set; }
        public string Email { get; set; }
        public string Img { get; set; }
    }
}
