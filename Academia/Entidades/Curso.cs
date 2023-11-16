using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Entidades;

public partial class Curso
{
    [Key]
    public int IdComision { get; set; }
    [Key]
    public int IdPlan { get; set; }
    [Key]
    public int IdMateria { get; set; }
    [Key]
    public int Anio { get; set; }

    public int Cupo { get; set; }

    public virtual ICollection<Dictado>? Dictados { get; set; } = null;

    public virtual Comision? Id { get; set; } = null;

    public virtual ICollection<Inscripcion>? Inscripciones { get; set; } = null;
}
