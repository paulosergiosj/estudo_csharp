using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Estudo_Exceções.Entities;
using Estudo_Exceções.Entities.Exceptions;

namespace Estudo_Exceções
{
    class Program
    {
        static void Main(string[] args)
        {
            /*    try
                {
                    int a = int.Parse(Console.ReadLine());
                    int b = int.Parse(Console.ReadLine());

                    int result = a / b;
                }
                catch(DivideByZeroException e)
                {
                    Console.WriteLine("Erro! > "+ e.Message);
                }
                catch(FormatException e)
                {
                    Console.WriteLine("Erro! > "+e.Message);
                }
                Console.ReadKey();*/
            try
            {
                Console.Write("Room number: ");
                int number = int.Parse(Console.ReadLine());
                Console.Write("Check in date: ");
                DateTime checkIn = DateTime.Parse(Console.ReadLine());
                Console.Write("Check out date: ");
                DateTime checkOut = DateTime.Parse(Console.ReadLine());

                Reservation reservation = new Reservation(number, checkIn, checkOut);
            }
            catch(DomainException e)
            {
                Console.WriteLine("Error in reservation: "+e.Message);
            }
            catch (FormatException e)
            {
                Console.WriteLine("Format error: "+e.Message);
            }
            catch(Exception e)
            {
                Console.WriteLine("Unexpected: "+e.Message);
            }
        }
    }
}
