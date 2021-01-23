using System;

namespace _05_ByteBank
{
  class Program
  {
    static void Main(string[] args)
    {
      Cliente gabriela = new Cliente();
      gabriela.nome = "Gabriela";
      gabriela.profissao = "Desenvolvedora C#";
      gabriela.cpf = "124.124.324-34";

      ContaCorrente conta = new ContaCorrente();
      conta.titular = gabriela;
      conta.agencia = 3423;
      conta.agencia = 3423;
      conta.numero = 3423138;

      Console.WriteLine(gabriela.nome);
      Console.WriteLine(conta.titular.nome);

      Console.ReadLine();
    }
  }
}
