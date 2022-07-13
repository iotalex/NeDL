using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using AStack.Models;

namespace AStack.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AStackItemsController : ControllerBase
    {
        private readonly AStackContext _context;

        public AStackItemsController(AStackContext context)
        {
            _context = context;
        }

        // GET: api/AStackItems
        [HttpGet]
        public async Task<ActionResult<IEnumerable<AStackItem>>> GetTodoItems()
        {
            return await _context.TodoItems.ToListAsync();
        }

        // GET: api/AStackItems/5
        [HttpGet("{id}")]
        public async Task<ActionResult<AStackItem>> GetAStackItem(long id)
        {
            var aStackItem = await _context.TodoItems.FindAsync(id);

            if (aStackItem == null)
            {
                return NotFound();
            }

            return aStackItem;
        }

        // PUT: api/AStackItems/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutAStackItem(long id, AStackItem aStackItem)
        {
            if (id != aStackItem.Id)
            {
                return BadRequest();
            }

            _context.Entry(aStackItem).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!AStackItemExists(id))
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

        // POST: api/AStackItems
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<AStackItem>> PostAStackItem(AStackItem aStackItem)
        {
            _context.TodoItems.Add(aStackItem);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetAStackItem", new { id = aStackItem.Id }, aStackItem);
        }

        // DELETE: api/AStackItems/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAStackItem(long id)
        {
            var aStackItem = await _context.TodoItems.FindAsync(id);
            if (aStackItem == null)
            {
                return NotFound();
            }

            _context.TodoItems.Remove(aStackItem);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool AStackItemExists(long id)
        {
            return _context.TodoItems.Any(e => e.Id == id);
        }
    }
}
