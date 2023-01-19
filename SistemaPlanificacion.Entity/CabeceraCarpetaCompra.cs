using System;
using System.Collections.Generic;

namespace SistemaPlanificacion.Entity;

public partial class CabeceraCarpetaCompra
{
    public int IdCarpPlanif { get; set; }

    public int? NroCarpPlanif { get; set; }

    public string? CuceCarpCompra { get; set; }

    public string? ObjContratoCarpCompra { get; set; }

    public string? ModalidadCarpCompra { get; set; }

    public DateTime? FechaCarpCompra { get; set; }

    public string? NroFacturaCarpCompra { get; set; }

    public float? MontoAdjuCarpCompra { get; set; }

    public DateTime? FechaBienContratado { get; set; }

    public bool? Anulado { get; set; }

    public virtual CabeceraCarpetaPlanificacion IdCarpPlanifNavigation { get; set; } = null!;
}
