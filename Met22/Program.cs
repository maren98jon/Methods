using System;

namespace Met22
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("BIENVENIDO AL JUEGO DEL AHORCADO");
            string guessWord = string.Empty;
            string gameWord = RandomWord();
            HideWord(gameWord);
            Console.WriteLine(gameWord);

            string[] hidden = HideWord(gameWord);
            int trys = 4;
            Console.Write("Esta es tu palabra: ");
            WriteHiddenWord(hidden);

            bool exit = false;
            while (!exit && trys > 0)
            {
                Console.Clear();
                Console.WriteLine("Tienes " + trys + " intentos.");
                WriteHiddenWord(hidden);
                Console.WriteLine("Pulsa (P) para resolver la palabra o pulsa (L) para adivinar una letra.");
                string userOption = Console.ReadLine().ToUpper();
                if (userOption != "P" && userOption != "L")
                {
                    Console.WriteLine("Ingrese una opción correcta.");
                }
                else if (userOption == "P")
                {
                    if (SolveWord(gameWord))
                    {
                        Console.WriteLine("Enhorabuena has ganado!!");
                        exit = true;
                    }
                    else
                    {
                        trys--;
                    }
                }
                else
                {
                    Console.WriteLine("Introduce la letra que quieres adivinar: ");
                    string character = Console.ReadLine().ToUpper();
                    if (FindOutCharacter(character, gameWord))
                    {
                        hidden = RefreshHiddenWord(character, hidden, gameWord);
                        if (CheckArray(hidden))
                        {
                            Console.WriteLine("Enhorabuena has ganado!");
                            exit = true;
                        }
                    }
                    else
                    {
                        trys--;
                    }
                }
            }
            if (trys == 0)
            {
                Console.WriteLine("Perdiste, vuelve a intentarlo.");
            }
        }

        static bool CheckArray(string [] array)
        {
            bool finish = true;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == "'_'")
                {
                    finish = false;
                }
            }
            return finish;
        }

        static string RandomWord()
        {
            string[] words = {"BLANCO","FURGONETA","PLATANO","VENTANA","PANTALONES",
                                   "GIRASOL","LAPIZ","PANTALLA","PARED","PUENTE","CIELO",
                                   "BRAZO","SALTAR","HUELGA","NUMEROS","KILOGRAMO","AMBULANCIA",
                                   "BATERIA","AYUNTAMIENTO","MONTAÑA"};
            Random rnd = new Random();
            return words[rnd.Next(0, 20)];
        }

        static string [] RefreshHiddenWord(string character,string [] array,string word)
        {
            for (int i = 0; i < word.Length; i++)
            {
                if (word.Substring(i,1)==character)
                {
                    array[i] = character;                     
                }
            }
            return array;
        }

        static string[] HideWord(string word)
        {            
            string[] hidden = new string[word.Length];
            for (int i = 0; i < word.Length; i++)
            {
                hidden[i] = "'_'";
            }
            return hidden;
        }

        static void WriteHiddenWord(string[] array)
        {
            Console.Write("{");
            for (int i = 0; i < array.Length-1; i++)
            {
                Console.Write(array[i]+",");
            }
            Console.WriteLine(array[array.Length - 1]+"}");
        }

        static bool FindOutCharacter(string character, string word)
        {
            bool find = false;
            for (int i = 0; i < word.Length; i++)
            {
                if (word.Substring(i, 1) == character)
                {
                    find = true;
                }                        
            }
            return find;
           
        }

        static bool SolveWord(string word)
        {
            Console.WriteLine("Introduce la palabra que crees que es: ");
            string userTry = Console.ReadLine().ToUpper();
            if (userTry==word)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
