using System;

namespace Met01
{
    class Program
    {
        static void Main(string[] args)
        {
            static void Saludar()
            {
                Console.WriteLine("Hola");
            }

            for (int i = 0; i < 3; i++)
            {
                Saludar();
            }
        }
    }
    
}
