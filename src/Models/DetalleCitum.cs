using System;
using System.Collections.Generic;

namespace clinica_dental_ev03.Models;

public partial class DetalleCitum
{
    public int DetalleCitaId { get; set; }

    public int CitaId { get; set; }

    public int ServicioId { get; set; }

    public virtual Cita Cita { get; set; } = null!;

    public virtual Servicio Servicio { get; set; } = null!;
}
