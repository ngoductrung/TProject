using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TProject.Models;

namespace TProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MaintainsController : ControllerBase
    {
        private readonly Test1Context _context;

        public MaintainsController(Test1Context context)
        {
            _context = context;
        }

        // GET: api/Maintains
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Maintain>>> GetMaintain()
        {
            return await _context.Maintain.ToListAsync();
        }

        // GET: api/Maintains/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Maintain>> GetMaintain(string id)
        {
            var maintain = await _context.Maintain.FindAsync(id);

            if (maintain == null)
            {
                return NotFound();
            }

            return maintain;
        }

        // PUT: api/Maintains/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutMaintain(string id, Maintain maintain)
        {
            if (id != maintain.Np)
            {
                return BadRequest();
            }

            _context.Entry(maintain).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!MaintainExists(id))
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

        // POST: api/Maintains
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Maintain>> PostMaintain(Maintain maintain)
        {
            _context.Maintain.Add(maintain);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (MaintainExists(maintain.Np))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetMaintain", new { id = maintain.Np }, maintain);
        }

        // DELETE: api/Maintains/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Maintain>> DeleteMaintain(string id)
        {
            var maintain = await _context.Maintain.FindAsync(id);
            if (maintain == null)
            {
                return NotFound();
            }

            _context.Maintain.Remove(maintain);
            await _context.SaveChangesAsync();

            return maintain;
        }

        private bool MaintainExists(string id)
        {
            return _context.Maintain.Any(e => e.Np == id);
        }
    }
}
