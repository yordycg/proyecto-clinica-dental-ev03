using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace clinica_dental_ev03.Models;

public partial class ClinicaDentalDbContext : DbContext
{
    public ClinicaDentalDbContext()
    {
    }

    public ClinicaDentalDbContext(DbContextOptions<ClinicaDentalDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Cita> Citas { get; set; }

    public virtual DbSet<Dentista> Dentistas { get; set; }

    public virtual DbSet<DetalleCitum> DetalleCita { get; set; }

    public virtual DbSet<Paciente> Pacientes { get; set; }

    public virtual DbSet<Pago> Pagos { get; set; }

    public virtual DbSet<Servicio> Servicios { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=localhost\\SQLEXPRESS;Database=clinicaDentalDB;Trusted_Connection=True;TrustServerCertificate=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Cita>(entity =>
        {
            entity.HasKey(e => e.CitaId).HasName("PK__citas__5AC1B05BA08B06BE");

            entity.ToTable("citas");

            entity.Property(e => e.CitaId).HasColumnName("cita_id");
            entity.Property(e => e.DentistaId).HasColumnName("dentista_id");
            entity.Property(e => e.Estado)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("estado");
            entity.Property(e => e.Fecha).HasColumnName("fecha");
            entity.Property(e => e.Hora).HasColumnName("hora");
            entity.Property(e => e.RunPaciente)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("run_paciente");

            entity.HasOne(d => d.Dentista).WithMany(p => p.Cita)
                .HasForeignKey(d => d.DentistaId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__citas__dentista___5629CD9C");

            entity.HasOne(d => d.RunPacienteNavigation).WithMany(p => p.Cita)
                .HasForeignKey(d => d.RunPaciente)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__citas__run_pacie__5535A963");
        });

        modelBuilder.Entity<Dentista>(entity =>
        {
            entity.HasKey(e => e.DentistaId).HasName("PK__dentista__EA14642BEE766E0D");

            entity.ToTable("dentistas");

            entity.Property(e => e.DentistaId).HasColumnName("dentista_id");
            entity.Property(e => e.Apellido)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("apellido");
            entity.Property(e => e.Correo)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("correo");
            entity.Property(e => e.FechaRegistro)
                .HasDefaultValueSql("(getdate())")
                .HasColumnName("fecha_registro");
            entity.Property(e => e.Nombre)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("nombre");
            entity.Property(e => e.Telefono)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("telefono");
        });

        modelBuilder.Entity<DetalleCitum>(entity =>
        {
            entity.HasKey(e => e.DetalleCitaId).HasName("PK__detalle___250F2C2F8F246A77");

            entity.ToTable("detalle_cita");

            entity.Property(e => e.DetalleCitaId).HasColumnName("detalle_cita_id");
            entity.Property(e => e.CitaId).HasColumnName("cita_id");
            entity.Property(e => e.ServicioId).HasColumnName("servicio_id");

            entity.HasOne(d => d.Cita).WithMany(p => p.DetalleCita)
                .HasForeignKey(d => d.CitaId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__detalle_c__cita___5EBF139D");

            entity.HasOne(d => d.Servicio).WithMany(p => p.DetalleCita)
                .HasForeignKey(d => d.ServicioId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__detalle_c__servi__5FB337D6");
        });

        modelBuilder.Entity<Paciente>(entity =>
        {
            entity.HasKey(e => e.Run).HasName("PK__paciente__C2B74E6D3858E69C");

            entity.ToTable("pacientes");

            entity.Property(e => e.Run)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("run");
            entity.Property(e => e.Apellido)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("apellido");
            entity.Property(e => e.Correo)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("correo");
            entity.Property(e => e.FechaRegistro)
                .HasDefaultValueSql("(getdate())")
                .HasColumnName("fecha_registro");
            entity.Property(e => e.Nombre)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("nombre");
            entity.Property(e => e.Sexo)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("sexo");
            entity.Property(e => e.Telefono)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("telefono");
        });

        modelBuilder.Entity<Pago>(entity =>
        {
            entity.HasKey(e => e.PagoId).HasName("PK__pagos__FFF0A58EF780251A");

            entity.ToTable("pagos");

            entity.Property(e => e.PagoId).HasColumnName("pago_id");
            entity.Property(e => e.CitaId).HasColumnName("cita_id");
            entity.Property(e => e.EstadoPago)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("estado_pago");
            entity.Property(e => e.Fecha)
                .HasColumnType("datetime")
                .HasColumnName("fecha");
            entity.Property(e => e.MetodoPago)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("metodo_pago");
            entity.Property(e => e.Monto).HasColumnName("monto");

            entity.HasOne(d => d.Cita).WithMany(p => p.Pagos)
                .HasForeignKey(d => d.CitaId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__pagos__cita_id__5BE2A6F2");
        });

        modelBuilder.Entity<Servicio>(entity =>
        {
            entity.HasKey(e => e.ServicioId).HasName("PK__servicio__AF3A090C3B2BCE68");

            entity.ToTable("servicios");

            entity.HasIndex(e => e.Nombre, "UQ__servicio__72AFBCC6C207DD2C").IsUnique();

            entity.Property(e => e.ServicioId).HasColumnName("servicio_id");
            entity.Property(e => e.Costo).HasColumnName("costo");
            entity.Property(e => e.Duracion).HasColumnName("duracion");
            entity.Property(e => e.Nombre)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("nombre");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
