using Laboratorio11.Models;
using Microsoft.EntityFrameworkCore;

namespace Laboratorio11.Services;

public class LivroRepositorioEF : ILivroRepositorio
{
  private readonly BibliotecaContext _context;
  public LivroRepositorioEF(BibliotecaContext context)
  {
    _context = context;
  }

  public async Task<Livro> GetOneAsync(int id)
  {
    var livro = await _context.Livros.FindAsync(id);
    if (livro is null)
      throw new Exception("Livro não encontrado");
    return livro;
  }
  public async Task<IEnumerable<Livro>> GetAllAsync()
  {
    return await _context.Livros.ToArrayAsync();
  }

  public async Task<IEnumerable<Livro>> GetAsync(int autorId)
  {
    return await _context.Livros.Where(e => e.Id == autorId).ToArrayAsync();
  }

  public async Task<Livro> AddAsync(Livro livro)
  {
    await _context.Livros.AddAsync(livro);
    await _context.SaveChangesAsync();
    return livro;
  }
}
