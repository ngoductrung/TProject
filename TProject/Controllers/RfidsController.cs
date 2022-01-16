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
    public class RfidsController : ControllerBase
    {
        private readonly Test1Context _context;

        public RfidsController(Test1Context context)
        {
            _context = context;
        }

        // GET: api/Rfids
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Rfid>>> GetRfid()
        {
            return await _context.Rfid.ToListAsync();
        }

        // GET: api/Rfids/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Rfid>> GetRfid(string id)
        {
            var rfid = await _context.Rfid.FindAsync(id);

            if (rfid == null)
            {
                return NotFound();
            }

            return rfid;
        }

        // PUT: api/Rfids/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutRfid(string id, Rfid rfid)
        {
            if (id != rfid.Rfid1)
            {
                return BadRequest();
            }

            _context.Entry(rfid).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!RfidExists(id))
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

        // POST: api/Rfids
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Rfid>> PostRfid(Rfid rfid)
        {
            _context.Rfid.Add(rfid);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (RfidExists(rfid.Rfid1))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetRfid", new { id = rfid.Rfid1 }, rfid);
        }

        // DELETE: api/Rfids/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Rfid>> DeleteRfid(string id)
        {
            var rfid = await _context.Rfid.FindAsync(id);
            if (rfid == null)
            {
                return NotFound();
            }

            _context.Rfid.Remove(rfid);
            await _context.SaveChangesAsync();

            return rfid;
        }

        private bool RfidExists(string id)
        {
            return _context.Rfid.Any(e => e.Rfid1 == id);
        }
    }
}
