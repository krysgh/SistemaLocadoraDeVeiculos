// See https://aka.ms/new-console-template for more information

using SistemaLocadoraDeVeiculos;


/*
Cliente c = new Cliente("Roberto", "Carlos", 'M', Convert.ToDateTime("20/12/2000"), new Telefone(16, 991230978), new Endereco("Morada do Sol", 12, "Centro", "Florianópolis", "São Paulo", "Brasil", 13756000));

Carro carro = new Carro("ABCDEF","Ford","K",2018,"Azul",1499.99,250,false,true,4,true);

Moto m = new Moto("CPK309","Honda","XJ6",2003,"Preto",699.99,2,"Normal",true,true,false);


Caminhao caminhao = new Caminhao("A","B","C",2000,"Cinza",2000.99,2000,7.5,3,"Líquido");

*/

void AvisoOpcaoInexistente()
{
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.WriteLine("Digite uma opção válida!\n");
    Console.ResetColor();
}

Veiculo CadastrarInfoGeralVeiculo(Veiculo v)
{
    Console.Write("Informe a placa do veículo: ");
    v.SetPlaca(Console.ReadLine()!);
    Console.Write("Informe a marca do veículo: ");
    v.SetMarca(Console.ReadLine()!);
    Console.Write("Informe o modelo do veículo: ");
    v.SetModelo(Console.ReadLine()!);
    Console.Write("Informe a cor do veículo: ");
    v.SetCor(Console.ReadLine()!);
    Console.Write("Informe o valor da diária do veículo: ");
    v.SetValorDaDiaria(Convert.ToDouble(Console.ReadLine()));

    return v;
}

Locadora locadora = new Locadora();
int opMenu, tipoVeiculo;

