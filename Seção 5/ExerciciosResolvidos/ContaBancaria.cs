using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosResolvidos
{
    internal class ContaBancaria
    {
        public int Numero { get; private set; }
        public string Tituliar { get; set; }
        public double Saldo { get; private set; }

        public ContaBancaria(int numero, string tituliar)
        {
            Numero = numero;
            Tituliar = tituliar;
        }

        public ContaBancaria(int numero, string tituliar, double saldo) : this(numero, tituliar)
        {
            Saldo = saldo;
        }

        public void Deposito(double valor)
        {
            Saldo += valor;
        }

        public void Saque(double valor)
        {
            Saldo -= valor;
            Saldo -= 5.0;
        }

        public override string ToString()
        {
            return "Conta "
                    + Numero
                    + ", Titular: "
                    + Tituliar
                    + ", Saldo: $"
                    + Saldo.ToString("F2");
        }
    }
}
