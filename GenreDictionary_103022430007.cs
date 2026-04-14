using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;

namespace Modul7_Kelompok_Radit
{
    class GenreInfo
    {
        public string id;
        public string name;
        public string description;
        public List<string> popularMovies;
    }

    class GenreDictionary
    {
        public string category;
        public GenreInfo GenreInfo;
    }

    class GenreDictionary_103022430007
    {
        public void ReadJson()
        {
            var fileJson = System.IO.File.ReadAllText(@"../../../jurnal7_3_103022430007.json");
            var options = new JsonSerializerOptions
            {
                IncludeFields = true,
            };

            GenreDictionary gd = JsonSerializer.Deserialize<GenreDictionary>(fileJson, options);

            Console.WriteLine("ID: " + gd.GenreInfo.id);
            Console.WriteLine("Name: " + gd.GenreInfo.name);
            Console.WriteLine("Description: " + gd.GenreInfo.description);
            Console.WriteLine("Popular Movies: ");
            foreach (var movie in gd.GenreInfo.popularMovies)
            {
                Console.Write(movie + ", ");
            }
        }
    }
}
