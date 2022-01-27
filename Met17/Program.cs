using System;

namespace Met17
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("De qúe figura quieres calcular el área: ");
            Console.WriteLine("1- Círculo");
            Console.WriteLine("2- Cuadrado");
            Console.WriteLine("3- Triángulo");
            Console.WriteLine("Introduce el número de tu opción: ");
            int userOption = Int32.Parse(Console.ReadLine());
            switch (userOption)
            {
                case 1:
                    Console.WriteLine("Introduzca el radio: ");
                    int circleRadius = Int32.Parse(Console.ReadLine());
                    Console.WriteLine("El área de tu circulo es: " + CircleArea(circleRadius));

                        break;

                case 2:
                    Console.WriteLine("Introduzca la altura del rectángulo: ");
                    int rectangleHeight = Int32.Parse(Console.ReadLine());
                    Console.WriteLine("Introduzca la anchura del rectángulo: ");
                    int rectangleWide = Int32.Parse(Console.ReadLine());
                    Console.WriteLine("El área de tu cuadrado es: " + RectangleArea(rectangleHeight,rectangleWide));

                    break;

                case 3:
                    Console.WriteLine("Introduzca la altura del triángulo: ");
                    int triangleHeight = Int32.Parse(Console.ReadLine());
                    Console.WriteLine("Introduzca la base del triángulo: ");
                    int triangleBase = Int32.Parse(Console.ReadLine());
                    Console.WriteLine("El área de tu cuadrado es: " + TriangleArea(triangleHeight, triangleBase));

                    break;

                default:
                    Console.WriteLine("No es una opción válida.");

                    break;
            }

            static double CircleArea(int radius)
            {
                return Math.PI *radius*radius;
            }

            static int RectangleArea(int height,int wide)
            {
                return wide * height;
            }

            static float TriangleArea(int height,int bases)
            {
                return bases * height / 2;
            }
        }
    }
}
