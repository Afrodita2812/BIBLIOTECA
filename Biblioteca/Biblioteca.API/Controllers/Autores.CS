using Biblioteca.API.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Biblioteca.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AutoresController : ControllerBase
    {
        private static List<Autores> _autoresList = new List<Autores>();

        
        [HttpPost]
        [Route("Autores")]
        public async Task<IActionResult> CreateAutores(Autores autor)
        {
           
            _autoresList.Add(autor);
             await Task.CompletedTask;

            return CreatedAtAction(nameof(GetAutor), new { id = autor.Id }, autor);
        }

        [HttpGet("{id}")]
        public ActionResult<Autores> GetAutor(int id)
        {
            var autor = _autoresList.FirstOrDefault(a => a.Id == id);

            return Ok(autor); 
   
        }
    }
}
