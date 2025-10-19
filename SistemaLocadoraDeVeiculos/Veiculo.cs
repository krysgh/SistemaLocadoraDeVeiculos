using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaLocadoraDeVeiculos
{
    public abstract class Veiculo
    {
        private string Placa { get; set; }

        private string Marca { get; set; }

        private string Modelo { get; set; }

        private int AnoDeFabricacao { get; set; }

        private string Cor { get; set; }

        private double ValorDaDiaria { get; set; }

        public Veiculo(string placa, string marca, string modelo, int anoFabricacao, string cor, double valorDaDiaria)
        {
            this.Placa = placa;
            this.Marca = marca;
            this.Modelo = modelo;
            this.AnoDeFabricacao = anoFabricacao;
            this.Cor = cor;
            this.ValorDaDiaria = valorDaDiaria;
        }

        public string GetPlaca(){return this.Placa;}
        public string GetMarca(){return this.Marca;}
        public string GetModelo(){return this.Modelo;}
        public int GetAnoDeFabricacao() {return this.AnoDeFabricacao;}
        public string GetCor(){return this.Cor;}
        public double GetValorDaDiaria() { return this.ValorDaDiaria; }

        public void SetPlaca(string placa) { this.Placa = placa;}
        public void SetMarca(string marca) { this.Marca = marca; }
        public void SetModelo(string modelo) { this.Modelo = modelo; }
        public void SetAnoDeFabricacao(int anoDeFabricacao) { this.AnoDeFabricacao = anoDeFabricacao; }
        public void SetCor(string cor) { this.Cor = cor; }
        public void SetValorDaDiaria(double valorDaDiaria) { this.ValorDaDiaria = valorDaDiaria; }

        public override string ToString()
        {
            return $"Placa: {this.Placa}\n" +
                $"Marca: {this.Marca}\n" +
                $"Modelo: {this.Modelo}\n" +
                $"Ano de fabricação: {this.AnoDeFabricacao}\n" +
                $"Cor: {this.Cor}\n" +
                $"Valor da diária: {this.ValorDaDiaria}";
        }



    }
}
