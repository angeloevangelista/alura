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

      Funcionario carlos = new Funcionario();
      carlos.Nome = "Carlos";
      carlos.CPF = "235.567.487-28";
      carlos.Salario = 2355;

      gerenciadorBonificacao.Registrar(carlos);

      Console.WriteLine(
        "Total de bonificações: " + gerenciadorBonificacao.GetTotalBonificacao()
      );

      Console.ReadLine();
    }
  }
}
