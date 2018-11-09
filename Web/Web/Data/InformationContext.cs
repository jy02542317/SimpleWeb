using Web.Models;
using Microsoft.EntityFrameworkCore;

namespace Web.Data
{
    public class InformationContext : DbContext
    {
        public virtual DbSet<Contacts> Contact { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder
        optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(@"Server=.;Database=Contactdemo;Trusted_Connection=false;User ID=sa;Password=Password01! ");
            }
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Contacts>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID").ValueGeneratedNever();
                entity.Property(e => e.Address).HasColumnName("Address").HasColumnType("nvarchar(200)");
                entity.Property(e => e.Company).HasColumnName("Company").HasColumnType("nvarchar(50)");
                entity.Property(e => e.CreateTime).HasColumnName("CreateTime").HasColumnType("datetime");
                entity.Property(e => e.Message).HasColumnName("Message").HasColumnType("text");
                entity.Property(e => e.Mobile).HasColumnName("Mobile").HasColumnType("nvarchar(20)").HasMaxLength(20);
                entity.Property(e => e.Name).HasColumnName("Name").HasColumnType("nvarchar(50)").HasMaxLength(50);
                entity.Property(e => e.Email).HasColumnName("Email").HasColumnType("nvarchar(50)").HasMaxLength(50);
            });
        }
    }
}
