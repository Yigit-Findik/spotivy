namespace spotivie
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Song song = new Song("song", new List<Artist>(), 0);
            Song onedance = new Song("one dance", new List<Artist>(), 0);

            Artist artist = new Artist("artist", new List<Album>(), new List<Song>());
            Artist artist2 = new Artist("artist2", new List<Album>(), new List<Song>());
            Artist artist3 = new Artist("artist34", new List<Album>(), new List<Song>());
            Artist artist4 = new Artist("artist4", new List<Album>(), new List<Song>());
            artist.AddSong(song);
            artist.AddSong(onedance);

            //add in song object Artists field the name of the artist
            song.Artists.Add(artist);
            song.Artists.Add(artist2);
            song.Artists.Add(artist3);
            song.Artists.Add(artist4);
            //song.Artists.Add(artist.Name);

            Console.WriteLine(song.ToString());
            
        }
    }
}