namespace _06_ByteBank
{
  class Cliente
  {
    private string _cpf;
    public string CPF
    {
      get => this._cpf;
      set
      {
        // Validação de CPF
        _cpf = value;
      }
    }

    public string Nome { get; set; }
    public string Profissao { get; set; }
  }
}
