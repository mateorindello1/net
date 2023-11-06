using System;
using System.Collections.Generic;

namespace Entidades;

public partial class Inscripcion
{
    public int IdAlumno { get; set; }

    public int IdComision { get; set; }

    public int IdPlan { get; set; }

    public int IdMateria { get; set; }

    public int Anio { get; set; }

    public string Condicion { get; set; } = null!;

    public int? Nota { get; set; }

    public virtual Curso? Curso { get; set; } = null;

    public virtual Persona? IdAlumnoNavigation { get; set; } = null;
}
