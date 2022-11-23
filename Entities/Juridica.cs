using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Impostos.Entities
{
    class Juridica : Pessoa
    {
        public int Funcionarios { get; set; }

        public Juridica(string nome, double rendaAnual, int funcionarios)
            :base(nome, rendaAnual)
        {
            Funcionarios = funcionarios;
        }

        public override double Imposto()
        {
            double imposto;
            if (Funcionarios > 10)
            {
                imposto = RendaAnual * 0.14;
            }
            else
                imposto = RendaAnual * 0.16;

            return imposto;
        }
    }
}
