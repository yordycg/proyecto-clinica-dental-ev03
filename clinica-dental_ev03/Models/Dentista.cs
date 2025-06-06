using System;
using System.Collections.Generic;

namespace clinica_dental_ev03.Models;

public partial class Dentista
{
    public int DentistaId { get; set; }

    public string Nombre { get; set; } = null!;

    public string Apellido { get; set; } = null!;

    public string? Telefono { get; set; }

    public string? Correo { get; set; }

    public DateOnly? FechaRegistro { get; set; }

    public virtual ICollection<Cita> Cita { get; set; } = new List<Cita>();
}
