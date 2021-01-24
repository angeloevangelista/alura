namespace ByteBank.Funcionarios
{
  public class Diretor : Funcionario
  {
    public Diretor(string cpf) : base(cpf)
    {
    }

    public override double GetBonificacao()
    {
      return this.Salario + base.GetBonificacao();
    }
  }
}
