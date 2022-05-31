using Microsoft.AspNetCore.Mvc;
using Laboratorio11.Models;
using Laboratorio11.Services;

namespace Laboratorio11.Controllers;


[ApiController]
[Route("[controller]")]
public class ConsultaController : ControllerBase
{
  private readonly ILogger<DevolverController> _logger;
  private readonly BibliotecaContext _context;
  private readonly IAutoresRepositorio _autoresRepositorio;
  private readonly ILivroRepositorio _livroRepositorio;

  private readonly IEmprestimoRepositorio _emprestimoRepositorio;

  public ConsultaController(ILogger<DevolverController> logger, BibliotecaContext context, IAutoresRepositorio autoresRepositorio, ILivroRepositorio livroRepositorio, IEmprestimoRepositorio emprestimoRepositorio)
  {
    _logger = logger;
    _context = context;
    _autoresRepositorio = autoresRepositorio;
    _livroRepositorio = livroRepositorio;
    _emprestimoRepositorio = emprestimoRepositorio;
  }

  [HttpGet("{id}")]
  [Route("{consultar}/{id}")]
  public async Task<IActionResult> ConsultaLivros(int id)
  {
    var livros = await _livroRepositorio.GetAsync(id);
    if (livros.Count() == 0)
      return NotFound("Livro não encontrado");

    IEnumerable<Emprestimo> listaEmprestimos = new List<Emprestimo>();
    foreach (var livro in livros)
    {
      var emprestimos = await _emprestimoRepositorio.GetAsync(livro.Id);
      listaEmprestimos = listaEmprestimos.Concat(new [] {emprestimos});
    }
    
    (IEnumerable<Livro>, IEnumerable<Emprestimo>) t = (livros, listaEmprestimos);

    return Ok(t);
  }
}