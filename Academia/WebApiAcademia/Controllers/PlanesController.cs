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
    public class PlanesController : ControllerBase
    {
        private readonly AcademiaContext _context;

        public PlanesController(AcademiaContext context)
        {
            _context = context;
        }

        // GET: api/Planes
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Plan>>> GetPlanes()
        {
          if (_context.Planes == null)
          {
              return NotFound();
          }
            return await _context.Planes.ToListAsync();
        }

        // GET: api/Planes/5
        [HttpGet("idPlan={id}")]
        public async Task<ActionResult<Plan>> GetPlan(int idPlan)
        {
          if (_context.Planes == null)
          {
              return NotFound();
          }
            var plan = await _context.Planes.FindAsync(idPlan);

            if (plan == null)
            {
                return NotFound();
            }

            return plan;
        }

        // PUT: api/Planes/5
        [HttpPut("idPlan={id}")]
        public async Task<IActionResult> PutPlan(int idPlan, Plan plan)
        {
            if (idPlan != plan.IdPlan)
            {
                return BadRequest();
            }

            _context.Entry(plan).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PlanExists(idPlan))
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

        // POST: api/Planes
        [HttpPost]
        public async Task<ActionResult<Plan>> PostPlan(Plan plan)
        {
          if (_context.Planes == null)
          {
              return Problem("Entity set 'AcademiaContext.Planes'  is null.");
          }
            _context.Planes.Add(plan);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetPlan", new { idPlan = plan.IdPlan }, plan);
        }

        // DELETE: api/Planes/5
        [HttpDelete("idPlan={idPlan}")]
        public async Task<IActionResult> DeletePlan(int idPlan)
        {
            if (_context.Planes == null)
            {
                return NotFound();
            }
            var plan = await _context.Planes.FindAsync(idPlan);
            if (plan == null)
            {
                return NotFound();
            }

            _context.Planes.Remove(plan);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool PlanExists(int idPlan)
        {
            return (_context.Planes?.Any(e => e.IdPlan == idPlan)).GetValueOrDefault();
        }
    }
}
