﻿namespace exercicios_s3_p1
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

            Console.WriteLine("\n---Exercicio 2---");
            double pi = 3.14159;
            Console.WriteLine("Irei calcular a área de um circulo com base em um raio.\nDigite o valor do raio de um circulo:");
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
            Console.Write($"O resultado da formula (A*B - C*D) será: {a*b-c*d}");
        }
    }
}