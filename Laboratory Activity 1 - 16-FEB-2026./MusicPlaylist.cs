
using System;

class Song 
{
    public string title;
    public string artist;
    public double duration;

public Song()
{
    title = "Unknown";
    artist = "Unknown";
    duration = 0.0;
}
public Song(string title, string artist, double duration){
    this.title = title;
    this.artist = artist;
    this.duration = duration;
}
public Song(string title, string artist) : this(title, artist, 0.0)
{
}
public void DisplaySong()
{
    Console.WriteLine($"{title,-20} {artist, -15} {duration,6:F2}");
}
}
class MusicPlayOrganizer
{
    static void Main()
    {
        Console.Write("Songs to add: ");
        int songCount = int.Parse(Console.ReadLine()!);
        
        Song[] playlist = new Song[songCount];
        
        for (int i = 0; i < songCount; i++){
            Console.WriteLine($"\nSong# {i+1}");
            
            Console.Write("Title: ");
            string title = Console.ReadLine()!;
            
            Console.Write("Artist: ");
            string artist = Console.ReadLine()!;
            
            Console.Write("Duration (minutes): ");
            string inputDuration = Console.ReadLine()!;
            double duration;
            
            
            if (double.TryParse(inputDuration, out duration ) == false)
            {
                duration = 0.0;
            }
            if (title == "" && artist == "")
            {
                playlist[i] = new Song();
            }
            else 
            {
                if (title == "") {title = "Unknown";}
                if (artist == "") {artist = "Unknown";}
                playlist[i] =new Song(title, artist, duration);   
            }
        }
        Console.WriteLine("\n=== || MY PLAYLIST || ===");
        
        Console.WriteLine($"{"title", -20}{"artist", -15}{"duration", 6}");
        Console.WriteLine(new string('-', 60));
        
        double totalDuration = 0;
        
        for(int i = 0; i < playlist.Length; i++) {
            playlist[i].DisplaySong();
            totalDuration += playlist[i].duration;
        }
        double averageDuration;
        
        if (songCount >0)
        {
            averageDuration = totalDuration / songCount;
        }
        else
        {
            averageDuration = 0;
        }
        Console.WriteLine($"\nTotal Duration: {totalDuration:F2} mins");
        Console.WriteLine($"\nAverage Duration: {averageDuration:F2} mins");
        }
    }


