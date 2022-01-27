using System;

namespace Met14
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduce una frase: ");
            string userSentence = Console.ReadLine();
            userSentence = userSentence.ToLower();
            Console.WriteLine("Tu frase tiene " + CountAllVocals(userSentence) + " vocales.");

            static int CountAllVocals(string sentence)
            {
                string [] allVocals = { "a", "e", "i", "o", "u" };
                {
                    int contador = 0;
                    for (int i = 0; i < 5; i++)
                    {
                        contador += CountSingleVocal(sentence, allVocals[i]);
                        Console.WriteLine(contador);
                    }
                    return contador;
                }
            }

            static int CountSingleVocal(string sentence, string vocal)
            {
                int contador = 0;
                for (int i = 0; i < sentence.Length; i++)
                {
                    Console.Write(sentence.Substring(i, 1));
                    if (sentence.Substring(i,1)==vocal)
                    {
                        contador++;
                        Console.Write(contador);
                    }
                }
                return contador;
            }

        }
    }
}
