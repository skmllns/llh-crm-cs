using System;

namespace llh_crm_cs.Models
{
    public class Course
    {
        public int CourseID { get; set; }
        public int CourseName { get; set; }
        public string CourseCategory { get; set; }
        public DateTime CourseDate { get; set; }
    }
}