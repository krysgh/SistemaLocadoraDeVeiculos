using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaLocadoraDeVeiculos
{
    public class Aluguel
    {
        private Cliente ClienteAtivo { get; set; }

        private Veiculo VeiculoAlugado { get; set; }

        private double ValorTotal { get; set; }

        private int Dias { get; set; }

        public Aluguel(Cliente ClienteAtivo, Veiculo VeiculoAlugado, int Dias)
        {
            this.ClienteAtivo = ClienteAtivo;
            this.VeiculoAlugado = VeiculoAlugado;
            this.Dias = Dias;
            this.ValorTotal = Dias * VeiculoAlugado.GetValorDaDiaria();
        }

        public Cliente GetClienteAtivo()
        {
            return this.ClienteAtivo;
        } 

        public void SetClienteAtivo(Cliente ClienteAtivo)
        {
            this.ClienteAtivo = ClienteAtivo;
        }

        public Veiculo GetVeiculoAlugado()
        {
            return this.VeiculoAlugado;
        }

        public void SetVeiculoAlugado(Veiculo VeiculoAlugado)
        {
            this.VeiculoAlugado = VeiculoAlugado;
        }

        public double GetValorTotal()
        {
            return this.ValorTotal;
        }

        public int GetDias()
        {
            return this.Dias;
        }

        public void SetDias(int Dias)
        {
            this.Dias = Dias;
        }

        public override string ToString()
        {
            return $"Cliente: {this.ClienteAtivo}\n" +
                $"Veículo: {this.VeiculoAlugado}\n" +
                $"Dias: {this.Dias}\n" +
                $"Valor Total: {this.ValorTotal}";
        }
    }
}
