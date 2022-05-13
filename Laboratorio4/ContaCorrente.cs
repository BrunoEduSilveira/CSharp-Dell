using System;

class ContaCorrente
{
  private decimal saldo;
  private string nome;
  private DateTime dataCriacao;

  public ContaCorrente(string nome)
  {
    this.nome = nome;
    this.dataCriacao = DateTime.Now;
    this.saldo = 0;
  }
  public void Depositar(decimal val)
  {
    saldo = saldo + val;
  }

  public void Sacar(decimal val)
  {
    saldo = saldo - val;
  }

  public decimal Saldo
  {
    get { return saldo; }
  }

  public string Nome
  {
    get { return nome; }
    set { nome = value; }
  }
}