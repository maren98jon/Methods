using System;

namespace Met06
{
    class Program
    {
        static void Main(string[] args)
        {
            int [] arrayInt = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };
            LeerArray(arrayInt);
            LeerArrayAtras(arrayInt);

            static void LeerArray(int[] arrays)
            {
                for (int i = 0; i < arrays.Length; i++)
                {
                    Console.WriteLine(arrays[i]);
                }
            }

            static void LeerArrayAtras(int[] arrays)
            {
                for (int i = arrays.Length-1; i >=0; i--)
                {
                    Console.WriteLine(arrays[i]);
                }
            }
        }
    }
}
