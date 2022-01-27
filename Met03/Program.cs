using System;

namespace Met03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduce un número:");
            int userNum1 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Introduce otro número:");
            int userNum2 = Int32.Parse(Console.ReadLine());

            Console.WriteLine("El resultado de la suma es: " + Suma(userNum1, userNum2));

            static int Suma(int num1,int num2)
            {
                int suma = num1 + num2;
                return suma;
            }
        }
    }
}
