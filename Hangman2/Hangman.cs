using System;
using System.Linq;

class Hangman
{
        static void Main(string[] args)
    {
    // Her Skriver den Velkommen.
        Console.WriteLine("Velkommen til Hangman, Lavet af LucasLupin!!");

    // Skriv dit Ord Her som den anden skal gætte.
        Console.WriteLine("Skriv et ord: ");
    // Her gemmer den dit Ord i secretWord.
        string ? secretWord = Console.ReadLine();
        Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n");
        // Her Tester den om det er Bogstav og ikke tal, samt tjekker om du kun skriver 1 bogstav og ikke flere.
        bool wordTest = secretWord.All(Char.IsLetter);

    // Hvis Der er indtastet et tal eller flere bogstaver så vil denne lave en fejl besked.
        while (wordTest == false || secretWord.Length == 0)
        {
            Console.WriteLine("Ordet skal kun indeholde bogstaver");
            Console.Write("Skriv et ord: ");
            secretWord = Console.ReadLine();
            wordTest = secretWord.All(Char.IsLetter);
        }

    // Her returnere den en copy af det hemmelige ord i uppercase.
        secretWord = secretWord.ToUpper();

    // Her Bliver der lavet en masse Mellemrum, så du kommer ned hvor det ligner en ny side.
        Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n" +
                          "\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n" +
                          "\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n");

    // Her bliver variablerne tildelt en værdi.
        int lives = 5;
        int counter = -1;
        int wordLength = secretWord.Length;
        char[] secretArray = secretWord.ToCharArray();
        char[] printArray = new char[wordLength];
        char[] guessedLetters = new char[28];
        int numberStore = 0;
        bool victory = false;

    // Her Finder den ud af Hvilken plads det det rigtige svar høre til på.
        foreach (char letter in printArray)
        {
            counter++;
            printArray[counter] = '-';
        }

    // 
        while (lives > 0)
        {
            counter = -1;
            string printProgress = String.Concat(printArray);
            bool letterFound = false;
            int multiples = 0;

    // Her siger den hvis alle ord den har printet er det samme som alle ord i det hemmelige ord, så har man vundet.
            if (printProgress == secretWord)
            {
                victory = true;
            Console.WriteLine("\n\n\n\n\n\n\n\n\n");
                Console.WriteLine("Du har Fundet alle Bogstaver, du har vundet!!");
                Console.WriteLine("\n\n");
                Console.WriteLine($"Ordet var {secretWord} !!!");
                break;
            }

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

    //Her Printer den ud og skriver hvor mange rigtige du har lige nu.
            Console.WriteLine("current progress: " + printProgress);
            Console.Write("\n\n\n");
            Console.Write("Gæt et bogstav: ");
            string? playerGuess = Console.ReadLine();

            bool guessTest = playerGuess.All(Char.IsLetter);

    // Her tester den om ud kun har skrevet et bogstav ind, og ikke tal eller tegn.
            while (guessTest == false || playerGuess.Length != 1)
            {
                Console.WriteLine("Put kun et bogstav ind tak");
                Console.Write("Gæt et bogstav: ");
                playerGuess = Console.ReadLine();
                guessTest = playerGuess.All(Char.IsLetter);
            }

    // Her Laver den playerguess variable om til uppercase.
            playerGuess = playerGuess.ToUpper();
            char playerChar = Convert.ToChar(playerGuess);

    // Hvis guessedLetters ikke har playerchar, så skal den plus en til numberStore.
            if (guessedLetters.Contains(playerChar) == false)
            {

                guessedLetters[numberStore] = playerChar;
                numberStore++;
    // Hvis bogstavet de gætter er det samme som playerchar, så skal den multiples i letterfound.
                foreach (char letter in secretArray)
                {
                    counter++;
                    if (letter == playerChar)
                    {
                        printArray[counter] = playerChar;
                        letterFound = true;
                        multiples++;
                    }
                }

                if (letterFound)
                {
                    Console.WriteLine("Du har fundet {0} bostav {1}!", multiples, playerChar);
                }

        // Her Skriver den at bogstavet ikke er i Ordet, og minusser et liv.
                else
                {
                    Console.WriteLine("Der er ikke bogstav {0}!", playerChar);
                    lives--;
                }
        // Her skriver den så dit antal liv du har tilbage.
                Console.WriteLine(lives);
            }
        }
    }
}
