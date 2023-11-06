using System;
using System.Collections.Generic;

namespace Entidades;

public partial class Especialidad
{
    public int IdEspecialidad { get; set; }

    public string Descripcion { get; set; } = null!;

    public virtual ICollection<Plan>? Planes { get; set; } = null;
}
