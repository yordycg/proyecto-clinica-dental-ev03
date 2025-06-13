using System;
using System.Collections.Generic;

namespace clinica_dental_ev03.ModelsTemp;

public partial class Usuario
{
    public int UsuarioId { get; set; }

    public string EmpleadoRun { get; set; } = null!;

    public string Nombre { get; set; } = null!;

    public string Password { get; set; } = null!;

    public DateOnly? FechaRegistro { get; set; }

    public virtual Empleado EmpleadoRunNavigation { get; set; } = null!;
}
