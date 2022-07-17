using System.Text;

namespace DEVCar;

public static class Regras
{
  public static List<Veiculo> GerarLista()
  {
    List<Veiculo> lista = new List<Veiculo>();
    return lista;
  }

  public static List<Carro> GerarListaCarro()
  {
    List<Carro> listaCarro = new List<Carro>();
    return listaCarro;
  }

  public static List<Camionete> GerarListaCamionete()
  {
    List<Camionete> listaCamionete = new List<Camionete>();
    return listaCamionete;
  }

  public static List<MotoTriciclo> GerarListaMotoTriciclo()
  {
    List<MotoTriciclo> listaMotoTriciclo = new List<MotoTriciclo>();
    return listaMotoTriciclo;
  }

  public static void Cadastrar(List<Veiculo> lista, List<Carro> listaCarro, List<Camionete> listaCamionete, List<MotoTriciclo> listaMotoTriciclo, List<Veiculo> listaHistorico)
  {
    Menu.MenuCadastro(lista, listaCarro, listaCamionete, listaMotoTriciclo, listaHistorico);
  }

  public static void CadastrarCarro(List<Veiculo> lista, List<Carro> listaCarro, List<Camionete> listaCamionete, List<MotoTriciclo> listaMotoTriciclo, List<Veiculo> listaHistorico)
  {
    Carro veiculo = Menu.MenuCadastroCarro(lista);
    lista.Add(veiculo);
    listaCarro.Add(veiculo);
    Menu.ShowMenu(lista, listaCarro, listaCamionete, listaMotoTriciclo, listaHistorico);
  }

  public static void CadastrarCamionete(List<Veiculo> lista, List<Carro> listaCarro, List<Camionete> listaCamionete, List<MotoTriciclo> listaMotoTriciclo, List<Veiculo> listaHistorico)
  {
    Camionete veiculo = Menu.MenuCadastroCamionete(lista);
    lista.Add(veiculo);
    listaCamionete.Add(veiculo);
    Menu.ShowMenu(lista, listaCarro, listaCamionete, listaMotoTriciclo, listaHistorico);
  }

  public static void CadastrarMotoTriciclo(List<Veiculo> lista, List<Carro> listaCarro, List<Camionete> listaCamionete, List<MotoTriciclo> listaMotoTriciclo, List<Veiculo> listaHistorico)
  {
    MotoTriciclo veiculo = Menu.MenuCadastroMotoTriciclo(lista);
    lista.Add(veiculo);
    listaMotoTriciclo.Add(veiculo);
    Menu.ShowMenu(lista, listaCarro, listaCamionete, listaMotoTriciclo, listaHistorico);
  }

  public static void Vender(List<Veiculo> lista, List<Carro> listaCarro, List<Camionete> listaCamionete, List<MotoTriciclo> listaMotoTriciclo, List<Veiculo> listaHistorico)
  {
    Menu.MenuHeaderLista();
    List<Veiculo> listaVeiculosDisponiveis = lista.FindAll(elemento => elemento.Vendido == false);
    if (listaVeiculosDisponiveis.Count == 0)
    {
      System.Console.WriteLine("Lista vazia.");
      Console.ReadLine();
      Menu.ShowMenu(lista, listaCarro, listaCamionete, listaMotoTriciclo, listaHistorico);
    }

    int index = 1;
    foreach (Veiculo veiculo in listaVeiculosDisponiveis)
    {

      System.Console.WriteLine(index);
      System.Console.WriteLine($"({veiculo.TipoVeiculo})");
      System.Console.WriteLine(veiculo.Nome);
      System.Console.WriteLine(veiculo.Valor);
      System.Console.WriteLine(veiculo.Placa);
      System.Console.WriteLine("================");
      System.Console.WriteLine(string.Empty);
      index++;
    }

    System.Console.WriteLine("Que carro você gostaria de vender? Digite o índice: ");
    System.Console.WriteLine("Aperte 0 para voltar ao menu");


    string inputEscolha = Console.ReadLine()!;
    int escolha;
    while (!int.TryParse(inputEscolha, out escolha))
    {
      System.Console.WriteLine("Você não digitou um número. \nDigite 0 para sair ou o índice: ");
      escolha = Int32.Parse(Console.ReadLine()!);
    }

    if (escolha == 0)
      Menu.ShowMenu(lista, listaCarro, listaCamionete, listaMotoTriciclo, listaHistorico);

    Veiculo carroEscolhido = listaVeiculosDisponiveis[(escolha - 1)];

    Menu.MenuHeaderLista();
    System.Console.WriteLine("Você deseja vender este carro?");
    System.Console.WriteLine(string.Empty);
    System.Console.WriteLine($"({carroEscolhido.TipoVeiculo})");
    System.Console.WriteLine(carroEscolhido.Nome);
    System.Console.WriteLine(carroEscolhido.Valor);
    System.Console.WriteLine(carroEscolhido.Placa);
    System.Console.WriteLine(string.Empty);
    System.Console.WriteLine("Digite 1 para vender ou 2 para sair: ");


    inputEscolha = Console.ReadLine()!;
    while (!int.TryParse(inputEscolha, out escolha))
    {
      System.Console.WriteLine("Você não digitou um número. \nDigite 1 para vender ou 2 para sair: ");
      escolha = Int32.Parse(Console.ReadLine()!);
    }

    if (escolha == 2)
      Menu.ShowMenu(lista, listaCarro, listaCamionete, listaMotoTriciclo, listaHistorico);

    if (escolha == 1)
    {
      carroEscolhido.VenderVeiculo();
      listaHistorico.Add(carroEscolhido);
      Menu.ShowMenu(lista, listaCarro, listaCamionete, listaMotoTriciclo, listaHistorico);
    }

    else
      Menu.ShowMenu(lista, listaCarro, listaCamionete, listaMotoTriciclo, listaHistorico);
  }

