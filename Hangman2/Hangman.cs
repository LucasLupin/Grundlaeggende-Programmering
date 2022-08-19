using System;
using System.Linq;

class Hangman
{
        static void Main(string[] args)
    {
        string? secretWord = SecretWordInput();
        secretWord = TestForLetters(secretWord);

        // Her bliver variablerne tildelt en værdi.
        int lives = 10;
        int counter = -1;
        int wordLength = secretWord.Length;
        char[] secretArray = secretWord.ToCharArray();
        char[] printArray = new char[wordLength];
        char[] guessedLetters = new char[28];
        int numberStore = 0;
        bool victory = false;

        // Her Finder den ud af Hvilken plads det det rigtige svar høre til på.
        FindTheRighPlace(printArray);

        
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

            HowManyLivesLeft(lives);
            string? playerGuess;
            bool guessTest;

            CurrentProgress(printProgress, out playerGuess, out guessTest);
            CheckForOnlyOneLetter(ref playerGuess, ref guessTest);
            char playerChar = ConvertToUppercase(ref playerGuess);

        // Hvis guessedLetters ikke har playerchar, så skal den plus en til numberStore.
        if (guessedLetters.Contains(playerChar) == false)
            {

                guessedLetters[numberStore] = playerChar;
                numberStore++;


        // Hvis bogstavet de gætter er det samme som playerchar, så skal den multiples i letterfound.
        CheckIfLetterIsSecretword(secretArray, printArray, ref letterFound, ref multiples, playerChar);
        lives = RightLetterAndNotRightLetter(lives, letterFound, multiples, playerChar);

            }
        }
    }

        static int RightLetterAndNotRightLetter(int lives, bool letterFound, int multiples, char playerChar)
    {
        if (letterFound)
        {
            Console.WriteLine("Du har fundet {0} bostav {1}!", multiples, playerChar);
        }

        // Her Skriver den at bogstavet ikke er i Ordet, og minusser et liv.
        else
        {
            Console.WriteLine("Der er ikke bogstav {0}!", playerChar);
            Console.WriteLine("\n");
            lives--;
        }

        return lives;
    }



        static void CheckIfLetterIsSecretword(char[] secretArray, char[] printArray, ref bool letterFound, ref int multiples, char playerChar)
    {
        // Hvis bogstavet de gætter er det samme som playerchar, så skal den multiples i letterfound.
        for (int i = 0; i < secretArray.Length; i++)
        {
            char letter = secretArray[i];

            if (letter == playerChar)
            {
                printArray[i] = playerChar;
                letterFound = true;
                multiples++;
            }
        }
    }



        static char ConvertToUppercase(ref string? playerGuess)
    {
        // Her Laver den playerguess variable om til uppercase.
        playerGuess = playerGuess.ToUpper();
        char playerChar = Convert.ToChar(playerGuess);
        return playerChar;
    }



        static void CheckForOnlyOneLetter(ref string? playerGuess, ref bool guessTest)
    {
        // Her tester den om ud kun har skrevet et bogstav ind, og ikke tal eller tegn.
        while (guessTest == false || playerGuess.Length != 1)
        {
            Console.WriteLine("Put kun et bogstav ind tak");
            Console.Write("Gæt et bogstav: ");
            playerGuess = Console.ReadLine();
            guessTest = playerGuess.All(Char.IsLetter);
        }
    }



        static void CurrentProgress(string printProgress, out string? playerGuess, out bool guessTest)
    {
        //Her Printer den ud og skriver hvor mange rigtige du har lige nu.
        Console.WriteLine("current progress: " + printProgress);
        Console.Write("\n\n\n");
        Console.Write("Gæt et bogstav: ");
        playerGuess = Console.ReadLine();
        guessTest = playerGuess.All(Char.IsLetter);
    }



        static void HowManyLivesLeft(int lives)
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



        static void FindTheRighPlace(char[] printArray)
    {
        // Her Finder den ud af Hvilken plads det det rigtige svar høre til på.
        for (int i = 0; i < printArray.Length; i++)
        {
            char letter = printArray[i];
            printArray[i] = '-';
        }
    }




        static string TestForLetters(string? secretWord)
    {
        // Her Tester den om det er Bogstav og ikke tal, samt tjekker om du kun skriver 1 bogstav og ikke flere.
        bool wordTest = secretWord.All(Char.IsLetter);

        // Hvis Der er indtastet flere bogstaver så vil denne lave en fejl besked.
        while (wordTest == false || secretWord.Length == 0)
        {
            Console.WriteLine("Ordet skal kun indeholde bogstaver");
            Console.Write("Skriv et ord: ");
            secretWord = Console.ReadLine();
            wordTest = secretWord.All(Char.IsLetter);
        }
        secretWord = secretWord.ToUpper();
        return secretWord;
    }




        static string? SecretWordInput()
    {
        // Her Skriver den Velkommen.
        Console.WriteLine("Velkommen til Hangman, Lavet af LucasLupin!!");

        // Skriv dit Ord Her som den anden skal gætte.
        Console.WriteLine("Skriv et ord: ");

        // Her gemmer den dit Ord i secretWord.
        string? secretWord = Console.ReadLine();
        Console.Clear();
        return secretWord;
    }
}
