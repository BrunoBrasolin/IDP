#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using IDP.Models;

namespace IDP.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AcessosController : ControllerBase
    {
        private readonly IDPContext _context;

        public AcessosController(IDPContext context)
        {
            _context = context;
        }

        // GET: api/Acessos
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Acesso>>> GetAcesso()
        {
            return await _context.Acesso.ToListAsync();
        }

        // GET: api/Acessos/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Acesso>> GetAcesso(int id)
        {
            var acesso = await _context.Acesso.FindAsync(id);

            if (acesso == null)
            {
                return NotFound();
            }

            return acesso;
        }

        // PUT: api/Acessos/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutAcesso(int id, Acesso acesso)
        {
            if (id != acesso.Id)
            {
                return BadRequest();
            }

            _context.Entry(acesso).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!AcessoExists(id))
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

        // POST: api/Acessos
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Acesso>> PostAcesso(Acesso acesso)
        {
            _context.Acesso.Add(acesso);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetAcesso", new { id = acesso.Id }, acesso);
        }

        // DELETE: api/Acessos/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAcesso(int id)
        {
            var acesso = await _context.Acesso.FindAsync(id);
            if (acesso == null)
            {
                return NotFound();
            }

            _context.Acesso.Remove(acesso);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool AcessoExists(int id)
        {
            return _context.Acesso.Any(e => e.Id == id);
        }
    }
}
