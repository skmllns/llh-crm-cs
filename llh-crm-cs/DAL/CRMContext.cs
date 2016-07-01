using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using llh_crm_cs.Models;

namespace llh_crm_cs.DAL
{
    public class CRMContext : DbContext
    {

        public CRMContext() : base("CRMContext")
        {
        }

        public DbSet<Constituent> Constituents { get; set; }
        public DbSet<Artist> Artists { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Volunteer> Volunteers { get; set; }
        public DbSet<Interest> Interests { get; set; }
        public DbSet<Occurence> Occurences { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Donation> Donations { get; set; }
    }
}