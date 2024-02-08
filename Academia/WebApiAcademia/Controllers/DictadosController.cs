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
    public class DictadosController : ControllerBase
    {
        private readonly AcademiaContext _context;

        public DictadosController(AcademiaContext context)
        {
            _context = context;
        }

        // GET: api/Dictados
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Dictado>>> GetDictados(int? idPlanFilter = null, int? idMateriaFilter = null, int? idComisionFilter = null, int? anioFilter = null)
        {
            IQueryable<Dictado> query = _context.Dictados;
            query = query.Include(d => d.IdDocenteNavigation);
            if (query == null) return NotFound();
            if (idPlanFilter is not null) query = query.Where(dictado => dictado.IdPlan == idPlanFilter);
            if (idMateriaFilter is not null) query = query.Where(dictado => dictado.IdMateria == idMateriaFilter);
            if (idComisionFilter is not null) query = query.Where(dictado => dictado.IdComision == idComisionFilter);
            if (anioFilter is not null) query = query.Where(dictado => dictado.Anio == anioFilter);
            return await query.ToListAsync();
        }

        // GET: api/Dictados/5
        [HttpGet("idComision={idComision}&idPlan{idPlan}&idMateria={idMateria}&anio={anio}&idDocente={idDocente}")]
        public async Task<ActionResult<Dictado>> GetDictado(int idComision, int idPlan, int idMateria, int anio, int idDocente)
        {
            if (_context.Dictados == null)
            {
                return NotFound();
            }
            _context.Dictados.Include(d => d.IdDocenteNavigation);
            var dictado = await _context.Dictados
                .Where(c => c.IdComision == idComision && 
                            c.IdPlan == idPlan && 
                            c.IdMateria == idMateria && 
                            c.Anio == anio &&
                            c.IdDocente == idDocente)
                    .FirstOrDefaultAsync(); 
            if (dictado == null)
            {
                return NotFound();
            }

            return dictado;
        }

        // PUT: api/Dictados/5
        [HttpPut("idComision={idComision}&idPlan{idPlan}&idMateria={idMateria}&anio={anio}&idDocente={idDocente}")]
        public async Task<IActionResult> PutDictado(int idComision, int idPlan, int idMateria, int anio, int idDocente, Dictado dictado)
        {
            if (idComision != dictado.IdComision || 
                idPlan != dictado.IdPlan || 
                idMateria != dictado.IdMateria || 
                anio != dictado.Anio || 
                idDocente != dictado.IdDocente)
            {
                return BadRequest();
            }

            _context.Entry(dictado).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!DictadoExists(idComision, idPlan, idMateria, anio, idDocente))
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

        // POST: api/Dictados
        [HttpPost]
        public async Task<ActionResult<Dictado>> PostDictado(Dictado dictado)
        {
            if (_context.Dictados == null)
            {
                return Problem("Entity set 'AcademiaContext.Dictados'  is null.");
            }
            _context.Dictados.Add(dictado);
            await _context.SaveChangesAsync();
            //try
            //{
            //    await _context.SaveChangesAsync();
            //}
            //catch (DbUpdateException)
            //{
            //    if (DictadoExists(dictado.IdComision, dictado.IdPlan, dictado.IdMateria, dictado.Anio, dictado.IdDocente))
            //    {
            //        return Conflict();
            //    }
            //    else
            //    {
            //        throw;
            //    }
            //}

            return CreatedAtAction("GetDictado", new { idComision = dictado.IdComision, idPlan = dictado.IdPlan, idMateria = dictado.IdMateria, anio = dictado.Anio, idDocente = dictado.IdDocente }, dictado);
        }

        // DELETE: api/Dictados/5
        [HttpDelete("idComision={idComision}&idPlan{idPlan}&idMateria={idMateria}&anio={anio}&idDocente={idDocente}")]
        public async Task<IActionResult> DeleteDictado(int idComision, int idPlan, int idMateria, int anio, int idDocente)
        {
            if (_context.Dictados == null)
            {
                return NotFound();
            }
            var dictado = await _context.Dictados
                .Where(d => d.IdComision == idComision && 
                            d.IdPlan == idPlan && 
                            d.IdMateria == idMateria && 
                            d.Anio == anio && 
                            d.IdDocente == idDocente)
                .FirstOrDefaultAsync();
            if (dictado == null)
            {
                return NotFound();
            }

            _context.Dictados.Remove(dictado);
            await _context.SaveChangesAsync();

            return NoContent();
        }
        [HttpPost("GroupCreate")]
        public async Task<ActionResult<IEnumerable<Dictado>>> PostDictados(IEnumerable<Dictado> dictados)
        {
            if (_context.Dictados == null)
            {
                return Problem("Entity set 'AcademiaContext.Dictados' is null.");
            }

            _context.Dictados.AddRange(dictados);

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                // Puedes manejar conflictos o excepciones específicas aquí si es necesario
                return Conflict();
            }

            return CreatedAtAction("GetDictados", dictados);
        }

        private bool DictadoExists(int idComision, int idPlan, int idMateria, int anio, int idDocente)
        {
            return _context.Dictados.Any(d => d.IdComision == idComision && d.IdPlan == idPlan && d.IdMateria == idMateria && d.Anio == anio && d.IdDocente == idDocente);
        }
    }
}
