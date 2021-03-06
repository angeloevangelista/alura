﻿using System;
using ByteBank.Modelos;

namespace ByteBank.SistemaAgencia
{
  class Program
  {
    static void Main(string[] args)
    {
      Lista<int> lista = new Lista<int>();

      Console.ReadLine();
    }

    static int SomarVarios(params int[] numeros)
    {
      int acumulador = 0;
      foreach (int numero in numeros)
      {
        acumulador += numero;
      }
      return acumulador;
    }

    static void TestaListaContaCorrente()
    {
      ListaDeContaCorrente lista = new ListaDeContaCorrente();

      ContaCorrente contaDoGui = new ContaCorrente(11111, 1111111);

      ContaCorrente[] contas = new ContaCorrente[]
      {
        contaDoGui,
        new ContaCorrente(874, 5679787),
        new ContaCorrente(874, 5679754)
      };

      lista.AdicionarVarios(contas);

      lista.AdicionarVarios(
        contaDoGui,
        new ContaCorrente(874, 5679787),
        new ContaCorrente(874, 5679787),
        new ContaCorrente(874, 5679787),
        new ContaCorrente(874, 5679787),
        new ContaCorrente(874, 5679787),
        new ContaCorrente(874, 5679787),
        new ContaCorrente(874, 5679787),
        new ContaCorrente(874, 5679787)
      );

      for (int i = 0; i < lista.Tamanho; i++)
      {
        ContaCorrente itemAtual = lista[i];
        Console.WriteLine($"Item na posição {i} = Conta {itemAtual.Numero}/{itemAtual.Agencia}");
      }
    }

    public static void TestaArrayContaCorrente()
    {
      ContaCorrente[] contas = new ContaCorrente[]
      {
        new ContaCorrente(874, 5679787),
        new ContaCorrente(874, 4456668),
        new ContaCorrente(874, 7781438)
      };

      for (int indice = 0; indice < contas.Length; indice++)
      {
        ContaCorrente contaAtual = contas[indice];
        Console.WriteLine($"Conta {indice} {contaAtual.Numero}");
      }
    }

    public static void TestaArrayInt()
    {
      // ARRAY de inteiros, com 5 posições!
      int[] idades = null;
      idades = new int[3];

      idades[0] = 15;
      idades[1] = 28;
      idades[2] = 35;
      //idades[3] = 50;
      //idades[4] = 28;

      Console.WriteLine(idades.Length);

      int acumulador = 0;
      for (int indice = 0; indice < idades.Length; indice++)
      {
        int idade = idades[indice];

        Console.WriteLine($"Acessando o array idades no índice {indice}");
        Console.WriteLine($"Valor de idades[{indice}] = {idade}");

        acumulador += idade;
      }

      int media = acumulador / idades.Length;
      Console.WriteLine($"Média de idades = {media}");
    }
  }
}
