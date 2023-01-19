using System;
using System.Collections.Generic;

namespace SistemaPlanificacion.Entity;

public partial class DetalleCarpetaPlanificacion
{
    public int IdCarpPlanif { get; set; }

    public int? NroCarpPlanif { get; set; }

    public int? IdPartida { get; set; }

    public string? NombreItemCarpeta { get; set; }

    public float? MontoPoa { get; set; }

    public float? MontoPlanif { get; set; }

    public float? MontoPresup { get; set; }

    public float? MontoCompra { get; set; }

    public int? IdEmpresa { get; set; }

    public bool? Anulado { get; set; }

    public virtual CabeceraCarpetaPlanificacion IdCarpPlanifNavigation { get; set; } = null!;

    public virtual Empresa? IdEmpresaNavigation { get; set; }

    public virtual PartidaPresupuestaria? IdPartidaNavigation { get; set; }
}
