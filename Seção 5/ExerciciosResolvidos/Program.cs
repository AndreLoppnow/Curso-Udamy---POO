namespace ExerciciosResolvidos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Entre com o númer da conta:");
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
            Console.WriteLine("Dados da conta atualizado" + ContaBanco);
            



        }
    }
}
