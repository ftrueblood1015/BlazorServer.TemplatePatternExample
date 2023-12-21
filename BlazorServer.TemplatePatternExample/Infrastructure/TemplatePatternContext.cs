using BlazorServer.TemplatePatternExample.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace BlazorServer.TemplatePatternExample.Infrastructure
{
    public class TemplatePatternContext : DbContext
    {
        public TemplatePatternContext(DbContextOptions<TemplatePatternContext> options) : base(options)
        {
            
        }

        DbSet<Employee> Employees => Set<Employee>();
        DbSet<Manager> Managers => Set<Manager>();

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Manager>().HasData(
                new Manager { Id = 1, Department = "IT", Description = "IT Manager", IsActive = true, Name = "Billy "}    
            );

            modelBuilder.Entity<Employee>().HasData(
                new Employee { Id = 1, Department = "IT", Description = "IT Employee", IsActive = true, ManagerId = 1, Name = "Bob" },
                new Employee { Id = 2, Department = "IT", Description = "IT Employee", IsActive = true, ManagerId = 1, Name = "Thorton" }
            );
        }
    }
}
