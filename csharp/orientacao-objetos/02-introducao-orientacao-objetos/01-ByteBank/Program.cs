using System;

namespace _01_ByteBank
{
  class Program
  {
    static void Main(string[] args)
    {
      ContaCorrente contaCorrenteGabriela = new ContaCorrente();

      contaCorrenteGabriela.titular = "Gabriela";
      contaCorrenteGabriela.agencia = 863;
      contaCorrenteGabriela.numero = 863452;
      contaCorrenteGabriela.saldo = 9001;

      Console.WriteLine("Titular: " + contaCorrenteGabriela.titular);
      Console.WriteLine("Agência: " + contaCorrenteGabriela.agencia);
      Console.WriteLine("Número: " + contaCorrenteGabriela.numero);
      Console.WriteLine("Saldo: " + contaCorrenteGabriela.saldo);

      Console.ReadLine();
    }
  }
}
