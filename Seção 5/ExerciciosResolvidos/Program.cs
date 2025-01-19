namespace ExerciciosResolvidos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Ativiade respondida
            /*Console.Write("Entre com o númer da conta:");
            int conta = int.Parse(Console.ReadLine());
            Console.Write("Entre o tirular da conta:");
            string nome = Console.ReadLine();
            Console.Write("Haverá deposíto inicial (s/n)?");
            char despositotrue = char.Parse(Console.ReadLine());
            double depositoinicial = 0;
            ContaBanco ContaBanco = new ContaBanco(conta, depositoinicial, nome);

            if (despositotrue == 's')
            {
                Console.Write("Entre o valor de deposito inical:");
                depositoinicial = double.Parse(Console.ReadLine());
                ContaBanco.Deposito(depositoinicial);
                Console.WriteLine("Dados da conta:");
                ContaBanco.ToString();
            }
            else
            {
                ContaBanco.ToString();
            }

            Console.Write("Entre com um valor para deposito:");
            depositoinicial = double.Parse(Console.ReadLine());
            ContaBanco.Deposito(depositoinicial);
            Console.WriteLine("Dados da conta atualizado");
            ContaBanco.ToString();

            Console.Write("Entre com um valor para deposito:");
            depositoinicial = double.Parse(Console.ReadLine());
            ContaBanco.Saque(depositoinicial);
            Console.WriteLine("Dados da conta atualizado" + ContaBanco);*/

            //Correção

            ContaBancaria conta;

            Console.Write("Entre o númer da conta: ");
            int numero = int.Parse(Console.ReadLine());
            Console.Write("Entre o tirular da conta: ");
            string nome = Console.ReadLine();
            Console.Write("Haverá deposíto inicial (s/n)? ");
            char resposta = char.Parse(Console.ReadLine());

            if (resposta == 's' || resposta == 'S')
            {
                Console.Write("Entre o valor de depósito inical: ");
                double saldoInicial = double.Parse(Console.ReadLine());
                conta = new ContaBancaria(numero, nome, saldoInicial);
            }
            else
            {
                conta = new ContaBancaria(numero, nome);
            }
            Console.WriteLine();
            Console.WriteLine("Dados da Conta:");
            Console.WriteLine(conta);
            Console.WriteLine();

            Console.WriteLine("Entre um valor para deposito: ");
            double deposito = double.Parse(Console.ReadLine());
            conta.Deposito(deposito);
            Console.WriteLine();
            Console.WriteLine("Dados da conta atualizados: ");
            Console.WriteLine(conta);
            Console.WriteLine();

            Console.WriteLine("Entre um valor para saque: ");
            double saque = double.Parse(Console.ReadLine());
            Console.WriteLine();
            conta.Saque(saque);
            Console.WriteLine("Dados da conta atualizados:");
            Console.WriteLine(conta);
        }
    }
}
