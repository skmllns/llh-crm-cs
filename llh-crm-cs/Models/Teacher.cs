using System.Collections.Generic;

namespace llh_crm_cs.Models
{
    public class Teacher
    {
        public int TeacherID { get; set; }
        public virtual ICollection<Course> Courses { get; set; }
    }
}