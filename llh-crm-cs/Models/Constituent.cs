using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace llh_crm_cs.Models
{
    public class Constituent
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ConstituentID { get; set; }

        //use VM with this?
        public bool IsPerson { get; set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string ZipCode { get; set; }
        public string Country { get; set; }
     
        [DataType(DataType.EmailAddress, ErrorMessage = "Please enter a valid email address.")]
        public string Email { get; set; }

        public string PhoneNumber { get; set; }
        public string ReferralMethod { get; set; }
        public DateTime ActiveSince { get; set; }
        public string AgeRange { get; set; }
        public string Notes { get; set; }

        public virtual ICollection<Interest> Interests { get; set; }
        public virtual ICollection<Affiliation> Affiliations { get; set; }
        public virtual ICollection<Donation> Donations { get; set; }

    }
}