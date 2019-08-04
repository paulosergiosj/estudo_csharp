using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_MetodosAbstratos.Entities
{
    class Company : TaxPayer
    {
        
        public int NumberOfEmployees { get; set; }

        public Company(string name, double anualIncome, int numberOfEmployees):base(name,anualIncome)
        {
            NumberOfEmployees = numberOfEmployees;
        }

        public override double Tax()
        {
            if (NumberOfEmployees > 10)
            {
                return AnualIncome * 0.14;
            }
            else
            {
                return AnualIncome * 0.16;
            }
        }
    }
}
