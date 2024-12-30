
namespace ExercicioResolvido
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            //Exercicio quem tem a idade maior:
            /*Pessoa x, y;
            
            x = new Pessoa();
            y = new Pessoa();

            Console.WriteLine("Dados da primeira pessoa:");
            x.nome = Console.ReadLine();
            x.idade = int.Parse(Console.ReadLine());
            Console.WriteLine("Dados da segunda pessoa:");
            y.nome = Console.ReadLine();
            y.idade = int.Parse(Console.ReadLine());

            if (y.idade > x.idade)
            {
                Console.WriteLine("Pessoa mais velha: " + y.nome);
            }
            else { Console.WriteLine("Pessoa mais velha: " + x.nome); }*/

            //Exercicio média dos salários:
            /*SalarioFuncionarios x = new SalarioFuncionarios();
            SalarioFuncionarios y = new SalarioFuncionarios();

            Console.WriteLine("Dados do primeiro funcionario: ");
            x.nome = Console.ReadLine();
            x.salario = double.Parse(Console.ReadLine());
            Console.WriteLine("Dados do Segundo funcionario: ");
            y.nome = Console.ReadLine();
            y.salario = double.Parse(Console.ReadLine());
            double media = (x.salario + y.salario) / 2.0;
            Console.WriteLine("Salário médio = " + media.ToString("F2"));*/

            //Exercicio calculo do retangulo:
            /*Retangulo retangulo = new Retangulo();
            Console.WriteLine("Entre com a largura e altura do retângulo: ");
            retangulo.Base = double.Parse(Console.ReadLine());
            retangulo.Altura = double.Parse(Console.ReadLine());

            Console.WriteLine("AREA = " + retangulo.Area().ToString("F2"));
            Console.WriteLine("PERIMETRO = " + retangulo.Perimetro().ToString("F2"));
            Console.WriteLine("DIAGONAL = " + retangulo.Diagonal().ToString("F2"));*/

            //Calculo Aumento do Salário:
            /*Funcionario funcionario = new Funcionario();
            Console.Write("Nome: ");
            funcionario.Nome = Console.ReadLine();
            Console.Write("Salario Bruto: ");
            funcionario.SalarioBruto = double.Parse(Console.ReadLine());
            Console.Write("Imposto: ");
            funcionario.Imposto = double.Parse(Console.ReadLine());

            Console.WriteLine("Funcionário: " + funcionario);
            Console.Write("Digite a porcentagem para aumentar o salario: ");
            funcionario.AumentarSalario(double.Parse(Console.ReadLine()));
            Console.WriteLine("Dados atualizados: " + funcionario);*/

            //Validar se o Aluno está aprovado ou não:
            /*Aluno a = new Aluno();
            Aluno b = new Aluno();

            Console.Write("Nome do Aluno: ");
            a.Nome = Console.ReadLine();
            Console.WriteLine("Digite oas três notas do aluno: ");
            a.NotaA = double.Parse(Console.ReadLine());
            a.NotaB = double.Parse(Console.ReadLine());
            a.NotaC = double.Parse(Console.ReadLine());
            Console.WriteLine("NOTA FINAL = " + a.SomaDasNotas().ToString("F2"));

            if (a.Aprovado() == true)
            {
                Console.WriteLine("Aprovado");
            }
            else
            {
                Console.WriteLine("Reprovado");
                Console.WriteLine("Faltaram" + a.PontosFaltantes().ToString("F2") + "Pontos");
            }

            Console.Write("Nome do Aluno: ");
            b.Nome = Console.ReadLine();
            Console.WriteLine("Digite oas três notas do aluno: ");
            b.NotaA = double.Parse(Console.ReadLine());
            b.NotaB = double.Parse(Console.ReadLine());
            a.NotaC = double.Parse(Console.ReadLine());
            Console.WriteLine("NOTA FINAL = " + b.SomaDasNotas().ToString("F2"));

            if (b.Aprovado() == true)
            {
                Console.WriteLine("Aprovado");
            }
            else
            {
                Console.WriteLine("Reprovado");
                Console.WriteLine("Faltaram " + b.PontosFaltantes().ToString("F2") + " Pontos");
            }*/
           

        }
    }
}
