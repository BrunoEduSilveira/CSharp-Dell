public abstract class Conta
{
  private decimal saldo;
  private string titular;

  public Conta(string t)
  {
    this.titular = t;
  }

  public decimal Saldo
  {
    get { return saldo; }
  }

  public string Titular
  {
    get { return titular; }
  }

  public abstract string Id
  {
    get;
  }

  public virtual void Depositar(decimal valor)
  {
    saldo += valor;
  }

  public virtual void Sacar(decimal valor)
  {
    if(saldo > valor)
      saldo -= valor;

  }
}
public class ContaPoupanca : Conta
{
  private decimal taxaJuros;
  private DateTime dataAniversario;

  public ContaPoupanca(decimal j, DateTime d, string t) : base(t)
  {
    taxaJuros = j;
    dataAniversario = d;
  }

  public decimal Juros
  {
    get { return taxaJuros; }
    set { taxaJuros = value; }
  }

  public DateTime DataAniversario
  {
    get { return dataAniversario; }
  }

  public void AdicionarRendimento()
  {
    DateTime hoje = DateTime.Now;
    if (hoje.Day == dataAniversario.Day && hoje.Month == dataAniversario.Month)
    {
      decimal rendimento = this.Saldo * taxaJuros;
      this.Depositar(rendimento);
    }
  }

  public override string Id
  {
    get { return this.Titular + "(CP)"; }
  }

}