using System;
using System.Collections.Generic;

namespace Entidades;

public partial class Persona
{
    public int Legajo { get; set; }

    public string Nombre { get; set; } = null!;

    public string Apellido { get; set; } = null!;

    public string Direccion { get; set; } = null!;

    public string Email { get; set; } = null!;

    public string NombreUsuario { get; set; } = null!;

    public string Password { get; set; } = null!;

    public DateTime FechaNacimiento { get; set; }

    public string Telefono { get; set; } = null!;

    public int IdPlan { get; set; }

    public int TipoUsuario { get; set; }

    public virtual ICollection<Dictado> Dictados { get; set; } = new List<Dictado>();

    public virtual Plan IdPlanNavigation { get; set; } = null!;

    public virtual ICollection<Inscripcion> Inscripciones { get; set; } = new List<Inscripcion>();
}
