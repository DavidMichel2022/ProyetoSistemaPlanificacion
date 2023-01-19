using System;
using System.Collections.Generic;

namespace SistemaPlanificacion.Entity;

public partial class CabeceraCarpetaPlanificacion
{
    public int IdCarpPlanif { get; set; }

    public int? NroCarpPlanif { get; set; }

    public DateTime? FechaCarpPlanif { get; set; }

    public string? CodCertPoa { get; set; }

    public string? ReferenciaCarpPlanif { get; set; }

    public string? IdPrograma { get; set; }

    public string? IdActividad { get; set; }

    public string? IdCentro { get; set; }

    public float? MontoPoaCarpPlanif { get; set; }

    public float? MontoPlanifCarpPlanif { get; set; }

    public int? IdUsuario { get; set; }

    public bool? Anulado { get; set; }

    public string? UbicacionCarpPlanif { get; set; }

    public virtual CabeceraCarpetaCompra? CabeceraCarpetaCompra { get; set; }

    public virtual CabeceraCarpetaPresupuesto? CabeceraCarpetaPresupuesto { get; set; }

    public virtual CierreCarpeta? CierreCarpetum { get; set; }

    public virtual DetalleCarpetaPlanificacion? DetalleCarpetaPlanificacion { get; set; }

    public virtual Actividad? IdActividadNavigation { get; set; }

    public virtual CentroSalud? IdCentroNavigation { get; set; }

    public virtual Programa? IdProgramaNavigation { get; set; }

    public virtual Usuario? IdUsuarioNavigation { get; set; }
}
