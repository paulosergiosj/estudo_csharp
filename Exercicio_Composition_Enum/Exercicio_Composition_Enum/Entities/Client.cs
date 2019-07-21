using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_Composition_Enum.Entities
{
    class Client
    {
        public string Nome { get; set; }
        public string Email { get; set; }
        public DateTime BirthDate { get; set; }

        public Client() { }

        public Client(string nome, string email, DateTime birthDate)
        {
            Nome = nome;
            Email = email;
            BirthDate = birthDate;
        }

        public override string ToString()
        {
            return Nome + " (" + BirthDate.ToString("dd/MM/yyyy") + ") - " + Email; 
        }
    }
}
