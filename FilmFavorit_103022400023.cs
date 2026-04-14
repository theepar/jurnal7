using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;

namespace Modul7_Kelompok_Radit
{
    internal class FilmFavorit_103022400023
    {
        public class Film
        {
            public string title { get; set; }
            public string director { get; set; }
            public string year { get; set; }
            public string genre { get; set; }
            public float rating { get; set; }
            public int durationMinutes { get; set; }
            public bool isWatched { get; set; }
        }

        public void ReadJSON()
        {
            string baseDirectory = AppDomain.CurrentDomain.BaseDirectory;
            string projectDirectory = Path.GetFullPath(Path.Combine(baseDirectory, @"..\..\..\"));
            string filePath = Path.Combine(projectDirectory, "jurnal7_1_103022400023.json");

            if (File.Exists(filePath))
            {
                string jsonString = File.ReadAllText(filePath);
                Film f = JsonSerializer.Deserialize<Film>(jsonString);
                Console.WriteLine($"{f.title} ({f.year} - {f.rating}), genre: {f.genre}");
                Console.WriteLine($"directior : {f.director}");
                Console.WriteLine($"duration : {f.durationMinutes}");
                Console.WriteLine($"is Watched : {f.isWatched}");
            }
            else
            {
                Console.WriteLine($"error: {filePath} not found");
            }
        }

    }
}
