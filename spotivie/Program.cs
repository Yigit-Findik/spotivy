namespace spotivie
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Person> users = new List<Person>();
            List<Album> albums = new List<Album>();
            List<Song> songs = new List<Song>();

            Artist lijpe = new Artist("Lijpe", new List<Album>(), new List<Song>());
            Artist drake = new Artist("Drake", new List<Album>(), new List<Song>());
            Artist artist = new Artist("artist", new List<Album>(), new List<Song>());
            Artist fiftycent = new Artist("50cent", new List<Album>(), new List<Song>());

            Playlist ny = new Playlist(null, "NY");
            Playlist robertsBangers = new Playlist(null, "Robert's Bangers");

            Person robert = new Person("Robert", new List<Person>(), new List<Playlist>() { robertsBangers });
            Person yigit = new Person("Yigit", new List<Person>(), new List<Playlist>() { ny });
            Person obama = new Person("Obama", new List<Person>(), new List<Playlist>());

            users.Add(robert);
            users.Add(yigit);
            users.Add(obama);

            Song champagnepoetry = new Song("Champagne Poetry", new List<Artist>(), 2);
            Song wasErNooit = new Song("Was er nooit", new List<Artist>(), 2);
            Song onedance = new Song("One Dance", new List<Artist>(), 0);
            Song manymen = new Song("Many Men (Wish Death)", new List<Artist>(), 2);

            songs.Add(champagnepoetry);
            songs.Add(wasErNooit);
            songs.Add(onedance);
            songs.Add(manymen);

            Album levensles = new Album(new List<Artist>() { lijpe }, new List<Song>() { wasErNooit }, "Levensles");
            Album certifiedloverboy = new Album(new List<Artist>() { drake }, new List<Song>() { champagnepoetry }, "Certified Lover Boy");
            Album getrichordietryin = new Album(new List<Artist>() { fiftycent }, new List<Song>() { manymen }, "Get Rich or Die Tryin");

            albums.Add(levensles);
            albums.Add(certifiedloverboy);
            albums.Add(getrichordietryin);

            Client client = new Client(users, albums, songs);
            
            client.SetActiveUser(yigit);

            //add in song object Artists field the name of the artist
            wasErNooit.Artists.Add(lijpe);
            champagnepoetry.Artists.Add(drake);
            //song.Artists.Add(artist.Name);

            //adding song to artist
            lijpe.AddSong(wasErNooit);
            artist.AddSong(onedance);

            //adding album to artist
            lijpe.AddAlbum(levensles);
            

            client.AddFriend(0);

            Console.WriteLine(yigit.ShowFriends());
            //yigit.AddFriend(testPerson);
            //yigit.AddFriend(robert);
            //superuser.AddFriend(yigit);
            //superuser.AddFriend(robert);
            //superuser.AddFriend(testPerson);
            //Console.WriteLine(superuser.ShowFriends());

            //superuser.CreatePlaylist(Playlist hi

            //creating playlists for the playlist list in superuser (user/person what ever you want to call it really..)
            //superuser.CreatePlaylist();

        }
    }
}