using System;
using System.Collections.Generic;

namespace SistemaPlanificacion.Entity;

public partial class RolMenu
{
    public int IdRolMenu { get; set; }

    public int? IdRol { get; set; }

    public int? IdMenu { get; set; }

    public bool? Activo { get; set; }

    public DateTime? FechaRegistro { get; set; }

    public virtual MenuPrincipal? IdMenuNavigation { get; set; }

    public virtual RolGeneral? IdRolNavigation { get; set; }
}
