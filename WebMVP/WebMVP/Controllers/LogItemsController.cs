using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebMVP.Models;

namespace WebMVP.Controllers
{
    [Route("api/LogItems")]
    [ApiController]
    public class LogItemsController : ControllerBase
    {
        private readonly LogItemContext _context;

        public LogItemsController(LogItemContext context)
        {
            _context = context;
        }

        // GET: api/LogItems
        [HttpGet]
        public async Task<ActionResult<IEnumerable<LogItemDTO>>> GetLogItems()
        {
            return await _context.LogItems
                .Select(x => ItemToDTO(x))
                .ToListAsync();
        }

        // GET: api/LogItems/5
        [HttpGet("{id}")]
        public async Task<ActionResult<LogItemDTO>> GetLogItem(long id)
        {
            var logItem = await _context.LogItems.FindAsync(id);

            if (logItem == null)
            {
                return NotFound();
            }

            return ItemToDTO(logItem);
        }

        // PUT: api/LogItems/5
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateLogItem(long id, LogItemDTO logItemDTO)
        {
            if (id != logItemDTO.Id)
            {
                return BadRequest();
            }

            var logItem = await _context.LogItems.FindAsync(id);
            if (logItem == null)
            {
                return NotFound();
            }

            logItem.Name = logItemDTO.Name; //updated "Name" to "Name" 2 X times; unconventional, may have to change back? (1of3)
            logItem.IsComplete = logItemDTO.IsComplete;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException) when (!LogItemExists(id))
            {
                return NotFound();
            }

            return NoContent();
        }

        // POST: api/LogItems
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<LogItemDTO>> CreateLogItem(LogItemDTO logItemDTO)
        {
            var logItem = new LogItem
            {
                IsComplete = logItemDTO.IsComplete,
                Name = logItemDTO.Name //updated "Name" to "Name" 2 X times; unconventional, may have to change back? (2 of 3)
            };

            _context.LogItems.Add(logItem);
            await _context.SaveChangesAsync();

            return CreatedAtAction(
                nameof(GetLogItem),
                new { id = logItem.Id },
                ItemToDTO(logItem));
        }

        // DELETE: api/LogItems/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteLogItem(long id)
        {
            var logItem = await _context.LogItems.FindAsync(id);

            if (logItem == null)
            {
                return NotFound();
            }

            _context.LogItems.Remove(logItem);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool LogItemExists(long id) =>
             _context.LogItems.Any(e => e.Id == id);

        private static LogItemDTO ItemToDTO(LogItem logItem) =>
            new LogItemDTO
            {
                Id = logItem.Id,
                Name = logItem.Name,//updated "Name" to "Name" 2 X times; unconventional, may have to change back? (3 of 3)
                IsComplete = logItem.IsComplete
            };
        

    }
}
