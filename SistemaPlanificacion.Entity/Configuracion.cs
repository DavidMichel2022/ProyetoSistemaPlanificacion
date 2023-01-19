using System;
using System.Collections.Generic;

namespace SistemaPlanificacion.Entity;

public partial class Configuracion
{
    public string Recurso { get; set; } = null!;

    public string? Propiedad { get; set; }

    public int? Valor { get; set; }
}
