public class Circulo
{
  private double coordX;
  private double coordY;
  private double raio;

  public Circulo() : this(0, 0, 1)
  { }

  public Circulo(double x, double y, double r)
  {
    coordX = x;
    coordY = y;
    raio = Math.Abs(r);
  }

  public double CentroX
  {
    get { return coordX; }
    set { coordX = value; }
  }
  public double CentroY
  {
    get { return coordY; }
    set { coordY = value; }
  }

  public double Raio
  {
    get { return raio; }
    set { raio = value; }
  }

  public override string ToString()
  {
    return "(" + string.Format("{0:F2}", CentroX) + ";" + string.Format("{0:F2}", CentroY) + ")" + " raio= " + string.Format("{0:F2}", Raio);
  }

}

public class CirculoColorido : Circulo
{
  private string minhaCor;

  public string Cor
  {
    get { return minhaCor; }
    set { minhaCor = value; }
  }

  public CirculoColorido()
  {
    minhaCor = "preto";
  }
  public CirculoColorido(double x, double y, double r, string c) : base(x, y, r)
  {
    minhaCor = c;
  }

  public override string ToString()
  {
    return base.ToString() + " cor= " + Cor;
  }
}