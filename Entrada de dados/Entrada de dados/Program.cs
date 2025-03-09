using System.Globalization;

namespace Entrada_de_dados
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Console.Write("Digite algo para armazenar em uma variável: ");
            string frase = Console.ReadLine();
            Console.WriteLine($"\nO texto digitado foi: {frase}");

            Console.WriteLine("\n---\n");

            Console.Write("Digite três cores: ");
            string cores = Console.ReadLine();
            string[] coresVet = cores.Split(' ');
            string cor1 = coresVet[0];
            string cor2 = coresVet[1];
            string cor3 = coresVet[2];
            Console.WriteLine("As cores digitadas foram:");
            Console.WriteLine(cor1);
            Console.WriteLine(cor2);
            Console.WriteLine(cor3);*/

            /*Console.Write("Digite seu nome: ");
            string nome = Console.ReadLine();

            Console.Write("Digite sua idade: ");
            int idade = int.Parse(Console.ReadLine());

            Console.Write("Digite seu sexo (M/F):");
            char sexoC = char.Parse(Console.ReadLine());
            string sexo;
            if(sexoC == 'M' || sexoC == 'm')
            {
                sexo = "Masculino";
            }
            else if(sexoC == 'F' || sexoC == 'f')
            {
                sexo = "Feminino";
            }
            else
            {
                sexo = "Dinossauro ROAR!";
            }

            Console.Write("Digite sua altura (0.00):");
            double altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine($"Pelos dados que recebi você se chama {nome} é do sexo {sexo}, possui {altura} de altura e tem {idade} anos.\n---\n");*/

            /*Console.WriteLine("Digite nome, sexo(M/F), idade e altura:");
            string[] dados = Console.ReadLine().Split(' ');
            string nome = dados[0];
            char sexo = char.Parse(dados[1]);
            int idade = int.Parse(dados[2]);
            double altura = double.Parse(dados[3], CultureInfo.InvariantCulture);

            Console.WriteLine("Você digitou:");
            Console.WriteLine(nome);
            Console.WriteLine(sexo);
            Console.WriteLine(idade);
            Console.WriteLine(altura);*/

            Console.WriteLine("Entre com seu nome completo:");
            string fullName = Console.ReadLine();
            Console.WriteLine("Quantos quartos tem na sua casa?");
            int numberOfRooms = int.Parse(Console.ReadLine());
            Console.WriteLine("Entre com o preço de um produto:");
            double price = double.Parse(Console.ReadLine());
            Console.WriteLine("Entre seu último nome, idade e altura (mesma linha):");
            string[] userInfos = Console.ReadLine().Split(' ');
            string lastName = userInfos[0];
            int age = int.Parse(userInfos[1]);
            double height = double.Parse(userInfos[2], CultureInfo.InvariantCulture);

            Console.WriteLine("Você digitou:");
            Console.WriteLine(fullName);
            Console.WriteLine(numberOfRooms);
            Console.WriteLine(price.ToString("F2"));
            Console.WriteLine(lastName);
            Console.WriteLine(age);
            Console.WriteLine(height);

            Console.WriteLine("\n---\n\nFim do programa.");
        }
    }
}