using System.Globalization;

namespace SaidaDedados
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bom dia!");
            Console.WriteLine("Boa tarde!");
            Console.Write("Ou...");
            Console.WriteLine("Boa noite!");

            Console.WriteLine("\n---\n");
            //Apresentando variáveis na tela

            string nome = "Maria";
            int idade = 32;
            char sexo = 'F';
            double saldo = 110.243433;

            Console.Write(nome);
            Console.Write(" tem ");
            Console.Write(idade);
            Console.Write(" anos e possui um saldo na conta no valor de R$");
            Console.WriteLine(saldo.ToString("F2"));
            //Esse tratamento feito no saldo com o "toString" é pra que seja apresentada somente 2 casas depois da virgula
            //Caso deseje apresentar o resultado com ponto ao invés da virgula, basta fazer da seguinte forma:
            Console.WriteLine(saldo.ToString("F2", CultureInfo.InvariantCulture));

            Console.WriteLine("\n---\n");
            //Apresentando variáveis na tela de forma mais simples...

            //Com placeholders
            Console.WriteLine("{0} tem {1} anos e possui um saldo na conta no valor de R${2:F2}", nome, idade, saldo); //O ":F2" depois do 2 é para delimitar o número de casas depois da virgula
            //O C# substitui os indices pelas variáveis passadas no final

            //Com interpolação
            Console.WriteLine($"{nome} tem {idade} anos e possui um saldo na conta no valor de R${saldo:F2}");

            //Com concatenação
            Console.WriteLine(nome + " tem " + idade + " anos e possui um saldo na conta no valor de R$" + saldo.ToString("F2"));

            Console.WriteLine("\n---Exercicio de Fixação---\n");

            string produto1 = "Computador";
            string produto2 = "Mesa de escritório";

            byte idadeExercicio = 30;
            int codigo = 5290;
            char genero = 'M';

            double preco1 = 2100.0;
            double preco2 = 650.50;
            double medida = 53.234567;

            Console.WriteLine("Produtos:");
            Console.WriteLine($"{produto1}, cujo preço é R${preco1:F2}");
            Console.WriteLine($"{produto2}, cujo preço é R${preco2:F2}\n");
            Console.WriteLine($"Registro: {idadeExercicio} anos de idade, código {codigo} e gênero: {genero}\n");
            Console.WriteLine($"Medida com oito casas decimais: {medida:F8}");
            Console.WriteLine($"Arredondado (três casas decimais): {medida:F3}");
            Console.WriteLine($"Separador decimal invariant culture: {medida.ToString("F3", CultureInfo.InvariantCulture)}");
        }
    }
}