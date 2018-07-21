using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Towns.Models.Data
{
    public partial class TownsContext : DbContext
    {
        public virtual DbSet<Sweden> Sweden { get; set; }
        public TownsContext()
        {
        }

        public TownsContext(DbContextOptions<TownsContext> options)
            : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Sweden>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Abstract).IsUnicode(false);

                entity.Property(e => e.LastUpdated).HasColumnType("datetime");

                entity.Property(e => e.Region).IsUnicode(false);

                entity.Property(e => e.Town)
                    .IsRequired()
                    .IsUnicode(false);
            });
        }
    }
}
