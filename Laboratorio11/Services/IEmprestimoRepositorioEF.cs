using Laboratorio11.Models;
using Microsoft.EntityFrameworkCore;

namespace Laboratorio11.Services;

public class IEmprestimoRepositorioEF : IEmprestimoRepositorio
{
  private readonly BibliotecaContext _context;
  public IEmprestimoRepositorioEF(BibliotecaContext context)
  {
    _context = context;
  }

  public async Task<Emprestimo> AddAsync(Emprestimo emprestimo)
  {
    await _context.Emprestimos.AddAsync(emprestimo);
    await _context.SaveChangesAsync();
    return emprestimo;
  }

  public async Task<Emprestimo> UpdateAsync(Emprestimo emprestimo)
  {
    _context.Emprestimos.Update(emprestimo);
    await _context.SaveChangesAsync();
    return emprestimo;
  }

  public async Task<IEnumerable<Emprestimo>> GetAsync(int livroID)
  {
    return await _context.Emprestimos.Where(e => e.DataDevolucao == null && e.Livro.Id == livroID).ToArrayAsync();
  }
}