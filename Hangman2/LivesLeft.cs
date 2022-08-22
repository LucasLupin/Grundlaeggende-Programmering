using System;
using System.Diagnostics.Metrics;

namespace Hangman2
{
    internal class LivesLeft
    {

        internal static  void HowManyLivesLeft(int lives)
        {
            // Her Tjekker den om du har mere end 1 Liv hvis du har, får du afvide hvor mange liv du har tilbage.
            if (lives > 1)
            {
                Console.WriteLine("Du har {0} liv tilbage", lives);
            }
            // Her Tjekker den om du om du har 1 liv eller under 1 liv, Også skriver den om du har et liv.
            else
            {
                Console.WriteLine("Du har kun {0} liv Tilbage!!!", lives);
            }
        }
    }
}
