using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaLocadoraDeVeiculos
{
    public class Cliente : Pessoa
    {
        private Telefone Telefone;

        private Endereco Endereco;

        public Cliente(string nome, string sobrenome, char sexo, DateTime dataNascimento, Telefone telefone, Endereco endereco) : base(nome, sobrenome, sexo, dataNascimento)
        {
            this.Telefone = telefone;
            this.Endereco = endereco;
        }

        public override string ToString()
        {
            return
                $"\n{base.ToString()}\n" +
                $"Telefone: {this.Telefone.ToString()}\n" +
                $"Endereço: {this.Endereco.ToString()}";
        }


    }
}
