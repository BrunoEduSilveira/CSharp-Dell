using Laboratorio11.Models;
using System.ComponentModel.DataAnnotations;
public class LivroEmprestimoDTO
{
  // titulo, data de devolução, emprestado
  public string Titulo { get; set; } = null!;
  public DateTime? DataDevolucao { get; set; }
  public bool Entregue { get; set; }

  public override string ToString()
  {
    return $"{Titulo}\n{DataDevolucao}\n{Entregue}";
  }

  public LivroEmprestimoDTO(string titulo, DateTime? dataDevolucao, bool entregue)
  {
    Titulo = titulo;
    DataDevolucao = dataDevolucao;
    Entregue = entregue;
  }
}