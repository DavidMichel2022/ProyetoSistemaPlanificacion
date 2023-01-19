using System;
using System.Collections.Generic;

namespace SistemaPlanificacion.Entity;

public partial class PartidaPresupuestaria
{
    public int IdPartida { get; set; }

    public string? NombrePartida { get; set; }

    public DateTime? FechaRegistro { get; set; }

    public virtual ICollection<DetalleCarpetaPlanificacion> DetalleCarpetaPlanificacions { get; } = new List<DetalleCarpetaPlanificacion>();
}
