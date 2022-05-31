using Microsoft.AspNetCore.Mvc;
using Laboratorio11.Models;
using Laboratorio11.Services;

namespace Laboratorio11.Controllers;

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
  [Route("emprestar/{id}")]
  public async Task<IActionResult> EmprestarLivro(int id)
  {
    var livro = await _livroRepositorio.GetOneAsync(id);
    if (livro == null)
      return NotFound("Livro não encontrado");

    var emprestimo = new Emprestimo(0, DateTime.Now, DateTime.Now.AddDays(7), false, livro);
    await _emprestimoRepositorio.AddAsync(emprestimo);

    return Ok(emprestimo);
  }
}