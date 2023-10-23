using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApi.Models;

public partial class Alumno
{
    public Alumno(int id, string nombre, string apellido, int legajo, string email)
    {
        Id = id;
        Nombre = nombre;
        Apellido = apellido;
        Legajo = legajo;
        Email = email;
    }

    public override bool Equals(object obj)
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

    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }

    public string Nombre { get; set; } = null!;

    public string Apellido { get; set; } = null!;

    public int Legajo { get; set; }

    public string Email { get; set; } = null!;
}
