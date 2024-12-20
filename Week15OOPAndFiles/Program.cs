
List<Movie> myMovies = new List<Movie>();
string[] data = GetDataFromMyFile();
//ReadDataFromArray(data);

foreach(string line in data)
{
    string[] tempArray = line.Split(new char[] {','}, StringSplitOptions.RemoveEmptyEntries);
    Movie newMovie = new Movie(tempArray[0], tempArray[2]);
    myMovies.Add(newMovie);
}

foreach(Movie movie in myMovies)
{
    Console.WriteLine($"One of my favorite movies {movie.Tittle} was released in {movie.Year}");
}

static string[] GetDataFromMyFile()
{
    string filePath = @"C:\data\movies.txt";
    return File.ReadAllLines(filePath);
}

static void ReadDataFromArray(string[] someArray)
{
    foreach(string line in someArray)
    {
        Console.WriteLine(line);
    }
}


class Movie
{
    string tittle; //fields
    string year;

    public string Tittle
    {
        get { return tittle; }
    }

    public string Year
    {
        get { return year; }
    }
    public Movie(string _tittle, string _year)
    {
        tittle = _tittle;
        year = _year;
    }
}
