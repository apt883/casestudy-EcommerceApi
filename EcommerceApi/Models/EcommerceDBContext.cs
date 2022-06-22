using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace EcommerceApi.Models
{
    public partial class EcommerceDBContext : DbContext
    {
        public EcommerceDBContext()
        {
        }

        public EcommerceDBContext(DbContextOptions<EcommerceDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Admin> Admins { get; set; }
        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<TblLogin> TblLogins { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=DESKTOP-B4SLVHO;Initial Catalog=EcommerceDB;Integrated Security=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<Admin>(entity =>
            {
                entity.ToTable("Admin");

                entity.Property(e => e.AdminId)
                    .HasMaxLength(100)
                    .HasColumnName("AdminID");

                entity.Property(e => e.AdminName).HasMaxLength(100);
            });

            modelBuilder.Entity<Customer>(entity =>
            {
                entity.ToTable("Customer");

                entity.Property(e => e.UserId)
                    .HasMaxLength(100)
                    .HasColumnName("UserID");

                entity.Property(e => e.UserName).HasMaxLength(100);
            });

            modelBuilder.Entity<Product>(entity =>
            {
                entity.ToTable("Product");

                entity.Property(e => e.Category).HasMaxLength(50);

                entity.Property(e => e.Description).HasMaxLength(250);

                entity.Property(e => e.Images).HasMaxLength(200);

                entity.Property(e => e.Price).HasMaxLength(50);

                entity.Property(e => e.ProductId)
                    .HasMaxLength(50)
                    .HasColumnName("ProductID");

                entity.Property(e => e.ProductName).HasMaxLength(50);

                entity.Property(e => e.Title).HasMaxLength(200);
            });

            modelBuilder.Entity<TblLogin>(entity =>
            {
                entity.ToTable("TblLogin");

                entity.Property(e => e.Password).HasMaxLength(100);

                entity.Property(e => e.UserName).HasMaxLength(100);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
