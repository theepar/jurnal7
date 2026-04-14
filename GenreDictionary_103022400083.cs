using System;
using System.Text.Json;

public class Genre
{
    public GenreDictionary GenreDictionary { get; set; }
}
public class GenreDictionary
{
	public string category { get; set; }
    public GenreInfo GenreInfo { get; set; }
}

public class GenreInfo
{
    public string id { get; set; }
    public string name { get; set; }
    public string description { get; set; }
    public string[] popularMovies { get; set; }
}

public class GenreDictionary_103022400083
{
    public void ReadJSON()
    {
        string json = System.IO.File.ReadAllText(@"../../../jurnal7_3_103022400083.json");

        var options = new JsonSerializerOptions
        {
            IncludeFields = true,
        };

        Genre genre = JsonSerializer.Deserialize<Genre>(json, options);
        GenreInfo genreInfo = genre.GenreDictionary.GenreInfo;

        Console.WriteLine($"ID : {genre.GenreDictionary.GenreInfo.id}");
        Console.WriteLine($"Name : {genreInfo.name}");
        Console.WriteLine($"Description : {genreInfo.description}");
        Console.Write("Popular movies : ");

        for (int i = 0; i < genreInfo.popularMovies.Length; i++)
        {
            string popularMovie = genreInfo.popularMovies[i];
            Console.Write(popularMovie);

            if (i <= genreInfo.popularMovies.Length)
            {
                Console.Write(", ");
            }
        }
    }
}
