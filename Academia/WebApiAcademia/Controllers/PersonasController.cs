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
    public class PersonasController : ControllerBase
    {
        private readonly AcademiaContext _context;
        const int alumno = 0;
        const int docente = 1;
        const int administrador = 2;

        public PersonasController(AcademiaContext context)
        {
            _context = context;
        }

        // GET: api/Personas
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Persona>>> GetPersonas(int? rol)
        {
          if (_context.Personas == null)
          {
              return NotFound();
          }
            if (rol is not null)
            {
                switch (rol)
                {
                    case administrador:
                    case docente:
                    case alumno:
                        return await _context.Personas.Where(u => u.TipoUsuario == rol).ToListAsync();
                    default:
                        return BadRequest();
                }
            } else return await _context.Personas.ToListAsync();

        }

        // GET: api/Personas/5
        [HttpGet("{legajo}")]
        public async Task<ActionResult<Persona>> GetPersona(int legajo, int? rol)
        {
          if (_context.Personas == null)
          {
              return NotFound();
          }
            Persona? persona;
            if (rol is not null)
            {
                switch (rol)
                {
                    case administrador:
                    case docente:
                    case alumno:
                        persona = await _context.Personas.Where(u => u.Legajo == legajo && u.TipoUsuario == rol).FirstOrDefaultAsync();
                        break;
                    default:
                        return BadRequest();
                }
            } else persona = await _context.Personas.FindAsync(legajo);

            if (persona is null) return NotFound();
            return persona;
        }

        // PUT: api/Personas/5
        [HttpPut("{legajo}")]
        public async Task<IActionResult> PutPersona(int legajo, Persona persona)
        {
            //_context.Entry(persona).Reference(p => p.IdPlanNavigation).Load();
            //_context.Entry(persona).Collection(p => p.Dictados).Load();
            //_context.Entry(persona).Collection(p => p.Inscripciones).Load();

            if (legajo != persona.Legajo)
            {
                return BadRequest();
            }

            _context.Entry(persona).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PersonaExists(legajo))
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

        // POST: api/Personas
        [HttpPost]
        public async Task<ActionResult<Persona>> PostPersona(Persona persona)
        {
          if (_context.Personas == null)
          {
              return Problem("Entity set 'AcademiaContext.Personas'  is null.");
          }
            _context.Personas.Add(persona);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetPersona", new { legajo = persona.Legajo }, persona);
        }

        // DELETE: api/Personas/5
        [HttpDelete("{legajo}")]
        public async Task<IActionResult> DeletePersona(int legajo)
        {
            if (_context.Personas == null)
            {
                return NotFound();
            }
            var persona = await _context.Personas.FindAsync(legajo);
            if (persona == null)
            {
                return NotFound();
            }

            _context.Personas.Remove(persona);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool PersonaExists(int legajo)
        {
            return (_context.Personas?.Any(e => e.Legajo == legajo)).GetValueOrDefault();
        }

        [HttpPost("autenticar")]
        public async Task<ActionResult<Persona>> AutenticarUsuario([FromBody] Credenciales credenciales)
        {
            var persona = await _context.Personas
                        .SingleOrDefaultAsync(x => x.NombreUsuario == credenciales.userName && x.Password == credenciales.password);
            return (persona is null ? Conflict("Credenciales incorrectas.") : persona);
        }

        [HttpPost("usuariodisponible")]
        public async Task<IActionResult> ValidarUsuarioDisponible([FromBody] string nombreUsuario)
        {
            var persona = await _context.Personas.SingleOrDefaultAsync(x => x.NombreUsuario == nombreUsuario);
            if (persona is null)
            {
                return Ok(true); // El nombre de usuario está disponible.
            }
            else
            {
                return Conflict("El nombre de usuario no está disponible."); // El nombre de usuario no está disponible.
            }
        }
    }
}
