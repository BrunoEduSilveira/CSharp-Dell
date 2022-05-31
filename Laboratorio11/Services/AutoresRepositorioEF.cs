using Laboratorio11.Models;
using Microsoft.EntityFrameworkCore;

namespace Laboratorio11.Services;

public class AutoresRepositorioEF : IAutoresRepositorio
{
  private readonly BibliotecaContext _context;
  public AutoresRepositorioEF(BibliotecaContext context)
  {
    _context = context;
  }

  public async Task<IEnumerable<Autor>> GetAsync(string ultimoNome)
  {
    return await _context.Autores.Where(e => e.UltimoNome == ultimoNome).ToArrayAsync();
  }

  public async Task<Autor> UpdateAsync(Autor autor)
  {
    _context.Entry(autor).State = EntityState.Modified;
    await _context.SaveChangesAsync();
    return autor;
  }

  public async Task<Autor> AddAsync(Autor autor)
  {
    await _context.Autores.AddAsync(autor);
    await _context.SaveChangesAsync();
    return autor;
  }
}