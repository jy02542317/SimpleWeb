using Web.Models;
using Microsoft.EntityFrameworkCore;

namespace Web.Data
{
    public class InformationContext : DbContext
    {
        public virtual DbSet<Contact> Contact { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Contact>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");
                entity.Property(e => e.Id).
                .IsRequired()
                .HasMaxLength(25)
                .IsUnicode(false);
                entity.Property(e => e.InstalledRoles)
                .IsRequired()
                .HasMaxLength(50)
                .IsUnicode(false);
                entity.Property(e => e.MachineTypeId).HasColumnName("MachineTypeID");
                entity.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(25)
                .IsUnicode(false);
                entity.Property(e => e.OperatingSysId).HasColumnName("OperatingSysID");
              
                
            });
        }
    }
}
