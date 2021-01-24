using ByteBank.Funcionarios;

namespace ByteBank
{
  public class GerenciadorBonificacao
  {
    private double _totalBonificacao;

    public void Registrar(Funcionario funcionario)
    {
      this._totalBonificacao += funcionario.GetBonificacao();
    }

    public double GetTotalBonificacao()
    {
      return this._totalBonificacao;
    }
  }
}
