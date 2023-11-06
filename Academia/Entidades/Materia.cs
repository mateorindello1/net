using System;
using System.Collections.Generic;

namespace Entidades;

public partial class Materia
{
    public int IdMateria { get; set; }

    public string Nombre { get; set; } = null!;

    public string Descripcion { get; set; } = null!;

    public float HsSemanales { get; set; }

    public int HsTotales { get; set; }

    public int IdPlan { get; set; }

    public virtual ICollection<Comision>? Comisiones { get; set; } = null;

    public virtual Plan? IdPlanNavigation { get; set; } = null;
}
