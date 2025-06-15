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

    public virtual DbSet<DetalleCitum> DetalleCita { get; set; }

    public virtual DbSet<Empleado> Empleados { get; set; }

    public virtual DbSet<Paciente> Pacientes { get; set; }

    public virtual DbSet<Pago> Pagos { get; set; }

    public virtual DbSet<Servicio> Servicios { get; set; }

    public virtual DbSet<TiposEmpleado> TiposEmpleados { get; set; }

    public virtual DbSet<Usuario> Usuarios { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=localhost\\SQLEXPRESS;Database=clinicaDentalDB;Trusted_Connection=True;TrustServerCertificate=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Cita>(entity =>
        {
            entity.HasKey(e => e.CitaId).HasName("PK__citas__5AC1B05BCCD8C50E");

            entity.ToTable("citas");

            entity.Property(e => e.CitaId).HasColumnName("cita_id");
            entity.Property(e => e.CreadoPor)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("creado_por");
            entity.Property(e => e.DentistaId)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("dentista_id");
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

            entity.HasOne(d => d.CreadoPorNavigation).WithMany(p => p.CitaCreadoPorNavigations)
                .HasForeignKey(d => d.CreadoPor)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__citas__creado_po__4E88ABD4");

            entity.HasOne(d => d.Dentista).WithMany(p => p.CitaDentista)
                .HasForeignKey(d => d.DentistaId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__citas__dentista___4D94879B");

            entity.HasOne(d => d.RunPacienteNavigation).WithMany(p => p.Cita)
                .HasForeignKey(d => d.RunPaciente)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__citas__run_pacie__4CA06362");
        });

        modelBuilder.Entity<DetalleCitum>(entity =>
        {
            entity.HasKey(e => e.DetalleCitaId).HasName("PK__detalle___250F2C2F6FD53828");

            entity.ToTable("detalle_cita");

            entity.Property(e => e.DetalleCitaId).HasColumnName("detalle_cita_id");
            entity.Property(e => e.CitaId).HasColumnName("cita_id");
            entity.Property(e => e.ServicioId).HasColumnName("servicio_id");

            entity.HasOne(d => d.Cita).WithMany(p => p.DetalleCita)
                .HasForeignKey(d => d.CitaId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__detalle_c__cita___5165187F");

            entity.HasOne(d => d.Servicio).WithMany(p => p.DetalleCita)
                .HasForeignKey(d => d.ServicioId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__detalle_c__servi__52593CB8");
        });

        modelBuilder.Entity<Empleado>(entity =>
        {
            entity.HasKey(e => e.Run).HasName("PK__empleado__C2B74E6D6AD00120");

            entity.ToTable("empleados");

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
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("sexo");
            entity.Property(e => e.Telefono)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("telefono");
            entity.Property(e => e.TipoEmpleadoId).HasColumnName("tipo_empleado_id");

            entity.HasOne(d => d.TipoEmpleado).WithMany(p => p.Empleados)
                .HasForeignKey(d => d.TipoEmpleadoId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__empleados__tipo___403A8C7D");
        });

        modelBuilder.Entity<Paciente>(entity =>
        {
            entity.HasKey(e => e.Run).HasName("PK__paciente__C2B74E6D6796BA3F");

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
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("sexo");
            entity.Property(e => e.Telefono)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("telefono");
        });

        modelBuilder.Entity<Pago>(entity =>
        {
            entity.HasKey(e => e.PagoId).HasName("PK__pagos__FFF0A58E3E77E1DC");

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
                .HasConstraintName("FK__pagos__cita_id__5812160E");
        });

        modelBuilder.Entity<Servicio>(entity =>
        {
            entity.HasKey(e => e.ServicioId).HasName("PK__servicio__AF3A090C410E6D0F");

            entity.ToTable("servicios");

            entity.HasIndex(e => e.Nombre, "UQ__servicio__72AFBCC6BC4785E4").IsUnique();

            entity.Property(e => e.ServicioId).HasColumnName("servicio_id");
            entity.Property(e => e.Costo).HasColumnName("costo");
            entity.Property(e => e.Duracion).HasColumnName("duracion");
            entity.Property(e => e.Nombre)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("nombre");
        });

        modelBuilder.Entity<TiposEmpleado>(entity =>
        {
            entity.HasKey(e => e.TipoId).HasName("PK__tipos_em__6EA5A01B023A666A");

            entity.ToTable("tipos_empleados");

            entity.HasIndex(e => e.Nombre, "UQ__tipos_em__72AFBCC61593AB20").IsUnique();

            entity.Property(e => e.TipoId).HasColumnName("tipo_id");
            entity.Property(e => e.Nombre)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("nombre");
        });

        modelBuilder.Entity<Usuario>(entity =>
        {
            entity.HasKey(e => e.UsuarioId).HasName("PK__usuarios__2ED7D2AF55E6CAEF");

            entity.ToTable("usuarios");

            entity.HasIndex(e => e.Nombre, "UQ__usuarios__72AFBCC6A69422A1").IsUnique();

            entity.Property(e => e.UsuarioId).HasColumnName("usuario_id");
            entity.Property(e => e.EmpleadoRun)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("empleado_run");
            entity.Property(e => e.FechaRegistro)
                .HasDefaultValueSql("(getdate())")
                .HasColumnName("fecha_registro");
            entity.Property(e => e.Nombre)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("nombre");
            entity.Property(e => e.Password)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("password");

            entity.HasOne(d => d.EmpleadoRunNavigation).WithMany(p => p.Usuarios)
                .HasForeignKey(d => d.EmpleadoRun)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__usuarios__emplea__44FF419A");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
