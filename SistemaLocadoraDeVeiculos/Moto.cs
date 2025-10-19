using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaLocadoraDeVeiculos
{
    public class Moto : Veiculo
    {
        private int NumeroDeCapacetes { get; set; }
        
        private string TipoGuidao { get; set; }

        private bool TemBagageiro { get; set; }

        private bool TemBancoAjustavel { get; set; }

        private bool TemFreiosABS { get; set; }

        public Moto(string placa, string marca, string modelo, int anoDeFabricacao, string cor, double valorDaDiaria,
            int numeroDeCapacetes,string tipoGuidao,bool temBagageiro,bool temBancoAjustavel,bool temFreiosABS) 
            : base(placa,marca,modelo, anoDeFabricacao, cor, valorDaDiaria)
        {
            this.NumeroDeCapacetes = numeroDeCapacetes;
            this.TipoGuidao = tipoGuidao;
            this.TemBagageiro = temBagageiro;
            this.TemBancoAjustavel = temBancoAjustavel;
            this.TemFreiosABS = temFreiosABS;
        }

        public int GetNumeroDeCapacetes(){return this.NumeroDeCapacetes;}
        public string GetTipoGuidao(){return this.TipoGuidao;}
        public bool GetTemBagageiro(){return this.TemBagageiro;}
        public bool GetTemBancoAjustavel(){return this.TemBancoAjustavel;}
        public bool GetTemFreiosABS(){return this.TemFreiosABS;}

        public void SetNumeroDeCapacetes(int numeroDeCapacetes){this.NumeroDeCapacetes = numeroDeCapacetes;}
        public void SetTipoGuidao(string tipoGuidao){this.TipoGuidao = tipoGuidao;}
        public void SetTemBagageiro(bool temBagageiro){this.TemBagageiro = temBagageiro;}
        public void SetTeBancoAjustavel(bool temBancoAjustavel){this.TemBancoAjustavel = temBancoAjustavel;}
        public void SetTemFreiosABS(bool temFreiosABS){this.TemFreiosABS = temFreiosABS;}

        public override string ToString()
        {
            return $"MOTO\n" +
                $"{base.ToString()}\n" +
                $"Número de capacetes: {this.NumeroDeCapacetes}\n" +
                $"Tipo do guidão: {this.TipoGuidao}\n" +
                $"Tem bagageiro: {(this.TemBagageiro?"Sim":"Não")}\n" +
                $"Tem banco ajustável: {(this.TemBancoAjustavel ? "Sim" : "Não")}\n" +
                $"Tem freios ABS: {(this.TemFreiosABS ? "Sim" : "Não")}";
        }

    }
}
