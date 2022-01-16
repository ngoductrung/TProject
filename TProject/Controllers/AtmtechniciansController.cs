using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TProject.Entities;

namespace TProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AtmtechniciansController : ControllerBase
    {
        private readonly Test1Context _context;

        public AtmtechniciansController(Test1Context context)
        {
            _context = context;
        }

        // GET: api/Atmtechnicians
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Atmtechnicians>>> GetAtmtechnicians()
        {
            return await _context.Atmtechnicians.ToListAsync();
        }

        // GET: api/Atmtechnicians/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Atmtechnicians>> GetAtmtechnicians(string id)
        {
            var atmtechnicians = await _context.Atmtechnicians.FindAsync(id);

            if (atmtechnicians == null)
            {
                return NotFound();
            }

            return atmtechnicians;
        }

        // PUT: api/Atmtechnicians/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutAtmtechnicians(string id, Atmtechnicians atmtechnicians)
        {
            if (id != atmtechnicians.Id)
            {
                return BadRequest();
            }

            _context.Entry(atmtechnicians).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!AtmtechniciansExists(id))
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

        // POST: api/Atmtechnicians
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Atmtechnicians>> PostAtmtechnicians(Atmtechnicians atmtechnicians)
        {
            _context.Atmtechnicians.Add(atmtechnicians);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (AtmtechniciansExists(atmtechnicians.Id))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetAtmtechnicians", new { id = atmtechnicians.Id }, atmtechnicians);
        }

        // DELETE: api/Atmtechnicians/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Atmtechnicians>> DeleteAtmtechnicians(string id)
        {
            var atmtechnicians = await _context.Atmtechnicians.FindAsync(id);
            if (atmtechnicians == null)
            {
                return NotFound();
            }

            _context.Atmtechnicians.Remove(atmtechnicians);
            await _context.SaveChangesAsync();

            return atmtechnicians;
        }

        private bool AtmtechniciansExists(string id)
        {
            return _context.Atmtechnicians.Any(e => e.Id == id);
        }
    }
}
