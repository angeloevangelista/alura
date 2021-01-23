namespace _06_ByteBank
{
  class ContaCorrente
  {
    public Cliente Titular { get; set; }

    public int Agencia { get; set; }
    public int Numero { get; set; }
    private double _saldo = 100;

    public double Saldo
    {
      get
      {
        return this._saldo;
      }
      set
      {
        if (value > 0)
          this._saldo = value;
      }
    }

    public bool Sacar(double valor)
    {
      if (this._saldo < valor)
        return false;

      this._saldo -= valor;
      return true;
    }

    public void Depositar(double valor)
    {
      if (valor > 0)
        this._saldo += valor;
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
