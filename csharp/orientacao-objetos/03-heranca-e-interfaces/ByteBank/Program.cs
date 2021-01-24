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
      carlos.Salario = 2000;

      Console.WriteLine(carlos.Nome);
      gerenciadorBonificacao.Registrar(carlos);

      Diretor roberta = new Diretor();
      roberta.Nome = "Roberta";
      roberta.CPF = "353.325.389-12";
      roberta.Salario = 5000;

      Console.WriteLine(roberta.Nome);
      gerenciadorBonificacao.Registrar(roberta);

      Console.WriteLine(
        "Total de bonificações: " + gerenciadorBonificacao.GetTotalBonificacao()
      );

      Console.ReadLine();
    }
  }
}
