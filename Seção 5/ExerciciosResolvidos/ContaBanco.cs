using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosResolvidos
{
    internal class ContaBanco
    {
        private int _contaId;
        private string _nomeTitular; 
        private double _valorEmConta;

        public ContaBanco(int conta, double valorEmConta, string nomeTitular)
        {
            _contaId = conta;
            _nomeTitular = nomeTitular;
            _valorEmConta = valorEmConta;
        }

        public void Deposito(double quantidade)
        {
             _valorEmConta =+ quantidade;
        }

        public void Saque(double quantidade) 
        {
            _valorEmConta =- quantidade - 5;
        }

        public override string ToString()
        {
            return $"Conta {_contaId}, Titular: {_nomeTitular}, Saldo: $ {_valorEmConta}";
        }
    }
}
