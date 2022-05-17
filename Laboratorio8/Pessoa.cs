public class Pessoa : IComparable<Pessoa>
{
  private class SortIdade : IComparer<Object>
  {
    public int Compare(object a, object b)
    {
      Pessoa p1 = (Pessoa)a;
      Pessoa p2 = (Pessoa)b;
      if (p1.minhaIdade > p2.minhaIdade)
        return 1;
      if (p1.minhaIdade < p2.minhaIdade)
        return -1;
      else
        return 0;
    }
  }
  private class SortNome : IComparer<Object>
  {
    public int Compare(object a, object b)
    {
      Pessoa p1 = (Pessoa)a;
      Pessoa p2 = (Pessoa)b;
      return String.Compare(p1.meuNome, p2.meuNome);
    }
  }

  private string meuNome;
  private int minhaIdade;

  public Pessoa(string n, int i)
  {
    meuNome = n;
    minhaIdade = i;
  }

  public string Nome
  {
    get { return meuNome; }
  }

  public int Idade
  {
    get { return minhaIdade; }
  }

  public int CompareTo(Pessoa outro)
  {
    return minhaIdade.CompareTo(outro.minhaIdade);
  }

  public static IComparer<Object> SortIdadeAsc()
  {
    return (IComparer<Object>)new SortIdade();
  }

  public static IComparer<Object> SortNomeAsc()
  {
    return (IComparer<Object>)new SortNome();
  }
}