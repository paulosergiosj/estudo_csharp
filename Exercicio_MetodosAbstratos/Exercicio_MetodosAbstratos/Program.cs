using Exercicio_MetodosAbstratos.Entities;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_MetodosAbstratos
{
    class Program
    {
        static void Main(string[] args)
        {
            double TotalTaxes = 0;
            List<TaxPayer> list = new List<TaxPayer>();
            Console.WriteLine("Enter the number of tax payers: ");
            int i = int.Parse(Console.ReadLine());

            for (int a = 1; a <= i ; a++)
            {
                Console.WriteLine($"Tax payer #{a} data:");
                Console.Write("Individual or Company(i/c)?");
                char type = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Anual Income: ");
                double anualIncome = double.Parse(Console.ReadLine());
                if(type == 'i')
                {
                    Console.Write("Health expenditures: ");
                    double healthExpenditures = double.Parse(Console.ReadLine());
                    list.Add(new Individual(name, anualIncome, healthExpenditures));
                }
                else
                {
                    Console.Write("Enter the number of employees: ");
                    int numberOfEmployees = int.Parse(Console.ReadLine());
                    list.Add(new Company(name, anualIncome, numberOfEmployees));
                }
            }
            Console.WriteLine();
            Console.WriteLine("TAXES PAYED: ");

            foreach(TaxPayer payer in list)
            {
                Console.WriteLine(payer.Name + ": $ " + payer.Tax().ToString("F2",CultureInfo.InvariantCulture));
                TotalTaxes += payer.Tax();
            }
            Console.WriteLine($"TOTAL TAXES: $ {TotalTaxes.ToString("F2", CultureInfo.InvariantCulture)} ");
            Console.ReadKey();
        }
       
    }
}
