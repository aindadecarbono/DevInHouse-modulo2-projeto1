namespace DEVCar;

public class Program
{
  static void Main(string[] args)
  {
    List<Veiculo> lista = Regras.GerarLista();
    List<Carro> listaCarro = Regras.GerarListaCarro();
    List<Camionete> listaCamionete = Regras.GerarListaCamionete();
    List<MotoTriciclo> listaMotoTriciclo = Regras.GerarListaMotoTriciclo();
    List<Veiculo> listaHistorico = new List<Veiculo>();
    Menu.BemVindo();
    Menu.ShowMenu(lista, listaCarro, listaCamionete, listaMotoTriciclo, listaHistorico);

  }
}