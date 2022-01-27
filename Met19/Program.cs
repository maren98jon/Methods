using System;

namespace Met19
{
    class Program
    {
        static void Main(string[] args)
        {
            int count5 = 0;
            int countPar = 0;
            int countPerf = 0;
            bool exit = false;
            while (!exit)
            {
                Console.WriteLine("Introduce un número: ");
                int userNum = Int32.Parse(Console.ReadLine());
                

                if (userNum!=0)
                {
                    if (MultiploDe5(userNum))
                    {
                        count5++;
                        if (EsPerfecto(userNum))
                        {
                            countPerf++;
                        }

                    }
                    else if (EsPar(userNum))
                    {
                        countPar++;
                        if (EsPerfecto(userNum))
                        {
                            countPerf++;
                        }
                    } else if (EsPerfecto(userNum))
                    {
                        countPerf++;
                    }                        
                } else
                {                
                    exit = true;
                }
            }
            Console.WriteLine();
            Console.WriteLine("Cantidad de números pares: " + countPar);
            Console.WriteLine("Cantidad de números perfectos: " + countPerf);
            Console.WriteLine("Cantidad de múltiplos de 5: " + count5);

            static bool MultiploDe5(int number)
            {
                return number % 5 == 0;
            }

            static bool EsPar(int number)
            {
                return number % 2 == 0;
            }

            static bool EsPerfecto(int number)
            {
                int suma = 0;
                for (int i = 1; i < number; i++)
                {
                    if (number % i == 0)
                    {
                        suma += i;
                    }
                }
                return suma == number;
            }
        }
    }
}
