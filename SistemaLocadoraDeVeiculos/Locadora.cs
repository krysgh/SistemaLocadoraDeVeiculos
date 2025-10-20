using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaLocadoraDeVeiculos
{
    public class Locadora
    {
        private List<Veiculo> VeiculosCadastrados { get; set; }

        private List<Pessoa> ClientesCadastrados { get; set; }

        private List<Aluguel> Alugueis { get; set; }

        public Locadora()
        {
            this.VeiculosCadastrados = new List<Veiculo>();
            this.ClientesCadastrados = new List<Pessoa>();
            this.Alugueis = new List<Aluguel>();
            
        }
        
        public void CadastrarVeiculo(Veiculo veiculo)
        {
            this.VeiculosCadastrados.Add(veiculo);
        }

        public void CadastrarCliente(Pessoa cliente)
        {
            this.ClientesCadastrados.Add(cliente);
        }

        public bool ClienteCadastrado(string nome, string sobrenome)
        {
            foreach (Cliente aux in ClientesCadastrados)
            {
                if (aux.GetNome() == nome && aux.GetSobrenome() == sobrenome)
                    return true;
                
            }
            
                return false;
        }
        public bool VeiculoCadastrado(string marca, string modelo)
        {
            foreach (Veiculo aux in VeiculosCadastrados)
            {
                if (aux.GetMarca() == marca && aux.GetModelo() == modelo)
                    return true;

            }

            return false;
        }


        public void AlugarVeiculo(string nome, string sobrenome, string marca, string modelo, int dias)
        {
            Cliente cliente = null;
            Veiculo veiculo = null;

            foreach(Cliente c in ClientesCadastrados)
            {
                if (ClienteCadastrado(nome, sobrenome))
                    cliente = c;
                else
                    Console.WriteLine("Cliente não cadastrado!\n");
            }

            foreach(Veiculo v in VeiculosCadastrados)
            {
                if(VeiculoCadastrado(marca, modelo))
                    veiculo = v;
                else
                    Console.WriteLine("Veículo não cadastrado!\n");
            }
                
                this.Alugueis.Add(new Aluguel(cliente, veiculo, dias));
        }

        public void ListarVeiculosCadastrados()
        {
            Console.WriteLine("LISTA DE VEÍCULOS CADASTRADOS\n\n");
            foreach(Veiculo v in VeiculosCadastrados)
            {
                Console.WriteLine(v.ToString() + "\n");
            }
            Console.WriteLine("-----------------------------\n\n");
        }

        public void ListarClientesCadastrados()
        {
            Console.WriteLine("LISTA DE CLIENTES CADASTRADOS\n\n");
            foreach (Cliente c in ClientesCadastrados)
            {
                Console.WriteLine(c.ToString() + "\n");
            }
            Console.WriteLine("-----------------------------------------------\n\n");
        }

        public void ListarLocacoes()
        {
            Console.WriteLine("LISTA DE LOCAÇÕES\n\n");
            foreach (Aluguel a in Alugueis)
            {
                Console.WriteLine(a.ToString() + "\n");
            }
            Console.WriteLine("-----------------------------\n\n");
        }

    }
}
