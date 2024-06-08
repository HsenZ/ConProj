using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using WinFormsApp1.Repositories.Models;

namespace WinFormsApp1.Repositories;

public partial class InvEntities : DbContext
{
    public InvEntities()
    {
    }

    public InvEntities(DbContextOptions<InvEntities> options)
        : base(options)
    {
    }

    public virtual DbSet<ImageAndFp> ImageAndFps { get; set; }

    public virtual DbSet<ImageFace> ImageFaces { get; set; }

    public virtual DbSet<ImageFp> ImageFps { get; set; }

    public virtual DbSet<Invest> Invests { get; set; }

    public virtual DbSet<Invperson> Invpersons { get; set; }

    public virtual DbSet<Nation> Nations { get; set; }

    public virtual DbSet<Vehicle> Vehicles { get; set; }

    public virtual DbSet<Village> Villages { get; set; }

    public virtual DbSet<Worldkey> Worldkeys { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer(" Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=ThisProjDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<ImageAndFp>(entity =>
        {
            entity.HasKey(e => new { e.Serial, e.Serpers }).HasName("PK__ImageAnd__C87A60D58C749A6E");
        });

        modelBuilder.Entity<ImageFace>(entity =>
        {
            entity.HasKey(e => new { e.Serial, e.Serpers }).HasName("PK__ImageFac__52B352DE7AE93A87");
        });

        modelBuilder.Entity<ImageFp>(entity =>
        {
            entity.HasKey(e => new { e.Serial, e.Serpers }).HasName("PK__ImageFP__52B352DEBE3964BB");
        });

        modelBuilder.Entity<Invest>(entity =>
        {
            entity.HasKey(e => e.Serial).HasName("PK__INVEST__1CE6D4E686948906");

            entity.Property(e => e.Serial).ValueGeneratedNever();
        });

        modelBuilder.Entity<Invperson>(entity =>
        {
            entity.HasKey(e => new { e.Serial, e.Serpers }).HasName("PK__invperso__52B352DE4A195307");
        });

        modelBuilder.Entity<Nation>(entity =>
        {
            entity.HasKey(e => e.Code).HasName("PK__nations__AA1D43787AAB3A04");

            entity.Property(e => e.Code).ValueGeneratedNever();
        });

        modelBuilder.Entity<Vehicle>(entity =>
        {
            entity.HasKey(e => e.Vid).HasName("PK__vehicles__DDB00C7D982B0C2B");

            entity.Property(e => e.Vid).ValueGeneratedNever();
        });

        modelBuilder.Entity<Village>(entity =>
        {
            entity.HasKey(e => e.Code).HasName("PK__Village__AA1D4378ED70E3AB");

            entity.Property(e => e.Code).ValueGeneratedNever();
            entity.Property(e => e.Label).IsFixedLength();
        });

        modelBuilder.Entity<Worldkey>(entity =>
        {
            entity.HasKey(e => e.Code).HasName("PK__worldkey__AA1D43787A1409B4");

            entity.Property(e => e.Code).ValueGeneratedNever();
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
