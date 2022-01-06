using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace TProject.Models
{
    public partial class Test1Context : DbContext
    {

        public Test1Context(DbContextOptions<Test1Context> options)
            : base(options)
        {
        }

        public virtual DbSet<Alert> Alert { get; set; }
        public virtual DbSet<Atmtechnicians> Atmtechnicians { get; set; }
        public virtual DbSet<AuGroup> AuGroup { get; set; }
        public virtual DbSet<Authorize> Authorize { get; set; }
        public virtual DbSet<BusInfo> BusInfo { get; set; }
        public virtual DbSet<Device> Device { get; set; }
        public virtual DbSet<Driver> Driver { get; set; }
        public virtual DbSet<Fixing> Fixing { get; set; }
        public virtual DbSet<History> History { get; set; }
        public virtual DbSet<Insurance> Insurance { get; set; }
        public virtual DbSet<Maintain> Maintain { get; set; }
        public virtual DbSet<Management> Management { get; set; }
        public virtual DbSet<Oil> Oil { get; set; }
        public virtual DbSet<Owner> Owner { get; set; }
        public virtual DbSet<Register> Register { get; set; }
        public virtual DbSet<Rfid> Rfid { get; set; }
        public virtual DbSet<Stop> Stop { get; set; }
        public virtual DbSet<Users> Users { get; set; }

       
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Alert>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Alevel).HasColumnName("ALevel");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Management)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(30);

                entity.Property(e => e.Phone)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Position)
                    .IsRequired()
                    .HasMaxLength(30);

                entity.HasOne(d => d.ManagementNavigation)
                    .WithMany(p => p.Alert)
                    .HasForeignKey(d => d.Management)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Alert_Management");
            });

            modelBuilder.Entity<Atmtechnicians>(entity =>
            {
                entity.ToTable("ATMTechnicians");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Management)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(30);

                entity.Property(e => e.Phone)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Quit).HasColumnName("QUIT");

                entity.Property(e => e.Rfid)
                    .IsRequired()
                    .HasColumnName("RFID")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Sex)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.HasOne(d => d.ManagementNavigation)
                    .WithMany(p => p.Atmtechnicians)
                    .HasForeignKey(d => d.Management)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ATMTechnicians_Management");
            });

            modelBuilder.Entity<AuGroup>(entity =>
            {
                entity.HasKey(e => e.Aname)
                    .HasName("PK__Au_Group__6FF599D1E4808DE1");

                entity.ToTable("Au_Group");

                entity.Property(e => e.Aname)
                    .HasColumnName("AName")
                    .HasMaxLength(50);

                entity.Property(e => e.Info)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<Authorize>(entity =>
            {
                entity.HasKey(e => e.Account)
                    .HasName("PK__Authoriz__B0C3AC4789FF1B6E");

                entity.Property(e => e.Account)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Aname)
                    .IsRequired()
                    .HasColumnName("AName")
                    .HasMaxLength(50);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.HasOne(d => d.AnameNavigation)
                    .WithMany(p => p.Authorize)
                    .HasForeignKey(d => d.Aname)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Authorize_Au_Group");
            });

            modelBuilder.Entity<BusInfo>(entity =>
            {
                entity.HasKey(e => e.Np)
                    .HasName("PK__BusInfo__3214D54F2A84D8BC");

                entity.Property(e => e.Np)
                    .HasColumnName("NP")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Automaker)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.DeviceId)
                    .IsRequired()
                    .HasColumnName("DeviceID")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.DriverId)
                    .IsRequired()
                    .HasColumnName("DriverID")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Management)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Rfid)
                    .IsRequired()
                    .HasColumnName("RFID")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.HasOne(d => d.Driver)
                    .WithMany(p => p.BusInfo)
                    .HasForeignKey(d => d.DriverId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_BusInfo_Device");

                entity.HasOne(d => d.ManagementNavigation)
                    .WithMany(p => p.BusInfo)
                    .HasForeignKey(d => d.Management)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_BusInfo_Management");

                entity.HasOne(d => d.Rf)
                    .WithMany(p => p.BusInfo)
                    .HasForeignKey(d => d.Rfid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_BusInfo_RFID");
            });

            modelBuilder.Entity<Device>(entity =>
            {
                entity.Property(e => e.DeviceId)
                    .HasColumnName("DeviceID")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Active).HasColumnType("datetime");

                entity.Property(e => e.Imei)
                    .HasColumnName("IMEI")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Management).HasMaxLength(50);

                entity.Property(e => e.NetworkOp)
                    .IsRequired()
                    .HasColumnName("Network_Op")
                    .HasMaxLength(30);

                entity.Property(e => e.Sim)
                    .IsRequired()
                    .HasColumnName("SIM")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Skind)
                    .IsRequired()
                    .HasColumnName("SKind")
                    .HasMaxLength(20);

                entity.HasOne(d => d.ManagementNavigation)
                    .WithMany(p => p.Device)
                    .HasForeignKey(d => d.Management)
                    .HasConstraintName("FK_Device_Management");
            });

            modelBuilder.Entity<Driver>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Management)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(30);

                entity.Property(e => e.Phone)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Quit).HasColumnName("QUIT");

                entity.Property(e => e.Rfid)
                    .IsRequired()
                    .HasColumnName("RFID")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Sex)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.HasOne(d => d.IdNavigation)
                    .WithOne(p => p.DriverNavigation)
                    .HasForeignKey<Driver>(d => d.Id)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Driver_BusInfo");

                entity.HasOne(d => d.ManagementNavigation)
                    .WithMany(p => p.Driver)
                    .HasForeignKey(d => d.Management)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Driver_Management");
            });

            modelBuilder.Entity<Fixing>(entity =>
            {
                entity.HasKey(e => e.Np)
                    .HasName("PK__Fixing__3214D54F82B2ABCE");

                entity.Property(e => e.Np)
                    .HasColumnName("NP")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Ftime)
                    .HasColumnName("FTime")
                    .HasColumnType("datetime");

                entity.HasOne(d => d.NpNavigation)
                    .WithOne(p => p.Fixing)
                    .HasForeignKey<Fixing>(d => d.Np)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Fixing_BusInfo");
            });

            modelBuilder.Entity<History>(entity =>
            {
                entity.HasKey(e => e.Np)
                    .HasName("PK__History__3214D54FD756E6F6");

                entity.Property(e => e.Np)
                    .HasColumnName("NP")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.AverageSpeed)
                    .HasColumnName("Average_speed")
                    .HasComputedColumnSql("(([Max_speed]+[Min_Speed])/(2))");

                entity.Property(e => e.Management)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.MaxSpeed).HasColumnName("Max_speed");

                entity.Property(e => e.MinSpeed).HasColumnName("Min_speed");

                entity.Property(e => e.Time).HasColumnType("date");

                entity.HasOne(d => d.ManagementNavigation)
                    .WithMany(p => p.History)
                    .HasForeignKey(d => d.Management)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_History_Management");

                entity.HasOne(d => d.NpNavigation)
                    .WithOne(p => p.History)
                    .HasForeignKey<History>(d => d.Np)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_History_BusInfo");
            });

            modelBuilder.Entity<Insurance>(entity =>
            {
                entity.HasKey(e => e.Np)
                    .HasName("PK__Insuranc__3214D54F907B8347");

                entity.Property(e => e.Np)
                    .HasColumnName("NP")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Ifrom)
                    .HasColumnName("IFrom")
                    .HasColumnType("datetime");

                entity.Property(e => e.Ito)
                    .HasColumnName("ITo")
                    .HasColumnType("datetime");

                entity.HasOne(d => d.NpNavigation)
                    .WithOne(p => p.Insurance)
                    .HasForeignKey<Insurance>(d => d.Np)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Insurance_BusInfo");
            });

            modelBuilder.Entity<Maintain>(entity =>
            {
                entity.HasKey(e => e.Np)
                    .HasName("PK__Maintain__3214D54FC5C9160C");

                entity.Property(e => e.Np)
                    .HasColumnName("NP")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Info).HasMaxLength(100);

                entity.Property(e => e.LastTime).HasColumnType("datetime");

                entity.HasOne(d => d.NpNavigation)
                    .WithOne(p => p.Maintain)
                    .HasForeignKey<Maintain>(d => d.Np)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Maintain_BusInfo");
            });

            modelBuilder.Entity<Management>(entity =>
            {
                entity.HasKey(e => e.Name)
                    .HasName("PK__Manageme__737584F78DC84571");

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.Property(e => e.City)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.Info)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<Oil>(entity =>
            {
                entity.HasKey(e => e.Np)
                    .HasName("PK__Oil__3214D54F6E4F51AA");

                entity.Property(e => e.Np)
                    .HasColumnName("NP")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Info).HasMaxLength(100);

                entity.Property(e => e.Otime)
                    .HasColumnName("OTime")
                    .HasColumnType("datetime");

                entity.HasOne(d => d.NpNavigation)
                    .WithOne(p => p.Oil)
                    .HasForeignKey<Oil>(d => d.Np)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Oil_BusInfo");
            });

            modelBuilder.Entity<Owner>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Management)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(30);

                entity.Property(e => e.Phone)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Quit).HasColumnName("QUIT");

                entity.Property(e => e.Rfid)
                    .IsRequired()
                    .HasColumnName("RFID")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Sex)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.HasOne(d => d.ManagementNavigation)
                    .WithMany(p => p.Owner)
                    .HasForeignKey(d => d.Management)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Owner_Management");
            });

            modelBuilder.Entity<Register>(entity =>
            {
                entity.HasKey(e => e.Np)
                    .HasName("PK__Register__3214D54F8D9D8C14");

                entity.Property(e => e.Np)
                    .HasColumnName("NP")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Outdate).HasColumnType("datetime");

                entity.HasOne(d => d.NpNavigation)
                    .WithOne(p => p.Register)
                    .HasForeignKey<Register>(d => d.Np)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Register_BusInfo");
            });

            modelBuilder.Entity<Rfid>(entity =>
            {
                entity.HasKey(e => e.Rfid1)
                    .HasName("PK__RFID__4508DC09D1004813");

                entity.ToTable("RFID");

                entity.Property(e => e.Rfid1)
                    .HasColumnName("RFID")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Active).HasColumnType("datetime");

                entity.Property(e => e.Info)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Management)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.HasOne(d => d.ManagementNavigation)
                    .WithMany(p => p.Rfid)
                    .HasForeignKey(d => d.Management)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_RFID_Management");
            });

            modelBuilder.Entity<Stop>(entity =>
            {
                entity.HasKey(e => e.Sid)
                    .HasName("PK__Stop__CA195970C6D54D3A");

                entity.Property(e => e.Sid)
                    .HasColumnName("SID")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Addr)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Kind)
                    .IsRequired()
                    .HasMaxLength(30);

                entity.Property(e => e.Management)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Sname)
                    .IsRequired()
                    .HasColumnName("SName")
                    .HasMaxLength(50);

                entity.HasOne(d => d.ManagementNavigation)
                    .WithMany(p => p.Stop)
                    .HasForeignKey(d => d.Management)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Stop_Management");
            });

            modelBuilder.Entity<Users>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Account)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Addr)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.FullName)
                    .IsRequired()
                    .HasMaxLength(30);

                entity.Property(e => e.Management)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Pass)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.AccountNavigation)
                    .WithMany(p => p.Users)
                    .HasForeignKey(d => d.Account)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Users_Authorize");

                entity.HasOne(d => d.ManagementNavigation)
                    .WithMany(p => p.Users)
                    .HasForeignKey(d => d.Management)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Users_Management");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
