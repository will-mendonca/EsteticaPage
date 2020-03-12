using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using EsteticaPage.Model;

namespace EsteticaPage.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ItemServicosController : ControllerBase
    {
        private readonly EsteticaPageDbContext _context;

        public ItemServicosController(EsteticaPageDbContext context)
        {
            _context = context;
        }

        // GET: api/ItemServicos
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ItemServico>>> GetItemServicos()
        {
            return await _context.ItemServicos.ToListAsync();
        }

        // GET: api/ItemServicos/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ItemServico>> GetItemServico(int id)
        {
            var itemServico = await _context.ItemServicos.FindAsync(id);

            if (itemServico == null)
            {
                return NotFound();
            }

            return itemServico;
        }

        // PUT: api/ItemServicos/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutItemServico(int id, ItemServico itemServico)
        {
            if (id != itemServico.Id)
            {
                return BadRequest();
            }

            _context.Entry(itemServico).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ItemServicoExists(id))
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

        // POST: api/ItemServicos
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPost]
        public async Task<ActionResult<ItemServico>> PostItemServico(ItemServico itemServico)
        {
            _context.ItemServicos.Add(itemServico);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetItemServico", new { id = itemServico.Id }, itemServico);
        }

        // DELETE: api/ItemServicos/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<ItemServico>> DeleteItemServico(int id)
        {
            var itemServico = await _context.ItemServicos.FindAsync(id);
            if (itemServico == null)
            {
                return NotFound();
            }

            _context.ItemServicos.Remove(itemServico);
            await _context.SaveChangesAsync();

            return itemServico;
        }

        private bool ItemServicoExists(int id)
        {
            return _context.ItemServicos.Any(e => e.Id == id);
        }
    }
}
