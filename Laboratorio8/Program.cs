string[] lista = { "Julio", "Lucia", "Daniel", "Joao" };
Console.WriteLine("Array antes da ordenação");
for (int i = 0; i < lista.Length; i++)
{
  Console.WriteLine(lista[i] + " ");
}
Console.WriteLine();
Array.Sort(lista);
Console.WriteLine("Array depois da ordenação");
for (int i = 0; i < lista.Length; i++)
{
  Console.WriteLine(lista[i] + " ");
}
Console.WriteLine("---------------------------------");

Console.WriteLine();
Pessoa[] lista2 = {
                    new Pessoa("Jose", 25),
                    new Pessoa("Ana", 28),
                    new Pessoa("Paulo", 20)
};
Array.Sort(lista2, Pessoa.SortNomeAsc());
Console.WriteLine("Array depois da ordenação por nome");
for (int i = 0; i < lista2.Length; i++)
{
  Console.WriteLine(lista2[i].Nome + " ");
}
Console.WriteLine("---------------------------------");
Array.Sort(lista2, Pessoa.SortIdadeAsc());
Console.WriteLine("Array depois da ordenação por idade");
for (int i = 0; i < lista2.Length; i++)
{
  Console.WriteLine(lista2[i].Nome + " ");
}