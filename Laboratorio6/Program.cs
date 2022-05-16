ContaPoupanca contaPoupanca1 = new ContaPoupanca(10.3M, DateTime.Now, "Bruno");

Console.WriteLine("Deposito de 500,00");
contaPoupanca1.Depositar(500M);
Console.WriteLine($"Saldo: {contaPoupanca1.Saldo}");
Console.WriteLine("Saque de 75,60");
contaPoupanca1.Sacar(75.6M);
Console.WriteLine($"Saldo: {contaPoupanca1.Saldo}");
Console.WriteLine($"Titular: {contaPoupanca1.Titular}");
Console.WriteLine($"Id: {contaPoupanca1.Id}");
contaPoupanca1.AdicionarRendimento();
Console.WriteLine($"Taxa de Juros: {contaPoupanca1.Juros}");
Console.WriteLine($"Data Aniversario: {contaPoupanca1.DataAniversario}");
Console.WriteLine("-------------------------------");

Conta conta1 = new ContaPoupanca(10.3M, DateTime.Now, "Claudio");

Console.WriteLine("Deposito de 150,00");
conta1.Depositar(150M);
Console.WriteLine($"Saldo: {conta1.Saldo}");
Console.WriteLine("Saque de 45,50");
conta1.Sacar(45.5M);
Console.WriteLine($"Saldo: {conta1.Saldo}");
Console.WriteLine($"Titular: {conta1.Titular}");
Console.WriteLine($"Id: {conta1.Id}");
Console.WriteLine("-------------------------------");

Random rnd = new Random();
List<Conta> listaContas = new List<Conta>();
listaContas.Add(conta1);
listaContas.Add(contaPoupanca1);

foreach (var conta in listaContas)
{
  decimal depositoRnd = rnd.Next(50,1500);
  decimal saqueRnd = rnd.Next(15,500);
  Console.WriteLine($"Deposito de {depositoRnd}");
  conta.Depositar(depositoRnd);
  Console.WriteLine($"Saldo: {conta.Saldo}");
  Console.WriteLine($"Saque de {saqueRnd}");
  conta.Sacar(saqueRnd);
  Console.WriteLine($"Saldo: {conta.Saldo}");
  Console.WriteLine($"Titular: {conta.Titular}");
  Console.WriteLine($"Id: {conta.Id}");
  Console.WriteLine("-------------------------------");
}