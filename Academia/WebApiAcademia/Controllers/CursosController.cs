using System;
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
        public async Task<ActionResult<IEnumerable<Curso>>> GetCursos(int? idPlanFilter = null, int? idMateriaFilter = null, int? idComisionFilter = null)
        {
            IQueryable<Curso> query = _context.Cursos;
            if (query == null)
            {
                return NotFound();
            }
            if (idPlanFilter is not null)
            {
                query = query.Where(curso => curso.IdPlan == idPlanFilter);
            }
            if (idMateriaFilter is not null)
            {
                query = query.Where(curso => curso.IdMateria == idMateriaFilter);
            }
            if (idComisionFilter is not null)
            {
                query = query.Where(curso => curso.IdComision == idComisionFilter);
            }
            return await query.ToListAsync();
        }

        // GET: api/Cursos/5
        [HttpGet("idComision={idComision}&idPlan={idPlan}&idMateria={idMateria}&anio={anio}")]
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
        [HttpPut("idComision={idComision}&idPlan={idPlan}&idMateria={idMateria}&anio={anio}")]
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
        [HttpDelete("idComision={idComision}&idPlan={idPlan}&idMateria={idMateria}&anio={anio}")]
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
