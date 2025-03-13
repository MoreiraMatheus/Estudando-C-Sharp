namespace exercicios_s3_p1
{
    class program
    {
        static void Main(String[] args)
        {
            Console.WriteLine("---Exercicio 1---");
            Console.WriteLine("Digite um número:");
            int n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite outro número:");
            int n2 = int.Parse(Console.ReadLine());
            Console.WriteLine($"A soma desses dois valores é:{n1+n2}");
        }
    }
}