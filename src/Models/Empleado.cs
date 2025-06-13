using System;
using System.Collections.Generic;

namespace clinica_dental_ev03.ModelsTemp;

public partial class Empleado
{
    public string Run { get; set; } = null!;

    public string Nombre { get; set; } = null!;

    public string Apellido { get; set; } = null!;

    public int TipoEmpleadoId { get; set; }

    public string Sexo { get; set; } = null!;

    public string? Telefono { get; set; }

    public string? Correo { get; set; }

    public DateOnly? FechaRegistro { get; set; }

    public virtual ICollection<Cita> CitaCreadoPorNavigations { get; set; } = new List<Cita>();

    public virtual ICollection<Cita> CitaDentista { get; set; } = new List<Cita>();

    public virtual TiposEmpleado TipoEmpleado { get; set; } = null!;

    public virtual ICollection<Usuario> Usuarios { get; set; } = new List<Usuario>();
}
