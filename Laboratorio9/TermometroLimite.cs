public class TermometroLimite : Termometro
{
  private double limiteSuperior;
  private bool disparadoEventoLimiteSuperior;

  public TermometroLimite (double ls)
  {
    limiteSuperior = ls;
    disparadoEventoLimiteSuperior = false;
  }
  
  public double LimiteSuperior
  {
    get { return limiteSuperior; }
    set { limiteSuperior = value; }
  }

  public delegate void MeuDelegate(string msg);

  public event MeuDelegate LimiteSuperiorEvent;

  public event MeuDelegate TemperaturaNormalEvent;

  private void OnLimiteSuperiorEvent()
  {
    // verifica se a temperatura ultrapassou o limite e
    // verifica se o evento já foi disparado, para não disparar continuamente.
    if((this.Temperatura > limiteSuperior) && (!disparadoEventoLimiteSuperior))
    {
      if(LimiteSuperiorEvent != null)
      {
        LimiteSuperiorEvent("Atenção: temperatura acima do limite!!!");
        disparadoEventoLimiteSuperior = true;
      }  
    }
  }

  private void OnTemperaturaNormalEvent()
  {
    if((this.Temperatura <= limiteSuperior) && (disparadoEventoLimiteSuperior))
    {
      if(TemperaturaNormalEvent != null)
      {
        TemperaturaNormalEvent("A tempeatura voltou ao normal.");
        disparadoEventoLimiteSuperior = false;
      }
    }
  }

  public override void Aumentar()
  {
    base.Aumentar();
    OnLimiteSuperiorEvent();
  }

  public override void Aumentar(double quantia)
  {
    base.Aumentar(quantia);
    OnLimiteSuperiorEvent();
  }

  public override void Diminuir()
  {
    base.Diminuir();
    OnTemperaturaNormalEvent();
  }

  public override void Diminuir(double quantia)
  {
    base.Diminuir(quantia);
    OnTemperaturaNormalEvent();
  }
}