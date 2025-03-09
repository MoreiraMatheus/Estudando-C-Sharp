namespace Entrada_de_dados
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite algo para armazenar em uma variável: ");
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
            Console.WriteLine(cor3);
        }
    }
}