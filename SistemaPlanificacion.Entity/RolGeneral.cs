using System;
using System.Collections.Generic;

namespace SistemaPlanificacion.Entity;

public partial class RolGeneral
{
    public int IdRol { get; set; }

    public string? Descripcion { get; set; }

    public bool? Activo { get; set; }

    public DateTime? FechaRegistro { get; set; }

    public virtual ICollection<RolMenu> RolMenus { get; } = new List<RolMenu>();
}
