using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaLocadoraDeVeiculos
{
    public abstract class Pessoa
    {
        private string Nome { get; set; }

        private string Sobrenome { get; set; }

        private char Sexo { get; set; }

        private DateTime DataNascimento { get; set; }

        public Pessoa(string nome, string sobrenome, char sexo, DateTime dataNascimento)
        {
            this.Nome = nome;
            this.Sobrenome = sobrenome;
            this.Sexo = sexo;
            this.DataNascimento = dataNascimento;
        }


        public string GetNome()
        {
            return this.Nome;
        }

        public void SetNome(string nome)
        {
            this.Nome = nome;
        }

        public string GetSobrenome()
        {
            return this.Sobrenome;
        }

        public void SetSobrenome(string sobrenome)
        {
            this.Sobrenome = sobrenome;
        }
        public char GetSexo()
        {
            return this.Sexo;
        }

        public void SetSexo(char sexo)
        {
            this.Sexo = sexo;
        }
        public DateTime GetDataNascimento()
        {
            return this.DataNascimento;
        }

        public void SetDataNascimento(DateTime dataNascimento)
        {
            this.DataNascimento = dataNascimento;
        }


        public override string ToString()
        {
            return $"Nome: {this.Nome}\n" +
                $"Sobrenome: {this.Sobrenome}\n" +
                $"Sexo: {this.Sexo}\n" +
                $"Data de nascimento: {this.DataNascimento:d}";
        }
    }
}
