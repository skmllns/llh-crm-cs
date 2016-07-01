using System.Collections.Generic;

namespace llh_crm_cs.Models
{
    public class Artist
    {
        public int ArtistID { get; set; }
        public string ArtistCategory { get; set; }
        public virtual ICollection<Occurence> Occurences { get; set; }
    }
}