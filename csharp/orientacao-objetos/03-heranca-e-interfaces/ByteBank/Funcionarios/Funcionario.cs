namespace ByteBank.Funcionarios
{
  public abstract class Funcionario
  {
    public static int TotalDeFuncionarios { get; set; }

    public string Nome { get; set; }
    public string CPF { get; private set; }
    public double Salario { get; protected set; }

    public Funcionario(double salario, string cpf)
    {
      this.CPF = cpf;
      this.Salario = salario;
      Funcionario.TotalDeFuncionarios++;
    }

    public virtual void AumentarSalario()
    {
      Salario *= 1.1;
    }

    public virtual double GetBonificacao()
    {
      return this.Salario * 0.1;
    }
  }
}
