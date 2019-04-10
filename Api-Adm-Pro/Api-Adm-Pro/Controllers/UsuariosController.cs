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
    public class UsuariosController : Controller
    {
        private ApplicationDbContext _context;

        public UsuariosController(ApplicationDbContext context)
        {
            _context = context;
        }
        // GET: api/Usuarios
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Usuario>>> GetUsuario()
        {
            return await _context.Usuarios.ToListAsync();
        }

        // GET api/Usuarios/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Usuario>> GetUsuario(long id)
        {
            var Usuario = await _context.Usuarios.FindAsync(id);
            if (Usuario == null)
            {
                return NotFound();
            }
            return Usuario;
        }

        // POST: api/Usuarios
        [HttpPost]
        public async Task<ActionResult<Prestamo>> PostUsuario(Usuario item)
        {
            _context.Usuarios.Add(item);
            await _context.SaveChangesAsync();
            return CreatedAtAction(nameof(GetUsuario), new { id = item.Id },
            item);
        }

        // PUT: api/Usuarios/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutUsuario(long id, Usuario item)
        {
            if (id != item.Id)
            {
                return BadRequest();
            }
            _context.Entry(item).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return NoContent();
        }

        // DELETE: api/Usuarios/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePrestamo(long id)
        {
            var Usuario = await _context.Usuarios.FindAsync(id);
            if (Usuario == null)
            {
                return NotFound();
            }
            _context.Usuarios.Remove(Usuario);
            await _context.SaveChangesAsync();
            return NoContent();
        }
    }
}
