namespace ByteBank.Funcionarios
{
  public class Diretor : Funcionario
  {
    public Diretor(string cpf) : base(5000, cpf)
    {
    }

    public override void AumentarSalario()
    {
      Salario *= 1.15;
    }

    public override double GetBonificacao()
    {
      return this.Salario * 0.5;
    }
  }
}
