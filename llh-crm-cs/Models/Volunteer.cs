using System.Collections.Generic;

namespace llh_crm_cs.Models
{
    public class Volunteer
    {
        public int VolunteerID { get; set; }
        public virtual ICollection<Occurence> Occurences { get; set; }
    }
}