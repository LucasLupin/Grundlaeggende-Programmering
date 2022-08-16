using System;
namespace Procent
{
    public class Program
    {
        static void Main()
        {

            do
            {
                double[] talinput = Inputnum();
                double[] resultArray = Calculator(talinput);
                Showresult(talinput, resultArray);
                Console.WriteLine("Wanna try again (Y/N)");
            }
            while (Console.ReadKey().Key == ConsoleKey.Y);
            static double[] Inputnum()
            {

                Console.Write("Skriv Tal 1 her ");
                double num1 = Convert.ToDouble(Console.ReadLine());
                

                Console.Write("Skriv Tal 2 her ");
                double num2 = Convert.ToDouble(Console.ReadLine());

                double[] talinput = { num1, num2 };
                return talinput;
        }

            static double[] Calculator(double[]talinput)
            {
                double num1 = talinput[0];
                double num2 = talinput[1];

                double? j = num1 * num2 / 100d;
                double resultat1 = (double)j;

                double? v = (double)num2 * num1 / 100;
                double resultat2 = (double)v;

                double[] resultArray = { resultat1, resultat2 };
                return resultArray;
            }


            static void Showresult(double[]talinput, double[] resultarray)
            {
                Console.WriteLine($"{talinput[0]} % of {talinput[1]} equals {resultarray[0]}");

                Console.WriteLine($"{talinput[1]} % of {talinput[0]} equals {resultarray[1]}");


            }
            }
        }
    }

   
