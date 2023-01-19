using System;
using System.Collections.Generic;

namespace SistemaPlanificacion.Entity;

public partial class Actividad
{
    public string IdActividad { get; set; } = null!;

    public string? NombreActividad { get; set; }

    public DateTime? FechaRegistro { get; set; }

    public virtual ICollection<CabeceraCarpetaPlanificacion> CabeceraCarpetaPlanificacions { get; } = new List<CabeceraCarpetaPlanificacion>();
}
