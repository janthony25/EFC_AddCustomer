using EFC_AddCustomer.Models;
using Microsoft.EntityFrameworkCore;

namespace EFC_AddCustomer.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            
        }

        public DbSet<CustomerName> CustomerNames { get; set; }
        public DbSet<Item> Items { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Item>()
                .HasOne<CustomerName>(i => i.CustomerName)
                .WithMany(c => c.Items)
                .HasForeignKey(i => i.CustomerName)
                .IsRequired();
        }
    }
}
