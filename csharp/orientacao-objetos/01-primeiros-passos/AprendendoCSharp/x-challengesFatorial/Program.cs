using System;

namespace x_challengesFatorial
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Desafios - Fatorial.");

      int numero = 6;
      int fatorial = 1;

      for (int contador = 1; contador <= numero; contador++)
        fatorial *= contador;

      Console.WriteLine("O fatorial de " + numero + " é " + fatorial);

      Console.ReadLine();
    }
  }
}
