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
    public class BusInfoesController : ControllerBase
    {
        private readonly Test1Context _context;

        public BusInfoesController(Test1Context context)
        {
            _context = context;
        }

        // GET: api/BusInfoes
        [HttpGet]
        public async Task<ActionResult<IEnumerable<BusInfo>>> GetBusInfo()
        {
            return await _context.BusInfo.ToListAsync();
        }

        // GET: api/BusInfoes/5
        [HttpGet("{id}")]
        public async Task<ActionResult<BusInfo>> GetBusInfo(string id)
        {
            var busInfo = await _context.BusInfo.FindAsync(id);

            if (busInfo == null)
            {
                return NotFound();
            }

            return busInfo;
        }

        // PUT: api/BusInfoes/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutBusInfo(string id, BusInfo busInfo)
        {
            if (id != busInfo.Np)
            {
                return BadRequest();
            }

            _context.Entry(busInfo).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!BusInfoExists(id))
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

        // POST: api/BusInfoes
        [HttpPost]
        public async Task<ActionResult<BusInfo>> PostBusInfo(BusInfo busInfo)
        {
            _context.BusInfo.Add(busInfo);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (BusInfoExists(busInfo.Np))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetBusInfo", new { id = busInfo.Np }, busInfo);
        }

        // DELETE: api/BusInfoes/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<BusInfo>> DeleteBusInfo(string id)
        {
            var busInfo = await _context.BusInfo.FindAsync(id);
            if (busInfo == null)
            {
                return NotFound();
            }

            _context.BusInfo.Remove(busInfo);
            await _context.SaveChangesAsync();

            return busInfo;
        }

        private bool BusInfoExists(string id)
        {
            return _context.BusInfo.Any(e => e.Np == id);
        }
    }
}
