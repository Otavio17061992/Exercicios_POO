using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoPOO3.Entities
{
    internal class LegalPerson : Person
    {
        public int Funcionarios { get; set; }

        public LegalPerson(int funcionarios,string nome,double rendaAnual)
            :base(nome,rendaAnual) 
        {
            Funcionarios= funcionarios;
        }

        public override double CalculoImposto()
        {
            if(Funcionarios <= 10)
            {
                return (RendaAnual * 0.16);
            }
            else
            {
                return (RendaAnual * 0.14);
            }
        }
    }
}
