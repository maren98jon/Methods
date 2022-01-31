using System;

namespace Met23
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ROUTE START");
            string[] roads = { "Alice's House-Bob's House" , "Alice's House-Cabin","Alice's House-Post Office",
                               "Bob's House-Town Hall","Daria's House-Ernie's House", "Daria's House-Town Hall",
                               "Ernie's House-Grete's House", "Grete's House-Farm","Grete's House-Shop", "Marketplace-Farm",
                               "Marketplace-Post Office", "Marketplace-Shop","Marketplace-Town Hall", "Shop-Town Hall" };

            string [] places = {"Alice's House","Bob's House","Cabin","Daria's House","Ernie's House",
                                "Grete's House","Farm","Marketplace","Post Office","Shop","Town Hall"};


            
            string actualPosition = "Post Office";
            string[] nextDestinations = Create10Destinations(places); //creo los destinos random
            int numDestinations = nextDestinations.Length;
            while (numDestinations > 0) //Mientras queden destinos
            {
                Console.WriteLine("Estas en: "+actualPosition);
                ShowDeliveryStatus(nextDestinations); //muestro donde hay que entregar paquetes
                nextDestinations = RefreshDestinations(actualPosition, nextDestinations);
                string[] RouteRoads = CalculateRoute(roads, actualPosition, nextDestinations[0]);

            }
        }

        static string[] CalculateRoute(string[] roads, string actualPos, string destination)
        {
            int numberOptionalRoads = 0;
            int numberSureRoads = 0;
            string[] optionRoad = new string[20];
            string[] sureRoads = new string[20];
            bool exit = false;
            while (!exit)
            {
                for (int i = 0; i < roads.Length; i++) //para posicion actual miro cuantas opciones y elijo una random que me lleva a un sitio.
                {
                    if (roads[i].IndexOf(actualPos) >= 0) //para todas las carreteras miro cuantas coinciden con mi origen y las guardo en un array nuevo
                    {
                        optionRoad[numberOptionalRoads] = roads[i];
                        roads[i] = "0";

                        numberOptionalRoads++;
                    }
                }
                Random rnd = new Random();
                int rndNum = rnd.Next(0, numberOptionalRoads); //creo num aleatorio y escojo carretera
                
                sureRoads[numberSureRoads] = optionRoad[rndNum];
                numberSureRoads++;
                if (optionRoad[rndNum].IndexOf(actualPos) < optionRoad[rndNum].IndexOf("-"))  //sacamos el otro lado de la carretera  
                {
                    actualPos = optionRoad[rndNum].Substring(optionRoad[rndNum].IndexOf("-") + 1);
                }
                else
                {
                    actualPos = optionRoad[rndNum].Substring(0, optionRoad[rndNum].IndexOf("-") - 1);
                }
                numberOptionalRoads = 0;
                if (actualPos==destination)
                {
                    exit = true;
                }
            }
            int finalCount = 0;
            for (int i = 0; i < sureRoads.Length; i++) 
            {
                if (sureRoads[i]!=null)    
                {
                    finalCount++;
                    
                }
            }
            string[] finalRoads = new string[finalCount];
            for (int i = 0; i < finalCount; i++)
            {
                finalRoads[i] = sureRoads[i];
            }

            return finalRoads;
        }




       

        static int NumberOfRoads(string[] route) //cuantas carreteras tengo que tomar en una ruta
        { 
            int numberRoads = 0;
            for (int i = 0; i < route.Length; i++)
            {
                if (route[i] == "0")
                {
                    numberRoads++;
                }
            }
            return numberRoads;
        }

        static string[] CheckFastestRoute(string[] firstRoute,string[] secondRoute) //le voy a meter dos rutas y quiero devolver la ruta mas rapida
        {
            if (NumberOfRoads(firstRoute)<NumberOfRoads(secondRoute))
            {
                return firstRoute;
            } else
            {
                return secondRoute;
            }
        }

        static void ReadRoute (string [] actualizedRoads,string[] originalRoads, string actualPos) //escribir las carreteras a tomar en su orden correcto
        {
            //int count = 0;
            for (int i = 0; i < actualizedRoads.Length; i++)
            {
                if (actualizedRoads[i]=="0")
                {
                    if (originalRoads[i].IndexOf(actualPos) < 2)
                    {
                        actualPos = originalRoads[i].Substring(originalRoads[i].IndexOf("-") + 1);
                        Console.WriteLine("Tome la carretera: " + originalRoads[i]);
                        actualizedRoads[i] = "1";

                    }
                    else
                    {
                        actualPos = originalRoads[i].Substring(0, originalRoads[i].IndexOf("-") - 1);
                        Console.WriteLine("Tome la carretera: " + originalRoads[i].Substring(0, originalRoads[i].IndexOf("-") - 1) + "-" + originalRoads[i].Substring(originalRoads[i].IndexOf("-") + 1));
                        actualizedRoads[i] = "1";
                    }
                    i = 0;
                }
            }

            //for (int i = 0; i < actualizedRoads.Length; i++)    
            //{
            //    if (actualizedRoads[i].IndexOf(actualPos)<2)
            //    {
            //        actualPos = actualizedRoads[i].Substring(actualizedRoads[i].IndexOf("-") + 1);
            //        Console.WriteLine("Tome la carretera: " + actualizedRoads[i]);
            //    }
            //    else
            //    {
            //        actualPos = actualizedRoads[i].Substring(0,actualizedRoads[i].IndexOf("-") - 1);
            //        Console.WriteLine("Tome la carretera: " + actualizedRoads[i].Substring(0, actualizedRoads[i].IndexOf("-") - 1)+"-"+ actualizedRoads[i].Substring(actualizedRoads[i].IndexOf("-") + 1));
            //    }
            //}

        }

        static string[] Create10Destinations(string[] places) //crear 10 destinos aleatorios
        {
            string[] randomDestinations = new string[10];
            for (int i = 0; i < 10; i++)
            {
                Random rnd = new Random();               
                randomDestinations[i] = places[rnd.Next(0,10)];
            }
            return randomDestinations;
        }

        static void ShowDeliveryStatus(string[] array) //mostrar 
        {
            Console.WriteLine("DELIVERY STATUS");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write("Package destination: " + "\t"+array[i]);
                Console.WriteLine();                
            }
        }

        static string FindRoute(string[] roads, string actualPosition, string destination) //metemos array de carreteras, posicion actual y destino
        {
            for (int i = 0; i < roads.Length; i++) //for para saber si hay carretera directa
            {
                if (roads[i].IndexOf(actualPosition) > 0 && roads[i].IndexOf(destination) > 0) //si la carretera conecta el origen y el destino
                {
                    Console.WriteLine("Carretera a tomar: " + roads[i]);
                    return SeparatePlaceFromRoad(roads[i], actualPosition); //salimos del metodo diciendo que vamos directamente
                }
            }
            //sabiendo k no hay ninguna directa hago gotorandomplace, que me dice a donde ir aleatoriamente
            string lastRoad = string.Empty;
            return FindRoute(roads, GoToRndPlace(roads, actualPosition, lastRoad), destination);
        }

        static string GoToRndPlace(string[] roads, string actualPosition, string lastRoad) //me devuelve string con el lugar rnd al que ir desde mi pos 
        {
            int count = 0;
            for (int i = 0; i < roads.Length; i++) //primero vemos cuantas carreteras podemos escoger desde esta posicion
            {
                if (roads[i].IndexOf(actualPosition) >= 0)
                {
                    count++;
                }
            }
            //vamos a generar un num aleatorio para escoger una de esas carreteras
            Random rnd = new Random();
            int choose = rnd.Next(1, count + 1);
            //sabiendo cuantas carreteras son, creamos array con estas carreteras y le metemos el numero random, tendremos ya la carretera que tomaremos
            string[] PosibleRoads = new string[count];
            int count2 = 0;
            for (int i = 0; i < roads.Length; i++)
            {
                if (roads[i].IndexOf(actualPosition) >= 0 && roads[i] != lastRoad)
                {
                    PosibleRoads[count2] = roads[i];
                    count2++;
                }
            } //tengo array con las posibles carreteras
            Console.WriteLine("Tomaremos la carretera: " + PosibleRoads[choose - 1]);
            return SeparatePlaceFromRoad(PosibleRoads[choose - 1], actualPosition);
        }

        static string SeparatePlaceFromRoad(string roads,string actualPosition)
        {
            if (roads.IndexOf(actualPosition)<2)
            {
                return roads.Substring(roads.IndexOf("-") + 1);
            }
            else
            {
                return roads.Substring(0, roads.IndexOf("-") - 1);
            }
        }

        static string [] RefreshDestinations(string  actualPos, string [] remainingDestinations) //quiero meterle destinos que quedan y en el que estoy //le digo cuantos paquetes repartir y despues borro los entregados
        {
            int count = 0;
            for (int j =0;j<remainingDestinations.Length;j++) //primero recorro la lista buscando cuantos paquetes he repartido en este sitio
            {
                if (actualPos==remainingDestinations[j])
                {
                    count++;
                }
            }
            Console.WriteLine("Tienes que repartir " + count + " paquetes en: "+ actualPos);
            Console.WriteLine("Pulse una tecla cualquiera cuando hayan sido repartidos: ");
            Console.ReadKey();
            Console.WriteLine();
            ShowDeliveryStatus(remainingDestinations);
            Console.WriteLine();
            string [] refreshDestination = new string[remainingDestinations.Length-count];
            int space = 0; //creo un variable que en caso de coincidir el destino me reste para no dejar espacios en blanco en el nuevo array
            for (int i = 0; i < remainingDestinations.Length;i++) //recorro otra vez todos los destinos 
            {                
                if (actualPos != remainingDestinations[i]) //si no coincide el destino con mi sitio lo meto al array nuevo
                {
                    refreshDestination[i - space] = remainingDestinations[i];
                }
                else
                {
                    space++;
                }
             
            }
            return refreshDestination;
        }
    }
}
