using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApiAcademia.Context;
using Entidades;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace WebApiAcademia.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ComisionesController : ControllerBase
    {
        private readonly AcademiaContext _context;

        public ComisionesController(AcademiaContext context)
        {
            _context = context;
        }

        // GET: api/Comisiones
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Comision>>> GetComisiones(int? idPlanFilter = null, int? idMateriaFilter = null)
        {
            IQueryable<Comision> query = _context.Comisiones;
            if (query == null)
            {
                return NotFound();
            }
            if (idPlanFilter is not null)
            {
                query = query.Where(comision => comision.IdPlan == idPlanFilter);
            }
            if (idMateriaFilter is not null)
            {
                query = query.Where(comision => comision.IdMateria == idMateriaFilter);
            }
            return await query.ToListAsync();
        }

        // GET: api/Comisiones/5
        [HttpGet("idComision={idComision}&idPlan={idPlan}&idMateria={idMateria}")]
        public async Task<ActionResult<Comision>> GetComision(int idComision,int idPlan, int idMateria)
        {
          if (_context.Comisiones == null)
          {
              return NotFound();
          }
            var comision = await _context.Comisiones
                .Where(c => c.IdComision == idComision && c.IdPlan == idPlan && c.IdMateria == idMateria)
                .FirstOrDefaultAsync();

            if (comision == null)
            {
                return NotFound();
            }

            return comision;
        }

        // PUT: api/Comisiones/5
        [HttpPut("idComision={idComision}&idPlan={idPlan}&idMateria={idMateria}")]
        public async Task<IActionResult> PutComision(int idComision, int idPlan, int idMateria, Comision comision)
        {
            if (idComision != comision.IdComision || idPlan != comision.IdPlan || idMateria != comision.IdMateria)
            {
                return BadRequest();
            }

            _context.Entry(comision).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ComisionExists(idComision, idPlan, idMateria))
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

        // POST: api/Comisiones
        [HttpPost]
        public async Task<ActionResult<Comision>> PostComision(Comision comision)
        {
          if (_context.Comisiones == null)
          {
              return Problem("Entity set 'AcademiaContext.Comisiones'  is null.");
          }
            _context.Comisiones.Add(comision);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (ComisionExists(comision.IdComision,comision.IdPlan,comision.IdMateria))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetComision", new { idComision = comision.IdComision, idPlan = comision.IdPlan, idMateria = comision.IdMateria }, comision);
        }

        // DELETE: api/Comisiones/5
        [HttpDelete("idComision={idComision}&idPlan={idPlan}&idMateria={idMateria}")]
        public async Task<IActionResult> DeleteComision(int idComision, int idPlan, int idMateria)
        {
            if (_context.Comisiones == null)
            {
                return NotFound();
            }
            var comision = await _context.Comisiones
                .Where(c => c.IdComision == idComision && c.IdPlan == idPlan && c.IdMateria == idMateria)
                .FirstOrDefaultAsync();
            if (comision == null)
            {
                return NotFound();
            }

            _context.Comisiones.Remove(comision);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ComisionExists(int idComision, int idPlan, int idMateria)
        {
            return _context.Comisiones.Any(c => c.IdComision == idComision && c.IdPlan == idPlan && c.IdMateria == idMateria);
        }
    }
}
