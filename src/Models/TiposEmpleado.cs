using System;
using System.Collections.Generic;

namespace clinica_dental_ev03.Models;

public partial class TiposEmpleado
{
    public int TipoId { get; set; }

    public string Nombre { get; set; } = null!;

    public virtual ICollection<Empleado> Empleados { get; set; } = new List<Empleado>();
}
