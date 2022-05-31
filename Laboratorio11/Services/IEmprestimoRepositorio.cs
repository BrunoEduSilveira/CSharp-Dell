using Laboratorio11.Models;
namespace Laboratorio11.Services;

public interface IEmprestimoRepositorio
{
  Task<Emprestimo> AddAsync(Emprestimo emprestimo);
  Task<Emprestimo> UpdateAsync(Emprestimo emprestimo);
  Task<Emprestimo> GetAsync(int livroID);
}