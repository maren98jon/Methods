using System;

namespace Met13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduzca una cantidad de euros: ");
            float euros = Int32.Parse(Console.ReadLine());
            Console.WriteLine("¿A qué moneda quiere pasarlo? Escriba libras,dolares o yenes.");
            string moneda = Console.ReadLine();

            CambioMoneda(euros, moneda);

            static void CambioMoneda(float cantidad, string tipo)
            {
                if (tipo=="libras")
                {
                    Console.WriteLine(cantidad + " euros son " + cantidad / 0.86 + " libras.");
                } else if (tipo == "dolares")
                {
                    Console.WriteLine(cantidad + " euros son " + cantidad / 1.28611 + " dolares.");
                } else if (tipo == "yenes")
                {
                    Console.WriteLine(cantidad + " euros son " + cantidad / 129.852 + " yenes.");
                }
            }

            

        }
    }
}
