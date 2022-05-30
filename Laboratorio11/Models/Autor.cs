namespace Laboratorio11.Models;
public class Autor
{
  public int Id { get; set; }
  public string PrimeiroNome { get; set; } = null!;
  public string UltimoNome { get; set; } = null!;
  public IEnumerable<Livro>? Livros { get; set; }

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