using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApi.Context;
using WebApi.Models;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AlumnosController : ControllerBase
    {
        private readonly DbExamenContext _context;

        public AlumnosController(DbExamenContext context)
        {
            _context = context;
        }

        // GET: api/Alumnos
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Alumno>>> GetAlumnos(string? apellidoFilter="")
        {
          if (_context.Alumnos == null)
          {
              return NotFound();
          }
            if (!string.IsNullOrEmpty(apellidoFilter))
            {
                return await _context.Alumnos.Where(u => u.Apellido.StartsWith(apellidoFilter)).ToListAsync();
            }
                return await _context.Alumnos.ToListAsync();
        }

        // GET: api/Alumnos/5
        [HttpGet("{legajo}")]
        public async Task<ActionResult<Alumno>> GetAlumno(int legajo)
        {
          if (_context.Alumnos == null)
          {
              return NotFound();
          }
            var alumno = await _context.Alumnos.FindAsync(legajo);

            if (alumno == null)
            {
                return NotFound();
            }

            return alumno;
        }

        // PUT: api/Alumnos/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{legajo}")]
        public async Task<IActionResult> PutAlumno(int legajo, Alumno alumno)
        {
            if (legajo != alumno.Legajo)
            {
                return BadRequest();
            }

            _context.Entry(alumno).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!AlumnoExists(legajo))
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

        // POST: api/Alumnos
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Alumno>> PostAlumno(Alumno alumno)
        {
            if (_context.Alumnos == null)
            {
                return Problem("Entity set 'DbExamenContext.Alumnos'  is null.");
            }
            _context.Alumnos.Add(alumno);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (AlumnoExists(alumno.Legajo))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetAlumno", new { id = alumno.Legajo }, alumno);
        }

        // DELETE: api/Alumnos/5
        [HttpDelete("{legajo}")]
        public async Task<IActionResult> DeleteAlumno(int legajo)
        {
            if (_context.Alumnos == null)
            {
                return NotFound();
            }
            var alumno = await _context.Alumnos.FindAsync(legajo);
            if (alumno == null)
            {
                return NotFound();
            }

            _context.Alumnos.Remove(alumno);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool AlumnoExists(int legajo)
        {
            return (_context.Alumnos?.Any(e => e.Legajo == legajo)).GetValueOrDefault();
        }
    }
}
