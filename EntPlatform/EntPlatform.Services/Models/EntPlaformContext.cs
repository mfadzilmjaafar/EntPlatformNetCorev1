using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace EntPlatform.Services.Models
{
    public partial class EntPlaformContext : DbContext
    {
        public EntPlaformContext()
        {
        }

        public EntPlaformContext(DbContextOptions<EntPlaformContext> options)
            : base(options)
        {
        }

     

        public virtual DbSet<AspNetRoleClaims> AspNetRoleClaims { get; set; }
        public virtual DbSet<AspNetRoles> AspNetRoles { get; set; }
        public virtual DbSet<AspNetUserClaims> AspNetUserClaims { get; set; }
        public virtual DbSet<AspNetUserLogins> AspNetUserLogins { get; set; }
        public virtual DbSet<AspNetUserRoles> AspNetUserRoles { get; set; }
        public virtual DbSet<AspNetUsers> AspNetUsers { get; set; }
        public virtual DbSet<AspNetUserTokens> AspNetUserTokens { get; set; }
        public virtual DbSet<BusinessNature> BusinessNature { get; set; }
        public virtual DbSet<BusinessNatureDetails> BusinessNatureDetails { get; set; }
        public virtual DbSet<Country> Country { get; set; }
        public virtual DbSet<Organisation> Organisation { get; set; }
        public virtual DbSet<OrganisationBusinessNature> OrganisationBusinessNature { get; set; }
        public virtual DbSet<OrganisationContact> OrganisationContact { get; set; }
        public virtual DbSet<State> State { get; set; }

//        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
//        {
//            if (!optionsBuilder.IsConfigured)
//            {
////#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
//                optionsBuilder.UseSqlServer("Data Source=172.19.5.88;Initial Catalog=EntPlaform;Persist Security Info=True;User ID=sa;Password=P@ssw0rd;");
//            }
//        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AspNetRoleClaims>(entity =>
            {
                entity.HasIndex(e => e.RoleId);

                entity.Property(e => e.RoleId).IsRequired();

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.AspNetRoleClaims)
                    .HasForeignKey(d => d.RoleId);
            });

            modelBuilder.Entity<AspNetRoles>(entity =>
            {
                entity.HasIndex(e => e.NormalizedName)
                    .HasName("RoleNameIndex");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Name).HasMaxLength(256);

                entity.Property(e => e.NormalizedName).HasMaxLength(256);
            });

            modelBuilder.Entity<AspNetUserClaims>(entity =>
            {
                entity.HasIndex(e => e.UserId);

                entity.Property(e => e.UserId).IsRequired();

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AspNetUserClaims)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<AspNetUserLogins>(entity =>
            {
                entity.HasKey(e => new { e.LoginProvider, e.ProviderKey });

                entity.HasIndex(e => e.UserId);

                entity.Property(e => e.UserId).IsRequired();

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AspNetUserLogins)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<AspNetUserRoles>(entity =>
            {
                entity.HasKey(e => new { e.UserId, e.RoleId });

                entity.HasIndex(e => e.RoleId);

                entity.HasIndex(e => e.UserId);

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.AspNetUserRoles)
                    .HasForeignKey(d => d.RoleId);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AspNetUserRoles)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<AspNetUsers>(entity =>
            {
                entity.HasIndex(e => e.NormalizedEmail)
                    .HasName("EmailIndex");

                entity.HasIndex(e => e.NormalizedUserName)
                    .HasName("UserNameIndex")
                    .IsUnique();

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Email).HasMaxLength(256);

                entity.Property(e => e.NormalizedEmail).HasMaxLength(256);

                entity.Property(e => e.NormalizedUserName).HasMaxLength(256);

                entity.Property(e => e.UserName).HasMaxLength(256);
            });

            modelBuilder.Entity<AspNetUserTokens>(entity =>
            {
                entity.HasKey(e => new { e.UserId, e.LoginProvider, e.Name });
            });

            modelBuilder.Entity<BusinessNature>(entity =>
            {
                entity.Property(e => e.Nature).HasMaxLength(50);
            });

            modelBuilder.Entity<BusinessNatureDetails>(entity =>
            {
                entity.Property(e => e.Description).HasMaxLength(200);

                entity.HasOne(d => d.BusinessNatureNavigation)
                    .WithMany(p => p.BusinessNatureDetails)
                    .HasForeignKey(d => d.BusinessNature)
                    .HasConstraintName("FK_BusinessNatureDetails_BusinessNature");
            });

            modelBuilder.Entity<Country>(entity =>
            {
                entity.HasKey(e => e.CountryCode);

                entity.Property(e => e.CountryCode).ValueGeneratedNever();

                entity.Property(e => e.CallingCode).HasColumnType("numeric(4, 0)");

                entity.Property(e => e.Ibancode)
                    .HasColumnName("IBANCode")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.IsoalphaCode)
                    .HasColumnName("ISOAlphaCode")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(60)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Organisation>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Address1).HasMaxLength(50);

                entity.Property(e => e.Address2).HasMaxLength(50);

                entity.Property(e => e.Address3).HasMaxLength(50);

                entity.Property(e => e.Company).HasMaxLength(100);

                entity.Property(e => e.Email).HasMaxLength(50);

                entity.Property(e => e.Fax).HasMaxLength(15);

                entity.Property(e => e.Postcode).HasMaxLength(5);

                entity.Property(e => e.Telephone).HasMaxLength(15);

                entity.Property(e => e.Website).HasMaxLength(50);
            });

            modelBuilder.Entity<OrganisationBusinessNature>(entity =>
            {
                entity.HasKey(e => e.RowId);

                entity.HasOne(d => d.BusinessNatureDetails)
                    .WithMany(p => p.OrganisationBusinessNature)
                    .HasForeignKey(d => d.BusinessNatureDetailsId)
                    .HasConstraintName("FK_OrganisationBusinessNature_BusinessNatureDetails");

                entity.HasOne(d => d.Organisation)
                    .WithMany(p => p.OrganisationBusinessNature)
                    .HasForeignKey(d => d.OrganisationId)
                    .HasConstraintName("FK_OrganisationBusinessNature_Organisation");
            });

            modelBuilder.Entity<OrganisationContact>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Department).HasMaxLength(50);

                entity.Property(e => e.Email).HasMaxLength(50);

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.Property(e => e.Position).HasMaxLength(50);

                entity.Property(e => e.Telephone).HasMaxLength(50);

                entity.HasOne(d => d.Organisation)
                    .WithMany(p => p.OrganisationContact)
                    .HasForeignKey(d => d.OrganisationId)
                    .HasConstraintName("FK_OrganisationContact_Organisation");
            });

            modelBuilder.Entity<State>(entity =>
            {
                entity.HasKey(e => e.StateCode);

                entity.Property(e => e.StateCode).ValueGeneratedNever();

                entity.Property(e => e.Abbreviation)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Isocode)
                    .HasColumnName("ISOCode")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.StateName)
                    .HasMaxLength(60)
                    .IsUnicode(false);
            });
        }
    }
}
