using Microsoft.AspNetCore.Mvc;
using Laboratorio11.Models;
using Laboratorio11.Services;

namespace Laboratorio11.Controllers;

[ApiController]
[Route("[controller]")]
public class EmprestarController : ControllerBase
{
  private readonly ILogger<DevolverController> _logger;
  private readonly BibliotecaContext _context;
  private readonly IAutoresRepositorio _autoresRepositorio;
  private readonly ILivroRepositorio _livroRepositorio;
  private readonly IEmprestimoRepositorio _emprestimoRepositorio;

  public EmprestarController(ILogger<DevolverController> logger, BibliotecaContext context, IAutoresRepositorio autoresRepositorio, ILivroRepositorio livroRepositorio, IEmprestimoRepositorio emprestimoRepositorio)
  {
    _logger = logger;
    _context = context;
    _autoresRepositorio = autoresRepositorio;
    _livroRepositorio = livroRepositorio;
    _emprestimoRepositorio = emprestimoRepositorio;
  }

  [HttpPut("{id}")]
  public async Task<ActionResult<Livro>> EmprestarLivro(int id)
  {
    try
    {
      var livro = await _livroRepositorio.GetOneAsync(id);
      if (livro is null)
        return NotFound("Livro não encontrado");

      // object cycle - Livro.Emprestimos - Emprestimo.Livro - fazer DTO(?)
      var novoEmprestimo = new Emprestimo(0, DateTime.Now, DateTime.Now.AddDays(7), false, livro);
      var emprestimo = await _emprestimoRepositorio.GetAsync(livro.Id);
      if(emprestimo is null)
      {
        await _emprestimoRepositorio.AddAsync(novoEmprestimo);

        return Ok(novoEmprestimo);
      }
      else
        return Conflict("Livro já emprestado");
      
    }
    catch (System.Exception ex)
    {
      return BadRequest(ex.Message);
    }
  }
}