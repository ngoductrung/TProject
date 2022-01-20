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
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class HistoriesController : ControllerBase
    {
        private readonly Test1Context _context;

        public HistoriesController(Test1Context context)
        {
            _context = context;
        }

        // GET: api/Histories
        [HttpGet]
        public async Task<ActionResult<IEnumerable<History>>> GetHistory()
        {
            return await _context.History.ToListAsync();
        }

        // GET: api/Histories/5
        [HttpGet("{id}")]
        public async Task<ActionResult<History>> GetHistory(string id)
        {
            var history = await _context.History.FindAsync(id);

            if (history == null)
            {
                return NotFound();
            }

            return history;
        }

        // PUT: api/Histories/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutHistory(string id, History history)
        {
            if (id != history.Np)
            {
                return BadRequest();
            }

            _context.Entry(history).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!HistoryExists(id))
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

        // POST: api/Histories
        [HttpPost]
        public async Task<ActionResult<History>> PostHistory(History history)
        {
            _context.History.Add(history);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (HistoryExists(history.Np))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetHistory", new { id = history.Np }, history);
        }

        // DELETE: api/Histories/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<History>> DeleteHistory(string id)
        {
            var history = await _context.History.FindAsync(id);
            if (history == null)
            {
                return NotFound();
            }

            _context.History.Remove(history);
            await _context.SaveChangesAsync();

            return history;
        }


        [HttpGet("Total/{id}")]
        public async Task<ActionResult<IEnumerable<History>>> GetTotal(String id, DateTime begin, DateTime end)
        {
            var history = await _context.History.FindAsync(id);
            double Total = 0;
            if (history == null)
            {
                return NotFound("Kiểm tra lại số xe");
            }
            else if ((begin < history.Time) && (history.Time < end))
            {
                Total += history.TripLength;
            }
            return Ok(Total);
        }

            private bool HistoryExists(string id)
        {
            return _context.History.Any(e => e.Np == id);
        }
    }
}
