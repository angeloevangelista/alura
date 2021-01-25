using System;
using System.Collections.Generic;

namespace ByteBank.SistemaAgencia.Extensoes
{
  public static class ConsoleExtensoes
  {
    public static void AsConsoleError(this string message)
    {
      Console.ForegroundColor = ConsoleColor.Red;
      Console.Write("Ocorreu um erro: ");

      Console.ForegroundColor = ConsoleColor.White;
      Console.WriteLine(message);
    }
  }
}
