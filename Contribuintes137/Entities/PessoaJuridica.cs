
namespace Contribuintes137.Entities
{
    class PessoaJuridica : Contribuinte
    {
        public int QuantFuncionarios { get; private set; }

        public PessoaJuridica() { }

        public PessoaJuridica(string nome, double rendaAnual, int quantFuncionarios) : base(nome, rendaAnual)
        {
            QuantFuncionarios = quantFuncionarios;
        }

        public override double PagImposto()
        {
            double imposto = 0.0;
            if (QuantFuncionarios > 10)
            {
                imposto = RendaAnual * 0.14;
            }
            else
            {
                imposto = RendaAnual * 0.16;

            }
            return imposto;
        }    
    }
}
