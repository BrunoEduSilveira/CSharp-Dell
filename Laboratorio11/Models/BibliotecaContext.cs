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
      entityBuilder.Property(e => e.Id)
                .IsRequired()
                .UseIdentityColumn()
                .ValueGeneratedOnAdd();

      entityBuilder.Property(e => e.Titulo)
            .IsRequired()
            .HasMaxLength(200);
    });

    modelBuilder.Entity<Autor>(entityBuilder =>
    {
      entityBuilder.Property(e => e.Id)
                .IsRequired()
                .UseIdentityColumn()
                .ValueGeneratedOnAdd();

      entityBuilder.Property(e => e.PrimeiroNome)
            .IsRequired()
            .HasMaxLength(100);

      entityBuilder.Property(e => e.UltimoNome)
            .IsRequired()
            .HasMaxLength(100);
    });

    modelBuilder.Entity<Emprestimo>(entityBuilder =>
    {
      entityBuilder.Property(e => e.Id)
                .IsRequired()
                .UseIdentityColumn()
                .ValueGeneratedOnAdd();

      entityBuilder.Property(e => e.DataEmprestimo)
            .IsRequired();

      entityBuilder.Property(e => e.DataDevolucao)
            .IsRequired();
    });

    modelBuilder.Entity<Autor>()
      .HasMany(e => e.Livros)
      .WithMany(e => e.Autores)
      .UsingEntity<LivroAutor>()
      .HasKey(e => new { e.AutorId, e.LivroId });

    modelBuilder.Entity<Livro>()
      .HasMany(e => e.Emprestimo)
      .WithOne(e => e.Livro);
  }

  protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
  {
    optionsBuilder.UseSqlServer(@"Data Source=localhost;Initial Catalog=Laboratorio11;Integrated Security=True");
    optionsBuilder.EnableSensitiveDataLogging().LogTo(Console.WriteLine);
  }
}
