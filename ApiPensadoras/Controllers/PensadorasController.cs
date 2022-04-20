#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ApiPensadoras.Context;
using ApiPensadoras.Models;

namespace ApiPensadoras.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PensadorasController : ControllerBase
    {
        private readonly ApiPensadorasDbContext _context;

        public PensadorasController(ApiPensadorasDbContext context)
        {
            _context = context;
        }

        // GET: api/Pensadoras
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Pensadora>>> GetPensadoras()
        {
            return await _context.Pensadoras.ToListAsync();
        }

        // GET: api/Pensadoras/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Pensadora>> GetPensadora(int id)
        {
            var pensadora = await _context.Pensadoras.FindAsync(id);

            if (pensadora == null)
            {
                return NotFound();
            }

            return pensadora;
        }

        // PUT: api/Pensadoras/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutPensadora(int id, Pensadora pensadora)
        {
            if (id != pensadora.PensadoraId)
            {
                return BadRequest();
            }

            _context.Entry(pensadora).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PensadoraExists(id))
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

        // POST: api/Pensadoras
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Pensadora>> PostPensadora(Pensadora pensadora)
        {
            _context.Pensadoras.Add(pensadora);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetPensadora", new { id = pensadora.PensadoraId }, pensadora);
        }

        // DELETE: api/Pensadoras/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePensadora(int id)
        {
            var pensadora = await _context.Pensadoras.FindAsync(id);
            if (pensadora == null)
            {
                return NotFound();
            }

            _context.Pensadoras.Remove(pensadora);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool PensadoraExists(int id)
        {
            return _context.Pensadoras.Any(e => e.PensadoraId == id);
        }
    }
}
