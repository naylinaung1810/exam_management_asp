using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exam_Management_System.Models
{
    public class TestImg
    {
       public IFormFile Photo { get; set; }
       public string name { get; set; }
    }
}
