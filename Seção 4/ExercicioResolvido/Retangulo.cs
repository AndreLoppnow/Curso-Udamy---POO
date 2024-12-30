using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioResolvido
{
    internal class Retangulo
    {
        public double Base;
        public double Altura;

        public double Area()
        {
            double area = Base * Altura;
            return area;
        }

        public double Perimetro()
        {
            double perimetro = 2.0 * (Base + Altura);
            return perimetro;
        }
        public double Diagonal()
        {
            double diagonal = Math.Sqrt(Base * Base + Altura * Altura);
            return diagonal;
        }
    }
}
