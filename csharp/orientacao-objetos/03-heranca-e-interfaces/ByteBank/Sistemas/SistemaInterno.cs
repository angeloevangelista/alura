using System;
using ByteBank.Funcionarios;

namespace ByteBank.Sistemas
{
  public class SistemaInterno
  {
    public bool Logar(Autenticavel funcionario, string senha)
    {
      bool usuarioAutenticado = funcionario.Autenticar(senha);

      Console.WriteLine(usuarioAutenticado
        ? "Bem-vindo ao sistema!"
        : "Senha incorreta."
      );

      return usuarioAutenticado;
    }
  }
}
