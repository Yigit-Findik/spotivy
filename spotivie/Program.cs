namespace spotivie
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Song song = new Song("song", new List<Artist>(), 0);
            Song onedance = new Song("one dance", new List<Artist>(), 0);

            Console.WriteLine(song.ToString());

            Artist artist = new Artist("artist", new List<Album>(), new List<Song>());
            artist.AddSong(song);
            artist.AddSong(onedance);
            Console.WriteLine(artist.ToString());
            Console.WriteLine(song.ToString());
            
        }
    }
}