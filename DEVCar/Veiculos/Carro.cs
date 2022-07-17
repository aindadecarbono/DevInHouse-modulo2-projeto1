namespace DEVCar;

public class Carro : Veiculo
{
  public enum Portas
  {
    Duas = 2,
    Quatro = 4
  }

  public Portas Porta { get; set; }

  public enum Combustiveis
  {
    Flex = 1,
    Gasolina
  }

  public Combustiveis Combustivel { get; set; }

  public uint Potencia { get; set; }


  public Carro(Portas porta, Combustiveis combustivel, uint potencia, Guid numeroChassi, DateTime dataFabricacao, string nome, string placa, decimal valor, ulong cpfComprador, Cores cor, TiposVeiculo tipoVeiculo, bool vendido) : base(numeroChassi, dataFabricacao, nome, placa, valor, cpfComprador, cor, tipoVeiculo, vendido)
  {
    Porta = porta;
    Combustivel = combustivel;
    Potencia = potencia;


  }
}