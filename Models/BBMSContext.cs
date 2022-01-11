using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace BBMS.Models
{
    public partial class BBMSContext : DbContext
    {
        public BBMSContext()
        {
        }

        public BBMSContext(DbContextOptions<BBMSContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Admin> Admins { get; set; }
        public virtual DbSet<Bloodstock> Bloodstocks { get; set; }
        public virtual DbSet<Hospital> Hospitals { get; set; }
        public virtual DbSet<Request> Requests { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=.;Database=BBMS;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<Admin>(entity =>
            {
                entity.ToTable("ADMIN");

                entity.Property(e => e.AdminId).HasColumnName("admin_id");

                entity.Property(e => e.AdminEmail)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("admin_email");

                entity.Property(e => e.AdminName)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("admin_name");

                entity.Property(e => e.AdminPassword)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("admin_password");

                entity.Property(e => e.IsActive)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("isActive");
            });

            modelBuilder.Entity<Bloodstock>(entity =>
            {
                entity.HasKey(e => e.StockId)
                    .HasName("PK__BLOODSTO__E86668624A8F4A24");

                entity.ToTable("BLOODSTOCK");

                entity.Property(e => e.StockId).HasColumnName("stock_id");

                entity.Property(e => e.BagQuantity).HasColumnName("bag_quantity");

                entity.Property(e => e.BloodGroup)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("blood_group");

                entity.Property(e => e.PricePerBag)
                    .HasColumnType("decimal(10, 2)")
                    .HasColumnName("price_perBag");

                entity.Property(e => e.Status)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("status");
            });

            modelBuilder.Entity<Hospital>(entity =>
            {
                entity.ToTable("HOSPITAL");

                entity.Property(e => e.HospitalId).HasColumnName("hospital_id");

                entity.Property(e => e.Address)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("address");

                entity.Property(e => e.City)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("city");

                entity.Property(e => e.CreatedOn)
                    .HasColumnType("date")
                    .HasColumnName("createdOn");

                entity.Property(e => e.Email)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("email");

                entity.Property(e => e.HospitalName)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("hospital_name");

                entity.Property(e => e.Password)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("password");

                entity.Property(e => e.PhoneNo)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("phone_no");

                entity.Property(e => e.State)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("state");

                entity.Property(e => e.UpdatedOn)
                    .HasColumnType("date")
                    .HasColumnName("updatedOn");
            });

            modelBuilder.Entity<Request>(entity =>
            {
                entity.ToTable("REQUEST");

                entity.Property(e => e.RequestId).HasColumnName("request_id");

                entity.Property(e => e.AmountToPay)
                    .HasColumnType("decimal(10, 2)")
                    .HasColumnName("amount_to_pay");

                entity.Property(e => e.CreatedOn)
                    .HasColumnType("date")
                    .HasColumnName("createdOn");

                entity.Property(e => e.HospitalId).HasColumnName("hospital_id");

                entity.Property(e => e.PaymentStatus)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("paymentStatus");

                entity.Property(e => e.RequestDate)
                    .HasColumnType("date")
                    .HasColumnName("request_date");

                entity.Property(e => e.RequiredQuantity).HasColumnName("required_quantity");

                entity.Property(e => e.Status)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("status");

                entity.Property(e => e.StockId).HasColumnName("stock_id");

                entity.Property(e => e.UpdatedOn)
                    .HasColumnType("date")
                    .HasColumnName("updatedOn");

                entity.HasOne(d => d.Hospital)
                    .WithMany(p => p.Requests)
                    .HasForeignKey(d => d.HospitalId)
                    .HasConstraintName("FK__REQUEST__hospita__2A4B4B5E");

                entity.HasOne(d => d.Stock)
                    .WithMany(p => p.Requests)
                    .HasForeignKey(d => d.StockId)
                    .HasConstraintName("FK__REQUEST__stock_i__2B3F6F97");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
