using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoPOO3.Entities
{
    abstract class Person
    {
        public string Nome { get; set; }
        public double RendaAnual { get; set; }


        public Person(string nome , double rendaAnual) 
        {
            Nome = nome;
            RendaAnual = rendaAnual;
        }

        public abstract double CalculoImposto();

    }
}
