using System;
using System.Globalization;


namespace ORIENTAÇÃO_A_OBJETOS_CSHARP
{
    class Program
    {
        //exercicio 1 : criando uma classe pessoa.
        /*static void Main(string[] args)
        {
            Pessoa X, Y;

            X = new Pessoa();
            Y = new Pessoa();

            Console.WriteLine("Digite o nome e a idade da primeira pessoa: ");
            X.Nome = Console.ReadLine();
            X.Idade = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o nome e a idade da segunda pessoa: ");
            Y.Nome = Console.ReadLine();
            Y.Idade = double.Parse(Console.ReadLine());

            if (X.Idade > Y.Idade)
            {
                Console.WriteLine(X.Nome + " é a pessoa mais velha.");
            }
            else
            {
                Console.WriteLine(Y.Nome + " é a pessoa mais velha.");
            }
        }*/
        //exercicio 2 : 
        //usando o using System.Globalization; , CULTUREINFO.INVARIANTCULTURE e o TO STRING("F2", CULTUREINFO.INVARIANTCULTURE)
        /* static void Main(string[] args)
        {
            funcionario X, Y;
            X = new funcionario();
            Y = new funcionario();

            Console.WriteLine("Dados do primeiro funcionario");
            X.Nome = Console.ReadLine();
            X.salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Dados do segundo funcionario");
            Y.Nome = Console.ReadLine();
            Y.salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double media = (X.salario + Y.salario) / 2;

            Console.WriteLine("Salario medio = " + media.ToString("F2", CultureInfo.InvariantCulture));

        }*/

        //exercicio de classes.
        /*static void Main(string[] args)
        {
            produto x = new produto();
           

            Console.WriteLine("Entre com os dados do produto: ");
            Console.Write("Nome: ");
            x.nome = Console.ReadLine();
            Console.Write("Valor: ");
            x.valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantidade: ");
            x.quantidade = double.Parse(Console.ReadLine());

            Console.WriteLine(x.ToString());

            Console.WriteLine("Digite o número a ser adicionado ao estoque: ");
            x.add = double.Parse(Console.ReadLine());
            x.addproduto();

            Console.WriteLine("Digite o número a ser removido do estoque: ");
            x.remov = double.Parse(Console.ReadLine());
            x.removproduto();

        }*/
    }
}
