using System;

namespace _07_ByteBank
{
  class Program
  {
    static void Main(string[] args)
    {
      ContaCorrente conta = new ContaCorrente(867, 894239);

      Console.WriteLine(conta.Agencia);
      Console.WriteLine(conta.Numero);

      ContaCorrente contaGabi = new ContaCorrente(867, 32342);

      Console.WriteLine(ContaCorrente.TotalDeContasCriadas);

      Console.ReadLine();
    }
  }
}
