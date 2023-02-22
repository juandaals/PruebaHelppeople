using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace prueba_intento2.Models;

public partial class BolsaEmpleoDbContext : DbContext
{


    public BolsaEmpleoDbContext(DbContextOptions<BolsaEmpleoDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Ciudadano> Ciudadanos { get; set; }

    public virtual DbSet<Vacante> Vacantes { get; set; }


    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Ciudadano>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Ciudadan__3213E83FA8F5F38B");

            entity.HasIndex(e => e.Cedula, "UQ__Ciudadan__415B7BE59C157493").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Apellido)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("apellido");
            entity.Property(e => e.AspiracionSalarial).HasColumnName("aspiracionSalarial");
            entity.Property(e => e.Cedula)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("cedula");
            entity.Property(e => e.Correo)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("correo");
            entity.Property(e => e.FechaNacimiento)
                .HasColumnType("datetime")
                .HasColumnName("fechaNacimiento");
            entity.Property(e => e.Nombre)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("nombre");
            entity.Property(e => e.Profesion)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("profesion");
            entity.Property(e => e.TipoDocumento).HasColumnName("tipoDocumento");
        });

        modelBuilder.Entity<Vacante>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Vacantes__3213E83FB91D139D");

            entity.HasIndex(e => e.Codigo, "UQ__Vacantes__40F9A206EFAA7786").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Cargo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("cargo");
            entity.Property(e => e.CiudadanoId).HasColumnName("ciudadanoId");
            entity.Property(e => e.Codigo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("codigo");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(300)
                .IsUnicode(false)
                .HasColumnName("descripcion");
            entity.Property(e => e.Empresa)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("empresa");
            entity.Property(e => e.Salario).HasColumnName("salario");

            entity.HasOne(d => d.Ciudadano).WithMany(p => p.Vacantes)
                .HasForeignKey(d => d.CiudadanoId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_Ciudadano_Vacantes");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
