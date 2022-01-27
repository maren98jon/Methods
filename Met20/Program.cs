using System;

namespace Met20
{
    class Program

        // && AND
        // || OR option+1
    {
        static void Main(string[] args)
        {
            int month = PedirMes();
            Console.WriteLine("Introduce un año:");
            int startingYear = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Introduce otro año:");
            int endingYear = Int32.Parse(Console.ReadLine());

            int year = PedirAnio(startingYear, endingYear);
            int day = PedirDia(year, month);

            MostrarSiguienteDia(year,month,day);
        }
        static int PedirMes()
        {
            Console.WriteLine("Introduce un mes en formato numérico: ");
            int mes = Int32.Parse(Console.ReadLine());
            if (0 < mes && mes <= 12)
            {
                return mes;
            }
            else
            {
                return 0;
            }
        }

        static int PedirAnio(int startingYear, int endingYear)
        {
            if (startingYear > endingYear) 
            {
                int middleYear = endingYear;
                endingYear = startingYear;
                startingYear = middleYear;
            }
            Random rnd = new Random();
            return rnd.Next(startingYear, endingYear);
        }

        static int PedirDia(int year, int month)
        {
            Console.WriteLine("Introduce un día en formato numérico: ");
            int dia = Int32.Parse(Console.ReadLine());
            bool isLeapYear = DateTime.IsLeapYear(year);

            if (month == 1 || month == 3 || month == 5 || month == 7 ||
                month == 8 || month == 10 || month == 12)
            {
                if (dia < 1 || dia > 31)
                {
                    return 0;
                }
                else
                {
                    return dia;
                }
            }
            else if (month == 4 || month == 6 || month == 9 || month == 11)
            {
                if (dia < 1 || dia > 30)
                {
                    return 0;
                }
                else
                {
                    return dia;
                }
            }
            else
            {
                if (isLeapYear)
                {
                    if (dia < 1 || dia > 29)
                    {
                        return 0;
                    }
                    else
                    {
                        return dia;
                    }
                }
                else
                {
                    if (dia < 1 || dia > 28)
                    {
                        return 0;
                    }
                    else
                    {
                        return dia;
                    }
                }
            }
        }

        static void MostrarSiguienteDia(int year,int  month,int day)
        {
            DateTime today = Convert.ToDateTime($"{year}/{month}/{day}"); //year+"/"+month+"/"+day
            Console.WriteLine(today);
            DateTime tomorrow = today.AddDays(1);
            Console.WriteLine(tomorrow);
        }
    }
}
