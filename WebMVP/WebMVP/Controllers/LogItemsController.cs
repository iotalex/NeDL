﻿using System;
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
        public async Task<ActionResult<IEnumerable<LogItem>>> GetLogItems()
        {
            return await _context.LogItems.ToListAsync();
        }

        // GET: api/LogItems/5
        [HttpGet("{id}")]
        public async Task<ActionResult<LogItem>> GetLogItem(long id)
        {
            var logItem = await _context.LogItems.FindAsync(id);

            if (logItem == null)
            {
                return NotFound();//message if ID doesn't match, a message can be inserted here
            }

            return logItem;
        }

        // PUT: api/LogItems/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutLogItem(long id, LogItem logItem)
        {
            if (id != logItem.Id)
            {
                return BadRequest();
            }

            _context.Entry(logItem).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!LogItemExists(id))
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

        // POST: api/LogItems
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<LogItem>> PostLogItem(LogItem logItem)
        {
            _context.LogItems.Add(logItem);
            await _context.SaveChangesAsync();
            //return CreatedAtAction("GetLogItem", new { id = logItem.Id }, logItem);
            return CreatedAtAction(nameof(GetLogItem), new { id = logItem.Id }, logItem);
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

        private bool LogItemExists(long id)
        {
            return _context.LogItems.Any(e => e.Id == id);
        }
    }
}
