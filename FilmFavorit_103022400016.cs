using System;
using System.IO;
using System.Text.Json;

public class filmfavorit_103022400016
{
    public string title { get;set; }
    public string director { get;set; }
    public int year { get;set; }
    public string genre { get; set; }
    public double rating { get; set; }
    public int durationMinutes { get; set; }
    public bool isWatched { get; set; }
}
public class FilmFavorit_103022400016
{
    public void ReadJSON()
    {
        string fname = "jurnal7_1_103022400016.json";
        string fpath = Path.Combine(Directory.GetCurrentDirectory(), fname);
        if (!File.Exists(fpath))
        {
            fpath = Path.GetFullPath(Path.Combine(AppContext.BaseDirectory,"../../../" , fname));
        }

        string json = File.ReadAllText(fpath);  
        var options = new JsonSerializerOptions
        {
            IncludeFields = true,
        };

        filmfavorit_103022400016 film = JsonSerializer.Deserialize<filmfavorit_103022400016>(json,options);
        Console.WriteLine($"title :{ film.title} director :{film.director} year :{ film.year} genre :{ film.genre} rating :{ film.rating} durationMinutes :{ film.durationMinutes} isWatched :{ film.isWatched}");
    }
}