byte b;
b = byte.MaxValue;
//Console.WriteLine("Valor máximo de byte: " + b);
Console.WriteLine($"Valor máximo de byte: {b}");
Console.WriteLine("----------------------------");

int i;
i = int.MaxValue;
Console.WriteLine("Valor máximo de int: " + i);
Console.WriteLine("----------------------------");

long l;
l = long.MaxValue;
Console.WriteLine("Valor máximo de long: " + l);
Console.WriteLine("----------------------------");

string strPrimeira = "Alo ";
string strSegunda = "Mundo";
string strTerceira = strPrimeira + strSegunda;
Console.WriteLine(strTerceira);

int cchTamanho = strTerceira.Length;
string strQuarta = "Tamanho = " + cchTamanho.ToString();
Console.WriteLine(strQuarta);
Console.WriteLine(strTerceira.Substring(0, 5));
Console.WriteLine("----------------------------");

DateTime dt = new DateTime(2015, 04, 23);
string strQuinta = dt.ToString();
Console.WriteLine(strQuinta);
Console.WriteLine("----------------------------");

float floatTest;
double doubleTest;
decimal decimalTest;
floatTest = 134.43215f;
doubleTest = 0.42d;
decimalTest = 15000m;
Console.WriteLine("Float: " + floatTest);
Console.WriteLine("Double: " + doubleTest);
Console.WriteLine("Decimal: " + decimalTest);
Console.WriteLine("----------------------------");

string txt = "";
int countVogais = 0;
int countEspaco = 0;
char[] vogais = { 'a', 'e', 'i', 'o', 'u' };
Console.WriteLine("Digite um texto:");
txt = Console.ReadLine();
foreach (char c in txt)
{
  if(c == ' ')
  {
    countEspaco++;
  }
  foreach (char v in vogais)
  {
    if (c == v)
    {
      countVogais++;
    }
  }
}
int countResto = txt.Length - (countVogais + countEspaco);
Console.WriteLine("Quantidade de letras no texto: " +  txt.Length);
Console.WriteLine("Quantidade de vogais no texto: " + countVogais);
Console.WriteLine("Quantidade de espaço no texto: " + countEspaco);
Console.WriteLine("Quantidade de consoantes e caracteres especiais: " + countResto);
Console.WriteLine("----------------------------");

DateTime dataHoje = DateTime.Now;
DateTime dataAmanha = dataHoje.AddDays(1);
DateTime dataAnoAtras = dataHoje.AddYears(-1);
Console.WriteLine("Data de hoje: " + dataHoje);
Console.WriteLine("Data de amanhã: " + dataAmanha);
Console.WriteLine("Data de um Ano atrás: " + dataAnoAtras);
Console.WriteLine("----------------------------");

int x = 10;
float f1 = 0;
f1 = x;
Console.WriteLine(f1);
f1 = 0.5F;
x = (int) f1;
Console.WriteLine(x);
Console.WriteLine("----------------------------");

// string stringInteiro = "123456789";
// int valorStringInteiro = Convert.ToInt32(stringInteiro);
// Console.WriteLine(valorStringInteiro);
// Int64 valorInt64 = 123456789;
// int valorInt = Convert.ToInt32(valorInt64);
// Console.WriteLine(valorInt);
// // string stringInteiroGrande = "99999999999999999999999999999999999999999999999";
// // int valorStringInteiroGrande = Convert.ToInt32(stringInteiroGrande);
// Console.WriteLine("----------------------------");

string stringInteiro = "123456789";
int valorStringInteiro;
bool conversao1 = Int32.TryParse(stringInteiro, out valorStringInteiro);
Console.WriteLine("Conversão efetuada: " + conversao1 + " Valor: " + valorStringInteiro);

string stringInteiroGrande = "99999999999999999999999999999999999999999999999";
int valorStringInteiroGrande;
bool conversao2 = Int32.TryParse(stringInteiroGrande, out valorStringInteiroGrande);
Console.WriteLine("Conversão efetuada: " + conversao2 + " Valor: " + valorStringInteiroGrande);

string stringLetras = "abc";
double valorStringLetras;
bool conversao3 = Double.TryParse(stringLetras, out valorStringLetras);
Console.WriteLine("Conversão efetuada: " + conversao3 + " Valor: " + valorStringLetras);
Console.WriteLine("----------------------------");

double valorFracionado = 4.7;
int valorInteiro1 = (int) valorFracionado;
int valorInteiro2 = Convert.ToInt32(valorFracionado);
Console.WriteLine("Conversão explicita = " + valorInteiro1);
Console.WriteLine("Conversão método Convert = " + valorInteiro2);
Console.WriteLine("$Conversão método Convert = {valorInteiro2}");
Console.WriteLine("----------------------------");

int x1 = 10;
double y1 = 3.4;
Console.WriteLine("{0}  {1}",x1,y1);
Console.WriteLine("Composite formatting, ou Formatação de Composição. Faz a indexação na string do primeiro parametro e passa pelos outros parametros os valores dos componentes, começando pelo 0.");
Console.WriteLine("----------------------------");
