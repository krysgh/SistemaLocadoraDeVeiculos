using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace SistemaLocadoraDeVeiculos
{
    public class Endereco
    {
        private string Logradouro { get; set; }

        private int Numero { get; set; }

        private string Bairro { get; set; }

        private string Cidade { get; set; }
        
        private string Estado { get; set; }

        private string Pais { get; set; }

        private int CEP { get; set; }

        public Endereco(string logradouro, int numero, string bairro, string cidade, string estado, string pais, int cep)
        {
            this.Logradouro = logradouro;
            this.Numero = numero;
            this.Bairro = bairro;
            this.Cidade = cidade;
            this.Estado = estado;
            this.Pais = pais;
            this.CEP = cep;
        }   

        public string GetLogradouro()
        {
            return this.Logradouro;
        }

        public void SetLogradouro(string logradouro)
        {
            this.Logradouro = logradouro;
        }

        public int GetNumero()
        {
            return this.Numero;
        }

        public void SetNumero(int numero)
        {
            this.Numero = numero;
        }

        public string GetBairro()
        {
            return this.Bairro;
        }

        public void SetBairro(string bairro)
        {
            this.Bairro = bairro;
        }

        public string GetCidade()
        {
            return this.Cidade;
        }

        public void SetCidade(string cidade)
        {
            this.Cidade = cidade;
        }
        public string GetEstado()
        {
            return this.Estado;
        }

        public void SetEstado(string estado)
        {
            this.Estado = estado;
        }

        public string GetPais()
        {
            return this.Pais;
        }

        public void SetPais(string pais)
        {
            this.Pais = pais;
        }

        public int GetCEP()
        {
            return this.CEP;
        }

        public void SetCEP(int cep)
        {
            this.CEP = cep;
        }

        public override string ToString()
        {
            return $"{this.Logradouro}, " +
                $"{this.Numero} - " +
                $"{this.Bairro}, " +
                $"{this.Cidade} - " +
                $"{this.Estado}, " +
                $"{this.Pais}, " +
                $"{this.CEP}";
        }
    }
}
