namespace ValidaPar
{
    class Program
    {
        static void Main(string[] args)
        {
            bool numeroPar = true;
            string mensagem = "O número escolhido pelo usuário é PAR!";
            byte numero = 3;

            if (numero % 2 == 1)
            {   
                numeroPar = false;
                mensagem = "O número escolhido pelo usuário é IMPAR!";
            }

            Console.WriteLine(mensagem);
        }
    }
}