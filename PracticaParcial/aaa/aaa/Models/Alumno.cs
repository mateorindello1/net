using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApi.Models;

public partial class Alumno
{
    [Key]
    public int Legajo { get; set; }

    public string Nombre { get; set; } = null!;

    public string Apellido { get; set; } = null!;

    public string Email { get; set; } = null!;

    public Alumno(int legajo, string nombre, string apellido, string email)
    {
        Nombre = nombre;
        Apellido = apellido;
        Legajo = legajo;
        Email = email;
    }

    public bool SameFields(object obj)
    {
        if (obj is Alumno other)
        {
            return
                Nombre == other.Nombre &&
                Apellido == other.Apellido &&
                Legajo == other.Legajo &&
                Email == other.Email;
        }

        return false;
    }
}