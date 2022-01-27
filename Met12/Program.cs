using System;

namespace Met12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("¿Cuántos números quieres generar? ");
            int numQuantity = Int32.Parse(Console.ReadLine());
            Console.WriteLine("¿Cuál será el valor máximo? ");
            int numMax = Int32.Parse(Console.ReadLine());
            Console.WriteLine("¿Cuál será el valor mínimo? ");
            int numMin = Int32.Parse(Console.ReadLine());

            for (int i = 0; i < numQuantity; i++)
            {
                Console.WriteLine(ShowRndNum(numMin, numMax));
            }

            static int ShowRndNum(int min,int max)
            {
                Random rnd = new Random();
                return rnd.Next(min, max+1);
            }

        }
    }
}
