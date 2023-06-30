using Microsoft.EntityFrameworkCore;
using ThinKsaDev.ItDeveloper.Domain.Entities;

namespace ThinKsaDev.ItDeveloper.Data.Data.ORM
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<Patient> Patient { get; set; }
        public DbSet<PatientState> PatientState { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            base.OnModelCreating(modelBuilder);
        }
    }
}
