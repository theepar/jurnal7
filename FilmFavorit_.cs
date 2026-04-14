using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Modul7_Kelompok_Radit
{
    public class filmfavorit_103022400063
    {
        [JsonInclude]
        public string title { get; set; }
        [JsonInclude]
        public string director {  get; set; }
        [JsonInclude]
        public string genre{  get; set; }
        [JsonInclude]
        public int rating{  get; set; }
        [JsonInclude]
        public int durationMinutes{  get; set; }
        [JsonInclude]
        public bool isWatched{  get; set; }

    }
    public class FilmFavorit_103022400063
    {
        [JsonInclude]
        public List<filmfavorit_103022400063> filmfavorit {  get; set; }
        public void ReadJson()
        {
            string jsonstring = File.ReadAllText("D:\\jurnal7\\jurnal7_1_103022400063_103022400063.json");
            filmfavorit_103022400063 film = JsonSerializer.Deserialize<filmfavorit_103022400063>(jsonstring);

            Console.WriteLine("Film");

            Console.WriteLine($"title: {film.title} Director: {film.director} Genre: {film.genre} rating:{film.rating} durationMinutes:{film.durationMinutes} isWatched:{film.isWatched}");
        }
 
           
    }
}
