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
    public class FrasesController : ControllerBase
    {
        private readonly ApiPensadorasDbContext _context;

        public FrasesController(ApiPensadorasDbContext context)
        {
            _context = context;
        }

        // GET: api/Frases
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Frase>>> GetFrases()
        {
            return await _context.Frases.ToListAsync();
        }

        // GET: api/Frases/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Frase>> GetFrase(int id)
        {
            var frase = await _context.Frases.FindAsync(id);

            if (frase == null)
            {
                return NotFound();
            }

            return frase;
        }

        // PUT: api/Frases/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutFrase(int id, Frase frase)
        {
            if (id != frase.FraseId)
            {
                return BadRequest();
            }

            _context.Entry(frase).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!FraseExists(id))
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

        // POST: api/Frases
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Frase>> PostFrase(Frase frase)
        {
            _context.Frases.Add(frase);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetFrase", new { id = frase.FraseId }, frase);
        }

        // DELETE: api/Frases/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteFrase(int id)
        {
            var frase = await _context.Frases.FindAsync(id);
            if (frase == null)
            {
                return NotFound();
            }

            _context.Frases.Remove(frase);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool FraseExists(int id)
        {
            return _context.Frases.Any(e => e.FraseId == id);
        }
    }
}
