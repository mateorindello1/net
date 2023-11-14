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
    public class InscripcionesController : ControllerBase
    {
        private readonly AcademiaContext _context;

        public InscripcionesController(AcademiaContext context)
        {
            _context = context;
        }

        // GET: api/Inscripciones
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Inscripcion>>> GetInscripciones()
        {
            if (_context.Inscripciones == null)
            {
                return NotFound();
            }
            return await _context.Inscripciones.ToListAsync();
        }

        // GET: api/Inscripciones/1/2/3/2023/4
        [HttpGet("idAlumno={idAlumno}&idComision={idComision}&idPlan={idPlan}&idMateria={idMateria}&anio={anio}")]
        public async Task<ActionResult<Inscripcion>> GetInscripcion(int idAlumno, int idComision, int idPlan, int idMateria, int anio)
        {
            if (_context.Inscripciones == null)
            {
                return NotFound();
            }
            var inscripcion = await _context.Inscripciones
                .Where(i => i.IdAlumno == idAlumno && i.IdComision == idComision && i.IdPlan == idPlan && i.IdMateria == idMateria && i.Anio == anio)
                .FirstOrDefaultAsync();

            if (inscripcion == null)
            {
                return NotFound();
            }

            return inscripcion;
        }

        // PUT: api/Inscripciones/1/2/3/2023/4
        [HttpPut("idAlumno={idAlumno}&idComision={idComision}&idPlan={idPlan}&idMateria={idMateria}&anio={anio}")]
        public async Task<IActionResult> PutInscripcion(int idAlumno, int idComision, int idPlan, int idMateria, int anio, Inscripcion inscripcion)
        {
            if (idAlumno != inscripcion.IdAlumno || 
                idComision != inscripcion.IdComision || 
                idPlan != inscripcion.IdPlan || 
                idMateria != inscripcion.IdMateria || 
                anio != inscripcion.Anio)
            {
                return BadRequest();
            }

            _context.Entry(inscripcion).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!InscripcionExists(idAlumno, idComision, idPlan, idMateria, anio))
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

        // POST: api/Inscripciones
        [HttpPost]
        public async Task<ActionResult<Inscripcion>> PostInscripcion(Inscripcion inscripcion)
        {
            if (_context.Inscripciones == null)
            {
                return Problem("Entity set 'TuProyecto.Inscripciones' is null.");
            }
            _context.Inscripciones.Add(inscripcion);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (InscripcionExists(inscripcion.IdAlumno, inscripcion.IdComision, inscripcion.IdPlan, inscripcion.IdMateria, inscripcion.Anio))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetInscripcion", new { idAlumno = inscripcion.IdAlumno, idComision = inscripcion.IdComision, idPlan = inscripcion.IdPlan, idMateria = inscripcion.IdMateria, anio = inscripcion.Anio }, inscripcion);
        }

        // DELETE: api/Inscripciones/1/2/3/2023/4
        [HttpDelete("idAlumno={idAlumno}&idComision={idComision}&idPlan={idPlan}&idMateria={idMateria}&anio={anio}")]
        public async Task<IActionResult> DeleteInscripcion(int idAlumno, int idComision, int idPlan, int idMateria, int anio)
        {
            if (_context.Inscripciones == null)
            {
                return NotFound();
            }
            var inscripcion = await _context.Inscripciones
                .Where(i => i.IdAlumno == idAlumno && 
                            i.IdComision == idComision && 
                            i.IdPlan == idPlan && 
                            i.IdMateria == idMateria && 
                            i.Anio == anio)
                .FirstOrDefaultAsync();

            if (inscripcion == null)
            {
                return NotFound();
            }

            _context.Inscripciones.Remove(inscripcion);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool InscripcionExists(int idAlumno, int idComision, int idPlan, int idMateria, int anio)
        {
            return _context.Inscripciones.Any(i =>  i.IdAlumno == idAlumno && 
                                                    i.IdComision == idComision && 
                                                    i.IdPlan == idPlan && 
                                                    i.IdMateria == idMateria && 
                                                    i.Anio == anio);
        }
    }
}
