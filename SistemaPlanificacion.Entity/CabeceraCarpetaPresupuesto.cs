using System;
using System.Collections.Generic;

namespace SistemaPlanificacion.Entity;

public partial class CabeceraCarpetaPresupuesto
{
    public int IdCarpPlanif { get; set; }

    public int? NroCarpPlanif { get; set; }

    public string? CodCertPresup { get; set; }

    public string? IdPrograma { get; set; }

    public string? IdActividad { get; set; }

    public DateTime? FechaCarpPresup { get; set; }

    public float? MontoPresupCarpPresup { get; set; }

    public bool? Anulado { get; set; }

    public virtual CabeceraCarpetaPlanificacion IdCarpPlanifNavigation { get; set; } = null!;
}
