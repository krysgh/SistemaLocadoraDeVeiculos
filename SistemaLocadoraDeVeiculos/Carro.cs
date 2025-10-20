using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaLocadoraDeVeiculos
{
    public class Carro : Veiculo
    {
        private int NumeroDePortas { get; set; }

        private bool TemArCondicionado { get; set; }

        private bool TemDirecaoHidraulica { get; set; }

        private int NumeroAirBags { get; set; }

        private bool TemMultiMidia { get; set; }

        public Carro(string placa, string marca, string modelo, int anoDeFabricacao, string cor, double valorDaDiaria,
            int numeroDePortas, bool temArCondicionado, bool temDirecaoHidraulica, int numeroAirBags,bool temMultimidia ) 
            : base(placa,marca,modelo,anoDeFabricacao,cor,valorDaDiaria)
        {
            this.NumeroDePortas = numeroDePortas;
            this.TemArCondicionado = temArCondicionado;
            this.TemDirecaoHidraulica = temDirecaoHidraulica;
            this.NumeroAirBags = numeroAirBags;
            this.TemMultiMidia = temMultimidia;
        }

        public int GetNumeroDePortas(){return this.NumeroDePortas;}
        public bool GetTemArCondicionado(){return this.TemArCondicionado;}
        public bool GetTemDirecaoHidraulica(){return this.TemDirecaoHidraulica;}
        public int GetNumeroAirBags(){return this.NumeroAirBags;}
        public bool GetTemMultimidia(){ return this.TemMultiMidia; }

        public void SetNumeroDePortas(int numeroDePortas){this.NumeroDePortas = numeroDePortas;}
        public void SetTemArCondicionado(bool temArCondicionado){this.TemArCondicionado = temArCondicionado;}
        public void SetTemDirecaoHidraulica(bool temDirecaoHidraulica){this.TemDirecaoHidraulica = temDirecaoHidraulica;}
        public void SetNumeroAirBags(int numeroAirBags){this.NumeroAirBags = numeroAirBags;}
        public void SetTemMultimidia(bool temMultimidia){this.TemMultiMidia = temMultimidia;}

        public override string ToString()
        {
            return $"CARRO\n" +
                $"{base.ToString()}\n" +
                $"Número de portas: {this.NumeroDePortas}\n" +
                $"Tem ar condicionado: {(this.TemArCondicionado?"Sim": "Não")}\n" +
                $"Tem direção hidráulica: {(this.TemDirecaoHidraulica?"Sim":"Não")}\n" +
                $"Número de airbags: {this.NumeroAirBags}\n" +
                $"Tem multimídia: {(this.TemMultiMidia?"Sim": "Não")}";
        }

    }
}
