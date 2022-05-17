
IEstadoBinario[] lista = new IEstadoBinario[2];
lista[0] = new Lampada(110, 60);
lista[0].Ligar();
lista[1] = new TermometroEletrico();
for (int i = 0; i < lista.Length; i++)
{
  Console.WriteLine(lista[i].Estado);
}

Ventilador ventilador = new Ventilador(2);
ventilador.Ligar();
Console.WriteLine($"Ventilador está {ventilador.Estado} na velocidade {ventilador.Velocidade}");