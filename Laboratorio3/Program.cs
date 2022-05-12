List<string> listaStrings = new List<string>();
listaStrings.Add("Um");
listaStrings.Add("Hello");
listaStrings.Add("World");
Console.WriteLine(listaStrings[0]);
Console.WriteLine(listaStrings[1]);
Console.WriteLine(listaStrings[2]);
//listaStrings.Add(10);
Console.WriteLine("-----------------");

Queue<Object> q = new Queue<object>();
q.Enqueue(".Net Framework");
q.Enqueue(new Decimal(123.456));
q.Enqueue(654.321);
Console.WriteLine(q.Dequeue());
Console.WriteLine(q.Dequeue());
Console.WriteLine(q.Dequeue());

Queue<int> minhaFila = new Queue<int>();
minhaFila.Enqueue(10);
minhaFila.Enqueue(200);
minhaFila.Enqueue(1000);
Console.WriteLine(minhaFila.Dequeue());
Console.WriteLine(minhaFila.Dequeue());
Console.WriteLine(minhaFila.Dequeue());

Dictionary<int, string> paises = new Dictionary<int, string>();
paises[44] = "Reino Unido";
paises[33] = "França";
paises[55] = "Brasil";
Console.WriteLine("O código 55 é: {0}", paises[55]);
foreach (KeyValuePair<int, string> item in paises)
{
  int codigo = item.Key;
  string pais = item.Value;
  Console.WriteLine("Código {0} = {1}", codigo, pais);
}

Console.WriteLine("Digite o nome do país que deseja saber o DDI");
string paisBusca = Console.ReadLine();
int codigoBusca = 0;
foreach (KeyValuePair<int, string> item in paises)
{
  if(String.Equals(paisBusca.ToUpper(), item.Value.ToUpper()))
    codigoBusca = item.Key;
}
if(codigoBusca < 1) 
  Console.WriteLine("País não encontrado.");
else 
  Console.WriteLine("Código {0} = {1}", codigoBusca, paises[codigoBusca]);

