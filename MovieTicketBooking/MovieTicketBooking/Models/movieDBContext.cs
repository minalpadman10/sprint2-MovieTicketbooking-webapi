using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace MovieTicketBooking.Models
{
    public partial class movieDBContext : DbContext
    {
        public movieDBContext()
        {
        }

        public movieDBContext(DbContextOptions<movieDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<TblAdmin> TblAdmins { get; set; }
        public virtual DbSet<TblConfirmation> TblConfirmations { get; set; }
        public virtual DbSet<TblLogin> TblLogins { get; set; }
        public virtual DbSet<TblMovie> TblMovies { get; set; }
        public virtual DbSet<TblPayment> TblPayments { get; set; }
        public virtual DbSet<TblRecepit> TblRecepits { get; set; }
        public virtual DbSet<Tblregister> Tblregisters { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=DESKTOP-BUE654A;Initial Catalog=movieDB;Integrated Security=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<TblAdmin>(entity =>
            {
                entity.ToTable("TblAdmin");

                entity.Property(e => e.Password).HasMaxLength(100);

                entity.Property(e => e.Username).HasMaxLength(100);
            });

            modelBuilder.Entity<TblConfirmation>(entity =>
            {
                entity.ToTable("TblConfirmation");

                entity.Property(e => e.MovieName)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("Movie Name");

                entity.Property(e => e.NoOfTickets).HasColumnName("No.of Tickets");

                entity.Property(e => e.TheaterName)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("Theater Name");
            });

            modelBuilder.Entity<TblLogin>(entity =>
            {
                entity.ToTable("TblLogin");

                entity.Property(e => e.Password).HasMaxLength(100);

                entity.Property(e => e.UserName).HasMaxLength(100);
            });

            modelBuilder.Entity<TblMovie>(entity =>
            {
                entity.ToTable("TblMovie");

                entity.Property(e => e.NoOfTickets).HasColumnName("No.of-Tickets");

                entity.Property(e => e.SelectDate).HasColumnName("Select-Date");

                entity.Property(e => e.SelectMovie)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("Select-Movie");

                entity.Property(e => e.SelectTheater)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("Select-Theater");

                entity.Property(e => e.SelectTime).HasColumnName("Select-Time");
            });

            modelBuilder.Entity<TblPayment>(entity =>
            {
                entity.ToTable("TblPayment");

                entity.Property(e => e.Upiid).HasColumnName("UPIID");
            });

            modelBuilder.Entity<TblRecepit>(entity =>
            {
                entity.ToTable("TblRecepit");

                entity.Property(e => e.Fare).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Movie)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.NoOfTickets).HasColumnName("No.of Tickets");

                entity.Property(e => e.Show).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Theatre).HasMaxLength(100);
            });

            modelBuilder.Entity<Tblregister>(entity =>
            {
                entity.ToTable("Tblregister");

                entity.Property(e => e.Email).HasMaxLength(100);

                entity.Property(e => e.FirstName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.LastName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Password).HasMaxLength(100);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
