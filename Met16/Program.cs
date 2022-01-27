using System;

namespace Met16
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduce una frase: ");
            string userSentence = Console.ReadLine();
            SentenceBackwards(userSentence);

            static void SentenceBackwards(string sentence)
            {
                
                for (int i = sentence.Length-1; i >= 0; i--)
                {
                    Console.Write(sentence.Substring(i, 1));
                }
                
            }
        }
    }
}
