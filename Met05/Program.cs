using System;

namespace Met05
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduce un número: ");
            int userNum = Int32.Parse(Console.ReadLine());
            //Console.WriteLine(EsPar(userNum))
            if (EsPar(userNum))
            {
                Console.WriteLine("El número es par.");
            }
            else
            {
                Console.WriteLine("El número es impar.");
            }

            //static string EsPar(int num)
            //{
            //    if (num%2==0)
            //    {
            //        return "El número es par.";
            //    } else
            //    {
            //        return "El número es impar.";
            //    }

            static bool EsPar(int num)
            {
                if (num % 2 == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            
        }
    }
}
