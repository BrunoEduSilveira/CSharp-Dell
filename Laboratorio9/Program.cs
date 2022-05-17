// inicializa o termometro e mostra seu valor
TermometroLimite term = new TermometroLimite(5);
term.Aumentar(2);
Console.WriteLine(term.ToString());

// adiciona um tratador ao evento LimiteSuperiorEvent
term.LimiteSuperiorEvent += new TermometroLimite.MeuDelegate(TrataEvento);

// adiciona um tratador ao evento TemperaturaNormalEvent
term.TemperaturaNormalEvent += new TermometroLimite.MeuDelegate(TrataEvento);

// aumentar a temperatura além do limite
term.Aumentar(4);
Console.WriteLine(term.ToString());

// Diminuir a temperatura para voltar dentro do limite
term.Diminuir(3);
Console.WriteLine(term.ToString());

static void TrataEvento(string msg)
{
  Console.WriteLine(msg);
}

