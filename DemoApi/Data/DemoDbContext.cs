using DemoApi.Models;
using Microsoft.EntityFrameworkCore;

namespace DemoApi.Data
{
    public class DemoDbContext : DbContext
    {
        public DemoDbContext()
        {
        }

        public DemoDbContext(DbContextOptions<DemoDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<Gender> Genders { get; set; }
        public virtual DbSet<TlmApp> TlmApps { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
        }
        }
}
