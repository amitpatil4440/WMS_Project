using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace WheelChairAPI.Models
{
    public partial class wmsContext : DbContext
    {
        public wmsContext()
        {
        }

        public wmsContext(DbContextOptions<wmsContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AirportStaff> AirportStaff { get; set; }
        public virtual DbSet<Booking> Booking { get; set; }
        public virtual DbSet<Passenger> Passenger { get; set; }
        public virtual DbSet<Supervisor> Supervisor { get; set; }
        public virtual DbSet<WheelChair> WheelChair { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
             //   optionsBuilder.UseSqlServer("Server=10.3.117.39;Database=wms;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AirportStaff>(entity =>
            {
                entity.HasKey(e => e.StaffId)
                    .HasName("PK__AirportS__96D4AAF7349B32CE");

                entity.HasIndex(e => e.Email)
                    .HasName("UQ__AirportS__A9D10534C74904DB")
                    .IsUnique();

                entity.Property(e => e.StaffId).HasColumnName("StaffID");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.MobileNo)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Password)
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Booking>(entity =>
            {
                entity.HasKey(e => e.Pnrno)
                    .HasName("PK__Booking__4677517B4FB80148");

                entity.Property(e => e.Pnrno).HasColumnName("PNRNo");

                entity.Property(e => e.Arrival)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Class)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.Departure)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.PassengerId).HasColumnName("PassengerID");

                entity.Property(e => e.PassengerName)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.SeatNo)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Time).HasColumnType("datetime");

                entity.HasOne(d => d.Passenger)
                    .WithMany(p => p.Booking)
                    .HasForeignKey(d => d.PassengerId)
                    .HasConstraintName("FK__Booking__Passeng__267ABA7A");
            });

            modelBuilder.Entity<Passenger>(entity =>
            {
                entity.HasIndex(e => e.Email)
                    .HasName("UQ__Passenge__A9D10534870D5B65")
                    .IsUnique();

                entity.Property(e => e.PassengerId).HasColumnName("PassengerID");

                entity.Property(e => e.Address)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.DisabilityType)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.MobileNo)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Password)
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Supervisor>(entity =>
            {
                entity.HasIndex(e => e.Email)
                    .HasName("UQ__Supervis__A9D10534C6B043D6")
                    .IsUnique();

                entity.Property(e => e.SupervisorId).HasColumnName("SupervisorID");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.MobileNo)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.PassengerId).HasColumnName("PassengerID");

                entity.Property(e => e.Password)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Pnrno).HasColumnName("PNRNo");

                entity.Property(e => e.StaffId).HasColumnName("StaffID");

                entity.Property(e => e.Wid).HasColumnName("WID");

                entity.HasOne(d => d.Passenger)
                    .WithMany(p => p.Supervisor)
                    .HasForeignKey(d => d.PassengerId)
                    .HasConstraintName("FK__Superviso__Passe__35BCFE0A");

                entity.HasOne(d => d.PnrnoNavigation)
                    .WithMany(p => p.Supervisor)
                    .HasForeignKey(d => d.Pnrno)
                    .HasConstraintName("FK__Superviso__PNRNo__36B12243");

                entity.HasOne(d => d.Staff)
                    .WithMany(p => p.Supervisor)
                    .HasForeignKey(d => d.StaffId)
                    .HasConstraintName("FK__Superviso__Staff__38996AB5");

                entity.HasOne(d => d.W)
                    .WithMany(p => p.Supervisor)
                    .HasForeignKey(d => d.Wid)
                    .HasConstraintName("FK__Supervisor__WID__37A5467C");
            });

            modelBuilder.Entity<WheelChair>(entity =>
            {
                entity.HasKey(e => e.Wid)
                    .HasName("PK__WheelCha__DB3765191433624C");

                entity.Property(e => e.Wid).HasColumnName("WID");

                entity.Property(e => e.Status)
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
