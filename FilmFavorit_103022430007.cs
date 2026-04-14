using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;

namespace Modul7_Kelompok_Radit
{
    class Film
    {
        public string title;
        public string director;
        public string year;
        public string genre;
        public double rating;
        public int durationMinutes;
        public bool isWatched;
    }

    class FilmFavorit_103022430007
    {
        public void ReadJSON()
        {
            var fileJson = System.IO.File.ReadAllText(@"../../../jurnal7_1_103022430007.json");
            var options = new JsonSerializerOptions
            {
                IncludeFields = true,
            };

            Film film = JsonSerializer.Deserialize<Film>(fileJson, options);

            Console.WriteLine("Judul: " + film.title);
            Console.WriteLine("Sutradara: " + film.director);
            Console.WriteLine("Tahun: " + film.year);
            Console.WriteLine("Genre: " + film.genre);
            Console.WriteLine("Rating: " + film.rating);
            Console.WriteLine("Durasi (mnt): " + film.durationMinutes);
            Console.WriteLine("Sudah Nonton?: " + (film.isWatched ? "Sudah" : "Belum"));
        }
    }
}
