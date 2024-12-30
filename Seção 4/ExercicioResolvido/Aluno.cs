using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioResolvido
{
    internal class Aluno
    {
        public string Nome;
        public double NotaA, NotaB, NotaC;

        public double SomaDasNotas()
        {
            return NotaA + NotaB + NotaC;
        }

        public bool Aprovado()
        {
            if (SomaDasNotas() >= 60)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public double PontosFaltantes()
        {
            return 60 - SomaDasNotas();
        }
    }
}
