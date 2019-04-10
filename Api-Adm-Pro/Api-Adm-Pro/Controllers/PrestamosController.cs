using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApiAdmPro.Context;
using ApiAdmPro.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ApiAdmPro.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PrestamosController : Controller
    {
        private ApplicationDbContext _context;

        public PrestamosController(ApplicationDbContext context)
        {
            _context = context;
        }
        // GET: api/Prestamos
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Prestamo>>> GetPrestamo()
        {
            return await _context.Prestamos.ToListAsync();
        }

        // GET api/Prestamos/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Prestamo>> GetPrestamo(long id)
        {
            var Prestamo = await _context.Prestamos.FindAsync(id);
            if (Prestamo == null)
            {
                return NotFound();
            }
            return Prestamo;
        }

        // POST: api/Prestamos
        [HttpPost]
        public async Task<ActionResult<Prestamo>> PostPrestamo(Prestamo item)
        {
            _context.Prestamos.Add(item);
            await _context.SaveChangesAsync();
            return CreatedAtAction(nameof(GetPrestamo), new { id = item.Id },
            item);
        }

        // PUT: api/Prestamos/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutPrestamo(long id, Prestamo item)
        {
            if (id != item.Id)
            {
                return BadRequest();
            }
            _context.Entry(item).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return NoContent();
        }

        // DELETE: api/Prestamos/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePrestamo(long id)
        {
            var Prestamo = await _context.Prestamos.FindAsync(id);
            if (Prestamo == null)
            {
                return NotFound();
            }
            _context.Prestamos.Remove(Prestamo);
            await _context.SaveChangesAsync();
            return NoContent();
        }
    }
}
