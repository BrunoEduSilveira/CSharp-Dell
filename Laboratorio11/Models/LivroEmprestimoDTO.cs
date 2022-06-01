using Laboratorio11.Models;
using System.ComponentModel.DataAnnotations;
public class LivroEmprestimoDTO
{
  // titulo, data de devolução, emprestado
  public string Titulo { get; set; } = null!;
  public DateTime? DataDevolucao { get; set; }
  public bool Disponivel { get; set; }

  public override string ToString()
  {
    return $"{Titulo}\n{DataDevolucao}\n{Disponivel}";
  }

  public LivroEmprestimoDTO(string titulo, DateTime? dataDevolucao, bool disponivel)
  {
    Titulo = titulo;
    DataDevolucao = dataDevolucao;
    Disponivel = disponivel;
  }
}