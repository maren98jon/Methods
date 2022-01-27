using System;

namespace Met18
{
    class Program
    {
        static void Main(string[] args)
        {
            bool exit = false;
            while (!exit)
            {
                ShowCalcMenu();
                Console.WriteLine("Introduce la opción deseada: ");
                int userOption = Int32.Parse(Console.ReadLine());
                if (userOption<1 || 7<userOption)
                {
                    Console.WriteLine("Opción "+userOption+" no disponible, vuelva a intentarlo");
                }
                else if (userOption==7)
                {
                    exit = true;
                }
                else if (userOption==1)
                {
                    CalcSum();
                }
                else if (userOption==2)
                {
                    CalcMinus();
                }
                else if (userOption==3)
                {
                    CalcMultiplication();
                }
                else if (userOption==4)
                {
                    CalcPower();
                }
                else if (userOption==5)
                {
                    CalcFraction();
                }
                else if (userOption==6)
                {
                    CalcSquare();
                }
            }
            
        }

        static void CalcSum()
        {
            Console.WriteLine("Introduce un primer número: ");
            int firstNumber = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Introduce un segundo número: ");
            int secondNumber = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Operación seleccionada: Resta");
            Console.WriteLine(firstNumber + " + " + secondNumber + " = " + (firstNumber + secondNumber));
        }

        static void CalcMinus()
        {
            Console.WriteLine("Introduce un primer número: ");
            int firstNumber = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Introduce un segundo número: ");
            int secondNumber = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Operación seleccionada: Resta");
            Console.WriteLine(firstNumber + " - " + secondNumber + " = " + (firstNumber - secondNumber));
        }

            static void CalcMultiplication()
        {
            Console.WriteLine("Introduce un primer número: ");
            int firstNumber = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Introduce un segundo número: ");
            int secondNumber = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Operación seleccionada: Multiplicación");
            Console.WriteLine(firstNumber + " x " + secondNumber + " = "+ firstNumber*secondNumber);
        }

        static void CalcPower()
        {
            Console.WriteLine("Introduce un número: ");
            int number = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Operación seleccionada: Potencia");
            Console.WriteLine(number + Convert.ToChar(253) + "= " + Math.Pow(number,2));
        }

        static void CalcFraction()
        {
            Console.WriteLine("Introduce un primer número: ");
            int firstNumber = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Introduce un segundo número: ");
            int secondNumber = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Operación seleccionada: División");
            Console.WriteLine(firstNumber + " / " + secondNumber + " = " + (firstNumber / secondNumber));
        }

        static void CalcSquare()
        {
            Console.WriteLine("Introduce un número: ");
            int number = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Operación seleccionada: Raíz");
            Console.WriteLine(Convert.ToChar(251) + number + "= " +Math.Sqrt(number));
        }

        static void ShowCalcMenu()
        {
            Console.WriteLine("********************");
            Console.WriteLine("Calculadora");
            Console.WriteLine("********************");
            Console.WriteLine("1. Suma");
            Console.WriteLine("2. Resta");
            Console.WriteLine("3. Multiplicación");
            Console.WriteLine("4. Potencia");
            Console.WriteLine("5. División");
            Console.WriteLine("6. Raíz");
            Console.WriteLine("7. Salir");
        }
    }
}
