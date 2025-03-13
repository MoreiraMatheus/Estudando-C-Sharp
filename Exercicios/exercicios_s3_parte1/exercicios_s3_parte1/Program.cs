namespace exercicios_s3_p1
{
    class program
    {
        static void Main(String[] args)
        {
            double pi = 3.14159; // utilizado nos exercicios 2 e 6

            Console.WriteLine("---Exercicio 1---");
            Console.Write("Digite um número:");
            int n1 = int.Parse(Console.ReadLine());
            Console.Write("Digite outro número:");
            int n2 = int.Parse(Console.ReadLine());
            Console.WriteLine($"A soma desses dois valores é:{n1+n2}");

            Console.WriteLine("\n---Exercicio 2---");
            Console.Write("Irei calcular a área de um circulo com base em um raio.\nDigite o valor do raio de um circulo:");
            double raio = double.Parse(Console.ReadLine());
            Console.WriteLine($"A Área do circulo será:{pi * Math.Pow(raio, 2):F4}");

            Console.WriteLine("\n---Exercicio 3---");
            Console.WriteLine("Digite 4 números, vou te falar a diferença do produto entre eles:");
            Console.Write("A:");
            int a = int.Parse(Console.ReadLine());
            Console.Write("B:");
            int b = int.Parse(Console.ReadLine());
            Console.Write("C:");
            int c = int.Parse(Console.ReadLine());
            Console.Write("D:");
            int d = int.Parse(Console.ReadLine());
            Console.WriteLine($"O resultado da formula (A*B - C*D) será: {a*b-c*d}");

            Console.WriteLine("\n---Exercicio 4---");
            Console.Write("Digite seu número, suas horas trabalhadas e quanto você recebe por hora(Separados por espaço): ");
            string[] dadosFuncionario = Console.ReadLine().Split(' ');
            string numeroFuncionario = dadosFuncionario[0];
            int horasFuncionario = int.Parse(dadosFuncionario[1]);
            double valorHoraFuncionario = double.Parse(dadosFuncionario[2]);
            Console.WriteLine($"Seus dados são: \nNUMBER = {numeroFuncionario}\nSALARY = U$ {horasFuncionario * valorHoraFuncionario:F2}");

            Console.WriteLine("\n---Exercicio 5---");
            Console.WriteLine("Informe o código, quantidade e valor de uma peça(Separados por espaço): ");
            string[] peca1 = Console.ReadLine().Split(' ');
            int quantidade1 = int.Parse(peca1[1]);
            double valor1 = double.Parse(peca1[2]);
            Console.WriteLine("Informe o código, quantidade e valor de outra peça(Separados por espaço): ");
            string[] peca2 = Console.ReadLine().Split(' ');
            int quantidade2 = int.Parse(peca2[1]);
            double valor2 = double.Parse(peca2[2]);
            Console.WriteLine($"VALOR A PAGAR: R$ {(quantidade1 * valor1)+(quantidade2 * valor2):F2}");

            Console.WriteLine("\n---Exercicio 6---");
            Console.WriteLine("Digite 3 números");
            Console.Write("A: ");
            double a6 = double.Parse(Console.ReadLine());
            Console.Write("B: ");
            double b6 = double.Parse(Console.ReadLine());
            Console.Write("C: ");
            double c6 = double.Parse(Console.ReadLine());
            Console.WriteLine($"TRIANGULO: {(a6/2)*c6:F3}");
            Console.WriteLine($"CIRCULO: {pi * Math.Pow(c6, 2):F3}");
            Console.WriteLine($"TRAPEZIO: {(a6 + b6) * c6/2:F3}");
            Console.WriteLine($"QUADRADO: {Math.Pow(b6,2):F3}");
            Console.WriteLine($"RETANGULO: {a6 * b6:F3}");
        }
    }
}