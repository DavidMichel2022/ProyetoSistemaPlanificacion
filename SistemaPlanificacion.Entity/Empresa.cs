using System;
using System.Collections.Generic;

namespace SistemaPlanificacion.Entity;

public partial class Empresa
{
    public int IdEmpresa { get; set; }

    public string? NombreEmpresa { get; set; }

    public DateTime? FechaRegistro { get; set; }

    public virtual ICollection<DetalleCarpetaPlanificacion> DetalleCarpetaPlanificacions { get; } = new List<DetalleCarpetaPlanificacion>();
}
