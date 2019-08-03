using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Checkbox.Models
{
    public class Course
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public List<StudentCourse> StudentCourse { get; set; }
    }
}
