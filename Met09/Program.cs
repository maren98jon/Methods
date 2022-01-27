using System;

namespace Met09
{
    class Program
    {
        static void Main(string[] args)
        {
            bool exit = false;
            while (!exit)
            {
                Console.WriteLine("Introduce el primer número: ");
                float userNum1 = Int32.Parse(Console.ReadLine());
                Console.WriteLine("Introduce el segundo número: ");
                int userNum2 = Int32.Parse(Console.ReadLine());
                if (userNum2!=0)
                {
                    Division(userNum1 , userNum2);
                }
                else
                {
                    exit = true;
                }
            }

            static void Division(float num1, int num2)
            {
                Console.WriteLine(num1 / num2);
                Console.WriteLine("");
            }
        }
    }
}
