using Laboratorio11.Models;
namespace Laboratorio11.Services;

public interface ILivroRepositorio
{
  Task<Livro> GetOneAsync(int id);
  Task<IEnumerable<Livro>> GetAllAsync();
  Task<IEnumerable<Livro>> GetAsync(int autorId);
  Task<Livro> AddAsync(Livro livro);
}