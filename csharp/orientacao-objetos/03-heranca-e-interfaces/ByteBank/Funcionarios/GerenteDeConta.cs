namespace ByteBank.Funcionarios
{
  public class GerenteDeConta : Funcionario
  {
    public GerenteDeConta(string cpf) : base(2000, cpf)
    {
    }

    public override void AumentarSalario()
    {
      Salario *= 1.25;
    }

    public override double GetBonificacao()
    {
      return this.Salario * 0.05;
    }
  }
}
