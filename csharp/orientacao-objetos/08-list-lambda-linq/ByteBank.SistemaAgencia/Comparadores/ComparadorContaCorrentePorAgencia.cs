using System.Collections;
using System.Collections.Generic;
using ByteBank.Modelos;

namespace ByteBank.SistemaAgencia.Comparadores
{
  public class ComparadorContaCorrentePorAgencia : IComparer<ContaCorrente>
  {
    public int Compare(ContaCorrente x, ContaCorrente y)
    {
      if (x == null)
        return 1;

      return x.Agencia - y.Agencia;

      // Implementação já existente no tipo INT
      // return x.Agencia.CompareTo(y.Agencia);
    }
  }
}
