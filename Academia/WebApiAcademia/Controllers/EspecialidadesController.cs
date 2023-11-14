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
    public class EspecialidadesController : ControllerBase
    {
        private readonly AcademiaContext _context;

        public EspecialidadesController(AcademiaContext context)
        {
            _context = context;
        }

        // GET: api/Especialidades
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Especialidad>>> GetEspecialidades()
        {
          if (_context.Especialidades == null)
          {
              return NotFound();
          }
            return await _context.Especialidades.ToListAsync();
        }

        // GET: api/Especialidades/5
        [HttpGet("idEspecialidad={idEspecialidad}")]
        public async Task<ActionResult<Especialidad>> GetEspecialidad(int idEspecialidad)
        {
          if (_context.Especialidades == null)
          {
              return NotFound();
          }
            var especialidad = await _context.Especialidades.FindAsync(idEspecialidad);

            if (especialidad == null)
            {
                return NotFound();
            }

            return especialidad;
        }

        // PUT: api/Especialidades/5
        [HttpPut("idEspecialidad={idEspecialidad}")]
        public async Task<IActionResult> PutEspecialidad(int idEspecialidad, Especialidad especialidad)
        {
            if (idEspecialidad != especialidad.IdEspecialidad)
            {
                return BadRequest();
            }

            _context.Entry(especialidad).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EspecialidadExists(idEspecialidad))
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

        // POST: api/Especialidades
        [HttpPost]
        public async Task<ActionResult<Especialidad>> PostEspecialidad(Especialidad especialidad)
        {
          if (_context.Especialidades == null)
          {
              return Problem("Entity set 'AcademiaContext.Especialidades'  is null.");
          }
            _context.Especialidades.Add(especialidad);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetEspecialidad", new { idEspecialidad = especialidad.IdEspecialidad }, especialidad);
        }

        // DELETE: api/Especialidades/5
        [HttpDelete("idEspecialidad={idEspecialidad}")]
        public async Task<IActionResult> DeleteEspecialidad(int idEspecialidad)
        {
            if (_context.Especialidades == null)
            {
                return NotFound();
            }
            var especialidad = await _context.Especialidades.FindAsync(idEspecialidad);
            if (especialidad == null)
            {
                return NotFound();
            }

            _context.Especialidades.Remove(especialidad);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool EspecialidadExists(int idEspecialidad)
        {
            return (_context.Especialidades?.Any(e => e.IdEspecialidad == idEspecialidad)).GetValueOrDefault();
        }
    }
}
