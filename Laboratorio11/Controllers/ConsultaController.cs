using Microsoft.AspNetCore.Mvc;
using Laboratorio11.Models;
using Laboratorio11.Services;

namespace Laboratorio11.Controllers;


[ApiController]
[Route("[controller]")]
public class ConsultaController : ControllerBase
{
  private readonly ILogger<DevolverController> _logger;
  private readonly IAutoresRepositorio _autoresRepositorio;
  private readonly ILivroRepositorio _livroRepositorio;
  private readonly IEmprestimoRepositorio _emprestimoRepositorio;

  public ConsultaController(ILogger<DevolverController> logger, BibliotecaContext context, IAutoresRepositorio autoresRepositorio, ILivroRepositorio livroRepositorio, IEmprestimoRepositorio emprestimoRepositorio)
  {
    _logger = logger;
    _autoresRepositorio = autoresRepositorio;
    _livroRepositorio = livroRepositorio;
    _emprestimoRepositorio = emprestimoRepositorio;
  }

  // test get all
  [HttpGet]
  public Task<IEnumerable<Livro>> GetAll()
  {
    return _livroRepositorio.GetAllAsync();
  }

  [HttpGet("{id}")]
  public async Task<ActionResult<IEnumerable<LivroEmprestimoDTO>>> ConsultarLivro(int id)
  {
    try
    {
      var livros = await _livroRepositorio.GetAsync(id);
      if (livros.Count() == 0)
        return NotFound("Nenhum livro não encontrado");

      var listaLivroEmprestimoDTO = new List<LivroEmprestimoDTO>();

      foreach (var livro in livros)
      {
        //var emprestimos = await _emprestimoRepositorio.GetAsync(livro.Id);
        var livroEmprestimoDTO = new LivroEmprestimoDTO(livro.Titulo, null, false);
        listaLivroEmprestimoDTO.Add(livroEmprestimoDTO);

      }
      return listaLivroEmprestimoDTO;
    }
    catch (System.Exception)
    {
      return BadRequest("Erro ao consultar livro");
    }
  }
}