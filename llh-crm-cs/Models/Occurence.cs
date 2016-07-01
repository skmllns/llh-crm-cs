using System;

namespace llh_crm_cs.Models
{
    public class Occurence
    {
        public int OccurenceID { get; set; }
        public int OccurenceName { get; set; }
        public string OccurenceCategory { get; set; }
        public DateTime OccurenceDate { get; set; }
    }
}