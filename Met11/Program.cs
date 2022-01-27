using System;

namespace Met11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduce un año para saber si es bisiesto: ");
            int userYear = Int32.Parse(Console.ReadLine());
            Console.WriteLine("El año " + userYear + Bisiesto(userYear));

            static string Bisiesto(int year)
            {
                if (year%4==0)
                {
                    return " es bisiesto.";
                }
                else
                {
                    return " no es bisiesto.";
                }
            }
        }
    }
}
