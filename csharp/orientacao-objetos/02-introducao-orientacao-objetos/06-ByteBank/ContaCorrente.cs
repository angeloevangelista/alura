namespace _06_ByteBank
{
  class ContaCorrente
  {
    public Cliente titular;
    public int agencia;
    public int numero;
    private double saldo = 100;

    public double ObterSaldo()
    {
      return this.saldo;
    }

    public void DefinirSaldo(double valor)
    {
      if (valor > 0)
        this.saldo = valor;
    }

    public bool Sacar(double valor)
    {
      if (this.saldo < valor)
        return false;

      this.saldo -= valor;
      return true;
    }

    public void Depositar(double valor)
    {
      if (valor > 0)
        this.saldo += valor;
    }

    public bool Transferir(double valor, ContaCorrente contaDestino)
    {
      if (!(valor > 0) || !this.Sacar(valor))
        return false;

      contaDestino.Depositar(valor);
      return true;
    }
  }
}
