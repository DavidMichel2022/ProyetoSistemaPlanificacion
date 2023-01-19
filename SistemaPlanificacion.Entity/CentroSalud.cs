using System;
using System.Collections.Generic;

namespace SistemaPlanificacion.Entity;

public partial class CentroSalud
{
    public string IdCentro { get; set; } = null!;

    public string? NombreCentro { get; set; }

    public DateTime? FechaRegistro { get; set; }

    public virtual ICollection<CabeceraCarpetaPlanificacion> CabeceraCarpetaPlanificacions { get; } = new List<CabeceraCarpetaPlanificacion>();
}
