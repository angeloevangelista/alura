using System;

namespace _09_Escopo
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Executando projeto 9 - Escopo.");

      int idadeJoao = 18;
      bool acompanhado = false;
      string mensagemAdicional;

      if (acompanhado)
        mensagemAdicional = "João está acompanhado.";
      else
      {
        mensagemAdicional = "João não está acompanhado.";
        Console.WriteLine(mensagemAdicional);
      }

      if (idadeJoao >= 18 || acompanhado)
      {
        Console.WriteLine("Pode entrar.");
        Console.WriteLine(mensagemAdicional);
      }
      else
      {
        Console.WriteLine("Não pode entrar.");
      }

      Console.ReadLine();
    }
  }
}
