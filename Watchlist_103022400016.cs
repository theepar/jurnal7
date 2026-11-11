using System.Text.Json;

public class data
{
    public string watchlistName { get; set; }
    public string createdBy { get; set; }
    public List<Movies> movies { get; set; }
}
public class Movies
{
    public string id { get; set; }
    public string title { get; set; }
    public int year { get; set; }
    public string genre { get; set; }
    public double rating { get; set; }
}


public class Watchlist_103022400016
{
    public void ReadJSON()
    {
        string fname = "jurnal7_2_103022400016.json";
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

        data datas = JsonSerializer.Deserialize<data>(json, options);
        Console.WriteLine($"title :{datas.watchlistName} director :{datas.createdBy}");

        for (int i = 0; i < datas.movies.Count; i++)
        {
            Console.WriteLine($"ID : {datas.movies[i].id}, judul : {datas.movies[i].title}, tahun :{datas.movies[i].year}, genre :{datas.movies[i].genre}, rating: {datas.movies[i].rating}");
        }
    }
}