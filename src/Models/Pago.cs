using System;
using System.Collections.Generic;

namespace clinica_dental_ev03.Models;

public partial class Pago
{
    public int PagoId { get; set; }

    public int CitaId { get; set; }

    public int Monto { get; set; }

    public DateTime Fecha { get; set; }

    public string MetodoPago { get; set; } = null!;

    public string EstadoPago { get; set; } = null!;

    public virtual Cita Cita { get; set; } = null!;
}
