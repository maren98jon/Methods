using System;

namespace Met04
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduce un número: ");
            int userNum = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Su factorial es: " + Factorial(userNum));

            static int Factorial(int num)
            {
                int factorial = 1;
                for (int i = 1; i < num+1; i++)
                {
                    factorial *= i;
                }
                return factorial;
            }
        }
    }
}
