using OTRS.Interview.Entities;
using System.Data.Entity;

namespace OTRS.Interview
{
    public class TrsContext : DbContext
    {
        public TrsContext() : base("Data Source=.;Initial Catalog=OTRS_Dev;Integrated Security=True;MultipleActiveResultSets=True;")
        {
        }

        public DbSet<Client> Clients { get; set; }

        public DbSet<Beneficiary> Beneficiary { get; set; }

        public DbSet<Employer> Employers { get; set; }

        public DbSet<Employement> Employements { get; set; }
    }
}
