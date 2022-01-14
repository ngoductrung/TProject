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
    public class StopsController : ControllerBase
    {
        private readonly Test1Context _context;

        public StopsController(Test1Context context)
        {
            _context = context;
        }

        // GET: api/Stops
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Stop>>> GetStop()
        {
            return await _context.Stop.ToListAsync();
        }

        // GET: api/Stops/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Stop>> GetStop(string id)
        {
            var stop = await _context.Stop.FindAsync(id);

            if (stop == null)
            {
                return NotFound();
            }

            return stop;
        }

        // PUT: api/Stops/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutStop(string id, Stop stop)
        {
            if (id != stop.Sid)
            {
                return BadRequest();
            }

            _context.Entry(stop).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!StopExists(id))
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

        // POST: api/Stops

        [HttpPost]
        public async Task<ActionResult<Stop>> PostStop(Stop stop)
        {
            _context.Stop.Add(stop);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (StopExists(stop.Sid))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetStop", new { id = stop.Sid }, stop);
        }

        // DELETE: api/Stops/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Stop>> DeleteStop(string id)
        {
            var stop = await _context.Stop.FindAsync(id);
            if (stop == null)
            {
                return NotFound();
            }

            _context.Stop.Remove(stop);
            await _context.SaveChangesAsync();

            return stop;
        }

        private bool StopExists(string id)
        {
            return _context.Stop.Any(e => e.Sid == id);
        }
    }
}
