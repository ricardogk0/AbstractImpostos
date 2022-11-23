using System;
using System.Collections.Generic;
using Impostos.Entities;
using System.Globalization;

namespace Impostos
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Pessoa> list = new List<Pessoa>();

            Console.Write("Digite o número de pagadores: ");
            int op = int.Parse(Console.ReadLine());

            for(int i = 1; i <= op; i++)
            {
                Console.WriteLine($"Dados pagador #{i}");
                Console.Write("Fisica ou Juridica? (f ou j)");
                char tipo = char.Parse(Console.ReadLine());

                Console.Write("Nome: ");
                string nome = Console.ReadLine();

                Console.Write("Renda anual: ");
                double renda = double.Parse(Console.ReadLine());

                if(tipo == 'f')
                {
                    Console.Write("Gastos com saúde: ");
                    double saude = double.Parse(Console.ReadLine());
                    list.Add(new Fisica(nome, renda, saude));
                }
                else if (tipo == 'j')
                {
                    Console.Write("Número de funcionarios: ");
                    int func = int.Parse(Console.ReadLine());
                    list.Add(new Juridica(nome, renda, func));
                }
            }

            double total = 0;
            Console.WriteLine("\n\rImpostos pagos: ");
            foreach(Pessoa pessoa in list)
            {
                total += pessoa.Imposto();

                Console.WriteLine(pessoa.Nome + ": $ " + pessoa.Imposto().ToString("F2", CultureInfo.InvariantCulture));
            }

            Console.WriteLine("\n\rTotal de impostos: $ " + total.ToString("F2", CultureInfo.InvariantCulture));
        }

    }
}