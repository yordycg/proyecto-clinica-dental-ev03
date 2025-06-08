using System;
using System.Collections.Generic;

namespace clinica_dental_ev03.Models;

public partial class Cita
{
    public int CitaId { get; set; }

    public string RunPaciente { get; set; } = null!;

    public int DentistaId { get; set; }

    public int EstadoId { get; set; }

    public DateOnly Fecha { get; set; }

    public TimeOnly Hora { get; set; }

    public virtual ICollection<CitaServicio> CitaServicios { get; set; } = new List<CitaServicio>();

    public virtual Dentista Dentista { get; set; } = null!;

    public virtual EstadoCitum Estado { get; set; } = null!;

    public virtual ICollection<Pago> Pagos { get; set; } = new List<Pago>();

    public virtual Paciente RunPacienteNavigation { get; set; } = null!;
}
