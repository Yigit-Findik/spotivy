namespace spotivie
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Songs dummy data
            Song song = new Song("song", new List<Artist>(), 0);
            Song onedance = new Song("one dance", new List<Artist>(), 0);
            Song wasErNooit = new Song("Was er nooit", new List<Artist>(), 0);

            //Artist dummy data
            Artist lijpe = new Artist("Lijpe", new List<Album>(), new List<Song>());
            Artist artist = new Artist("artist", new List<Album>(), new List<Song>());

            //Album dummy data
            Album levensles = new Album(new List<Artist>() { lijpe }, new List<Song>() { wasErNooit}, "Levensles");
            Album album = new Album(new List<Artist>(), new List<Song>(), "album");
            Album album2 = new Album(new List<Artist>(), new List<Song>(), "album2");

            //add in song object Artists field the name of the artist
            wasErNooit.Artists.Add(lijpe);
            song.Artists.Add(artist);
            //song.Artists.Add(artist.Name);

            //adding song to artist
            lijpe.AddSong(wasErNooit);
            artist.AddSong(song);
            artist.AddSong(onedance);

            //adding album to artist
            lijpe.AddAlbum(levensles);
            artist.AddAlbum(album);
            artist.AddAlbum(album2);

            Console.WriteLine(levensles.ToString());
            Console.WriteLine(levensles.ShowArtists());

        }
    }
}