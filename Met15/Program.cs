using System;

namespace Met15
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduce una  frase: ");
            string userSentence = Console.ReadLine();
            userSentence = userSentence.Trim();
            Console.WriteLine("Tu frase tiene "+CountWords(userSentence)+" palabras.");

            
            
        }

        static int CountWords(string sentence)
        {
            int contador = 1;
            //for (int i = 0; i < sentence.Length; i++)
            //{
            //    if (sentence.Substring(i,1)==" ")
            //    {
            //        contador++;
            //    }
            //}
            //return contador;


            for (int i = 0; i < sentence.Length; i++)
            {
                if (sentence.Substring(i, 1) == " ") 
                {
                    bool exit = false;
                    while (!exit)
                    {
                        if (sentence.Substring(i + 1, 1) == " ")
                        {
                            i++;
                        }
                        else
                        {
                            exit = true;
                        }
                    }
                    
                 contador++;                    
                }

            }
            return contador;
        }
    }
}
