﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApiAcademia.Context;
using Entidades;

namespace WebApiAcademia.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CursosController : ControllerBase
    {
        private readonly AcademiaContext _context;

        public CursosController(AcademiaContext context)
        {
            _context = context;
        }

        // GET: api/Cursos
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Curso>>> GetCursos()
        {
          if (_context.Cursos == null)
          {
              return NotFound();
          }
            return await _context.Cursos.ToListAsync();
        }

        // GET: api/Cursos/5
        [HttpGet("{idComision}/{idPlan}/{idMateria}/{anio}")]
        public async Task<ActionResult<Curso>> GetCurso(int idComision, int idPlan, int idMateria, int anio)
        {
          if (_context.Cursos == null)
          {
              return NotFound();
          }
            var curso = await _context.Cursos
                .Where(c => c.IdComision == idComision && c.IdPlan == idPlan && c.IdMateria == idMateria && c.Anio == anio)
                .FirstOrDefaultAsync();

            if (curso == null)
            {
                return NotFound();
            }

            return curso;
        }

        // PUT: api/Cursos/5
        [HttpPut("{idComision}/{idPlan}/{idMateria}/{anio}")]
        public async Task<IActionResult> PutCurso(int idComision, int idPlan, int idMateria, int anio, Curso curso)
        {
            if (idComision != curso.IdComision || idPlan != curso.IdPlan || idMateria != curso.IdMateria || anio != curso.Anio)
            {
                return BadRequest();
            }

            _context.Entry(curso).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CursoExists(idComision, idPlan, idMateria, anio))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Cursos
        [HttpPost]
        public async Task<ActionResult<Curso>> PostCurso(Curso curso)
        {
          if (_context.Cursos == null)
          {
              return Problem("Entity set 'AcademiaContext.Cursos'  is null.");
          }
            _context.Cursos.Add(curso);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (CursoExists(curso.IdComision, curso.IdPlan, curso.IdMateria, curso.Anio))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetCurso", new { idComision = curso.IdComision, idPlan = curso.IdPlan, idMateria = curso.IdMateria, anio = curso.Anio }, curso);
        }

        // DELETE: api/Cursos/5
        [HttpDelete("{idComision}/{idPlan}/{idMateria}/{anio}")]
        public async Task<IActionResult> DeleteCurso(int idComision, int idPlan, int idMateria, int anio)
        {
            if (_context.Cursos == null)
            {
                return NotFound();
            }
            var curso = await _context.Cursos
                .Where(c => c.IdComision == idComision && c.IdPlan == idPlan && c.IdMateria == idMateria && c.Anio == anio)
                .FirstOrDefaultAsync();
            if (curso == null)
            {
                return NotFound();
            }

            _context.Cursos.Remove(curso);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool CursoExists(int idComision, int idPlan, int idMateria, int anio)
        {
            return _context.Cursos.Any(c => c.IdComision == idComision && c.IdPlan == idPlan && c.IdMateria == idMateria && c.Anio == anio);
        }
    }
}
