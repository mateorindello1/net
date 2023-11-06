using System;
using System.Collections.Generic;

namespace Entidades;

public partial class Plan
{
    public int IdPlan { get; set; }

    public string Descripcion { get; set; } = null!;

    public int IdEspecialidad { get; set; }

    public virtual ICollection<Comision> Comisiones { get; set; } = new List<Comision>();

    public virtual Especialidad IdEspecialidadNavigation { get; set; } = null!;

    public virtual ICollection<Materia> Materia { get; set; } = new List<Materia>();

    public virtual ICollection<Persona> Personas { get; set; } = new List<Persona>();
}
