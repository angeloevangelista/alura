using System;

namespace _07_Condicionais
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Executando projeto 7 - Condicionais.");

      int idadeJoao = 18;
      int quantidadePessoas = 2;

      if (idadeJoao >= 18)
      {
        Console.WriteLine("João possui mais de 18 anos idade, pode entrar.");
      }
      else
      {
        if (quantidadePessoas > 1)
        {
          Console.WriteLine(
            "João não possui mais de 18 anos, mas está acompanhado. Pode entrar."
          );
        }
        else
        {
          Console.WriteLine("João não possui mais de 18 anos, não pode entrar.");
        }
      }

      Console.ReadLine();
    }
  }
}
