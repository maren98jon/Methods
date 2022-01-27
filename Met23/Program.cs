using System;

namespace Met23
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("INICIO DE RUTA");
            string[] roads = { "Alice's House-Bob's House" , "Alice's House-Cabin","Alice's House-Post Office",
                               "Bob's House-Town Hall","Daria's House-Ernie's House", "Daria's House-Town Hall",
                               "Ernie's House-Grete's House", "Grete's House-Farm","Grete's House-Shop", "Marketplace-Farm",
                               "Marketplace-Post Office", "Marketplace-Shop","Marketplace-Town Hall", "Shop-Town Hall" };

            string [] places = {"Alice's House","Bob's House","Cabin","Daria's House","Ernie's House",
                                "Grete's House","Farm","Marketplace","Post Office","Shop","Town Hall"};

            ShowDeliveryStatus(Create10Destinations(places));
        }

        static string[] Create10Destinations(string[] roads) //crear 10 destinos aleatorios
        {
            string[] randomDestinations = new string[10];
            for (int i = 0; i < 10; i++)
            {
                Random rnd = new Random();               
                randomDestinations[i] = roads[rnd.Next(0,10)];
            }
            return randomDestinations;
        }

        static void ShowDeliveryStatus(string[] array) //mostrar 
        {
            Console.WriteLine("DELIVERY STATUS");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write("Package nº: " + (i + 1)+"\t"+array[i]);
                Console.WriteLine();                
            }
        }

        static void FindRoute(string[] roads, string actualPosition, string destination) //metemos array de carreteras, posicion actual y destino
        {
            int arrayPosition;
            for (int i = 0; i < roads.Length; i++)
            {
                if (roads[i].IndexOf(actualPosition) < 0 && roads[i].IndexOf(destination) < 0) //si ninguna carretera conecta el origen y el destino
                {
                    Console.WriteLine("No hay una ruta directa.");
                }
                else if (roads[i].IndexOf(actualPosition) > 0 && roads[i].IndexOf(destination) > 0) //si una carretera conecta directamente
                {
                    Console.WriteLine("Tomaremos la ruta: " + roads[i]);
                }
                else if (roads[i].IndexOf(destination) < 0)  //si hay que tomar mas de una carretera
                {

                }
            }

        }

        static string GoToRndPlace(string[] roads, string actualPosition)
        {
            int count = 0;
            for (int i = 0; i < roads.Length; i++) //primero vemos cuantas carreteras podemos escoger desde esta posicion
            {
                if (actualPosition == roads[i])
                {
                    count++;
                }
            }
            //vamos a generar un num aleatorio para escoger una de esas carreteras
            Random rnd = new Random();
            int choose = rnd.Next(1, count + 1);
            int round = 0;
            for (int i = 0; i < roads.Length; i++)
            {
                if (actualPosition == roads[i])
                {
                    round++;
                    if (choose == round)
                    {
                        return SeparatePlaceFromRoad(roads[i], actualPosition);
                    }
                }
            }
        }

        static string SeparatePlaceFromRoad(string roads,string actualPosition)
        {
            if (roads.IndexOf(actualPosition)<2)
            {
                return roads.Substring(roads.IndexOf("-"));
            }
            else
            {
                return roads.Substring(0, roads.IndexOf("-") - 1);
            }
        }

        static string [] RefreshDestinations(string  actualPos, string [] remainingDestinations) //quiero meterle destinos que quedan y en el que estoy
        {
            int count = 0;
            for (int j =0;j<remainingDestinations.Length;j++) //primero recorro la lista buscando cuantos paquetes he repartido en este sitio
            {
                if (actualPos==remainingDestinations[j])
                {
                    count++;
                }
            }
            string [] refreshDestination = new string[remainingDestinations.Length-count];
            for (int i = 0; i < remainingDestinations.Length;i++) //recorro otra vez todos los destinos 
            {
                int space = 0; //creo un variable que en caso de coincidir el destino me reste para no dejar espacios en blanco en el nuevo array
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
