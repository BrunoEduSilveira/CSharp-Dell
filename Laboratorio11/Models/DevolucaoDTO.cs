using Laboratorio11.Models;
using System.ComponentModel.DataAnnotations;

public class DevolucaoDTO
{
  public DateTime DataDevolucaoEstipulada { get; set; }
  public DateTime DataDevolucao { get; set; }
  public int LivroID { get; set; }
  public string Titulo { get; set; } = null!;
  public decimal Multa { get; set; }

  public override string ToString()
  {
    return $"{Titulo}\n{DataDevolucaoEstipulada}\n{DataDevolucao}\n{Multa}";
  }

  public DevolucaoDTO(DateTime dataDevolucaoEstipulada, DateTime dataDevolucao, int livroID, string titulo, decimal multa)
  {
    DataDevolucaoEstipulada = dataDevolucaoEstipulada;
    DataDevolucao = dataDevolucao;
    LivroID = livroID;
    Titulo = titulo;
    Multa = multa;
  }
}