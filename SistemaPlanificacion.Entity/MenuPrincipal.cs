using System;
using System.Collections.Generic;

namespace SistemaPlanificacion.Entity;

public partial class MenuPrincipal
{
    public int IdMenu { get; set; }

    public string? Descripcion { get; set; }

    public int? IdMenuPadre { get; set; }

    public string? Controlador { get; set; }

    public string? PaginaAccion { get; set; }

    public bool? Activo { get; set; }

    public DateTime? FechaRegistro { get; set; }

    public virtual ICollection<RolMenu> RolMenus { get; } = new List<RolMenu>();
}
