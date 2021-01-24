using System;
using ByteBank.Funcionarios;

namespace ByteBank
{
  class Program
  {
    static void Main(string[] args)
    {
      CalcularBonificacao();
      Console.ReadLine();
    }

    public static void CalcularBonificacao()
    {
      GerenciadorBonificacao gerenciadorBonificacao =
        new GerenciadorBonificacao();

      Designer pedro = new Designer("992.132.453-42");
      pedro.Nome = "Pedro";

      Diretor roberta = new Diretor("352.912.423-12");
      roberta.Nome = "Roberta";

      Auxiliar igor = new Auxiliar("354.120.342-39");
      igor.Nome = "Igor";

      GerenteDeConta camila = new GerenteDeConta("821.128.129-34");
      camila.Nome = "Camila";

      gerenciadorBonificacao.Registrar(pedro, roberta, igor, camila);

      Console.WriteLine(
        "Total de bonificações do mês: "
        + gerenciadorBonificacao.GetTotalBonificacao()
      );
    }
  }
}
