using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_MetodosAbstratos.Entities
{
    class Individual : TaxPayer
    {
        public double HealthExpenditures { get; set; }

        public Individual(string name, double anualIncome,double healthExpenditures):base(name,anualIncome)
        {
            HealthExpenditures = healthExpenditures;
        }

        public override double Tax()
        {
            double calc = 0;
            if (AnualIncome >= 20000)
            {
                calc = AnualIncome * 0.25;
            }
            else
            {
                calc = AnualIncome * 0.15;
            }
            calc -= (HealthExpenditures / 2);

            return calc;

        }
    }
}
