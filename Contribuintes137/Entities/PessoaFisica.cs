
namespace Contribuintes137.Entities
{
    class PessoaFisica : Contribuinte
    {
        public double GastoSaude { get; private set; }

        public PessoaFisica() { }

        public PessoaFisica(string nome, double rendaAnual, double gastoSaude) : base(nome, rendaAnual)
        {
            GastoSaude = gastoSaude;
        }

        public override double PagImposto()
        {
            double imposto = 0.0;
            if (RendaAnual > 20000.00)
            {
                imposto = RendaAnual * 0.25;
                if (GastoSaude > 0)
                {
                    imposto -= (GastoSaude * 0.5);
                }
                return imposto;
            }
            else
            {
                imposto = RendaAnual * 0.15;
                if (GastoSaude > 0)
                {
                    imposto -= (GastoSaude * 0.5);
                }
                return imposto;
            }
        }      
    }
}
