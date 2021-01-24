namespace ByteBank.Funcionarios
{
  public class Funcionario
  {
    public static int TotalDeFuncionarios { get; set; }

    public string Nome { get; set; }
    public string CPF { get; private set; }
    public double Salario { get; set; }

    public Funcionario(string cpf)
    {
      this.CPF = cpf;
      Funcionario.TotalDeFuncionarios++;
    }

    public virtual double GetBonificacao()
    {
      return this.Salario * 0.1;
    }
  }
}
