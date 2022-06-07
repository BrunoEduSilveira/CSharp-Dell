using Microsoft.AspNetCore.Mvc;
using Laboratorio11.Models;
using Laboratorio11.Services;

namespace Laboratorio11.Controllers;

[ApiController]
[Route("[controller]")]
public class DevolucaoController : ControllerBase
{
  private readonly ILogger<DevolucaoController> _logger;
  private readonly BibliotecaContext _context;
  private readonly IAutoresRepositorio _autoresRepositorio;
  private readonly ILivroRepositorio _livroRepositorio;
  private readonly IEmprestimoRepositorio _emprestimoRepositorio;

  public DevolucaoController(ILogger<DevolucaoController> logger, BibliotecaContext context, IAutoresRepositorio autoresRepositorio, ILivroRepositorio livroRepositorio, IEmprestimoRepositorio emprestimoRepositorio)
  {
    _logger = logger;
    _context = context;
    _autoresRepositorio = autoresRepositorio;
    _livroRepositorio = livroRepositorio;
    _emprestimoRepositorio = emprestimoRepositorio;
  }

  [HttpPut("{id}")] // .../api/devolucao/{id livro}
  public async Task<ActionResult<DevolucaoDTO>> DevolucaoLivro(int id)
  {
    try
    {
      var livro = await _livroRepositorio.GetOneAsync(id);
      if (livro is null)
        return NotFound("Livro não encontrado");

      var emprestimo = await _emprestimoRepositorio.GetAsync(livro.Id);
      if (emprestimo is null)
        return NotFound("Emprestimo não localizado. Livro não emprestado");
      else if (emprestimo.Entregue)
        return Conflict("Livro já devolvido");

      var dataDevolucaoEstipulada = emprestimo.DataDevolucao;
      var dataDevolucao = DateTime.Now;
      decimal multa = 0;

      if (dataDevolucao > emprestimo.DataDevolucao)
      {
        multa = 1.75m * (dataDevolucao - emprestimo.DataDevolucao).Days;
      }

      emprestimo.DataDevolucao = dataDevolucao;
      emprestimo.Entregue = true;

      _context.Emprestimos.Update(emprestimo);
      await _context.SaveChangesAsync();

      var retorno = new DevolucaoDTO(dataDevolucaoEstipulada, dataDevolucao, emprestimo.Livro.Id, emprestimo.Livro.Titulo, multa);
      return Ok(retorno);
    }
    catch (Exception)
    {
      return BadRequest("Erro ao devolver livro");
    }
  }
}