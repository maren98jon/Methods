using System;

namespace Met10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduce un número: ");
            int userNum1 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Introduce otro número:");
            int userNum2 = Int32.Parse(Console.ReadLine());

            if (Mayor(userNum1,userNum2))
            {
                Console.WriteLine("El primer número es más grande");
            }
            else
            {
                Console.WriteLine("El primer número NO es más grande");
            }

            static bool Mayor(int num1,int num2)
            {
                return num1 > num2;
            }
        }
    }
}
