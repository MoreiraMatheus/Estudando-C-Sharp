using System;

class Program {
    static void Main(string[] args) {

        Console.WriteLine("\n---Simples---\n");

        Console.WriteLine("Não digite o número 1:");
        int num1 = int.Parse(Console.ReadLine());
        if (num1 == 1) {
            Console.Write("FALEI PRA NÃO DIGITAR!\nMas ok...");
        }
        Console.WriteLine($"O número digitado foi {num1}");

        Console.WriteLine("\n---Composta---\n");

        Console.Write("Escreva um numero inteiro: ");
        int num2 = int.Parse(Console.ReadLine());

        if (num2 % 2 == 0) {
            Console.WriteLine("Par!");
        }
        else {
            Console.WriteLine("Impar!");
        }

        Console.WriteLine("\n---Encadeamentos---\n");

        Console.WriteLine("Qual a hora atual?");
        int hora = int.Parse(Console.ReadLine());
        if (hora < 12) {
            Console.WriteLine("Bom dia!");
        }
        else if (12 <= hora && hora < 18) {
            Console.WriteLine("Boa tarde!");
        }
        else {
            Console.WriteLine("Boa noite!");
        }
    }
}