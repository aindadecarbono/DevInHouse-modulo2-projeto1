namespace DEVCar;

public class MotoTriciclo : Veiculo
{
  public int Potencia { get; set; }
  public enum Rodas
  {
    Três = 3,
    Quatro
  }

  public Rodas Roda { get; set; }


  public MotoTriciclo(int potencia, Rodas roda, Guid numeroChassi, DateTime dataFabricacao, string nome, string placa, decimal valor, ulong cpfComprador, Cores cor, TiposVeiculo tipoVeiculo, bool vendido) : base(numeroChassi, dataFabricacao, nome, placa, valor, cpfComprador, cor, tipoVeiculo, vendido)
  {
    Potencia = potencia;
    Roda = roda;

  }
}