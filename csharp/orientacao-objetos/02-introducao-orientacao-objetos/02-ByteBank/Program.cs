using System;

namespace _02_ByteBank
{
  class Program
  {
    static void Main(string[] args)
    {
      ContaCorrente conta = new ContaCorrente();

      conta.titular = "Gabriela";

      Console.WriteLine("Titular: " + conta.titular);
      Console.WriteLine("Agência: " + conta.agencia);
      Console.WriteLine("Número: " + conta.numero);
      Console.WriteLine("Saldo: " + conta.saldo);

      Console.ReadLine();
    }
  }
}
