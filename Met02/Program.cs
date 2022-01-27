using System;

namespace Met02
{
    class Program
    {
        static void Main(string[] args)
        {
            static void Saludar()
            {
                Console.WriteLine("Hola");
            }

            static void LlamarSaludo(int num)
            {
                for (int i = 0; i < num; i++)
                {
                    Saludar();
                }
            }

            LlamarSaludo(5);
            Console.WriteLine();
            LlamarSaludo(3);

            

            
        }
    }
    
}
