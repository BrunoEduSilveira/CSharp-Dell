using Laboratorio11.Models;
using Microsoft.EntityFrameworkCore;

namespace Laboratorio11.Services;

public class EmprestimoRepositorioEF : IEmprestimoRepositorio
{
  private readonly BibliotecaContext _context;
  public EmprestimoRepositorioEF(BibliotecaContext context)
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

  public async Task<Emprestimo> GetAsync(int livroID)
  {
    var resultado = await _context.Emprestimos.Where(e => e.Livro.Id == livroID).FirstAsync();
    if (resultado is null)
      throw new Exception("Emprestimo não encontrado");
    return resultado;
  }
}