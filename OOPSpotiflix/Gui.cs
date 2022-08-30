using OOPSpotiflixV2;

namespace OOPSpotiflixV2
{
    internal class Gui
    {
        //private List<Movie> movieList;
        Data data = new Data();
        private string path = @"c:\SpotiflixData.json";
        public Gui()
        {
            data.MovieList = new();
            data.SeriesList = new();
            while (true)
            {
                Menu();
            }
        }
        #region DataHandling
        private void Menu()
        {
            Console.WriteLine("\nMENU\n1 for movies\n2 for series\n3 for music\n4 for save\n5 for load");

            switch (Console.ReadKey(true).Key)
            {
                case ConsoleKey.NumPad1:
                case ConsoleKey.D1:
                    Console.Clear();
                    MovieMenu();
                    break;
                case ConsoleKey.NumPad2:
                case ConsoleKey.D2:
                    Console.Clear();
                    SeriesMenu();
                    break;
                case ConsoleKey.NumPad3:
                case ConsoleKey.D3:
                    Console.Clear();
                    MusicMenu();
                    break;
                case ConsoleKey.NumPad4:
                case ConsoleKey.D4:
                    Console.Clear();
                    SaveData();
                    break;
                case ConsoleKey.NumPad5:
                case ConsoleKey.D5:
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
        #region Movie


        private void AddMovie()
        {
            Movie movie = new Movie();
            movie.Title = GetString("Title: ");
            movie.Length = GetLength();
            movie.Genre = GetString("Genre: ");
            movie.ReleaseDate = GetReleaseDate();
            movie.WWW = GetString("WWW: ");

            ShowMovie(movie);
            Console.WriteLine("Confirm adding to list (Y/N)");
            switch (Console.ReadKey(true).Key)
            {
                case ConsoleKey.Y:
                    Console.Clear();
                    data.MovieList.Add(movie);
                    break;
                default:
                    break;
            }
        }

        private void SearchMovie()
        {
            Console.Write("Search: ");
            string? search = Console.ReadLine();
            foreach (Movie movie in data.MovieList)
            {
                if (search != null)
                {
                    if (movie.Title.Contains(search) || movie.Genre.Contains(search))
                        ShowMovie(movie);
                }
            }
        }

        private void ShowMovie(Movie m)
        {
            Console.WriteLine($"{m.Title} \nMovie Length: {m.GetLength()} \n{m.Genre} \n{m.ReleaseDate} \n{m.WWW}");
        }

        private void ShowMovieList()
        {
            foreach (Movie m in data.MovieList)
            {
                ShowMovie(m);
            }
        }

        #endregion
        #region GetInput
        private void MovieMenu()
        {
            Console.WriteLine("\nMOVIE MENU\n1 for list of movies\n2 for search movies\n3 for add new movie");

            switch (Console.ReadKey(true).Key)
            {
                case ConsoleKey.NumPad1:
                case ConsoleKey.D1:
                    Console.Clear();
                    ShowMovieList();
                    break;
                case ConsoleKey.NumPad2:
                case ConsoleKey.D2:
                    Console.Clear();
                    SearchMovie();
                    break;
                case ConsoleKey.NumPad3:
                case ConsoleKey.D3:
                    Console.Clear();
                    AddMovie();
                    break;

                default:
                    break;
            }
        }
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

        private DateTime GetLength()
        {
            DateTime to;
            do
            {
                Console.Write("Length (hh:mm:ss): ");
            }
            while (!DateTime.TryParse("01-01-0001 " + Console.ReadLine(), out to));
            return to;
        }
        private DateTime GetReleaseDate()
        {
            DateTime dateOnly;
            string input = "";
            do
            {
                Console.Write("Release Date (dd/mm/yyyy): ");
                input = Console.ReadLine();
                if (input == "") return DateTime.Today;
            }
            while (!DateTime.TryParse(input, out dateOnly));
            return dateOnly;
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
        #region Series
        private void SeriesMenu()
        {
            Console.WriteLine("\nSeries MENU\n1 for list of series\n2 for search series\n3 for add new series");

            switch (Console.ReadKey(true).Key)
            {
                case ConsoleKey.NumPad1:
                case ConsoleKey.D1:
                    Console.Clear();
                    ShowSerieList();
                  

                    break;
                case ConsoleKey.NumPad2:
                case ConsoleKey.D2:
                    Console.Clear();
                    SearchSerie();
                   

                    break;
                case ConsoleKey.NumPad3:
                case ConsoleKey.D3:
                    Console.Clear();
                    AddSeries();
                

                    break;

                default:
                    break;
            }
        }


        private void AddSeries()
        {
            Series series = new Series();

            series.Title = GetString("Title: ");
            series.Genre = GetString("Genre: ");
            series.ReleaseDate = GetReleaseDate();
            series.WWW = GetString("WWW: ");
            series.Length = GetLength();

            ShowSerie(series);
            Console.WriteLine("Add series (Y/N)");
            if (Console.ReadKey(true).Key == ConsoleKey.Y) data.SeriesList.Add(series);
            do

            {
                AddEpisode(series);
                Console.WriteLine("Add another episode? (Y/N): ");
            }
            while (Console.ReadKey(true).Key == ConsoleKey.Y);
        }

        private void AddEpisode(Series series)
        {
            Episode episode = new Episode();
            episode.TitleEpisode = GetString("Titel on the Episode: ");
            episode.ReleaseDate = GetReleaseDate();
            episode.Season = GetInt("Season: ");
            episode.EpisodeNum = GetInt("Episode Nummer: ");

            ShowSerie(series);
            Console.WriteLine("Add series (Y/N)");
            if (Console.ReadKey(true).Key == ConsoleKey.Y) series.Episodes.Add(episode);

            if (Console.ReadKey(true).Key == ConsoleKey.Y) Console.Clear();
        }


        private void SearchSerie()
        {
            Console.Write("Search: ");
            string? search = Console.ReadLine();
            foreach (Series serie in data.SeriesList)
            {
                if (search != null)
                {
                    if (serie.Title.Contains(search) || serie.Genre.Contains(search))
                        ShowSerie(serie);
                }
            }
        }

        private void ShowSerie(Series s)
        {
            Console.WriteLine($"{s.Title} \n{s.Genre} \n{s.ReleaseDate} \n{s.WWW} \n\nEpisodes: ");

            foreach (Episode e in s.Episodes)
                {
                Console.WriteLine($"\t{e.TitleEpisode} {e.ReleaseDate} Episode Length: {e.Length} Season: {e.Season} Episode: {e.EpisodeNum}");
                }
        }


        private void ShowSerieList()
        {
            foreach (Series s in data.SeriesList)
            {
                ShowSerie(s);
            }
        }

      
        #endregion
        #region Music
        private void MusicMenu()
        {
            Console.WriteLine("\nMusic MENU\n1 for list of music\n2 for search music\n3 for add new music");

            switch (Console.ReadKey(true).Key)
            {
                case ConsoleKey.NumPad1:
                case ConsoleKey.D1:
                    Console.Clear();
                    ShowMusicList();

                    break;
                case ConsoleKey.NumPad2:
                case ConsoleKey.D2:
                    SearchMusic();

                    break;
                case ConsoleKey.NumPad3:
                case ConsoleKey.D3:
                    Console.Clear();
                    AddMusic();

                    break;

                default:
                    break;
            }
        }

        private void AddMusic()
        {
            Music music = new Music(); music.Songs = new();

            music.Album = GetString("Album: ");
            music.Artist = GetString("Artist: ");
            music.Genre = GetString("Genre: ");
            music.ReleaseDate = GetReleaseDate();
            Console.WriteLine("Add Album (Y/N)");
        if (Console.ReadKey(true).Key == ConsoleKey.Y) data.MusicList.Add(music);
            do

            {
                Song song = new Song();
                AddSong(music);
                Console.WriteLine("Add another Song?");
            }
            while (Console.ReadKey(true).Key == ConsoleKey.Y);
        }

        private void AddSong(Music music)
        {
            Song song = new Song();

            song.songname = GetString("Song Name: ");
            song.Length = GetLength();
            song.ReleaseDate = GetReleaseDate();

            Console.WriteLine("Add Song (Y/N)");
            if (Console.ReadKey(true).Key == ConsoleKey.Y) music.Songs.Add(song);
        }

        private void SearchMusic()
        {
            Console.Write("Search: ");
            string? search = Console.ReadLine();
            foreach (Music music in data.MusicList)
            {
                if (search != null)
                {
                    if (music.Title.Contains(search) || music.Genre.Contains(search))
                        ShowMusic(music);
                }
            }
        }

        private void ShowMusic(Music mu)
        {

            Console.WriteLine($"Artist: {mu.Artist} \nGenre: {mu.Genre} \nAlbum: {mu.Album} \nRealease Date: {mu.ReleaseDate} \n\nSongs:      ");

            foreach (Song s in mu.Songs)
            {
                Console.WriteLine($"        {mu.Artist} {s.songname} {s.Length} {mu.ReleaseDate}");
            }
        }

        private void ShowMusicList()
        {
            List<Music>? musicList = data.MusicList;
            foreach (Music mu in musicList)
            {
                ShowMusic(mu);
            }
        }
    }
}
#endregion