using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Entidades;

public partial class Dictado
{
    [Key]
    public int IdComision { get; set; }
    [Key]
    public int IdPlan { get; set; }
    [Key]
    public int IdMateria { get; set; }
    [Key]
    public int Anio { get; set; }
    [Key]
    public int IdDocente { get; set; }

    public string? Cargo { get; set; }

    public virtual Curso? Curso { get; set; } = null;

    public virtual Persona? IdDocenteNavigation { get; set; } = null;
}
