using System;

class ContaCorrente
{
  private decimal saldo;
  private string nome;
  private DateTime dataCriacao;
  private decimal saldoMedioCorrentista;
  private int qtdOperacoes;


  public ContaCorrente(string nome)
  {
    this.nome = nome;
    this.dataCriacao = DateTime.Now;
    this.saldo = 0; //default
  }
  public void Depositar(decimal val)
  {
    saldo = saldo + val;
    SaldoMedio(saldo);
  }

  public void Sacar(decimal val)
  {
    saldo = saldo - val;
    SaldoMedio(saldo);
  }

  private void SaldoMedio(decimal saldo)
  {
    qtdOperacoes++;
    this.saldoMedioCorrentista += saldo;
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

  public DateTime DataCriacao
  {
    get { return dataCriacao; }
  }

  public decimal SaldoMedioCorrentista
  {
    get { return saldoMedioCorrentista / qtdOperacoes; }
  }
}