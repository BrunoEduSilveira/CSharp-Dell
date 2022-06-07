using Microsoft.AspNetCore.Mvc;
using Laboratorio11.Models;
using Laboratorio11.Services;

namespace Laboratorio11.Controllers;


[ApiController]
[Route("[controller]")]
public class ConsultaController : ControllerBase
{
  private readonly ILogger<DevolucaoController> _logger;
  private readonly IAutoresRepositorio _autoresRepositorio;
  private readonly ILivroRepositorio _livroRepositorio;
  private readonly IEmprestimoRepositorio _emprestimoRepositorio;

  public ConsultaController(ILogger<DevolucaoController> logger, BibliotecaContext context, IAutoresRepositorio autoresRepositorio, ILivroRepositorio livroRepositorio, IEmprestimoRepositorio emprestimoRepositorio)
  {
    _logger = logger;
    _autoresRepositorio = autoresRepositorio;
    _livroRepositorio = livroRepositorio;
    _emprestimoRepositorio = emprestimoRepositorio;
  }

  // test get all
  [HttpGet] // .../api/consulta
  public Task<IEnumerable<Livro>> GetAllLivros()
  {
    return _livroRepositorio.GetAllAsync();
  }

  [HttpGet("{id}")] // .../api/consulta/{id autor}
  public async Task<ActionResult<ICollection<LivroEmprestimoDTO>>> ConsultarLivroEmprestado(int id)
  {
    try
    {
      var listaLivroEmprestimoDTO = new List<LivroEmprestimoDTO>();
      var livros = await _livroRepositorio.GetAsync(id);
      if (livros.Count() == 0)
        return NotFound("Nenhum livro não encontrado [1]");

      foreach (var livro in livros)
      {
        var emprestimo = await _emprestimoRepositorio.GetAsync(livro.Id);
        if (emprestimo is null)
          listaLivroEmprestimoDTO.Add(new LivroEmprestimoDTO(livro.Titulo, null, true));
        else
          listaLivroEmprestimoDTO.Add(new LivroEmprestimoDTO(livro.Titulo, emprestimo.Entregue?  null : emprestimo.DataDevolucao.Date, emprestimo.Entregue? true : false));
      }
      return listaLivroEmprestimoDTO;
    }
    catch (Exception)
    {
      return BadRequest("Erro ao consultar livro [2]");
    }
  }
}