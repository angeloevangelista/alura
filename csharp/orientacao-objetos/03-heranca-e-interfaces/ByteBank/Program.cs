using System;
using ByteBank.Funcionarios;

namespace ByteBank
{
  class Program
  {
    static void Main(string[] args)
    {
      GerenciadorBonificacao gerenciadorBonificacao =
        new GerenciadorBonificacao();

      Funcionario carlos = new Funcionario(2000, "235.567.487-28");
      carlos.Nome = "Carlos";

      Console.WriteLine(carlos.Nome);
      gerenciadorBonificacao.Registrar(carlos);

      carlos.AumentarSalario();
      Console.WriteLine("Novo salário do Carlos: " + carlos.Salario);

      Diretor roberta = new Diretor("353.325.389-12");
      roberta.Nome = "Roberta";

      Console.WriteLine(roberta.Nome);
      gerenciadorBonificacao.Registrar(roberta);

      Console.WriteLine(Funcionario.TotalDeFuncionarios);

      Console.WriteLine(
        "Total de bonificações: " + gerenciadorBonificacao.GetTotalBonificacao()
      );

      Console.ReadLine();
    }
  }
}