  public static void AcessarHistorico(List<Veiculo> lista, List<Carro> listaCarro, List<Camionete> listaCamionete, List<MotoTriciclo> listaMotoTriciclo, List<Veiculo> listaHistorico)
  {

    Menu.MenuHeaderLista();
    if (listaHistorico.Count == 0)
    {
      System.Console.WriteLine("Lista vazia.");
      Console.ReadLine();
      Menu.ShowMenu(lista, listaCarro, listaCamionete, listaMotoTriciclo, listaHistorico);
    }
    foreach (var elemento in listaHistorico)
    {

      System.Console.WriteLine("=============");
      System.Console.WriteLine($"({elemento.TipoVeiculo})");
      System.Console.WriteLine($"Nome: {elemento.Nome}");
      System.Console.WriteLine($"Placa: {elemento.Placa}");
      System.Console.WriteLine($"Valor: R${elemento.Valor}");
      System.Console.WriteLine($"CPF do comprador: {elemento.CPFComprador}");
      System.Console.WriteLine($"Data de venda: {elemento.DataVenda}");

    }

    Console.ReadLine();
    Menu.ShowMenu(lista, listaCarro, listaCamionete, listaMotoTriciclo, listaHistorico);
  }

  public static void AcessarRelatorios(List<Veiculo> lista, List<Carro> listaCarro, List<Camionete> listaCamionete, List<MotoTriciclo> listaMotoTriciclo, List<Veiculo> listaHistorico)
  {
    Menu.MenuHeaderLista();
    System.Console.WriteLine("1  Listar todos os veículos");
    System.Console.WriteLine("2  Listar todos os carros");
    System.Console.WriteLine("3  Listar todos as camionetes");
    System.Console.WriteLine("4  Listar todos as motos e triciclos");
    System.Console.WriteLine("5  Listar todos os veículos disponíveis");
    System.Console.WriteLine("6  Listar todos os veículos vendidos");
    System.Console.WriteLine("7  Listar os veículos vendidos com maior preço");
    System.Console.WriteLine("8  Listar os veículos vendidos com menor preço");

    switch (Console.ReadLine())
    {
      case "1":

        Menu.MenuHeaderLista();
        if (lista.Count == 0)
        {
          System.Console.WriteLine("Lista vazia.");
          Console.ReadLine();
          Menu.ShowMenu(lista, listaCarro, listaCamionete, listaMotoTriciclo, listaHistorico);
          break;
        }
        foreach (var elemento in lista)
        {

          System.Console.WriteLine("=============");
          System.Console.WriteLine($"({elemento.TipoVeiculo})");
          System.Console.WriteLine($"Nome: {elemento.Nome}");
          System.Console.WriteLine("Placa: " + elemento.Placa);
          System.Console.WriteLine("Valor: R$" + elemento.Valor);

        }

        Console.ReadLine();
        Menu.ShowMenu(lista, listaCarro, listaCamionete, listaMotoTriciclo, listaHistorico);
        break;


      case "2":

        Menu.MenuHeaderLista();
        if (listaCarro.Count == 0)
        {
          System.Console.WriteLine("Lista vazia.");
          Console.ReadLine();
          Menu.ShowMenu(lista, listaCarro, listaCamionete, listaMotoTriciclo, listaHistorico);
          break;
        }
        foreach (var elemento in listaCarro)
        {

          System.Console.WriteLine("=============");
          System.Console.WriteLine($"Nome: {elemento.Nome}");
          System.Console.WriteLine("Placa: " + elemento.Placa);
          System.Console.WriteLine("Valor: R$" + elemento.Valor);
          System.Console.WriteLine($"Vendido: {elemento.Vendido}");
        }

        Console.ReadLine();
        Menu.ShowMenu(lista, listaCarro, listaCamionete, listaMotoTriciclo, listaHistorico);
        break;


      case "3":

        Menu.MenuHeaderLista();
        if (listaCamionete.Count == 0)
        {
          System.Console.WriteLine("Lista vazia.");
          Console.ReadLine();
          Menu.ShowMenu(lista, listaCarro, listaCamionete, listaMotoTriciclo, listaHistorico);
          break;
        }
        foreach (var elemento in listaCamionete)
        {

          System.Console.WriteLine("=============");
          System.Console.WriteLine(elemento.TipoVeiculo);
          System.Console.WriteLine($"Nome: {elemento.Nome}");
          System.Console.WriteLine("Placa: " + elemento.Placa);
          System.Console.WriteLine("Valor: R$" + elemento.Valor);
          System.Console.WriteLine($"Vendido: {elemento.Vendido}");
        }

        Console.ReadLine();
        Menu.ShowMenu(lista, listaCarro, listaCamionete, listaMotoTriciclo, listaHistorico);
        break;


      case "4":

        Menu.MenuHeaderLista();
        if (listaMotoTriciclo.Count == 0)
        {
          System.Console.WriteLine("Lista vazia.");
          Console.ReadLine();
          Menu.ShowMenu(lista, listaCarro, listaCamionete, listaMotoTriciclo, listaHistorico);
          break;
        }
        foreach (var elemento in listaMotoTriciclo)
        {

          System.Console.WriteLine("=============");
          System.Console.WriteLine(elemento.TipoVeiculo);
          System.Console.WriteLine($"Nome: {elemento.Nome}");
          System.Console.WriteLine($"Placa: {elemento.Placa}");
          System.Console.WriteLine($"Valor: R${elemento.Valor}");
          System.Console.WriteLine($"Vendido: {elemento.Vendido}");

        }

        Console.ReadLine();
        Menu.ShowMenu(lista, listaCarro, listaCamionete, listaMotoTriciclo, listaHistorico);
        break;


      case "5":

        Menu.MenuHeaderLista();
        List<Veiculo> listaVeiculosDisponiveis = lista.FindAll(elemento => elemento.Vendido == false);
        if (listaVeiculosDisponiveis.Count == 0)
        {
          System.Console.WriteLine("Lista vazia.");
          Console.ReadLine();
          Menu.ShowMenu(lista, listaCarro, listaCamionete, listaMotoTriciclo, listaHistorico);
          break;
        }

        foreach (Veiculo veiculo in listaVeiculosDisponiveis)
        {
          System.Console.WriteLine($"({veiculo.TipoVeiculo})");
          System.Console.WriteLine($"Nome: {veiculo.Nome}");
          System.Console.WriteLine($"Valor: R${veiculo.Valor}");
          System.Console.WriteLine($"Placa: {veiculo.Placa}");
          System.Console.WriteLine("================");
          System.Console.WriteLine(string.Empty);
        }

        Console.ReadLine();
        Menu.ShowMenu(lista, listaCarro, listaCamionete, listaMotoTriciclo, listaHistorico);
        break;


      case "6":

        Menu.MenuHeaderLista();
        List<Veiculo> listaVeiculosVendidos = lista.FindAll(elemento => elemento.Vendido == true);
        if (listaVeiculosVendidos.Count == 0)
        {
          System.Console.WriteLine("Lista vazia.");
          Console.ReadLine();
          Menu.ShowMenu(lista, listaCarro, listaCamionete, listaMotoTriciclo, listaHistorico);
          break;
        }

        foreach (Veiculo veiculo in listaVeiculosVendidos)
        {
          System.Console.WriteLine($"({veiculo.TipoVeiculo})");
          System.Console.WriteLine(veiculo.Nome);
          System.Console.WriteLine(veiculo.Valor);
          System.Console.WriteLine(veiculo.Placa);
          System.Console.WriteLine("================");
          System.Console.WriteLine(string.Empty);
        }

        Console.ReadLine();
        Menu.ShowMenu(lista, listaCarro, listaCamionete, listaMotoTriciclo, listaHistorico);
        break;


      case "7":

        Menu.MenuHeaderLista();
        List<Veiculo> listaVeiculosVendidosMenorPreco = lista.FindAll(elemento => elemento.Vendido == true);
        listaVeiculosVendidosMenorPreco.Reverse();

        if (listaVeiculosVendidosMenorPreco.Count == 0)
        {
          System.Console.WriteLine("Lista vazia.");
          Console.ReadLine();
          Menu.ShowMenu(lista, listaCarro, listaCamionete, listaMotoTriciclo, listaHistorico);
          break;
        }

        foreach (Veiculo veiculo in listaVeiculosVendidosMenorPreco)
        {
          System.Console.WriteLine($"({veiculo.TipoVeiculo})");
          System.Console.WriteLine(veiculo.Nome);
          System.Console.WriteLine(veiculo.Valor);
          System.Console.WriteLine(veiculo.Placa);
          System.Console.WriteLine("================");
          System.Console.WriteLine(string.Empty);
        }

        Console.ReadLine();
        Menu.ShowMenu(lista, listaCarro, listaCamionete, listaMotoTriciclo, listaHistorico);
        break;


      case "8":

        Menu.MenuHeaderLista();
        List<Veiculo> listaVeiculosVendidosMaiorPreco = lista.FindAll(elemento => elemento.Vendido == true);
        listaVeiculosVendidosMaiorPreco.Sort();

        if (listaVeiculosVendidosMaiorPreco.Count == 0)
        {
          System.Console.WriteLine("Lista vazia.");
          Console.ReadLine();
          Menu.ShowMenu(lista, listaCarro, listaCamionete, listaMotoTriciclo, listaHistorico);
          break;
        }

        foreach (Veiculo veiculo in listaVeiculosVendidosMaiorPreco)
        {
          System.Console.WriteLine($"({veiculo.TipoVeiculo})");
          System.Console.WriteLine(veiculo.Nome);
          System.Console.WriteLine(veiculo.Valor);
          System.Console.WriteLine(veiculo.Placa);
          System.Console.WriteLine("================");
          System.Console.WriteLine(string.Empty);
        }

        Console.ReadLine();
        Menu.ShowMenu(lista, listaCarro, listaCamionete, listaMotoTriciclo, listaHistorico);
        break;

      default: System.Console.WriteLine("Nenhuma das opções acima foi selecionada"); Console.ReadLine(); AcessarRelatorios(lista, listaCarro, listaCamionete, listaMotoTriciclo, listaHistorico); break;
    }

  }



  public static Guid CadastrarChassi(List<Veiculo> lista)
  {
    Guid chassi = Guid.NewGuid();
    foreach (Veiculo elemento in lista)
    {
      if (elemento.NumeroChassi == chassi)
      {
        chassi = new Guid();
      }
    }
    return chassi;
  }

  public static string CadastrarPlaca(List<Veiculo> lista)
  {
    string placa = GerarPlaca();

    return placa;

    string GerarPlaca()
    {
      string letras = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
      string numeros = "0123456789";
      Random random = new Random();
      string placa;
      StringBuilder placaObjeto = new StringBuilder();


      for (int i = 0; i <= 3; i++)
      {
        placaObjeto.Append(letras.ElementAt(random.Next(26)));
      }

      placaObjeto.Append(numeros.ElementAt(random.Next(10)));

      placaObjeto.Append(letras.ElementAt(random.Next(26)));

      for (int i = 0; i < 2; i++)
      {
        placaObjeto.Append(numeros.ElementAt(random.Next(10)));
      }

      placa = placaObjeto.ToString();

      foreach (Veiculo elemento in lista)
      {
        if (elemento.Placa == placaObjeto.ToString())
        {
          placa = GerarPlaca();
        }
      }

      return placa;
    }

  }

}