using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace koi.respositories.Entities;

public partial class KoiFishManagementDbContext : DbContext
{
    public KoiFishManagementDbContext()
    {
    }

    public KoiFishManagementDbContext(DbContextOptions<KoiFishManagementDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Article> Articles { get; set; }

    public virtual DbSet<FeedCalculation> FeedCalculations { get; set; }

    public virtual DbSet<Fish> Fish { get; set; }

    public virtual DbSet<Order> Orders { get; set; }

    public virtual DbSet<Pond> Ponds { get; set; }

    public virtual DbSet<Product> Products { get; set; }

    public virtual DbSet<SaltCalculation> SaltCalculations { get; set; }

    public virtual DbSet<WaterParameter> WaterParameters { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=LAPTOP-BS6BM33C\\SQLEXPRESS;Initial Catalog=KoiFishManagementDB;Integrated Security=True;Trust Server Certificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Article>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Articles__3214EC07EAC07DC3");

            entity.Property(e => e.PublicationDate).HasColumnType("datetime");
            entity.Property(e => e.Title).HasMaxLength(100);
        });

        modelBuilder.Entity<FeedCalculation>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__FeedCalc__3214EC0750EE492F");

            entity.Property(e => e.Amount).HasColumnType("decimal(5, 2)");
            entity.Property(e => e.FeedingDate).HasColumnType("datetime");

            entity.HasOne(d => d.Fish).WithMany(p => p.FeedCalculations)
                .HasForeignKey(d => d.FishId)
                .HasConstraintName("FK__FeedCalcu__FishI__3F466844");
        });

        modelBuilder.Entity<Fish>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Fish__3214EC07CD2E07C2");

            entity.Property(e => e.BodyShape).HasMaxLength(50);
            entity.Property(e => e.Breed).HasMaxLength(50);
            entity.Property(e => e.Gender).HasMaxLength(10);
            entity.Property(e => e.Image).HasMaxLength(255);
            entity.Property(e => e.Name).HasMaxLength(100);
            entity.Property(e => e.Origin).HasMaxLength(100);
            entity.Property(e => e.Price).HasColumnType("decimal(10, 2)");
            entity.Property(e => e.Size).HasColumnType("decimal(5, 2)");
            entity.Property(e => e.Weight).HasColumnType("decimal(5, 2)");

            entity.HasOne(d => d.Pond).WithMany(p => p.Fish)
                .HasForeignKey(d => d.PondId)
                .HasConstraintName("FK__Fish__PondId__398D8EEE");
        });

        modelBuilder.Entity<Order>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Orders__3214EC079AE6CB2A");

            entity.Property(e => e.OrderDate).HasColumnType("datetime");

            entity.HasOne(d => d.Product).WithMany(p => p.Orders)
                .HasForeignKey(d => d.ProductId)
                .HasConstraintName("FK__Orders__ProductI__46E78A0C");
        });

        modelBuilder.Entity<Pond>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Ponds__3214EC07E3E2BA40");

            entity.Property(e => e.Depth).HasColumnType("decimal(5, 2)");
            entity.Property(e => e.Image).HasMaxLength(255);
            entity.Property(e => e.Name).HasMaxLength(100);
            entity.Property(e => e.PumpCapacity).HasColumnType("decimal(5, 2)");
            entity.Property(e => e.Size).HasColumnType("decimal(5, 2)");
            entity.Property(e => e.Volume).HasColumnType("decimal(5, 2)");
        });

        modelBuilder.Entity<Product>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Products__3214EC076DC64E6E");

            entity.Property(e => e.Description).HasMaxLength(255);
            entity.Property(e => e.Name).HasMaxLength(100);
            entity.Property(e => e.Price).HasColumnType("decimal(10, 2)");
        });

        modelBuilder.Entity<SaltCalculation>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__SaltCalc__3214EC07C32474BA");

            entity.Property(e => e.Amount).HasColumnType("decimal(5, 2)");
            entity.Property(e => e.CalculationDate).HasColumnType("datetime");

            entity.HasOne(d => d.Pond).WithMany(p => p.SaltCalculations)
                .HasForeignKey(d => d.PondId)
                .HasConstraintName("FK__SaltCalcu__PondI__4222D4EF");
        });

        modelBuilder.Entity<WaterParameter>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__WaterPar__3214EC072CC80B5B");

            entity.Property(e => e.MeasurementDate).HasColumnType("datetime");
            entity.Property(e => e.No2)
                .HasColumnType("decimal(5, 2)")
                .HasColumnName("NO2");
            entity.Property(e => e.No3)
                .HasColumnType("decimal(5, 2)")
                .HasColumnName("NO3");
            entity.Property(e => e.O2).HasColumnType("decimal(5, 2)");
            entity.Property(e => e.Ph)
                .HasColumnType("decimal(5, 2)")
                .HasColumnName("PH");
            entity.Property(e => e.Po4)
                .HasColumnType("decimal(5, 2)")
                .HasColumnName("PO4");
            entity.Property(e => e.Salt).HasColumnType("decimal(5, 2)");
            entity.Property(e => e.Temperature).HasColumnType("decimal(5, 2)");

            entity.HasOne(d => d.Pond).WithMany(p => p.WaterParameters)
                .HasForeignKey(d => d.PondId)
                .HasConstraintName("FK__WaterPara__PondI__3C69FB99");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
