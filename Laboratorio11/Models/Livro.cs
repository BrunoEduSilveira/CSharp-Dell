namespace Laboratorio11.Models;
public class Livro
{
    public int Id { get; set; }
    public string Titulo { get; set; } = null!;
    public IEnumerable<Autor>? Autores { get; set; }
    public Livro()
    {
    }
    public Livro(int id, string titulo)
    {
        Id = id;
        Titulo = titulo;
    }
}