using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace GrundProgrammering
{

  // 1.1

    class Opgave1
    {
        static void Main()
        {

            double Celsius;
            Console.WriteLine("Hvad er Fahrenheit");
            double Fahrenheit = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Celsius = {0}", Celsius = (Fahrenheit - 32) * 5 / 9);
            
        }
    }

  // 1.2
  
    class Opgave2
    {
        static void ConvertCelsius()
        {
            Console.Write("Skriv Celsius Her ");
            double celsius = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Kelvin = {0}", celsius + 273);
            Console.WriteLine("Fahrenheit = {0}", celsius * 18 / 10 + 32);
            Console.WriteLine("Réaumur = {0}", celsius * 0, 8);
        }

  // 1.3

        class Opgave3
        {
            static void Euro()
            {
                Console.Write("Skriv Dine Euro her ");
                double Euro = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("DKK = {0}", Euro * 7.51);
                double DKK = Convert.ToInt32(Console.ReadLine());
            }
        }

  // 1.4 - 1.5

        class Opgave4
        {
            static void Omsætningstal()
            {
                Console.Write("Skriv Omsætningstal Her ");
                double Omsætning = Convert.ToInt32(Console.ReadLine());

                Console.Write("Skriv Variable Omkostning Her ");
                double Variable = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("DækningBidrag = {0} ", Omsætning - Variable);
                double DækningBidrag = Convert.ToInt32(Console.ReadLine());

                Console.Write("Skriv Faste Omkostning Her ");
                double Faste = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Overskud = {0}", DækningBidrag - Faste);
                double Overskud = Convert.ToInt32(Console.ReadLine());
            }
        }
    }
}