using System;
using System.Text.Json;

public class FilmDetail
{
	public string title;
	public string director;
	public int year;
	public string genre;
	public int rating;
	public int durationMinutes;
	public bool isWatched;
}

public class FilmFavorit_103022400083
{
	public void ReadJSON()
	{
		string json = System.IO.File.ReadAllText(@"../../../jurnal7_1_103022400083.json");

		var options = new JsonSerializerOptions
		{
			IncludeFields = true
		};

		FilmDetail filmDetail = JsonSerializer.Deserialize<FilmDetail>(json, options);
		string sudahNonton = filmDetail.isWatched ? "Sudah" : "Belum";

        Console.WriteLine("Film favorit Farhan");
		Console.WriteLine($"Judul: {filmDetail.title}" +
			$"\nDirektor: {filmDetail.director}" +
			$"\nTahun rilis: {filmDetail.year}" +
			$"\nGenre: {filmDetail.genre}" +
			$"\nRating: {filmDetail.rating}% (Rotten tomatoes)" +
			$"\nDurasi (menit): {filmDetail.durationMinutes}" +
			"\nSudah ditonton: " + sudahNonton);
    }
}
