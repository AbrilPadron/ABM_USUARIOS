using System;
using System.Collections.Generic;
using ABM_USUARIOS.Models;
using Microsoft.EntityFrameworkCore;

namespace ABM_USUARIOS.Data;

public partial class AbmUsuariosContext : DbContext
{
    public AbmUsuariosContext()
    {
    }

    public AbmUsuariosContext(DbContextOptions<AbmUsuariosContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Usuario> Usuarios { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) { }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Usuario>(entity =>
        {
            entity.HasKey(e => e.IdUsuario).HasName("PK__USUARIO__91136B90A77ACE69");

            entity.ToTable("USUARIO");

            entity.HasIndex(e => e.Email, "UQ__USUARIO__161CF7249B1A302B").IsUnique();

            entity.HasIndex(e => e.Usuario1, "UQ__USUARIO__E251F484E9CBD4AA").IsUnique();

            entity.Property(e => e.IdUsuario).HasColumnName("ID_USUARIO");
            entity.Property(e => e.Apellido)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("APELLIDO");
            entity.Property(e => e.Ciudad)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CIUDAD");
            entity.Property(e => e.CodPostal)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("COD_POSTAL");
            entity.Property(e => e.Contraseña)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CONTRASEÑA");
            entity.Property(e => e.Direccion)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("DIRECCION");
            entity.Property(e => e.Email)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("EMAIL");
            entity.Property(e => e.FechaNac)
                .HasColumnType("datetime")
                .HasColumnName("FECHA_NAC");
            entity.Property(e => e.Nombre)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("NOMBRE");
            entity.Property(e => e.Telefono)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("TELEFONO");
            entity.Property(e => e.Usuario1)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("USUARIO");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
