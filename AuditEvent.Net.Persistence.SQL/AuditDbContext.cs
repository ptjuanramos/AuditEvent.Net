using AuditEvent.Net.Models;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics.CodeAnalysis;

namespace AuditEvent.Net.Persistence.SQL
{
    public class AuditDbContext : DbContext
    {
        public DbSet<Audit> Audits { get; set; }

        public AuditDbContext([NotNull] DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder
                .Entity<Audit>()
                .ToTable("Audits")
                .HasKey(a => a.Id);
        }
    }
}
