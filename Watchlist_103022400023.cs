using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;
using static Modul7_Kelompok_Radit.FilmFavorit_103022400023;

namespace Modul7_Kelompok_Radit
{
    internal class Watchlist_103022400023
    {
        public class Film
        {
            public string id { get; set; }
            public string title { get; set; }
            public int year { get; set; }
            public string genre { get; set; }
            public float rating { get; set; }
        }
        public class FilmData{
            public string watchlistName { get; set; }
            public string createdBy { get; set; }
            public List<Film> movies { get; set; } 
        }
        public void ReadJSON()
        {
            string baseDirectory = AppDomain.CurrentDomain.BaseDirectory;
            string projectDirectory = Path.GetFullPath(Path.Combine(baseDirectory, @"..\..\..\"));
            string filePath = Path.Combine(projectDirectory, "jurnal7_2_103022400023.json");

            if (File.Exists(filePath))
            {
                string jsonString = File.ReadAllText(filePath);
                FilmData data = JsonSerializer.Deserialize<FilmData>(jsonString);
                Console.WriteLine($"Watchlist Name : {data.watchlistName}");
                Console.WriteLine($"Created By : {data.createdBy}");
                Console.WriteLine("Movies : ");
                List<Film> films = data.movies;
                for (int i = 0; i < films.Count; i++)
                {
                    Film film = data.movies[i];
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
