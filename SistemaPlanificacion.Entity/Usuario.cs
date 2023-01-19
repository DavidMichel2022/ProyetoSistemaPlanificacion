using System;
using System.Collections.Generic;

namespace SistemaPlanificacion.Entity;

public partial class Usuario
{
    public int IdUsuario { get; set; }

    public string? NombreUsuario { get; set; }

    public string? ClaveUsuario { get; set; }

    public string? CarnetUsuario { get; set; }

    public string? CargoUsuario { get; set; }

    public string? ProfesionUsuario { get; set; }

    public string? MailUsuario { get; set; }

    public DateTime? FechaRegistro { get; set; }

    public int? IdRol { get; set; }

    public bool? ActivoUsuario { get; set; }

    public virtual ICollection<CabeceraCarpetaPlanificacion> CabeceraCarpetaPlanificacions { get; } = new List<CabeceraCarpetaPlanificacion>();
}
