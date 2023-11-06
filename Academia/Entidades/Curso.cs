using System;
using System.Collections.Generic;

namespace Entidades;

public partial class Curso
{
    public int IdComision { get; set; }

    public int IdPlan { get; set; }

    public int IdMateria { get; set; }

    public int Anio { get; set; }

    public int Cupo { get; set; }

    public virtual ICollection<Dictado> Dictados { get; set; } = new List<Dictado>();

    public virtual Comision Id { get; set; } = null!;

    public virtual ICollection<Inscripcion> Inscripciones { get; set; } = new List<Inscripcion>();
}
