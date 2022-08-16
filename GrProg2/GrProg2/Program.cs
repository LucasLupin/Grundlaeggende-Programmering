using System;
namespace GrProg2
{
	public class Program
	{
		static void Main(string[ ] args)
		{
            string? playername = "";

            while (playername != "exit")
            {
                Console.WriteLine("Hello");
                playername = ChooseName();
                if (playername != "exit" && playername != "")
                 {
                    SayMyName(playername);
                }
            }
		}

		static string? ChooseName()
        {
			Console.Write("Enter You´re name: ");
			string? name = Console.ReadLine();
			return name;

        }

		static void SayMyName(string? myName)
        {
            Console.WriteLine($"Hello {myName}. How are you doing?");

        }
	}
}

