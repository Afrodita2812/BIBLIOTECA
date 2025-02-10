
using Biblioteca.API.Models; 
namespace Biblioteca.API.Models 
{
    public class Autores 
    {
        public int Id { get; set; }
        public required string NombreAutor { get; set; }
        public required string ApellidoAutor { get; set; }
        public required string Nacionalidad { get; set; }
    }
}
