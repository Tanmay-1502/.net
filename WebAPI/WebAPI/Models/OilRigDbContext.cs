﻿using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace WebAPI.Models;

public partial class OilRigDbContext : DbContext
{
    public OilRigDbContext()
    {
    }

    public OilRigDbContext(DbContextOptions<OilRigDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Alert> Alerts { get; set; }

    public virtual DbSet<Issue> Issues { get; set; }

    public virtual DbSet<OilRig> OilRigs { get; set; }

    public virtual DbSet<User> Users { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseNpgsql("name=PostGre");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Alert>(entity =>
        {
            entity.HasKey(e => e.AlertId).HasName("Alert_pkey");

            entity.HasOne(d => d.Rig).WithMany(p => p.Alerts)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FKRigId");
        });

        modelBuilder.Entity<Issue>(entity =>
        {
            entity.HasKey(e => e.IssueId).HasName("Issue_pkey");

            entity.HasOne(d => d.Alert).WithMany(p => p.Issues)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FKAlertId");

            entity.HasOne(d => d.Rig).WithMany(p => p.Issues)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FKRigId");

            entity.HasOne(d => d.User).WithMany(p => p.Issues)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FKUserId");
        });

        modelBuilder.Entity<OilRig>(entity =>
        {
            entity.HasKey(e => e.RigId).HasName("OilRig_pkey");
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.HasKey(e => e.UserId).HasName("User_pkey");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
