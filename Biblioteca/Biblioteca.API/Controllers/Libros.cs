
using Biblioteca.API.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Biblioteca.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class LibrosController : ControllerBase
    {
        private static List<Libros> _LibrosList = new List<Libros>();

        
        [HttpPost]
        [Route("Libros")]
        public async Task<IActionResult> CreateLibros(Libros Libro)
        {
           
            _LibrosList.Add(Libro);

            return CreatedAtAction(nameof(GetLibro), new { id = Libro.Id }, Libro);
        }

        [HttpGet("{id}")]
        public ActionResult<Autores> GetLibro(int id)
        {
            var Libro = _LibrosList.FirstOrDefault(a => a.Id == id);

            return Ok(Libro); 
   
        }
    }
}
