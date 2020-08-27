using Contribuintes137.Entities;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace Contribuintes137
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Contribuinte> list = new List<Contribuinte>();

            Console.Write("Entre com o numero de contribuintes: ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Dados do Contribuinte #{i}");
                Console.WriteLine("É pessoa fisica ou juridica (f/j)? ");
                char tipo = char.Parse(Console.ReadLine());
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("Renda anual: ");
                double renda = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if (tipo == 'f')
                {
                    Console.Write("Gasto com saúde: ");
                    double saude = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Contribuinte pf = new PessoaFisica(nome, renda, saude);
                    list.Add(pf);

                }
                else if (tipo == 'j')
                {
                    Console.Write("Quantidade de funcionários: ");
                    int func = int.Parse(Console.ReadLine());
                    Contribuinte pj = new PessoaJuridica(nome, renda, func);
                    list.Add(pj);
                }

            }
            double soma = 0.0;
            Console.WriteLine("Tributos pagos:");
            foreach (Contribuinte obj in list)
            {
                Console.WriteLine(obj);
                soma += obj.PagImposto();
            }

            Console.Write("Valor total:" + soma);
        }
    }
}
