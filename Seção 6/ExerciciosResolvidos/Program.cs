namespace ExerciciosResolvidos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Estudante[] estudantes = new Estudante[10];

            Console.Write("Quantos quartos serão alugados? ");
            int qtdQuartos = int.Parse(Console.ReadLine());

            for (int i = 1; i <= qtdQuartos; i++)
            {
                Console.WriteLine();
                Console.WriteLine($"Aluguel #{i} ");
                Console.Write("Nome do estudante: ");
                string nome = Console.ReadLine();
                Console.Write("Email do estudante: ");
                string email = Console.ReadLine();
                Console.Write("Qual quarto será alugado? ");
                int quarto = int.Parse(Console.ReadLine());
                estudantes[quarto] = new Estudante(nome, email);
            }
            Console.WriteLine();
            Console.WriteLine("Quartos alugados:");

            for (int i = 0; i < 10; i++)
            {
                if (estudantes[i] != null)
                {
                    Console.WriteLine(i + ": " + estudantes[i]);
                }
            } 

        }
    }
}
