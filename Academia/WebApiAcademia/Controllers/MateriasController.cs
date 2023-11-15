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
    public class MateriasController : ControllerBase
    {
        private readonly AcademiaContext _context;

        public MateriasController(AcademiaContext context)
        {
            _context = context;
        }

        // GET: api/Materias
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Materia>>> GetMaterias(int? idPlan=null)
        {
          if (_context.Materias == null)
          {
              return NotFound();
          }
          if (idPlan is null) { return await _context.Materias.ToListAsync(); }
          else return await _context.Materias.Where(m => m.IdPlan == idPlan).ToListAsync();

        }

        // GET: api/Materias/5
        [HttpGet("idMateria={idMateria}")]
        public async Task<ActionResult<Materia>> GetMateria(int idMateria)
        {
          if (_context.Materias == null)
          {
              return NotFound();
          }
            var materia = await _context.Materias.FindAsync(idMateria);

            if (materia == null)
            {
                return NotFound();
            }

            return materia;
        }

        // PUT: api/Materias/5
        [HttpPut("idMateria={idMateria}")]
        public async Task<IActionResult> PutMateria(int idMateria, Materia materia)
        {
            if (idMateria != materia.IdMateria)
            {
                return BadRequest();
            }

            _context.Entry(materia).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!MateriaExists(idMateria))
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

        // POST: api/Materias
        [HttpPost]
        public async Task<ActionResult<Materia>> PostMateria(Materia materia)
        {
          if (_context.Materias == null)
          {
              return Problem("Entity set 'AcademiaContext.Materias'  is null.");
          }
            _context.Materias.Add(materia);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetMateria", new { idMateria = materia.IdMateria }, materia);
        }

        // DELETE: api/Materias/5
        [HttpDelete("idMateria={idMateria}")]
        public async Task<IActionResult> DeleteMateria(int idMateria)
        {
            if (_context.Materias == null)
            {
                return NotFound();
            }
            var materia = await _context.Materias.FindAsync(idMateria);
            if (materia == null)
            {
                return NotFound();
            }

            _context.Materias.Remove(materia);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool MateriaExists(int idMateria)
        {
            return (_context.Materias?.Any(e => e.IdMateria == idMateria)).GetValueOrDefault();
        }
    }
}
