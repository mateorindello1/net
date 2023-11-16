using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Entidades;

public partial class Plan
{
    [Key]
    public int IdPlan { get; set; }

    public string Descripcion { get; set; } = null!;

    public int IdEspecialidad { get; set; }

    public virtual ICollection<Comision>? Comisiones { get; set; } = null;

    public virtual Especialidad? IdEspecialidadNavigation { get; set; } = null;

    public virtual ICollection<Materia>? Materia { get; set; } = null;

    public virtual ICollection<Persona>? Personas { get; set; } = null;
}
