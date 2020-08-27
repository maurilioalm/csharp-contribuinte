using System;
using System.Collections.Generic;
using System.Text;

namespace Contribuintes137.Entities
{
    abstract class Contribuinte
    {
        public string Nome { get; protected set; }
        public double RendaAnual { get; protected set; }

        public Contribuinte()
        {
        }

        protected Contribuinte(string nome, double rendaAnual)
        {
            Nome = nome;
            RendaAnual = rendaAnual;
        }
       

        public abstract double PagImposto();
        public override string ToString()
        {
            return Nome + "  $ " + PagImposto().ToString("F2");
        }
    }
}
