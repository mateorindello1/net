using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Entidades;

namespace WebApiAcademia.Context;

public partial class AcademiaContext : DbContext
{
    public AcademiaContext()
    {
    }

    public AcademiaContext(DbContextOptions<AcademiaContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Comision> Comisiones { get; set; }

    public virtual DbSet<Curso> Cursos { get; set; }

    public virtual DbSet<Dictado> Dictados { get; set; }

    public virtual DbSet<Especialidad> Especialidades { get; set; }

    public virtual DbSet<Inscripcion> Inscripciones { get; set; }

    public virtual DbSet<Materia> Materias { get; set; }

    public virtual DbSet<Persona> Personas { get; set; }

    public virtual DbSet<Plan> Planes { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlServer("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Dell\\Downloads\\academia.mdf;Integrated Security=True;Connect Timeout=30");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Comision>(entity =>
        {
            entity.HasKey(e => new { e.IdComision, e.IdPlan, e.IdMateria }).HasName("PK_comision_idComision");

            entity.ToTable("comision", "academia");

            entity.HasIndex(e => e.IdMateria, "fk_comision_materia_idx");

            entity.HasIndex(e => e.IdPlan, "fk_comision_plan_idx");

            entity.Property(e => e.IdComision).HasColumnName("idComision");
            entity.Property(e => e.IdPlan).HasColumnName("idPlan");
            entity.Property(e => e.IdMateria).HasColumnName("idMateria");
            entity.Property(e => e.AnioEspecialidad).HasColumnName("anioEspecialidad");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(100)
                .HasColumnName("descripcion");

            entity.HasOne(d => d.IdMateriaNavigation).WithMany(p => p.Comisiones)
                .HasForeignKey(d => d.IdMateria)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("comision$fk_comision_materia");

            entity.HasOne(d => d.IdPlanNavigation).WithMany(p => p.Comisiones)
                .HasForeignKey(d => d.IdPlan)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("comision$fk_comision_plan");
        });

        modelBuilder.Entity<Curso>(entity =>
        {
            entity.HasKey(e => new { e.IdComision, e.IdPlan, e.IdMateria, e.Anio }).HasName("PK_curso_idComision");

            entity.ToTable("curso", "academia");

            entity.Property(e => e.IdComision).HasColumnName("idComision");
            entity.Property(e => e.IdPlan).HasColumnName("idPlan");
            entity.Property(e => e.IdMateria).HasColumnName("idMateria");
            entity.Property(e => e.Anio).HasColumnName("anio");
            entity.Property(e => e.Cupo).HasColumnName("cupo");

            entity.HasOne(d => d.Id).WithMany(p => p.Cursos)
                .HasForeignKey(d => new { d.IdComision, d.IdPlan, d.IdMateria })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("curso$fk_curso_comision");
        });

        modelBuilder.Entity<Dictado>(entity =>
        {
            entity.HasKey(e => new { e.IdComision, e.IdPlan, e.IdMateria, e.Anio, e.IdDocente }).HasName("PK_dictado_idComision");

            entity.ToTable("dictado", "academia");

            entity.HasIndex(e => e.IdDocente, "fk_dictado_docente_idx");

            entity.Property(e => e.IdComision).HasColumnName("idComision");
            entity.Property(e => e.IdPlan).HasColumnName("idPlan");
            entity.Property(e => e.IdMateria).HasColumnName("idMateria");
            entity.Property(e => e.Anio).HasColumnName("anio");
            entity.Property(e => e.IdDocente).HasColumnName("idDocente");
            entity.Property(e => e.Cargo)
                .HasMaxLength(50)
                .HasColumnName("cargo");

            entity.HasOne(d => d.IdDocenteNavigation).WithMany(p => p.Dictados)
                .HasForeignKey(d => d.IdDocente)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("dictado$fk_dictado_docente");

            entity.HasOne(d => d.Curso).WithMany(p => p.Dictados)
                .HasForeignKey(d => new { d.IdComision, d.IdPlan, d.IdMateria, d.Anio })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("dictado$fk_dictado_curso");
        });

        modelBuilder.Entity<Especialidad>(entity =>
        {
            entity.HasKey(e => e.IdEspecialidad).HasName("PK_especialidad_idEspecialidad");

            entity.ToTable("especialidad", "academia");

            entity.Property(e => e.IdEspecialidad).HasColumnName("idEspecialidad");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(100)
                .HasColumnName("descripcion");
        });

        modelBuilder.Entity<Inscripcion>(entity =>
        {
            entity.HasKey(e => new { e.IdAlumno, e.IdComision, e.IdPlan, e.IdMateria, e.Anio }).HasName("PK_inscripcion_idAlumno");

            entity.ToTable("inscripcion", "academia");

            entity.HasIndex(e => new { e.IdComision, e.IdPlan, e.IdMateria, e.Anio }, "fk_inscripcion_curso_idx");

            entity.Property(e => e.IdAlumno).HasColumnName("idAlumno");
            entity.Property(e => e.IdComision).HasColumnName("idComision");
            entity.Property(e => e.IdPlan).HasColumnName("idPlan");
            entity.Property(e => e.IdMateria).HasColumnName("idMateria");
            entity.Property(e => e.Anio).HasColumnName("anio");
            entity.Property(e => e.Condicion)
                .HasMaxLength(20)
                .HasColumnName("condicion");
            entity.Property(e => e.Nota).HasColumnName("nota");

            entity.HasOne(d => d.IdAlumnoNavigation).WithMany(p => p.Inscripciones)
                .HasForeignKey(d => d.IdAlumno)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("inscripcion$fk_inscripcion_alumno");

            entity.HasOne(d => d.Curso).WithMany(p => p.Inscripciones)
                .HasForeignKey(d => new { d.IdComision, d.IdPlan, d.IdMateria, d.Anio })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("inscripcion$fk_inscripcion_curso");
        });

        modelBuilder.Entity<Materia>(entity =>
        {
            entity.HasKey(e => e.IdMateria).HasName("PK_materia_idMateria");

            entity.ToTable("materia", "academia");

            entity.HasIndex(e => e.IdPlan, "fk_materia_plan_idx");

            entity.Property(e => e.IdMateria).HasColumnName("idMateria");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(100)
                .HasColumnName("descripcion");
            entity.Property(e => e.HsSemanales).HasColumnName("hsSemanales");
            entity.Property(e => e.HsTotales).HasColumnName("hsTotales");
            entity.Property(e => e.IdPlan).HasColumnName("idPlan");
            entity.Property(e => e.Nombre)
                .HasMaxLength(50)
                .HasColumnName("nombre");

            entity.HasOne(d => d.IdPlanNavigation).WithMany(p => p.Materia)
                .HasForeignKey(d => d.IdPlan)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("materia$fk_materia_plan");
        });

        modelBuilder.Entity<Persona>(entity =>
        {
            entity.HasKey(e => e.Legajo).HasName("PK_persona_legajo");

            entity.ToTable("persona", "academia");

            entity.HasIndex(e => e.IdPlan, "fk_persona_plan_idx");

            entity.HasIndex(e => e.NombreUsuario, "persona$nombreUsuario_UNIQUE").IsUnique();

            entity.Property(e => e.Legajo).HasColumnName("legajo");
            entity.Property(e => e.Apellido)
                .HasMaxLength(50)
                .HasColumnName("apellido");
            entity.Property(e => e.Direccion)
                .HasMaxLength(100)
                .HasColumnName("direccion");
            entity.Property(e => e.Email)
                .HasMaxLength(100)
                .HasColumnName("email");
            entity.Property(e => e.FechaNacimiento)
                .HasColumnType("date")
                .HasColumnName("fechaNacimiento");
            entity.Property(e => e.IdPlan).HasColumnName("idPlan");
            entity.Property(e => e.Nombre)
                .HasMaxLength(50)
                .HasColumnName("nombre");
            entity.Property(e => e.NombreUsuario)
                .HasMaxLength(20)
                .HasColumnName("nombreUsuario");
            entity.Property(e => e.Password)
                .HasMaxLength(20)
                .HasColumnName("password");
            entity.Property(e => e.Telefono)
                .HasMaxLength(20)
                .HasColumnName("telefono");
            entity.Property(e => e.TipoUsuario).HasColumnName("tipoUsuario");

            entity.HasOne(d => d.IdPlanNavigation).WithMany(p => p.Personas)
                .HasForeignKey(d => d.IdPlan)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("persona$fk_persona_plan");
        });

        modelBuilder.Entity<Plan>(entity =>
        {
            entity.HasKey(e => e.IdPlan).HasName("PK_plan_idPlan");

            entity.ToTable("plan", "academia");

            entity.HasIndex(e => e.IdEspecialidad, "fk_plan_especialidad_idx");

            entity.Property(e => e.IdPlan).HasColumnName("idPlan");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(100)
                .HasColumnName("descripcion");
            entity.Property(e => e.IdEspecialidad).HasColumnName("idEspecialidad");

            entity.HasOne(d => d.IdEspecialidadNavigation).WithMany(p => p.Planes)
                .HasForeignKey(d => d.IdEspecialidad)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("plan$fk_plan_especialidad");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
