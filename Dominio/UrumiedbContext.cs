using System;
using System.Collections.Generic;
using Dominio.Controllers;
using Microsoft.EntityFrameworkCore;

public partial class UrumiedbContext : DbContext
{
    public UrumiedbContext(DbContextOptions<UrumiedbContext> options)
        : base(options)
    {

    }

    public DbSet<Usuario> Usuario { get; set; }
    public DbSet<Alquiler> Alquiler { get; set; }



    public UrumiedbContext()
    {
    }


    public virtual DbSet<Alquiler> Alquilers { get; set; }

    public virtual DbSet<Usuario> Usuarios { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseMySql("server=localhost;database=urumiedb;user=root;password=mysql", ServerVersion.Parse("8.0.35-mysql"));

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder
            .UseCollation("utf8mb4_0900_ai_ci")
            .HasCharSet("utf8mb4");

        modelBuilder.Entity<Alquiler>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("alquiler");
        });

     
        modelBuilder.Entity<Usuario>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("usuario");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
