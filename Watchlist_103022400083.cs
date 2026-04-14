using System;
using System.Text.Json;

public class Watchlist
{
	public string watchlistName;
	public string createdBy;
	public Movie[] movies;
}

public class Movie
{
	public string id;
	public string title;
	public int year;
	public string genre;
	public double rating;
}

public class Watchlist_103022400083
{
    public void ReadJSON()
    {
        string json = System.IO.File.ReadAllText(@"../../../jurnal7_2_103022400083.json");

        var options = new JsonSerializerOptions
        {
            IncludeFields = true
        };

        Watchlist watchlist = JsonSerializer.Deserialize<Watchlist>(json, options);

        Console.WriteLine($"Watchlist name: {watchlist.watchlistName}");
        Console.WriteLine($"Created by: {watchlist.createdBy}");
        Console.WriteLine("Movies:");

        foreach (Movie movie in watchlist.movies)
        {
            Console.WriteLine(movie.id + " " + movie.title + " (" + movie.year + " - " + movie.rating + ")");
        }
    }
}
