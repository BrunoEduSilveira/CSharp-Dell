List<Pessoa> pessoas = new List<Pessoa>
{
    new Pessoa{Nome="Ana", DataNascimento=new DateTime(1980,3,14), Casada=true},
    new Pessoa{Nome="Paulo", DataNascimento=new DateTime(1978,10,14), Casada=true},
    new Pessoa{Nome="Maria", DataNascimento=new DateTime(2000,1,10), Casada=false},
    new Pessoa{Nome="Carlos", DataNascimento=new DateTime(1999,12,12), Casada=false}
};

var linq1 =
            from p in pessoas
            where p.Casada && p.DataNascimento >= new DateTime(1980, 1, 1)
            select p;
foreach (var pessoa in linq1)
{
  Console.WriteLine(pessoa);
}

var linq2 = pessoas.Where(p => p.Casada && p.DataNascimento >= new DateTime(1980, 1, 1));

foreach (var pessoa in linq2)
{
  Console.WriteLine(pessoa);
}
Console.WriteLine("---------------------------");
var linq3 =
            from p in pessoas
            group p by p.Casada into grupo
            orderby grupo.Key
            select grupo;

foreach (var grupo in linq3)
{
  string tipoGrupo = grupo.Key ? "Casados" : "Solteiros";
  Console.WriteLine($"[{grupo.Count()}] - {tipoGrupo}");
  foreach (var p in grupo)
  {
    Console.WriteLine($"\t{p.Nome}");
  }
}

var linq4 =
            (from p in pessoas
             orderby p.DataNascimento ascending
             select p).Take(1);

foreach (var p in linq4)
{
  Console.WriteLine($"Nome: {p.Nome}, Data de Nascimento: {p.DataNascimento.ToShortDateString()}");
}

var linq5 =
          (from p in pessoas
           orderby p.DataNascimento descending
           where !p.Casada
           select p).Take(1);

foreach (var p in linq5)
{
  Console.WriteLine(p);
}