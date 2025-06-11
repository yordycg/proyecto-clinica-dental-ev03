using System;
using System.Collections.Generic;

namespace clinica_dental_ev03.Models;

public partial class Cita
{
    public int CitaId { get; set; }

    public string RunPaciente { get; set; } = null!;

    public string DentistaId { get; set; } = null!;

    public string Estado { get; set; } = null!;

    public DateOnly Fecha { get; set; }

    public TimeOnly Hora { get; set; }

    public string CreadoPor { get; set; } = null!;

    public virtual Empleado CreadoPorNavigation { get; set; } = null!;

    public virtual Empleado Dentista { get; set; } = null!;

    public virtual ICollection<DetalleCitum> DetalleCita { get; set; } = new List<DetalleCitum>();

    public virtual ICollection<Pago> Pagos { get; set; } = new List<Pago>();

    public virtual Paciente RunPacienteNavigation { get; set; } = null!;
}
