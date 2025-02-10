namespace Biblioteca.API;
using Biblioteca.API.Models; 

public class Libros
{
    public int Id { get; set; }
    public required string Nombre { get; set; }
    public required string editorial{ get; set; }


}