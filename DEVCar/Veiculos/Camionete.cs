namespace DEVCar;

public class Camionete : Veiculo
{
  public enum Portas
  {
    Duas = 2,
    Quatro = 4
  }

  public Portas Porta { get; set; }

  public uint CapacidadeCacamba { get; set; }

  public uint Potencia { get; set; }

  public enum Combustiveis
  {
    Gasolina = 1,
    Diesel
  }

  public Combustiveis Combustivel { get; set; }



  public Camionete(Portas porta, uint capacidadeCacamba, uint potencia, Combustiveis combustivel, Guid numeroChassi, DateTime dataFabricacao, string nome, string placa, decimal valor, ulong cpfComprador, Cores cor, TiposVeiculo tipoVeiculo, bool vendido) : base(numeroChassi, dataFabricacao, nome, placa, valor, cpfComprador, cor, tipoVeiculo, vendido)
  {
    Porta = porta;
    CapacidadeCacamba = capacidadeCacamba;
    Potencia = potencia;
    Combustivel = combustivel;

  }

}