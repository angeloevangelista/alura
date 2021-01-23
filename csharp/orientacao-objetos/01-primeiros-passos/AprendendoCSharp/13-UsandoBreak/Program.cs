using System;

namespace _13_UsandoBreak
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine(
        "Executando projeto 13 - Usando o break."
      );

      // Usando o BREAK
      for (int contadorLinha = 1; contadorLinha <= 10; contadorLinha++)
      {
        for (int contadorColuna = 1; contadorColuna <= 10; contadorColuna++)
        {
          Console.Write('*');

          if (contadorColuna == contadorLinha)
            break;
        }

        Console.Write("\n");
      }

      // "Give me another way!"
      for (int contadorLinha = 1; contadorLinha <= 10; contadorLinha++)
      {
        for (int contadorColuna = 1; contadorColuna <= contadorLinha; contadorColuna++)
          Console.Write('*');

        Console.Write("\n");
      }

      Console.ReadLine();
    }
  }
}
