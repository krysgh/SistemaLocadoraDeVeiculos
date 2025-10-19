using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace SistemaLocadoraDeVeiculos
{
    public class Caminhao : Veiculo
    {
        private double CapacidadeCargaKG { get; set; }

        private double ComprimentoMetros { get; set; }

        private int NumeroDeEixos { get; set; }

        private string TipoDeCarroceria { get; set; }

        public Caminhao(string placa, string marca, string modelo, int anoDeFabricacao, string cor, double valorDaDiaria,
            double capacidadeCargaKG,double comprimentoMetros, int numeroEixos, string tipoCarroceria) 
            : base(placa, marca, modelo, anoDeFabricacao, cor, valorDaDiaria)
        {
            this.CapacidadeCargaKG = capacidadeCargaKG;
            this.ComprimentoMetros = comprimentoMetros;
            this.NumeroDeEixos = numeroEixos;
            this.TipoDeCarroceria = tipoCarroceria;
        }

        public double GetCapacidadeCargaKG(){return this.CapacidadeCargaKG;}
        public double GetComprimentoMetros(){return this.ComprimentoMetros;}
        public int GetNumeroDeEixos(){return this.NumeroDeEixos;}
        public string GetTipoDeCarroceria() { return this.TipoDeCarroceria; }

        public void SetCapacidadeCargaKG(double capacidadeCargaKG){this.CapacidadeCargaKG = capacidadeCargaKG;}
        public void SetComprimentoMetros(double comprimentoMetros){this.ComprimentoMetros = comprimentoMetros;}
        public void SetNumeroDeEixos(int numeroDeEixos){this.NumeroDeEixos = numeroDeEixos;}
        public void SetTipoDeCarroceria(string tipoDeCarroceria){this.TipoDeCarroceria = tipoDeCarroceria;}

        public override string ToString()
        {
            return $"CAMINHÃO\n" +
                $"{base.ToString()}\n" +
                $"Capacidade de carga (kg): {this.CapacidadeCargaKG}\n" +
                $"Comprimento (m): {this.ComprimentoMetros}\n" +
                $"Número de eixos: {this.NumeroDeEixos}\n" +
                $"Tipo de carroceria: {this.TipoDeCarroceria}";
        }

    }
}