do
{
    Console.Write("1 - Cadastrar veículo\n" +
        "2 - Cadastrar cliente\n" +
        "3 - Registrar locação\n" +
        "4 - Calcular valor total\n" +
        "5 - Listar veículos cadastrados\n" +
        "6 - Listar clientes cadastrados\n" +
        "7 - Listar locações\n" +
        "8 - Encerrar programa\n\n" +
        "Informe a opção desejada: ");
    opMenu = Convert.ToInt32(Console.ReadLine()!);
    Console.Clear();


    switch (opMenu)
    {
        case 1:
            do
            {
                Console.Write("CADASTRO DE VEÍCULOS\n\n" +
                    "1 - Carro\n" +
                    "2 - Moto\n" +
                    "3 - Caminhão\n\n" +
                    "Informe o tipo de veículo desejado: ");
                tipoVeiculo = Convert.ToInt32(Console.ReadLine()!);
                Console.Clear();



                switch(tipoVeiculo)
                {
                    case 1:
                        
                        Console.WriteLine("CADASTRO DE CARRO\n");
                        Console.Write("Informe a placa do veículo: ");
                        string placaCarro = Console.ReadLine()!;
                        Console.Write("Informe a marca do veículo: ");
                        string marcaCarro = Console.ReadLine()!;
                        Console.Write("Informe o modelo do veículo: ");
                        string modeloCarro = Console.ReadLine()!;
                        Console.Write("Informe o ano de fabricação do veículo: ");
                        int anoDeFabricacaoCarro = Convert.ToInt32(Console.ReadLine()!);
                        Console.Write("Informe a cor do veículo: ");
                        string corCarro = Console.ReadLine()!;
                        Console.Write("Informe o valor da diária do veículo: ");
                        double valorDiariaCarro = Convert.ToDouble(Console.ReadLine());

                        Console.Write("Informe o número de portas do veículo: ");
                        int numeroPortas = Convert.ToInt32(Console.ReadLine()!);
                        Console.Write("Informe se o veículo possui ar condicionado  [1]Sim [2]Não: ");
                        bool temArCondicionado = (Console.ReadLine() == "1" ? true:false);
                        Console.Write("Informe se o veículo tem direção hidráulica  [1]Sim [2]Não: ");
                        bool temDirecaoHidraulica = (Console.ReadLine() == "1" ? true : false);
                        Console.Write("Informe o número de airbags do veículo: ");
                        int numeroAirBags = Convert.ToInt32(Console.ReadLine()!);
                        Console.Write("Informe se o veículo tem multimídia  [1]Sim [2]Não: ");
                        bool temMultimidia = (Console.ReadLine() == "1" ? true : false);


                        locadora.CadastrarVeiculo(new Carro(placaCarro,marcaCarro,modeloCarro,anoDeFabricacaoCarro,corCarro,valorDiariaCarro,numeroPortas,temArCondicionado,temDirecaoHidraulica,numeroAirBags,temMultimidia));
                        Console.Clear();
                        break;
                    case 2:
                        Console.WriteLine("CADASTRO DE MOTO\n");
                        Console.Write("Informe a placa do veículo: ");
                        string placaMoto = Console.ReadLine()!;
                        Console.Write("Informe a marca do veículo: ");
                        string marcaMoto = Console.ReadLine()!;
                        Console.Write("Informe o modelo do veículo: ");
                        string modeloMoto = Console.ReadLine()!;
                        Console.Write("Informe o ano de fabricação do veículo: ");
                        int anoDeFabricacaoMoto = Convert.ToInt32(Console.ReadLine()!);
                        Console.Write("Informe a cor do veículo: ");
                        string corMoto = Console.ReadLine()!;
                        Console.Write("Informe o valor da diária do veículo: ");
                        double valorDiariaMoto = Convert.ToDouble(Console.ReadLine());

                        Console.Write("Informe o número de capacetes do veículo: ");
                        int numeroCapacetes = Convert.ToInt32(Console.ReadLine()!);
                        Console.Write("Informe o tipo de guidão do veículo: ");
                        string tipoGuidao = Console.ReadLine()!;
                        Console.Write("Informe se o veículo tem bagageiro  [1]Sim [2]Não: ");
                        bool temBagageiro = (Console.ReadLine() == "1" ? true : false);
                        Console.Write("Informe se o veículo tem banco ajustável  [1]Sim [2]Não: ");
                        bool temBancoAjustavel = (Console.ReadLine() == "1" ? true : false);
                        Console.Write("Informe se o veículo tem freios ABS  [1]Sim [2]Não: ");
                        bool temFreiosABS = (Console.ReadLine() == "1" ? true : false);


                        locadora.CadastrarVeiculo(new Moto(placaMoto, marcaMoto, modeloMoto, anoDeFabricacaoMoto, corMoto, valorDiariaMoto, numeroCapacetes, tipoGuidao, temBagageiro, temBancoAjustavel, temFreiosABS));
                        Console.Clear();
                        break;
                    case 3:
                        Console.WriteLine("CADASTRO DE CAMINHÃO\n");
                        Console.Write("Informe a placa do veículo: ");
                        string placaCaminhao = Console.ReadLine()!;
                        Console.Write("Informe a marca do veículo: ");
                        string marcaCaminhao = Console.ReadLine()!;
                        Console.Write("Informe o modelo do veículo: ");
                        string modeloCaminhao = Console.ReadLine()!;
                        Console.Write("Informe o ano de fabricação do veículo: ");
                        int anoDeFabricacaoCaminhao = Convert.ToInt32(Console.ReadLine()!);
                        Console.Write("Informe a cor do veículo: ");
                        string corCaminhao = Console.ReadLine()!;
                        Console.Write("Informe o valor da diária do veículo: ");
                        double valorDiariaCaminhao = Convert.ToDouble(Console.ReadLine());



                        Console.Write("Informe a capacidade de carga(kg) do veículo: ");
                        double capacidadeCargaKG = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Informe o comprimento(m) do veículo: ");
                        double comprimentoMetros = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Informe o número de eixos do veículo: ");
                        int numeroEixos = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Informe o tipo de carroceria do veículo: ");
                        string tipoCarroceria = Console.ReadLine()!;


                        locadora.CadastrarVeiculo(new Caminhao(placaCaminhao, marcaCaminhao, modeloCaminhao, anoDeFabricacaoCaminhao, corCaminhao, valorDiariaCaminhao, capacidadeCargaKG,comprimentoMetros,numeroEixos,tipoCarroceria));
                        Console.Clear();
                        break;
                    default:
                        AvisoOpcaoInexistente();
                        break;
                }
            } while (tipoVeiculo < 1 || tipoVeiculo > 3);

            break;
        case 2:
            Console.WriteLine("CADASTRO DE CLIENTES\n");
            Console.Write("Informe o nome do cliente: ");
            string nome = Console.ReadLine()!;
            Console.Write("Informe o sobrenome do cliente: ");
            string sobrenome = Console.ReadLine()!;
            Console.Write("Informe o sexo do cliente: ");
            char sexo = Convert.ToChar(Console.ReadLine()!);
            Console.Write("Informe a data de nascimento do cliente: ");
            DateTime dtNascimento = Convert.ToDateTime(Console.ReadLine()!);
            Console.Write("Informe o DDD do telefone do cliente: ");
            int ddd = Convert.ToInt32(Console.ReadLine()!);
            Console.Write("Informe o número de telefone do cliente: ");
            int numero = Convert.ToInt32(Console.ReadLine()!);
            Console.Write("Informe o logradouro do cliente: ");
            string logradouro = Console.ReadLine()!;
            Console.Write("Informe o número da casa do cliente: ");
            int numeroCasa = Convert.ToInt32(Console.ReadLine()!);
            Console.Write("Informe o bairro do cliente: ");
            string bairro = Console.ReadLine()!;
            Console.Write("Informe a cidade do cliente: ");
            string cidade = Console.ReadLine()!;
            Console.Write("Informe o estado do cliente: ");
            string estado = Console.ReadLine()!;
            Console.Write("Informe o país do cliente: ");
            string pais = Console.ReadLine()!;
            Console.Write("Informe o CEP do cliente: ");
            int cep = Convert.ToInt32(Console.ReadLine()!);


            locadora.CadastrarCliente(new Cliente(nome,sobrenome,sexo,dtNascimento,new Telefone(ddd,numero),new Endereco(logradouro,numeroCasa,bairro,cidade,estado,pais,cep)));
            Console.Clear();
            break;
        case 3:
            Console.WriteLine("REALIZAR LOCAÇÃO\n\n");
            Console.Write("Informe o nome do cliente: ");
            string nomeCliente = Console.ReadLine()!;
            Console.Write("Informe o sobrenome do cliente: ");
            string sobrenomeCliente = Console.ReadLine()!;
            Console.Write("Informe a marca do veículo: ");
            string marcaVeiculo = Console.ReadLine()!;
            Console.Write("Informe o modelo do veículo: ");
            string modeloVeiculo = Console.ReadLine()!;
            Console.Write("Informe o número de dias do aluguel: ");
            int dias = Convert.ToInt32(Console.ReadLine()!);

            locadora.AlugarVeiculo(nomeCliente, sobrenomeCliente, marcaVeiculo, modeloVeiculo, dias);
            break;
        case 4:
            break;
        case 5:
            locadora.ListarVeiculosCadastrados();
            break;
        case 6:
            locadora.ListarClientesCadastrados();
            break;
        case 7:
            locadora.ListarLocacoes();
            break;
        case 8:
            Console.WriteLine("Encerrando programa...");
            break;
        default:
            AvisoOpcaoInexistente();
            break;
    }


} while (opMenu != 8);


