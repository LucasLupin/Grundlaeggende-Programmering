using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace GrundProgrammering
{

 // 2.1 - 2.2

    class Opgave5
    {
        static void Navn()
        {
            string Navn;
            Console.WriteLine("Skriv Dit Navn Her: ");
            Navn = Console.ReadLine();


            int Alder;
            Console.WriteLine("Skriv Din Alder her: ");
            Alder = Convert.ToInt32(Console.ReadLine());


            if (Alder <= 1)
            {
                Console.WriteLine("Din Alder Er {0} År", Alder);
                Console.WriteLine("Dit Navn Er, {0}", Navn);
                Console.WriteLine("Du Er Lige Født");
                Console.BackgroundColor = ConsoleColor.Red;

            if (Alder >= 2 && Alder <= 5)
            {
                Console.WriteLine("Din Alder Er {0} År", Alder);
                Console.WriteLine("Dit Navn Er, {0}", Navn);
                Console.WriteLine("Du kan begynde i børnehave");
                Console.BackgroundColor = ConsoleColor.Yellow;
                }

            if (Alder >= 6 && Alder <= 16)
            {
                Console.WriteLine("Din Alder Er {0} År", Alder);
                Console.WriteLine("Dit Navn Er, {0}", Navn);
                Console.WriteLine("Du Går i Skole");
                Console.BackgroundColor = ConsoleColor.Green;

                }

            if (Alder > 16)
            {
                Console.WriteLine("Din Alder Er {0} År", Alder);
                Console.WriteLine("Dit Navn Er, {0}", Navn);
                Console.WriteLine("Nu Begynder Alvoren");
                Console.BackgroundColor = ConsoleColor.Blue;

                }
            

            }
        }
    }

 // 2.3

    class Opgave6
    {
        static void AlderKarakter()
        {

            int Karakter;
            Console.WriteLine("Skriv Dit Navn Her: ");
            Karakter = Convert.ToInt32(Console.ReadLine());


            int Alder;
            Console.WriteLine("Skriv Din Alder her: ");
            Alder = Convert.ToInt32(Console.ReadLine());


            if (Alder >= 18 && Alder <= 24)
            {
                if (Karakter >= 1 && Karakter <= 4)

                Console.WriteLine("Din Alder Er {0} År", Alder);
                Console.WriteLine("Dit Navn Er, {0}", Karakter);
                Console.BackgroundColor = ConsoleColor.Red;
            }

            else if (Alder >= 25 && Alder <= 29)
            {
                if (Karakter >= 1 && Alder <= 5)
                
                Console.WriteLine("Din Alder Er {0} År", Alder);
                Console.WriteLine("Dit Navn Er, {0}", Karakter);
                Console.BackgroundColor = ConsoleColor.Red;
            }

            if (Alder >= 18 && Alder <= 24)
            {
                if(Karakter >= 5 && Karakter <= 9)

                Console.WriteLine("Din Alder Er {0} År", Alder);
                Console.WriteLine("Dit Navn Er, {0}", Karakter);
                Console.BackgroundColor = ConsoleColor.Yellow;
            }

            else if (Alder >= 25 && Alder <= 29)
            {
                if (Karakter >= 6 && Karakter <= 10)

                Console.WriteLine("Din Alder Er {0} År", Alder);
                Console.WriteLine("Dit Navn Er, {0}", Karakter);
                Console.BackgroundColor = ConsoleColor.Yellow;
            }

            if (Alder >= 18 && Alder <= 24)
            {
                if (Karakter >= 10 && Karakter <= 13)

                Console.WriteLine("Din Alder Er {0} År", Alder);
                Console.WriteLine("Dit Navn Er, {0}", Karakter);
                Console.BackgroundColor = ConsoleColor.Green;
            }

            else if (Alder >= 25 && Alder <= 29)
            {
                if (Karakter >= 11 && Karakter <= 13)

                Console.WriteLine("Din Alder Er {0} År", Alder);
                Console.WriteLine("Dit Navn Er, {0}", Karakter);
                Console.BackgroundColor = ConsoleColor.Green;
            }
          }
       }
    }