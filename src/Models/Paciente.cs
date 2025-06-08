using System;
using System.Collections.Generic;

namespace clinica_dental_ev03.Models;

public partial class Paciente
{
    public string Run { get; set; } = null!;

    public string Nombre { get; set; } = null!;

    public string Apellido { get; set; } = null!;

    public string Sexo { get; set; } = null!;

    public string? Telefono { get; set; }

    public string? Correo { get; set; }

    public DateOnly? FechaRegistro { get; set; }

    public virtual ICollection<Cita> Cita { get; set; } = new List<Cita>();
}
