using System.Collections.Generic;

namespace ByteBank
{
  public static class ListExtensoes
  {
    public static void AdicionarVarios(List<int> lista, params int[] itens)
    {
      foreach (var item in itens)
        lista.Add(item);
    }
  }
}
