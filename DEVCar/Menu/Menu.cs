namespace DEVCar;

public static class Menu
{

  public static void MenuHeader()
  {
    Console.Clear();
    System.Console.WriteLine("DEVCar 1.0");
    System.Console.WriteLine("================");
    System.Console.WriteLine(string.Empty);
  }

  public static void MenuHeaderCadastro()
  {
    MenuHeader();
    System.Console.WriteLine("Cadastro de veículo");
    System.Console.WriteLine("------------------");
    System.Console.WriteLine(string.Empty);
  }
  public static void ShowMenu(List<Veiculo> lista, List<Carro> listaCarro, List<Camionete> listaCamionete, List<MotoTriciclo> listaMotoTriciclo, List<Veiculo> listaHistorico)
  {
    MenuHeader();
    System.Console.WriteLine("1 Cadastrar veículo");
    System.Console.WriteLine("2 Vender veículo");
    System.Console.WriteLine("3 Lista de veículos");
    System.Console.WriteLine("4 Acessar histórico das transferências");

    System.Console.WriteLine("0 Sair da aplicação");

    System.Console.WriteLine(string.Empty);

    System.Console.Write("Escolha a opção: ");

    switch (Console.ReadLine())
    {
      case "0": Console.Clear(); Environment.Exit(0); break;

      case "1": Regras.Cadastrar(lista, listaCarro, listaCamionete, listaMotoTriciclo, listaHistorico); break;

      case "2": Regras.Vender(lista, listaCarro, listaCamionete, listaMotoTriciclo, listaHistorico); break;

      case "3": Regras.AcessarRelatorios(lista, listaCarro, listaCamionete, listaMotoTriciclo, listaHistorico); break;

      case "4": Regras.AcessarHistorico(lista, listaCarro, listaCamionete, listaMotoTriciclo, listaHistorico); Console.ReadLine(); break;

      default:
        System.Console.WriteLine("Nenhuma das opções acima foi selecionada"); Console.ReadLine(); ShowMenu(lista, listaCarro, listaCamionete, listaMotoTriciclo, listaHistorico); break;
    }




  }
  public static void BemVindo()
  {
    Console.Clear();
    System.Console.WriteLine(@"
 ================================================
|       _____  ________      _______             |
|      |  __ \|  ____\ \    / / ____|            |
|      | |  | | |__   \ \  / / |     __ _ _ __   |
|      | |  | |  __|   \ \/ /| |    / _` | '__|  |
|      | |__| | |____   \  / | |___| (_| | |     |
|      |_____/|______|   \/   \_____\__,_|_|     |
|                                                |
 ================================================                                      
");
    System.Console.WriteLine("Bem vindo ao DEVCar\nAperte qualquer tecla para continuar...");
    Console.ReadLine();
  }

  public static void MenuCadastro(List<Veiculo> lista, List<Carro> listaCarro, List<Camionete> listaCamionete, List<MotoTriciclo> listaMotoTriciclo, List<Veiculo> listaHistorico)
  {
    MenuHeader();

    System.Console.WriteLine("O que você deseja cadastrar? \nEscolha a opção: ");
    System.Console.WriteLine(string.Empty);

    System.Console.WriteLine("1 Carro");
    System.Console.WriteLine("2 Camionete");
    System.Console.WriteLine("3 Moto/Triciclo");
    System.Console.WriteLine("0 Voltar ao menu");

    System.Console.WriteLine(string.Empty);

    switch (Console.ReadLine())
    {
      case "0": Console.Clear(); ShowMenu(lista, listaCarro, listaCamionete, listaMotoTriciclo, listaHistorico); break;

      case "1": Regras.CadastrarCarro(lista, listaCarro, listaCamionete, listaMotoTriciclo, listaHistorico); break;

      case "2": Regras.CadastrarCamionete(lista, listaCarro, listaCamionete, listaMotoTriciclo, listaHistorico); Console.ReadLine(); break;

      case "3": Regras.CadastrarMotoTriciclo(lista, listaCarro, listaCamionete, listaMotoTriciclo, listaHistorico); Console.ReadLine(); break;

      default:
        System.Console.WriteLine("Nenhuma das opções acima foi selecionada"); Console.ReadLine(); ShowMenu(lista, listaCarro, listaCamionete, listaMotoTriciclo, listaHistorico); break;
    }
  }

  public static Carro MenuCadastroCarro(List<Veiculo> lista)
  {

    MenuHeaderCadastro();
    Carro.Portas portas = MenuCadastrarQuantidadePortaCarro();


    MenuHeaderCadastro();
    Carro.Combustiveis combustivel = MenuCadastrarTipoCombustivelCarro();


    MenuHeaderCadastro();
    ushort potencia = MenuCadastrarPotencia();


    MenuHeaderCadastro();
    string nome = MenuCadastrarNome();


    MenuHeaderCadastro();
    uint valor = MenuCadastrarValor();


    MenuHeaderCadastro();
    ulong cpf = 0;

    MenuHeaderCadastro();
    Carro.Cores cor = MenuCadastrarCor();


    MenuHeaderCadastro();
    MenuConfirmarCadastroCarro(portas, combustivel, potencia, nome, valor, cor);


    Guid numeroChassi = Regras.CadastrarChassi(lista);
    string placa = Regras.CadastrarPlaca(lista);
    DateTime dataFabricacao = DateTime.Now;
    Carro.TiposVeiculo tipoVeiculo = Carro.TiposVeiculo.CARRO;
    bool vendido = false;


    Carro carro = new Carro(portas, combustivel, potencia, numeroChassi, dataFabricacao, nome, placa, valor, cpf, cor, tipoVeiculo, vendido);


    MenuHeaderCadastro();
    System.Console.WriteLine("Carro adicionado à lista");
    System.Console.WriteLine($"Carro: {nome}\nValor: R${valor}\nPortas: {portas}\nCombustível: {combustivel}\nPlaca: {placa}\nCor: {cor}\nData de fabricação: {dataFabricacao}\nNúmero do chassi: {numeroChassi}\nPressione qualquer tecla para continuar...");
    Console.ReadLine();

    return carro;

  }

  public static Camionete MenuCadastroCamionete(List<Veiculo> lista)
  {
    MenuHeaderCadastro();
    Camionete.Portas portas = MenuCadastrarQuantidadePortaCamionete();


    MenuHeaderCadastro();
    uint capacidadeCacamba = MenuCadastrarCapacidadeCacamba();


    MenuHeaderCadastro();
    Camionete.Combustiveis combustivel = MenuCadastrarTipoCombustivelCamionete();


    MenuHeaderCadastro();
    ushort potencia = MenuCadastrarPotencia();


    MenuHeaderCadastro();
    string nome = MenuCadastrarNome();


    MenuHeaderCadastro();
    uint valor = MenuCadastrarValor();


    MenuHeaderCadastro();
    ulong cpf = 0;


    MenuHeaderCadastro();
    Camionete.Cores cor = Camionete.Cores.Roxo;


    MenuHeaderCadastro();
    MenuConfirmarCadastroCamionete(portas, capacidadeCacamba, combustivel, potencia, nome, valor, cor);

    Guid numeroChassi = Regras.CadastrarChassi(lista);
    string placa = Regras.CadastrarPlaca(lista);
    DateTime dataFabricacao = DateTime.Now;
    Camionete.TiposVeiculo tipoVeiculo = Camionete.TiposVeiculo.CAMIONETE;
    bool vendido = false;


    Camionete camionete = new Camionete(portas, capacidadeCacamba, potencia, combustivel, numeroChassi, dataFabricacao, nome, placa, valor, cpf, cor, tipoVeiculo, vendido);


    MenuHeaderCadastro();
    System.Console.WriteLine("Camionete adicionada à lista");
    System.Console.WriteLine($"Camionete: {nome}\nValor: R${valor}\nPortas: {portas}\nCombustível: {combustivel}\nCapacidade de caçamba: {capacidadeCacamba} litros\nPlaca: {placa}\nCor: {cor}\nData de fabricação: {dataFabricacao}\nNúmero do chassi: {numeroChassi}\nPressione qualquer tecla para continuar...");
    Console.ReadLine();

    return camionete;
  }

  public static MotoTriciclo MenuCadastroMotoTriciclo(List<Veiculo> lista)
  {

    MenuHeaderCadastro();
    ushort potencia = MenuCadastrarPotencia();

    MenuHeaderCadastro();
    MotoTriciclo.Rodas roda = MenuCadastrarRodas();


    MenuHeaderCadastro();
    string nome = MenuCadastrarNome();


    MenuHeaderCadastro();
    uint valor = MenuCadastrarValor();


    MenuHeaderCadastro();
    ulong cpf = 0;


    MenuHeaderCadastro();
    MotoTriciclo.Cores cor = MenuCadastrarCor();


    MenuHeaderCadastro();
    MenuConfirmarCadastroMotoTriciclo(potencia, nome, valor, cor);

    Guid numeroChassi = Regras.CadastrarChassi(lista);
    string placa = Regras.CadastrarPlaca(lista);
    DateTime dataFabricacao = DateTime.Now;
    MotoTriciclo.TiposVeiculo tipoVeiculo = MotoTriciclo.TiposVeiculo.MOTO_TRICICLO;
    bool vendido = false;


    MotoTriciclo motoTriciclo = new MotoTriciclo(potencia, roda, numeroChassi, dataFabricacao, nome, placa, valor, cpf, cor, tipoVeiculo, vendido);


    MenuHeaderCadastro();
    System.Console.WriteLine("Veículo adicionado à lista");
    System.Console.WriteLine($"Veículo: {nome}\nValor: R${valor}\nPotência: {potencia}\nPlaca: {placa}\nCor: {cor}\nData de fabricação: {dataFabricacao}\nNúmero do chassi: {numeroChassi}\nPressione qualquer tecla para continuar...");
    Console.ReadLine();

    return motoTriciclo;
  }

  private static MotoTriciclo.Rodas MenuCadastrarRodas()
  {
    MotoTriciclo.Rodas rodas;
    System.Console.WriteLine("Quantidade de rodas: (3 ou 4)");
    string quantidadeRodas = Console.ReadLine()!;
    while (quantidadeRodas != "3" && quantidadeRodas != "4")
    {
      System.Console.WriteLine("Digite 3 ou 4");
      quantidadeRodas = Console.ReadLine()!;
    }

    rodas = quantidadeRodas == "3" ? MotoTriciclo.Rodas.Três : MotoTriciclo.Rodas.Quatro;
    System.Console.WriteLine($"{rodas} rodas.");
    Console.ReadLine();
    return quantidadeRodas == "3" ? MotoTriciclo.Rodas.Três : MotoTriciclo.Rodas.Quatro;

  }

  private static Carro.Portas MenuCadastrarQuantidadePortaCarro()
  {

    Carro.Portas portas;
    System.Console.WriteLine("Quantidade de portas: (2 ou 4)");
    string quantidadePorta = Console.ReadLine()!;
    while (quantidadePorta != "2" && quantidadePorta != "4")
    {
      System.Console.WriteLine("Digite 2 ou 4");
      quantidadePorta = Console.ReadLine()!;
    }

    portas = quantidadePorta == "2" ? Carro.Portas.Duas : Carro.Portas.Quatro;
    System.Console.WriteLine($"{portas} portas.");
    Console.ReadLine();
    return quantidadePorta == "2" ? Carro.Portas.Duas : Carro.Portas.Quatro;

  }

  private static Camionete.Portas MenuCadastrarQuantidadePortaCamionete()
  {

    System.Console.WriteLine("Quantidade de portas: (2 ou 4)");
    Camionete.Portas portas;
    string quantidadePorta = Console.ReadLine()!;
    while (quantidadePorta != "2" && quantidadePorta != "4")
    {
      System.Console.WriteLine("Digite 2 ou 4");
      quantidadePorta = Console.ReadLine()!;
    }

    portas = quantidadePorta == "2" ? Camionete.Portas.Duas : Camionete.Portas.Quatro;
    System.Console.WriteLine($"{portas} portas.");
    Console.ReadLine();
    return quantidadePorta == "2" ? Camionete.Portas.Duas : Camionete.Portas.Quatro;

  }

  private static Carro.Combustiveis MenuCadastrarTipoCombustivelCarro()
  {

    System.Console.WriteLine("Tipo de combustível: \n1  Flex\n2  Gasolina");
    string tipoCombustivel = Console.ReadLine()!;
    while (tipoCombustivel != "1" && tipoCombustivel != "2")
    {
      System.Console.WriteLine("Digite 1 para Flex e 2 para Gasolina");
      tipoCombustivel = Console.ReadLine()!;
    }

    Carro.Combustiveis combustivel = tipoCombustivel == "1" ? Carro.Combustiveis.Flex : Carro.Combustiveis.Gasolina;
    System.Console.WriteLine($"Combustível {combustivel}");
    Console.ReadLine();

    return tipoCombustivel == "1" ? Carro.Combustiveis.Flex : Carro.Combustiveis.Gasolina;
  }

  private static Camionete.Combustiveis MenuCadastrarTipoCombustivelCamionete()
  {

    System.Console.WriteLine("Tipo de combustível: \n1  Gasolina\n2  Diesel");
    string tipoCombustivel = Console.ReadLine()!;
    while (tipoCombustivel != "1" && tipoCombustivel != "2")
    {
      System.Console.WriteLine("Digite 1 para Gasolina e 2 para Diesel");
      tipoCombustivel = Console.ReadLine()!;
    }

    Camionete.Combustiveis combustivel = tipoCombustivel == "1" ? Camionete.Combustiveis.Gasolina : Camionete.Combustiveis.Diesel;
    System.Console.WriteLine($"Combustível {combustivel}");
    Console.ReadLine();

    return tipoCombustivel == "1" ? Camionete.Combustiveis.Gasolina : Camionete.Combustiveis.Diesel;
  }

  private static ushort MenuCadastrarPotencia()
  {
    System.Console.WriteLine("Digite a potência (em cavalos): ");
    string inputPotencia = Console.ReadLine()!;
    ushort potencia;
    while (!ushort.TryParse(inputPotencia, out potencia))
    {
      System.Console.WriteLine("Você não digitou um número. \nDigite a potência (em cavalos): ");
      potencia = UInt16.Parse(Console.ReadLine()!);
    }

    while (potencia < 1 || potencia > 1500)
    {
      System.Console.WriteLine("Digite a potência (em cavalos): ");
      potencia = UInt16.Parse(Console.ReadLine()!);
    }

    System.Console.WriteLine($"{potencia} HP");
    Console.ReadLine();

    return potencia;

  }

  private static string MenuCadastrarNome()
  {
    System.Console.WriteLine("Digite o nome do veículo: ");
    string nome = Console.ReadLine()!;

    System.Console.WriteLine($"Nome do veículo: {nome}");
    Console.ReadLine();

    return nome;
  }

  private static uint MenuCadastrarValor()
  {
    System.Console.WriteLine("Digite o valor do veículo: ");
    string inputValor = Console.ReadLine()!;
    uint valor;
    while (!uint.TryParse(inputValor, out valor))
    {
      System.Console.WriteLine("Você não digitou um número. \nDigite o valor do veículo: ");
      inputValor = Console.ReadLine()!;
    }

    while (valor < 1 || valor > 4_294_967_295)
    {
      System.Console.WriteLine("Digite o valor do veículo: ");
      valor = UInt32.Parse(Console.ReadLine()!);
    }

    System.Console.WriteLine($"Valor do veículo: R${valor}");
    Console.ReadLine();

    return valor;
  }



  private static Veiculo.Cores MenuCadastrarCor()
  {
    System.Console.WriteLine("Digite a cor do veículo: \n0  Preto\n1  Branco\n2 Vermelho\n3 Azul\n4 Roxo");
    string inputCor = Console.ReadLine()!;
    Veiculo.Cores cor = Veiculo.Cores.Azul;
    while (inputCor != "0" && inputCor != "1" && inputCor != "2" && inputCor != "3" && inputCor != "4")
    {
      System.Console.WriteLine("Digite a cor do veículo: \n0  Preto\n1  Branco\n2 Vermelho\n3 Azul\n4 Roxo");
      inputCor = Console.ReadLine()!;
    }
    switch (inputCor)
    {
      case "0": cor = Veiculo.Cores.Preto; break;
      case "1": cor = Veiculo.Cores.Branco; break;
      case "2": cor = Veiculo.Cores.Vermelho; break;
      case "3": cor = Veiculo.Cores.Azul; break;
      case "4": cor = Veiculo.Cores.Roxo; break;
      default: break;
    }

    System.Console.WriteLine($"Cor {cor}");
    Console.ReadLine();
    return cor;
  }

  private static uint MenuCadastrarCapacidadeCacamba()
  {
    System.Console.WriteLine("Digite a capacidade da caçamba: (em litros)");
    string inputValor = Console.ReadLine()!;
    uint valor;
    while (!uint.TryParse(inputValor, out valor))
    {
      System.Console.WriteLine("Você não digitou um número. \nDigite a capacidade da caçamba: (em litros)");
      inputValor = Console.ReadLine()!;
    }

    while (valor < 1 || valor > 4_294_967_295)
    {
      System.Console.WriteLine("Digite a capacidade da caçamba: (em litros)");
      valor = UInt32.Parse(Console.ReadLine()!);
    }

    System.Console.WriteLine($"Capacidade da caçamba: {valor} litros");
    Console.ReadLine();

    return valor;
  }

  private static void MenuConfirmarCadastroCarro(Carro.Portas portas, Carro.Combustiveis combustivel, ushort potencia, string nome, uint valor, Carro.Cores cor)
  {

    System.Console.WriteLine("Sumário de cadastro");
    System.Console.WriteLine("===================");
    System.Console.WriteLine($"Qtd de portas: {portas}\nCombustível: {combustivel}\nPotência: {potencia}\nNome: {nome}\nValor: R${valor}\nCor: {cor}");
    System.Console.WriteLine(string.Empty);
    System.Console.WriteLine("0  Alterar alguma informação\n1  Confirmar cadastro");
    string inputConfirmar = Console.ReadLine()!;
    while (inputConfirmar != "0" && inputConfirmar != "1")
    {
      System.Console.WriteLine("Digite 0 para alterar alguma informação\nDigite 1 para confirmar cadastro");
      inputConfirmar = Console.ReadLine()!;
    }

    if (inputConfirmar == "0")
    {
      MenuHeaderCadastro();
      System.Console.WriteLine("O que você deseja alterar?");
      System.Console.WriteLine("1  Qtd de portas\n2  Combustivel\n3  Potência\n4  Nome\n5  Valor\n6  Cor");
      string inputAlteracao = Console.ReadLine()!;
      while (inputAlteracao != "1" && inputAlteracao != "2" && inputAlteracao != "3" && inputAlteracao != "4" && inputAlteracao != "5" && inputAlteracao != "6")
      {
        System.Console.WriteLine("Alterar: \n1  Qtd de portas\n2  Combustivel\n3  Potência\n4  Nome\n5  Valor\n6  Cor");
        inputAlteracao = Console.ReadLine()!;
      }
      switch (inputAlteracao)
      {
        case "1": portas = MenuCadastrarQuantidadePortaCarro(); System.Console.WriteLine("(Atualizado)"); Console.ReadLine(); MenuConfirmarCadastroCarro(portas, combustivel, potencia, nome, valor, cor); break;

        case "2": combustivel = MenuCadastrarTipoCombustivelCarro(); System.Console.WriteLine("(Atualizado)"); Console.ReadLine(); MenuConfirmarCadastroCarro(portas, combustivel, potencia, nome, valor, cor); break;

        case "3": potencia = MenuCadastrarPotencia(); System.Console.WriteLine("(Atualizado)"); Console.ReadLine(); MenuConfirmarCadastroCarro(portas, combustivel, potencia, nome, valor, cor); break;

        case "4": nome = MenuCadastrarNome(); System.Console.WriteLine("(Atualizado)"); Console.ReadLine(); MenuConfirmarCadastroCarro(portas, combustivel, potencia, nome, valor, cor); break;

        case "5": valor = MenuCadastrarValor(); System.Console.WriteLine("(Atualizado)"); Console.ReadLine(); MenuConfirmarCadastroCarro(portas, combustivel, potencia, nome, valor, cor); break;

        case "6": cor = MenuCadastrarCor(); System.Console.WriteLine("(Atualizado)"); Console.ReadLine(); MenuConfirmarCadastroCarro(portas, combustivel, potencia, nome, valor, cor); break;

        default: break;
      }
      Console.ReadLine();
    }

    if (inputConfirmar == "1")
    {
      System.Console.WriteLine("Carro cadastrado com sucesso.");
      Console.ReadLine();
    }
  }


  private static void MenuConfirmarCadastroCamionete(Camionete.Portas portas, uint capacidadeCacamba, Camionete.Combustiveis combustivel, ushort potencia, string nome, uint valor, Camionete.Cores cor)
  {

    System.Console.WriteLine("Sumário de cadastro");
    System.Console.WriteLine("===================");
    System.Console.WriteLine($"Qtd de portas: {portas}\nCapacidade de caçamba: {capacidadeCacamba} litros\nCombustível: {combustivel}\nPotência: {potencia}\nNome: {nome}\nValor: R${valor}\nCor: {cor}");
    System.Console.WriteLine(string.Empty);
    System.Console.WriteLine("0  Alterar alguma informação\n1  Confirmar cadastro");
    string inputConfirmar = Console.ReadLine()!;
    while (inputConfirmar != "0" && inputConfirmar != "1")
    {
      System.Console.WriteLine("Digite 0 para alterar alguma informação\nDigite 1 para confirmar cadastro");
      inputConfirmar = Console.ReadLine()!;
    }

    if (inputConfirmar == "0")
    {
      MenuHeaderCadastro();
      System.Console.WriteLine("O que você deseja alterar?");
      System.Console.WriteLine("1  Qtd de portas\n2  Capacidade de caçamba  \n3  Combustível\n4  Potência\n5  Nome\n6  Valor");
      string inputAlteracao = Console.ReadLine()!;
      while (inputAlteracao != "1" && inputAlteracao != "1" && inputAlteracao != "2" && inputAlteracao != "3" && inputAlteracao != "4" && inputAlteracao != "5" && inputAlteracao != "6")
      {
        System.Console.WriteLine("Alterar: \n1  Qtd de portas\n2  Capacidade de caçamba  \n3  Combustível\n4  Potência\n5  Nome\n6  Valor");
        inputAlteracao = Console.ReadLine()!;
      }
      switch (inputAlteracao)
      {
        case "1": portas = MenuCadastrarQuantidadePortaCamionete(); System.Console.WriteLine("(Atualizado)"); Console.ReadLine(); MenuConfirmarCadastroCamionete(portas, capacidadeCacamba, combustivel, potencia, nome, valor, cor); break;

        case "2": capacidadeCacamba = MenuCadastrarCapacidadeCacamba(); System.Console.WriteLine("(Atualizado)"); Console.ReadLine(); MenuConfirmarCadastroCamionete(portas, capacidadeCacamba, combustivel, potencia, nome, valor, cor); break;

        case "3": combustivel = MenuCadastrarTipoCombustivelCamionete(); System.Console.WriteLine("(Atualizado)"); Console.ReadLine(); MenuConfirmarCadastroCamionete(portas, capacidadeCacamba, combustivel, potencia, nome, valor, cor); break;

        case "4": potencia = MenuCadastrarPotencia(); System.Console.WriteLine("(Atualizado)"); Console.ReadLine(); MenuConfirmarCadastroCamionete(portas, capacidadeCacamba, combustivel, potencia, nome, valor, cor); break;

        case "5": nome = MenuCadastrarNome(); System.Console.WriteLine("(Atualizado)"); Console.ReadLine(); MenuConfirmarCadastroCamionete(portas, capacidadeCacamba, combustivel, potencia, nome, valor, cor); break;

        case "6": valor = MenuCadastrarValor(); System.Console.WriteLine("(Atualizado)"); Console.ReadLine(); MenuConfirmarCadastroCamionete(portas, capacidadeCacamba, combustivel, potencia, nome, valor, cor); break;

        default: break;
      }
      Console.ReadLine();
    }

    if (inputConfirmar == "1")
    {
      System.Console.WriteLine("Camionete cadastrada com sucesso.");
      Console.ReadLine();
    }

  }

  private static void MenuConfirmarCadastroMotoTriciclo(ushort potencia, string nome, uint valor, MotoTriciclo.Cores cor)
  {

    System.Console.WriteLine("Sumário de cadastro");
    System.Console.WriteLine("===================");
    System.Console.WriteLine($"Nome: {nome}\nPotência: {potencia}\nValor: R${valor}\nCor: {cor}");
    System.Console.WriteLine(string.Empty);
    System.Console.WriteLine("0  Alterar alguma informação\n1  Confirmar cadastro");
    string inputConfirmar = Console.ReadLine()!;
    while (inputConfirmar != "0" && inputConfirmar != "1")
    {
      System.Console.WriteLine("Digite 0 para alterar alguma informação\nDigite 1 para confirmar cadastro");
      inputConfirmar = Console.ReadLine()!;
    }

    if (inputConfirmar == "0")
    {
      MenuHeaderCadastro();
      System.Console.WriteLine("O que você deseja alterar?");
      System.Console.WriteLine("1  Nome\n2  Potência\n3  Valor\n4  Cor");
      string inputAlteracao = Console.ReadLine()!;
      while (inputAlteracao != "1" && inputAlteracao != "2" && inputAlteracao != "3" && inputAlteracao != "4")
      {
        System.Console.WriteLine("Alterar: \n1  Nome\n2  Potência\n3  Valor\n4  Cor");
        inputAlteracao = Console.ReadLine()!;
      }
      switch (inputAlteracao)
      {
        case "1": nome = MenuCadastrarNome(); System.Console.WriteLine("(Atualizado)"); Console.ReadLine(); MenuConfirmarCadastroMotoTriciclo(potencia, nome, valor, cor); break;

        case "2": potencia = MenuCadastrarPotencia(); System.Console.WriteLine("(Atualizado)"); Console.ReadLine(); MenuConfirmarCadastroMotoTriciclo(potencia, nome, valor, cor); break;

        case "3": valor = MenuCadastrarValor(); System.Console.WriteLine("(Atualizado)"); Console.ReadLine(); MenuConfirmarCadastroMotoTriciclo(potencia, nome, valor, cor); break;

        case "4": cor = MenuCadastrarCor(); System.Console.WriteLine("(Atualizado)"); Console.ReadLine(); MenuConfirmarCadastroMotoTriciclo(potencia, nome, valor, cor); break;

        default: MenuConfirmarCadastroMotoTriciclo(potencia, nome, valor, cor); break;
      }
      Console.ReadLine();
    }

    if (inputConfirmar == "1")
    {
      System.Console.WriteLine("Veículo cadastrado com sucesso.");
      Console.ReadLine();
    }
  }

  public static void MenuHeaderLista()
  {
    MenuHeader();
    System.Console.WriteLine("Lista de veículos");
    System.Console.WriteLine("------------------");
    System.Console.WriteLine(string.Empty);
  }

}