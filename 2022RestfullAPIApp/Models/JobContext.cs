using Microsoft.EntityFrameworkCore;

namespace _2022RestfullAPIApp.Models
{
    public class JobContext : DbContext
    {
        public JobContext(DbContextOptions<JobContext> jobOptions) : base(jobOptions)
        {

        }
        public DbSet<Job> Jobs { get; set; }

        public DbSet<Applicant> applicants { get; set; }
    }
}
