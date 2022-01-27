using System;

namespace Met07
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arrayInt = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };
            bool booleano = false;
            AscendenteODescendente(arrayInt, booleano);


            static void AscendenteODescendente(int[] arrays, bool booleano)
            {
                if (booleano)
                {
                    LeerArray(arrays);
                }
                else
                {
                    LeerArrayAtras(arrays);
                }
            }


            static void LeerArray(int[] arrays)
            {
                for (int i = 0; i < arrays.Length; i++)
                {
                    Console.WriteLine(arrays[i]);
                }
            }

            static void LeerArrayAtras(int[] arrays)
            {
                for (int i = arrays.Length - 1; i >= 0; i--)
                {
                    Console.WriteLine(arrays[i]);
                }
            }
        }

    }

}
