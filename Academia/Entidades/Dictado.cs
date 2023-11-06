using System;
using System.Collections.Generic;

namespace Entidades;

public partial class Dictado
{
    public int IdComision { get; set; }

    public int IdPlan { get; set; }

    public int IdMateria { get; set; }

    public int Anio { get; set; }

    public int IdDocente { get; set; }

    public string? Cargo { get; set; }

    public virtual Curso? Curso { get; set; } = null;

    public virtual Persona? IdDocenteNavigation { get; set; } = null;
}
