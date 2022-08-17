namespace GPArray
{
    class Program
    {
        //The array for the details of the arrangement in text
        static string[] arrangements = new string[100];
        static int[,] tickets = new int[1000, 2];

        static void Main(string[] args)
        {
            AddToArray();
            while (true)
            {
                Menu();
            }
        }

        static void Menu()
        {
            Console.WriteLine("\n1. Vis arrangementer \n2. Køb Billet\n3. Vis alle billetter\n\nIndtast valg");

            switch (Console.ReadKey(true).Key)
            {
                case ConsoleKey.NumPad1:
                case ConsoleKey.D1:
                    ShowAllArrangements();
                    break;
                case ConsoleKey.NumPad2:
                case ConsoleKey.D2:
                    ShowAllArrangements();
                    int t = BuyTicket();
                    Console.WriteLine("Billet nummer: " + t);
                    break;
                case ConsoleKey.NumPad3:
                case ConsoleKey.D3:
                    ShowTicketsBought();
                    break;
                default:
                    break;
            }
        }

        static int BuyTicket()
        {
            Console.Write("Indtast nummer på arrangement du ønsker at købe billet til.");
            string input = Console.ReadLine();
            int.TryParse(input, out int arrangementNumber);
            Console.Write("Indtast antal ønskede billetter: ");
            input = Console.ReadLine();
            int.TryParse(input, out int amountOfTickets);

            int freeSpot = GetNextFreeSpotInTicketArray();
            tickets[freeSpot, 0] = amountOfTickets;
            tickets[freeSpot, 1] = arrangementNumber;
            return freeSpot;
        }

        static void ShowTicketsBought()
        {
            Console.WriteLine("Antal\tArrangement\tLokation");
            for (int i = 0; i < tickets.Length; i++)
            {
                if (tickets[i, 0] == 0) return;
                string arr = arrangements[tickets[i, 1]];
                string[] splitArray = arr.Split("- ");
                Console.WriteLine(tickets[i, 0] + "\t" + splitArray[0] + "\t" + splitArray[1]);
            }
        }

        static int GetNextFreeSpotInTicketArray()
        {
            for (int i = 0; i < tickets.Length; i++)
            {
                if (tickets[i, 0] == 0) { return i; }
            }
            return 0;
        }
        static void ShowAllArrangements()
        {
            foreach (string arr in arrangements)
            {
                ShowArrangement(arr);
            }
        }

        static void ShowArrangement(string arr)
        {
            if (arr != null && arr != "")
            {
                int i = Array.IndexOf(arrangements, arr);
                Console.WriteLine(i + " " + arr);
            }
        }

        static void AddToArray()
        {
            arrangements[0] = "Lil Johan - Den grå hal";
            arrangements[1] = "Deagle - TEC Kantinen";
            arrangements[2] = "Tec Lærerband - Amager Plads";
        }
    }

}