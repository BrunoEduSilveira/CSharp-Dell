public class Ventilador : IEstadoBinario
{
  private bool ligado;
  private int velocidade;

  public Ventilador(int v)
  {
    ligado = false;
    velocidade = v;
  }

  public void Ligar()
  {
    ligado = true;
  }
  public void Desligar()
  {
    ligado = false;
    velocidade = 0;
  }
  public EstadoBinario Estado
  {
    get
    {
      if (ligado)
        return EstadoBinario.Ligado;
      else
        return EstadoBinario.Desligado;
    }
  }
  public int Velocidade
  {
    get { return velocidade; }
    set { velocidade = value; }
  }

}