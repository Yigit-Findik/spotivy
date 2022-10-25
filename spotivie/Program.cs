namespace spotivie
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Songs dummy data
            Song song = new Song("song", new List<Artist>(), 0);
            Song onedance = new Song("One Dance", new List<Artist>(), 0);
            Song champagnepoetry = new Song("Champagne Poetry", new List<Artist>(), 0);
            Song wasErNooit = new Song("Was er nooit", new List<Artist>(), 0);

            //Artist dummy data
            Artist lijpe = new Artist("Lijpe", new List<Album>(), new List<Song>());
            Artist drake = new Artist("Drake", new List<Album>(), new List<Song>());
            Artist artist = new Artist("artist", new List<Album>(), new List<Song>());

            //Album dummy data
            Album levensles = new Album(new List<Artist>() { lijpe }, new List<Song>() { wasErNooit}, "Levensles");
            Album certifiedloverboy = new Album(new List<Artist>() { drake }, new List<Song>() { champagnepoetry }, "Certified Lover Boy");
            Album album = new Album(new List<Artist>(), new List<Song>(), "album");
            Album album2 = new Album(new List<Artist>(), new List<Song>(), "album2");

            //Playlist dummy data
            Playlist ny = new Playlist(null, "NY");

            //Person dummy data
            Person robert = new Person("Robert", new List<Person>(), new List<Playlist>());
            Person yigit = new Person("Yigit", new List<Person>() { robert }, new List<Playlist>() { ny });
            ny.Owner = yigit;

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

            Console.WriteLine(yigit.ToString());
            Console.WriteLine(ny.ToString());
            Console.WriteLine(levensles.ToString());
            Console.WriteLine(levensles.ShowArtists());

            onedance.Next();

            Console.WriteLine(yigit.SelectPlaylist(0));

        }
    }
}