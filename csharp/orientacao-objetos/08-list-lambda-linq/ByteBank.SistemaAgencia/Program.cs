using System;
using System.Collections.Generic;
using System.Linq;
using ByteBank.Modelos;
using ByteBank.SistemaAgencia.Comparadores;
using ByteBank.SistemaAgencia.Extensoes;

namespace ByteBank.SistemaAgencia
{
  class Program
  {
    static void Main(string[] args)
    {
      // "Que dahora cara kkkkkk".AsConsoleError();

      var contas = new List<ContaCorrente>()
      {
        new ContaCorrente(123, 97381),
        new ContaCorrente(122, 32346),
        new ContaCorrente(353, 23534),
        new ContaCorrente(236, 34923),
      };

      // contas.Sort(); ~~> Implementação em IComparable

      // contas.Sort(new ComparadorContaCorrentePorAgencia());

      var contasOrdenadas = contas.OrderBy(conta =>
      {
        if (conta == null)
          return int.MaxValue;

        return conta.Numero;
      });

      foreach (var conta in contasOrdenadas)
      {
        if (conta != null)
          Console.WriteLine($"Conta número {conta.Numero}, ag. {conta.Agencia}");
      }

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

    static void TestaSort()
    {
      List<int> numeros = new List<int>();

      numeros.Add(5);
      numeros.Add(6);
      numeros.Add(9);
      numeros.Add(0);
      numeros.Add(2);
      numeros.Add(4);
      numeros.Add(3);
      numeros.Add(8);
      numeros.Add(7);
      numeros.Add(1);
      numeros.AdicionarVarios(30, 40, 10, 20, -1234);
      // ListExtensoes.AdicionarVarios(numeros, 10, 20, 30, 40);

      numeros.Sort();

      foreach (var numero in numeros)
        Console.WriteLine(numero);
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
