using System;

namespace _05_CaracteresETextos
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine(
        "Executando projeto 5 - Caracteres e textos."
      );

      char primeiraLetra = 'a';
      Console.WriteLine(primeiraLetra);

      primeiraLetra = (char)65;
      Console.WriteLine(primeiraLetra);

      primeiraLetra = (char)(primeiraLetra + 1);
      Console.WriteLine(primeiraLetra);

      string titulo = "Alura Cursos de tecnologia " + 2020;
      string cursosProgramacao = @"- .NET
- Java
- JavaScript";

      Console.WriteLine(titulo);
      Console.WriteLine(cursosProgramacao);

      Console.ReadLine();
    }
  }
}
