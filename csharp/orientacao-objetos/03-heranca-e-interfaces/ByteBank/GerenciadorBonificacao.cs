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

    public void Registrar(params Funcionario[] funcionarios)
    {
      foreach (var funcionario in funcionarios)
        this.Registrar(funcionario);
    }

    public double GetTotalBonificacao()
    {
      return this._totalBonificacao;
    }
  }
}
