using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;
using static Modul7_Kelompok_Radit.FilmFavorit_103022400063;

namespace Modul7_Kelompok_Radit
{
    internal class Watchlist_103022400063
    {
        public class Watchlist
        {
            public string id { get; set; }
            public string title { get; set; }
            public int year { get; set; }
            public string genre { get; set; }
            public float rating { get; set; }
        }
        public class Watchlistdata
        {
            public string watchlistName { get; set; }
            public string createdBy { get; set; }
            public List<Watchlist> movies { get; set; }
        }
        public void ReadJSON()
        {
            string baseDirectory = AppDomain.CurrentDomain.BaseDirectory;
            string projectDirectory = Path.GetFullPath(Path.Combine(baseDirectory, @"..\..\..\"));
            string filePath = Path.Combine(projectDirectory, "jurnal7_2_103022400063.json");

            if (File.Exists(filePath))
            {
                string jsonString = File.ReadAllText(filePath);
                Watchlistdata data = JsonSerializer.Deserialize<Watchlistdata>(jsonString);
                Console.WriteLine($"Watchlist Name : {data.watchlistName}");
                Console.WriteLine($"Created By : {data.createdBy}");
                Console.WriteLine("Movies : ");
                List<Watchlist> Watchlist = data.movies;
                for (int i = 0; i < Watchlist.Count; i++)
                {
                    Watchlist film = data.movies[i];
                    Console.WriteLine($"{film.id} {film.title} ({film.year} - {film.rating})");
                }
            }
            else
            {
                Console.WriteLine($"error: {filePath} not found");
            }
        }
    }
}