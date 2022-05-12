using System.Text;

int[] array = new int[5] { 10, 20 , 30 , 40, 50 };
int i;
for (i = 0; i < 5; i++)
{
  Console.WriteLine("Indice = " + i + " & Valor = " +  array[i]);
}
Console.WriteLine("------------------------------");

string[] str = new string[3];
int iStr;
str[0] = "Um";
str[1] = "Dois";
str[2] = "Três";
for (iStr = 0; iStr < 3; iStr++)
{
  Console.WriteLine("Indice = " + iStr + " & Valor = " + str[iStr]);
}
Console.WriteLine("------------------------------");

DateTime[] dt = new DateTime[2];
int iDate;
dt[0] = new DateTime(2002, 5, 1);
dt[1] = new DateTime(2002, 6, 1);
for(iDate = 0;  iDate < 2; iDate++)
{
  Console.WriteLine("Indice = " + iDate + " & Data = " + dt[iDate].ToShortDateString()); 
}
Console.WriteLine("------------------------------");

int[] arrayInt1 = new int[100];
int[] arrayInt2 = new int[100];
Random numAleatorio = new Random();

for (i = 0; i < (int)arrayInt1.Length; i++)
{
  arrayInt1[i] = numAleatorio.Next(1,50000);
}


StringBuilder arrayInt1List = new StringBuilder();
foreach(var item1 in arrayInt1)
{
  arrayInt1List.Append("[").Append(item1).Append("] ");
}
Console.WriteLine("---- Lista 1 -----");
Console.WriteLine(arrayInt1List);
Console.WriteLine("------------------------------");

Array.Copy(arrayInt1, 0, arrayInt2, 0, arrayInt1.Length);
StringBuilder arrayInt2List = new StringBuilder();
foreach(var item2 in arrayInt2)
{
  arrayInt2List.Append("[").Append(item2).Append("] ");
}
Console.WriteLine("---- Lista 2 -----");
Console.WriteLine(arrayInt2List);
Console.WriteLine("------------------------------");

int[,] arrayMulti = new int[5, 5];