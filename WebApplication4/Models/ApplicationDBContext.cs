using Microsoft.EntityFrameworkCore;
using WebApplication4.Models;

namespace StudyProject.Models
{
    public class ApplicationDBContext : DbContext
    {

        public DbSet<Employee> employees { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
            .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
            .AddJsonFile("appsettings.json")
            .Build();
            optionsBuilder.UseSqlServer(configuration.GetConnectionString("DefaultConnection"));
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Company>()
               .HasOne(e => e.Employees)
               .WithOne(c => c.Companies)
               .HasForeignKey<Employee>(e => e.companyId);
            modelBuilder.Entity<Company>()
                .ToTable("Companies", schema: "Blogs");
            modelBuilder.Entity<Company>()
                .Property(c => c.CompanyName)
                .HasColumnName("CompanyTitle");
        }
    }
}

