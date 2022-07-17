namespace DEVCar;

abstract public class Veiculo : IComparable<Veiculo>
{
  protected Veiculo(Guid numeroChassi, DateTime dataFabricacao, string nome, string placa, decimal valor, ulong cpfComprador, Cores cor, TiposVeiculo tipoVeiculo, bool vendido)
  {
    NumeroChassi = numeroChassi;
    DataFabricacao = dataFabricacao;
    Nome = nome;
    Placa = placa;
    Valor = valor;
    CPFComprador = cpfComprador;
    Cor = cor;
    TipoVeiculo = tipoVeiculo;
    Vendido = vendido;
  }

  public Guid NumeroChassi { get; set; }

  public DateTime DataFabricacao { get; set; }

  public string Nome { get; set; }

  public string Placa { get; set; }

  public decimal Valor { get; set; }

  public ulong CPFComprador { get; set; }

  public enum Cores
  {
    Preto,
    Branco,
    Vermelho,
    Azul,
    Roxo
  }

  public Cores Cor { get; set; }

  public enum TiposVeiculo
  {
    CARRO,
    CAMIONETE,
    MOTO_TRICICLO
  }

  public TiposVeiculo TipoVeiculo { get; set; }

  public bool Vendido { get; set; }

  public DateTime DataVenda { get; set; }

  public void VenderVeiculo()
  {
    Menu.MenuHeaderLista();
    System.Console.WriteLine("Digite o CPF do comprador");
    CPFComprador = ulong.Parse(Console.ReadLine());
    Vendido = true;
    DataVenda = DateTime.Now;


    System.Console.WriteLine("Veículo vendido");
    System.Console.WriteLine(string.Empty);
    System.Console.WriteLine();
    System.Console.WriteLine($"({TipoVeiculo})");
    System.Console.WriteLine($"Nome: {Nome}");
    System.Console.WriteLine($"Valor: {Valor}");
    System.Console.WriteLine($"Placa: {Placa}");

  }

  public Veiculo ListarInformacoes()
  {
    return this;
  }

  public string AlterarInformacoes(Cores cor, decimal valor)
  {
    return "As seguintes informações foram alteradas: ...........";
  }

  public string AlterarInformacoes(Cores cor)
  {
    return "A seguinte informação foi alterada: ...........";
  }

  public string AlterarInformacoes(decimal valor)
  {
    //...
    return "A seguinte informação foi alterada: ...........";
  }

  public int CompareTo(Veiculo? comparacao)
  {
    if (Valor > comparacao.Valor)
      return 1;

    else if (Valor < comparacao.Valor)
      return -1;

    else return 0;
  }
}