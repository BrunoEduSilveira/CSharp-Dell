using Laboratorio11.Models;
public class LivroAutor
{
  public int LivroId { get; set; }
  public Livro Livro { get; set; } = null!;
  public int AutorId { get; set; }
  public Autor Autor { get; set; } = null!;
}