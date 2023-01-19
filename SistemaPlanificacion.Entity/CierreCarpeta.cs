using System;
using System.Collections.Generic;

namespace SistemaPlanificacion.Entity;

public partial class CierreCarpeta
{
    public int IdCarpPlanif { get; set; }

    public int? NroCarpPlanif { get; set; }

    public string? PartPresuCarpeta { get; set; }

    public float? SaldoFinal { get; set; }

    public string? TipoCierre { get; set; }

    public DateTime? FechaRegistro { get; set; }

    public bool? Anulado { get; set; }

    public virtual CabeceraCarpetaPlanificacion IdCarpPlanifNavigation { get; set; } = null!;
}
