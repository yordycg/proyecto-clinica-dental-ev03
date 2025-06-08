using System;
using System.Collections.Generic;

namespace clinica_dental_ev03.Models;

public partial class Servicio
{
    public int ServicioId { get; set; }

    public string Nombre { get; set; } = null!;

    public int Costo { get; set; }

    public int Duracion { get; set; }

    public virtual ICollection<CitaServicio> CitaServicios { get; set; } = new List<CitaServicio>();
}
