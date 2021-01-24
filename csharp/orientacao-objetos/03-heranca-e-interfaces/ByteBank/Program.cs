using System;
using ByteBank.Funcionarios;
using ByteBank.Sistemas;

namespace ByteBank
{
  class Program
  {
    static void Main(string[] args)
    {
      // CalcularBonificacao();
      UsarSistema();

      Console.ReadLine();
    }

    public static void UsarSistema()
    {
      SistemaInterno sistemaInterno = new SistemaInterno();

      Diretor roberta = new Diretor("352.912.423-12");
      roberta.Nome = "Roberta";
      roberta.Senha = "123";

      GerenteDeConta camila = new GerenteDeConta("821.128.129-34");
      camila.Nome = "Camila";
      camila.Senha = "abc";

      ParceiroComercial andre = new ParceiroComercial();
      andre.Senha = "123456";

      sistemaInterno.Logar(roberta, "123");
      sistemaInterno.Logar(camila, "abc");
      sistemaInterno.Logar(andre, "123456");
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
