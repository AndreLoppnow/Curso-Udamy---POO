using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosResolvidos
{
    internal class Estudante
    {
        public string Nome { get; set; }
        public string Email { get; set; }

        public Estudante(string pNome, string pEmail)
        {
            Nome = pNome;
            Email = pEmail;
        }

        public override string ToString()
        {
            return Nome + ", " + Email;
        }
    }
}
