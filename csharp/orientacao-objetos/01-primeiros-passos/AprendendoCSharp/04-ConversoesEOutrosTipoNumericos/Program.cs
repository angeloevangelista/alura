using System;

namespace _03_CriandoVariaveisPontoFlutuante
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine(
        "Executando projeto 4 - Conversões."
      );

      double salario = 1200.50;

      // O long tem 32 bits
      int salarioEmInteiro = (int)salario;
      Console.WriteLine(salarioEmInteiro);


      // O long tem 64 bits
      long idade = 13000000000;
      Console.WriteLine(idade);

      // O long tem 16 bits
      short quantidadeProdutos = 15000;
      Console.WriteLine(quantidadeProdutos);

      float altura = 1.65f;
      Console.WriteLine(altura);

      Console.WriteLine("A execução acabou. Tecle enter para finalizar...");
      Console.ReadLine();
    }
  }
}
