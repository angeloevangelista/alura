﻿using System;

namespace _06_ByteBank
{
  class Program
  {
    static void Main(string[] args)
    {
      ContaCorrente conta = new ContaCorrente();

      Cliente cliente = new Cliente();
      cliente.Nome = "Guilherme";
      cliente.CPF = "124.745.567-33";
      cliente.Profissao = "Desenvolvedor";

      conta.Saldo = -10;
      conta.Titular = cliente;

      Console.WriteLine(conta.Titular.Nome);
      Console.WriteLine(conta.Saldo);

      Console.ReadLine();
    }
  }
}
