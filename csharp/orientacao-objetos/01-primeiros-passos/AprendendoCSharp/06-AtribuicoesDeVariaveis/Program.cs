using System;

namespace _06_AtribuicoesDeVariaveis
{
  class Program
  {
    static void Main(string[] args)
    {

      Console.WriteLine("Executando projeto 6.");

      int idade = 32;
      int idadeGustavo = idade;

      idade = 20;

      Console.WriteLine(idade);
      Console.WriteLine(idadeGustavo);

      Console.ReadLine();
    }
  }
}
