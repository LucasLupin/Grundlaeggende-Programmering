using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace GrundProgrammering
{
    class Opgave9
    {
        static void Tabeller()
        {

     // 4.0

           Console.Write("Skriv den tabel du vil køre ");
            int a = (int)Convert.ToInt32(Console.ReadLine());
                int i = 1;
                    while (i <= 10)
        {
                Console.WriteLine(a + " * " + i + " = " + i * a);
                i++;
            }
            Console.ReadLine();
        }
    }

    class Opgave10
    {
        static void Ascii()
        {

            // 4.1

            Console.Write("Skriv Vandret Start");
            int Vandret = (int)Convert.ToInt32(Console.ReadLine());

            Console.Write("Skriv Lodret Start");
            int Lodret = (int)Convert.ToInt32(Console.ReadLine());

            Console.SetCursorPosition(Vandret, Lodret);





/*
            int i = 1;
            while (i <= 10)
            {
                Console.WriteLine(a + " * " + i + " = " + i * a);
                i++;
            }
            Console.ReadLine();*/
        }
    }
}
