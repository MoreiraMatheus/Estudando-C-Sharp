using System;

namespace operadores
{
    class Program
    {
        static void Main(string[] args)
        {
            //Operadores matemáticos
            int a = 10;
            //Menor
            bool c1 = a < 10;
            //Maior
            bool c2 = a > 20;
            //Igual
            bool c3 = a == 30;
            //Menor ou igual
            bool c4 = a <= 40;
            //Maior ou igual
            bool c5 = a >= 50;
            //Diferente
            bool c6 = a != 60;

            Console.WriteLine(c1);
            Console.WriteLine(c2);
            Console.WriteLine(c3);
            Console.WriteLine(c4);
            Console.WriteLine(c5);
            Console.WriteLine(c6);


        }
    }
}