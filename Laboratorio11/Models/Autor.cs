namespace Laboratorio11.Models;
public class Autor
{
  public int Id { get; set; }
  public string PrimeiroNome { get; set; } = null!;
  public string UltimoNome { get; set; } = null!;
  public ICollection<Livro>? Livros { get; set; }
  public List<LivroAutor> LivrosAutores {get;set;} = null!;

  public Autor()
  {
  }
  public Autor(int id, string primeiroNome, string ultimoNome)
  {
    Id = id;
    PrimeiroNome = primeiroNome;
    UltimoNome = ultimoNome;
  }
}