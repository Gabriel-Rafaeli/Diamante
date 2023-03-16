namespace Diamante.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero, espacos, asteriscos;

            Console.WriteLine("Digite um número impar: ");
            numero = int.Parse(Console.ReadLine());

            while (numero % 2 == 0)
            {
                Console.WriteLine("Este numero é par, tente novamente...");
                Console.WriteLine();
                Console.WriteLine("Digite um número impar: ");
                numero = int.Parse(Console.ReadLine());
            }

            asteriscos = 1;
            espacos = (numero - 1) / 2;
            for (int linha = 1; espacos > 0; linha++)
            {
                for (int count = 1; count <= espacos; count++)
                {
                    Console.Write(" ");
                }

                for (int count = 1; count <= asteriscos; count++)
                {
                    Console.Write("x");
                }
                espacos--;
                asteriscos += 2;
                Console.WriteLine();
            }
            for (int linha = 1; asteriscos > 0; linha++)
            {
                for (int count = 1; count <= espacos; count++)
                {
                    Console.Write(" ");
                }

                for (int count = 1; count <= asteriscos; count++)
                {
                    Console.Write("x");
                }

                espacos++;
                asteriscos -= 2;
                Console.WriteLine();
            }
        }
    }
}
