using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoPOO3.Entities
{
    class PhysicalPerson :Person
    {
        public double GastoSaude { get; set; }


        public PhysicalPerson(string Nome,double RendaAnual,double gastoSaude)
            : base(Nome, RendaAnual)
        {
            GastoSaude = gastoSaude;
        }

        public override double CalculoImposto()
        {
            if(RendaAnual < 20000.00)
            {
                return (RendaAnual * 0.15);
            }
            else
            {
                return (RendaAnual * 0.25) - (GastoSaude * 0.50);
            }
        }
    }
}
