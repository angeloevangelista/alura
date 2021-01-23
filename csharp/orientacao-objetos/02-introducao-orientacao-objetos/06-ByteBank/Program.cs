using System;

namespace _06_ByteBank
{
  class Program
  {
    static void Main(string[] args)
    {
      ContaCorrente conta = new ContaCorrente();

      Cliente cliente = new Cliente();
      cliente.nome = "Guilherme";
      cliente.cpf = "124.745.567-33";
      cliente.profissao = "Desenvolvedor";

      conta.Saldo = -10;
      conta.Titular = cliente;

      Console.WriteLine(conta.Titular.nome);
      Console.WriteLine(conta.Saldo);

      Console.ReadLine();
    }
  }
}
