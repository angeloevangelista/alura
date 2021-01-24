using System;
using ByteBank.Funcionarios;

namespace ByteBank
{
  class Program
  {
    static void Main(string[] args)
    {
      Funcionario carlos = new Funcionario();
      carlos.Nome = "Carlos";
      carlos.CPF = "235.567.487-28";
      carlos.Salario = 2355;

      Console.WriteLine(carlos.Nome);
      Console.WriteLine(carlos.GetBonificacao());
      Console.ReadLine();
    }
  }
}
