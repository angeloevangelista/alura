namespace ByteBank.Funcionarios
{
  public class Diretor : Funcionario
  {
    public override double GetBonificacao()
    {
      return this.Salario;
    }
  }
}
