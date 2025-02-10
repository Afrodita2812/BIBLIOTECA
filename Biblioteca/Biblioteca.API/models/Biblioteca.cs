using Biblioteca.API.Models; 
using System.Collections.Generic;

namespace Biblioteca.API.Models {

public class Biblioteca
{
    public required List<Autores> Autores { get; set; }
    public required List<Libros> Libros { get; set; }
}



}