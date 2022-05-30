using Microsoft.EntityFrameworkCore;

namespace Laboratorio11.Models;

public class BibliotecaContext : DbContext
{

  public BibliotecaContext()
  {
  }
  public BibliotecaContext(DbContextOptions<BibliotecaContext> options) : base(options)
  {
  }

  public DbSet<Livro> Livros { get; set; } = null!;
  public DbSet<Autor> Autores { get; set; } = null!;
  public DbSet<Emprestimo> Emprestimos { get; set; } = null!;

  protected override void OnModelCreating(ModelBuilder modelBuilder)
  {
    modelBuilder.Entity<Livro>(entityBuilder =>
    {
      entityBuilder.Property(livro => livro.Id)
                .IsRequired()
                .UseIdentityColumn()
                .ValueGeneratedOnAdd();

      entityBuilder.Property(livro => livro.Titulo)
            .IsRequired()
            .HasMaxLength(200);
    });

    modelBuilder.Entity<Autor>(entityBuilder =>
    {
      entityBuilder.Property(autor => autor.Id)
                .IsRequired()
                .UseIdentityColumn()
                .ValueGeneratedOnAdd();

      entityBuilder.Property(autor => autor.PrimeiroNome)
            .IsRequired()
            .HasMaxLength(100);

      entityBuilder.Property(autor => autor.UltimoNome)
            .IsRequired()
            .HasMaxLength(100);
    });

    modelBuilder.Entity<Emprestimo>(entityBuilder =>
    {
      entityBuilder.Property(emprestimo => emprestimo.Id)
                .IsRequired()
                .UseIdentityColumn()
                .ValueGeneratedOnAdd();

      entityBuilder.Property(emprestimo => emprestimo.DataEmprestimo)
            .IsRequired();

      entityBuilder.Property(emprestimo => emprestimo.DataDevolucao)
            .IsRequired(false);
    });
  }
}
