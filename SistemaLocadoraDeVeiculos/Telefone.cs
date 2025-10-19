using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaLocadoraDeVeiculos
{
    public class Telefone
    {
        private int DDD { get; set; }

        private int Numero { get; set; }

        public Telefone(int DDD, int Numero)
        {
            this.DDD = DDD;
            this.Numero = Numero;
        }

        public int GetDDD()
        {
            return this.DDD;
        }

        public void SetDDD(int DDD)
        {
            this.DDD = DDD;
        }

        public int GetNumero()
        {
            return this.Numero;
        }

        public void SetNumero(int Numero)
        {
            this.Numero = Numero;
        }

        public override string ToString()
        {
            return $"({this.DDD}){this.Numero}";
        }

    }
}
