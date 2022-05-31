namespace Laboratorio11.Models;
public class Emprestimo
{
  public int Id { get; set; }
  public DateTime DataEmprestimo { get; set; }
  public DateTime DataDevolucao { get; set; }
  public bool entregue { get; set; }
  public Livro Livro { get; set; } = null!;

  public Emprestimo()
  {
  }
  public Emprestimo(int id, DateTime dataEmprestimo, DateTime dataDevolucao, bool entregue, Livro livro)
  {
    Id = id;
    DataEmprestimo = dataEmprestimo;
    DataDevolucao = dataDevolucao;
    this.entregue = entregue;
    Livro = livro;
  }
}