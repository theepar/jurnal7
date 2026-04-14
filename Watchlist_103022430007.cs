using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;

namespace Modul7_Kelompok_Radit
{
    class Movie
    {
        public string id;
        public string title;
        public int year;
        public string genre;
        public double rating;
    }

    class Watchlist
    {
        public string watchlistName;
        public string createdBy;
        public Movie[] movies;
    }

    class Watchlist_103022430007
    {
        public void ReadJson()
        {
            var fileJson = System.IO.File.ReadAllText(@"../../../jurnal7_2_103022430007.json");
            var options = new JsonSerializerOptions
            {
                IncludeFields = true,
            };

            Watchlist wl = JsonSerializer.Deserialize<Watchlist>(fileJson, options);

            Console.WriteLine("Watchlist name: " + wl.watchlistName);
            Console.WriteLine("Created by: " + wl.createdBy);
            Console.WriteLine("Movies: ");
            foreach (var movie in wl.movies)
            {
                Console.WriteLine(movie.id + " " + movie.title + " (" + movie.year + " " + movie.rating + ")");
            }
        }
    }
}
