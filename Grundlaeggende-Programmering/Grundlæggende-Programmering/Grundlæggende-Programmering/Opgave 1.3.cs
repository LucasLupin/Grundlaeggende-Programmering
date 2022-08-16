using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace GrundProgrammering
{
    class Opgave7
    {
        static void Dag()
        {

        // 3.1

            int Dag;
            Console.WriteLine("Skriv dag-nummeret");
            Dag = Convert.ToInt32(Console.ReadLine());

            switch (Dag)
            {
                case 1:
                    Console.WriteLine("Idag er det Mandag");
                    break;

                case 2:
                    Console.WriteLine("Idag er det Tirsdag");
                    break;

                case 3:
                    Console.WriteLine("Idag er det Onsdag");
                    break;

                case 4:
                    Console.WriteLine("Idag er det Torsdag");
                    break;

                case 5:
                    Console.WriteLine("Idag er det Fredag");
                    break;

                case 6:
                    Console.WriteLine("Idag er det Lørdag");
                    break;

                case 7:
                    Console.WriteLine("Idag er det Søndag");
                    break;
            }

        }
    }

    class Opgave8
    {

        static void CelsiusEnheder()
        {


        // 3.2

            Console.Write("Skriv Celsius Her ");
            double celsius = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Skriv F,K,R For skifte Temperatur Enhed");
            string? enheder = (Console.ReadLine());

            switch (enheder)
            {
                case "f":
                case "F":
                    Console.Write("Fahrenheit = {0}", (celsius * 18 / 10) + 32);
                    break;

                case "r":
                case "R":
                    Console.WriteLine("Réaumur = {0}", celsius * 0, 8);
                    break;

                case "k":
                case "K":
                    Console.WriteLine("Kelvin = {0}", celsius + 273);
                    break;
            }
        }
    }
}

