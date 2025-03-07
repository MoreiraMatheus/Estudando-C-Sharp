namespace TiposDeDados
{
    class Program
    {
        static void Main(string[] args)
        {
            byte tipo1 = 255;
            bool tipo2 = false;
            double tipo3 = 3.4;
            float tipo4 = 3.4f;
            char tipo5 = 'A'; //char só guarda 1 caracere e nada mais, fora isso ele usa aspas simples
            string tipo6 = "Matheus"; //String em C# funciona como em outras linguagens, é uma cadeia de caracteres, e usa aspas duplas


            tipo1++;

            if (tipo1 == 0)
            {
                tipo2 = true;
            }

            Console.WriteLine("Isso é um Byte " + tipo1);
            Console.WriteLine("Isso é uma variável booleana " + tipo2);
            Console.WriteLine("Isso é um Double " + tipo3);
            Console.WriteLine("E isso aqui é um Float " + tipo4);
            Console.WriteLine("Isso é um char " + tipo5);
        }
    }
}