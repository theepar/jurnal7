using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;

namespace Modul7_Kelompok_Radit
{
    internal class GenreDictionary_103022400063
    {
        public class GenreInf
        {
            public string id { get; set; }
            public string name { get; set; }
            public string description { get; set; }
            public List<string> popularMovies { get; set; }
        }

        public class GenreDict
        {
            public string category { get; set; }
            public GenreInf GenreInfo { get; set; }
        }

        public class Genres
        {
            public GenreDict GenreDictionary { get; set; }
        }

        public void ReadJSON()
        {
            string baseDirectory = AppDomain.CurrentDomain.BaseDirectory;
            string projectDirectory = Path.GetFullPath(Path.Combine(baseDirectory, @"..\..\..\"));
            string filePath = Path.Combine(projectDirectory, "jurnal7_3_103022400063.json");

            if (File.Exists(filePath))
            {
                string jsonString = File.ReadAllText(filePath);
                Genres genreDictionary = JsonSerializer.Deserialize<Genres>(jsonString);
                GenreInf genreInf = genreDictionary.GenreDictionary.GenreInfo;
                Console.WriteLine($"ID : {genreInf.id}");
                Console.WriteLine($"Name : {genreInf.name}");
                Console.WriteLine($"description : {genreInf.description}");
                Console.Write($"Popular Movies : ");
                for (int i = 0; i < genreInf.popularMovies.Count; i++)
                {
                    Console.Write($"{genreInf.popularMovies[i]}");
                    if (i < genreInf.popularMovies.Count - 1)
                    {
                        Console.Write(", ");
                    }
                }
            }
            else
            {
                Console.WriteLine($"error: {filePath} not found");
            }
        }
    }
