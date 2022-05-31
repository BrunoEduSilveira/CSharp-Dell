namespace Laboratorio11.Models;
public class Livro
{
    public int Id { get; set; }
    public string Titulo { get; set; } = null!;
    public ICollection<Autor> Autores { get; set; } = null!;
    public ICollection<Emprestimo>? Emprestimo { get; set; }
    public List<LivroAutor> LivrosAutores {get;set;} = null!;

    public Livro()
    {
    }
    public Livro(int id, string titulo)
    {
        Id = id;
        Titulo = titulo;
    }
}