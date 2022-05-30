using Laboratorio11.Models;
namespace Laboratorio11.Services;

public interface IAutoresRepositorio
{
  Task<IEnumerable<Autor>> GetAsync(string ultimoNome);
  Task<Autor> UpdateAsync(Autor autor);
  Task<Autor> AddAsync(Autor autor);
}