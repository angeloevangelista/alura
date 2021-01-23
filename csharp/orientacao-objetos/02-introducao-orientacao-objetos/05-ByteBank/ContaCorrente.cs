namespace _05_ByteBank
{
  class ContaCorrente
  {
    public Cliente cliente;
    public int agencia;
    public int numero;
    public double saldo = 100;

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
