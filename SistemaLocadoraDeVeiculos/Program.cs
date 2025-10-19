// See https://aka.ms/new-console-template for more information

using SistemaLocadoraDeVeiculos;

Cliente c = new Cliente("Roberto", "Carlos", 'M', Convert.ToDateTime("20/12/2000"), new Telefone(16, 991230978), new Endereco("Morada do Sol", 12, "Centro", "Florianópolis", "São Paulo", "Brasil", 13756000));

Console.WriteLine(c.ToString());

Console.WriteLine("\n");

Carro carro = new Carro("ABCDEF","Ford","K",2018,"Azul",1499.99,250,false,true,4,true);

Console.WriteLine(carro.ToString());

Console.WriteLine("\n");

Moto m = new Moto("CPK309","Honda","XJ6",2003,"Preto",699.99,2,"Normal",true,true,false);

Console.WriteLine(m.ToString());

Console.WriteLine("\n");

Caminhao caminhao = new Caminhao("A","B","C",2000,"Cinza",2000.99,2000,7.5,3,"Líquido");

Console.WriteLine(caminhao.ToString());