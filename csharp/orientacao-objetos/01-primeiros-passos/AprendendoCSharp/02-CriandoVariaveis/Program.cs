using System;

namespace _02_CriandoVariaveis
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Executando projeto 2 - Criando Variáveis.");

      int idade;
      idade = 32;

      Console.WriteLine(idade);

      idade = 10;
      Console.WriteLine(idade);

      idade = 10 + 5;
      Console.WriteLine(idade);

      idade = 10 + 5 * 2;
      Console.WriteLine(idade);

      idade = (10 + 5) * 2;
      Console.WriteLine(idade);
      Console.WriteLine("A sua idade é" + idade + ", parabéns!");

      Console.WriteLine("A execução acabou. Tecle enter para finalizar...");
      Console.ReadLine();
    }
  }
}
