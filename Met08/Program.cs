using System;

namespace Met08
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduce un número: ");
            int userNum = Int32.Parse(Console.ReadLine());
            if (EstaBien(userNum))
            {
                Console.WriteLine("Tu numero es de " + ContarCifras(userNum) + " cifras.");
            }
            else
            {
                Console.WriteLine("Tu numero es positivo");
            }
                
            

            static bool EstaBien(int num)
            {
                if (num>=0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }

            static int ContarCifras(int num)
            {
                return Convert.ToString(num).Length;
            }
        }
    }
}
