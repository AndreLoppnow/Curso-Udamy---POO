namespace Vetor_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Produto[] produtos = new Produto[n];

            for (int i = 0; i < n; i++)
            {
                string nome = Console.ReadLine();
                double valor = double.Parse(Console.ReadLine());
                produtos[i] = new Produto { Nome = nome, Preco = valor };

            }

            double soma = 0.0;
            for (int i = 0; i < n; i++)
            {
                soma += produtos[i].Preco;
            }

            double media = soma / n;
            Console.WriteLine("Average Price = " + media.ToString("F2"));
        }
    }
}
