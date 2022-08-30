namespace FiskOop
{
    internal class Gui
    {
        Data data = new Data();
        private string path = @"c:\FishInfo.json";
        public Gui()
        {
            data.SaltWaterList = new();
            data.FreshWatersList = new();
            while (true)
            {
                Menu();
            }
        }
        #region Data
        private void Menu()
        {
            Console.WriteLine("\nMENU\n1 for Saltwater\n2 for FreshWater\n3 for save\n4 for load");

            switch (Console.ReadKey(true).Key)
            {
                case ConsoleKey.NumPad1:
                case ConsoleKey.D1:
                    Console.Clear();
                    SaltWaterMenu();
                    break;
                case ConsoleKey.NumPad2:
                case ConsoleKey.D2:
                    Console.Clear();
                    FreshWaterMenu();
                    break;
                case ConsoleKey.NumPad3:
                case ConsoleKey.D3:
                    Console.Clear();
                    SaveData();
                    break;
                case ConsoleKey.NumPad4:
                case ConsoleKey.D4:
                    Console.Clear();
                    LoadData();
                    break;
                default:
                    break;
            }
        }

        private void SaveData()
        {
            //string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string json = System.Text.Json.JsonSerializer.Serialize(data);
            File.WriteAllText(path, json);
            Console.WriteLine("File Saved Succesfully at " + path);
        }

        private void LoadData()
        {
            string json = File.ReadAllText(path);
            data = System.Text.Json.JsonSerializer.Deserialize<Data>(json);
            Console.WriteLine("File loaded succesfully from " + path);
        }
        #endregion
        #region GetInput
        private int GetInt(string type)
        {
            string? input;
            int i;
            do
            {
                Console.Write(type);
            }
            while (!int.TryParse(Console.ReadLine(), out i));
            return i;
        }

        private string GetString(string type)
        {
            string? input;
            do
            {
                Console.Write(type);
                input = Console.ReadLine();
                if (input == "") return "Unknown";
            }
            while (input == null || input == "");
            return input;
        }
        #endregion
        #region SaltWater
        private void SaltWaterMenu()
        {
            Console.WriteLine("\nSaltWater MENU\n1 for list of SaltWater Fish\n2 for Add SaltWaterFish");

            switch (Console.ReadKey(true).Key)
            {
                case ConsoleKey.NumPad1:
                case ConsoleKey.D1:
                    Console.Clear();
                    ShowSaltWaterList();
                    break;
                case ConsoleKey.NumPad2:
                case ConsoleKey.D2:
                    Console.Clear();
                    AddSaltWaterFish();
                    break;

                default:
                    break;
            }
        }

        private void AddSaltWaterFish()
        {
            SaltWater saltwater = new SaltWater();

            saltwater.Name = GetString("Fish Name: ");
            saltwater.Length = GetInt("Fish Length: ");
            saltwater.Weight = GetInt(@"Fish Weight: ");
            saltwater.FishFood = GetString("Carnivore/Herbivore: ");
            Console.Clear();

            ShowSaltWater(saltwater);
            Console.WriteLine("Confirm adding to list (Y/N)");
            if (Console.ReadKey(true).Key == ConsoleKey.Y) data.SaltWaterList.Add(saltwater);
            do

            {
                AddColor(saltwater);
                Console.WriteLine("Add another Color? (Y/N): ");
            }
            while (Console.ReadKey(true).Key == ConsoleKey.Y);
        }

        private void AddColor(SaltWater saltwater)
        {
            SaltColor color = new SaltColor();
            color.whatcolor = GetString("Fish Color: ");
            if (Console.ReadKey(true).Key == ConsoleKey.Y) saltwater.SaltColors.Add(color);
        }

        private void ShowSaltWater(SaltWater s)
        {
            Console.WriteLine($"{s.Name} \nFish Length: {s.Length} cm \nFish Weight: {s.Weight} Kg \n{s.FishFood}");

            foreach (SaltColor c in s.SaltColors)
            {
                Console.WriteLine($"{c.whatcolor}");
            }
        }
        private void ShowSaltWaterList()
        {
            foreach (SaltWater s in data.SaltWaterList)
            {
                ShowSaltWater(s);
            }
        }
        #endregion
        #region FreshWater
        private void FreshWaterMenu()
        {
            Console.WriteLine("\nFreshWater MENU\n1 for list of FreshWater Fish\n2 for Add FreshWater Fish");

            switch (Console.ReadKey(true).Key)
            {
                case ConsoleKey.NumPad1:
                case ConsoleKey.D1:
                    Console.Clear();
                    ShowFreshWaterList();
                    break;
                case ConsoleKey.NumPad2:
                case ConsoleKey.D2:
                    Console.Clear();
                    AddFreshWaterFish();
                    break;

                default:
                    break;
            }
        }

        private void AddFreshWaterFish()
        {
            FreshWater freshwater = new FreshWater();

            freshwater.Name = GetString("Fish Name: ");
            freshwater.Length = GetInt("Fish Length: ");
            freshwater.Weight = GetInt(@"Fish Weight: ");
            freshwater.FishFood = GetString("Carnivore/Herbivore: ");
            Console.Clear();

            ShowFreshWater(freshwater);
            Console.WriteLine("Confirm adding to list (Y/N)");
            if (Console.ReadKey(true).Key == ConsoleKey.Y) data.FreshWatersList.Add(freshwater);
            do

            {
                AddColor(freshwater);
                Console.WriteLine("Add another Color? (Y/N): ");
            }
            while (Console.ReadKey(true).Key == ConsoleKey.Y);
        }

        private void AddColor(FreshWater freshWater)
        {
            FreshColor color = new FreshColor();
            color.whatcolor = GetString("Fish Color: ");
            Console.WriteLine("Press Y to save");
            if (Console.ReadKey(true).Key == ConsoleKey.Y) freshWater.FreshColors.Add(color);
        }

        private void ShowFreshWater(FreshWater f)
        {
            Console.WriteLine($"{f.Name} \nFish Length: {f.Length} cm \nFish Weight: {f.Weight} Kg \n{f.FishFood}");
            Console.WriteLine("\nColors: ");
            foreach (FreshColor c in f.FreshColors)
            {
                Console.WriteLine($"        {c.whatcolor}");
            }
        }
        private void ShowFreshWaterList()
        {
            foreach (FreshWater f in data.FreshWatersList)
            {
                ShowFreshWater(f);
            }
        }
        #endregion
    }
}