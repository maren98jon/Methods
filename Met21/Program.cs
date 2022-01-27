using System;

namespace Met21
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduce un número para convertirlo en binario.");
            int userNum = Int32.Parse(Console.ReadLine());
            Console.WriteLine(NumeroBinario(userNum));

            static string NumeroBinario(int numero)
            {
                string binario = string.Empty;
                do
                {
                    binario = (numero % 2 + binario);
                    numero /= 2;
                } while (numero / 2 >= 1);
                    binario = numero + binario;
                return binario;
            }
        }
    }
}
