using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Impostos.Entities
{
    class Fisica : Pessoa
    {
        public double Saude { get; set; }

        public Fisica(string nome, double rendaAnual, double saude)
            :base(nome, rendaAnual)
        {
            Saude = saude;
        }

        public override double Imposto()
        {
            double impostos;
            if (RendaAnual < 20000)
            {
                impostos = RendaAnual * 0.15;
            }
            else
                impostos = RendaAnual * 0.25;

            if(Saude > 0)
            {
                impostos -= Saude * 0.5;
            }

            return impostos;
        }
    }
}
