using System;
using System.Collections;
using System.IO;
using System.Text.Json;

public class GenreDictionary
{
    public string category { get; set; }
    public List<GenreInfo> genre { get; set; }
    public List<popularMovies> popular { get; set; }
}
public class GenreInfo
{
    public int id { get; set; }
    public string name { get; set; }
    public string description { get; set; }
    public List<popularMovies> popular { get; set; }
}
public class popularMovies
{

}

public class GenreDictionary_103022400016
{
    public void ReadJSON()
    {
        string fname = "jurnal7_3_103022400016.json";
        string fpath = Path.Combine(Directory.GetCurrentDirectory(), fname);
        if (!File.Exists(fpath))
        {
            fpath = Path.GetFullPath(Path.Combine(AppContext.BaseDirectory, "../../../", fname));
        }

        string json = File.ReadAllText(fpath);
        var options = new JsonSerializerOptions
        {
            IncludeFields = true,
        };

        GenreDictionary datas = JsonSerializer.Deserialize<GenreDictionary>(json, options);
        Console.WriteLine($"category :{datas.category}");

        for (int i = 0; i < datas.genre.Count; i++)
        {
            Console.WriteLine($"genre info id:{datas.genre[i].id}");
            Console.WriteLine($"genre info name:{datas.genre[i].name}");
            Console.WriteLine($"genre info desk:{datas.genre[i].description}");
        }
        for (int i = 0; i < datas.popular.Count; i++)
        {
            Console.WriteLine($"popular :{datas.popular[i]}");
        }

    }
}