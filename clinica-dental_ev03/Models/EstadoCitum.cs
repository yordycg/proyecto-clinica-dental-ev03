using System;
using System.Collections.Generic;

namespace clinica_dental_ev03.Models;

public partial class EstadoCitum
{
    public int EstadoId { get; set; }

    public string Nombre { get; set; } = null!;

    public virtual ICollection<Cita> Cita { get; set; } = new List<Cita>();
}
