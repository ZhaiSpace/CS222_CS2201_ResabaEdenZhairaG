using System;

class Song
{
    public string title;
    public string artist;
    public double duration;

    // Default constructor
    public Song() : this("Unknown", "Unknown", 0) { }

    // Overloaded constructor (title + artist)
    public Song(string t, string a) : this(t, a, 0) { }

    // Parameterized constructor
    public Song(string t, string a, double d)
    {
        title = t;
        artist = a;
        duration = d;
    }

    public void DisplaySong()
    {
        Console.WriteLine("{0,-20} {1,-15} {2,5:F2}", title, artist, duration);
    }
}

class Program
{
    static void Main()
    {
        Console.Write("Songs to add: ");
        int n = Convert.ToInt32(Console.ReadLine());

        Song[] songs = new Song[n];

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("\nSong #" + (i + 1));

            Console.Write("Title: ");
            string t = Console.ReadLine();

            Console.Write("Artist: ");
            string a = Console.ReadLine();

            Console.Write("Duration (minutes): ");
            string dInput = Console.ReadLine();

            if (t == "" && a == "" && dInput == "")
                songs[i] = new Song();
            else if (dInput == "")
                songs[i] = new Song(t, a);
            else
                songs[i] = new Song(t, a, Convert.ToDouble(dInput));
        }

        Console.WriteLine("\n=== || MY PLAYLIST || ===");
        Console.WriteLine("{0,-20} {1,-15} {2,5}", "Title", "Artist", "Time");
        Console.WriteLine("------------------------------------------------");

        double total = 0;

        for (int i = 0; i < n; i++)
        {
            songs[i].DisplaySong();
            total += songs[i].duration;
        }

        double avg = n > 0 ? total / n : 0;

        Console.WriteLine("\nTotal Duration: " + total.ToString("F2") + " mins");
        Console.WriteLine("Average Duration: " + avg.ToString("F2") + " mins");
    }
}