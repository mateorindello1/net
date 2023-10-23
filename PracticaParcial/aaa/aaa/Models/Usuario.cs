using System;
using System.Collections.Generic;

namespace WebApi.Models;

public partial class Usuario
{

    public Usuario(string nombreUsuario, string clave, int tipoUsuario, string email)
    {
        this.NombreUsuario = nombreUsuario;
        this.Clave = clave;
        this.TipoUsuario = tipoUsuario;
        this.Email = email;
        this.UltimoIngreso = DateTime.Now;
    }
    public bool SameFields(object obj)
    {
        if (obj is Usuario other)
        {
            return
                NombreUsuario == other.NombreUsuario &&
                Clave == other.Clave &&
                TipoUsuario == other.TipoUsuario &&
                Email == other.Email;
        }

        return false;
    }

    public string NombreUsuario { get; set; } = null!;

    public string Clave { get; set; } = null!;

    public int TipoUsuario { get; set; }

    public string Email { get; set; } = null!;

    public DateTime? UltimoIngreso { get; set; }
}
