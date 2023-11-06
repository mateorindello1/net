using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Entidades;

public partial class Comision
{
    [Key]
    public int IdComision { get; set; }
    [Key]
    public int IdPlan { get; set; }
    [Key]
    public int IdMateria { get; set; }

    public string Descripcion { get; set; } = null!;

    public int AnioEspecialidad { get; set; }

    public virtual ICollection<Curso>? Cursos { get; set; } = null;

    public virtual Materia? IdMateriaNavigation { get; set; } = null;

    public virtual Plan? IdPlanNavigation { get; set; } = null;
}
