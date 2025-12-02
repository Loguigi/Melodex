using MelodexLibrary.Models;
using Microsoft.EntityFrameworkCore;

namespace MelodexLibrary.Data;

public class MelodexDbContext(DbContextOptions<MelodexDbContext> options) : DbContext(options)
{
    public DbSet<Class> Classes { get; set; }
    public DbSet<Intervention> Interventions { get; set; }
    public DbSet<SchoolYear> SchoolYears { get; set; }
    public DbSet<Session> Sessions { get; set; }
    public DbSet<Student> Students { get; set; }
    public DbSet<TreatmentPeriod> TreatmentPeriods { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        
        // TODO table definitions
    }
}