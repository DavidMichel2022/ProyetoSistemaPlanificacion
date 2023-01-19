using System;
using System.Collections.Generic;

namespace SistemaPlanificacion.Entity;

public partial class Programa
{
    public string IdPrograma { get; set; } = null!;

    public string? NombrePrograma { get; set; }

    public DateTime? FechaRegistro { get; set; }

    public virtual ICollection<CabeceraCarpetaPlanificacion> CabeceraCarpetaPlanificacions { get; } = new List<CabeceraCarpetaPlanificacion>();
}
