﻿namespace spotivie
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Songs dummy data
            Song song = new Song("song", new List<Artist>(), 0);
            Song onedance = new Song("one dance", new List<Artist>(), 0);

            //Artist dummy data
            Artist artist = new Artist("artist", new List<Album>(), new List<Song>());
            Artist artist2 = new Artist("artist2", new List<Album>(), new List<Song>());
            Artist artist3 = new Artist("artist34", new List<Album>(), new List<Song>());
            Artist artist4 = new Artist("artist4", new List<Album>(), new List<Song>());

            //Album dummy data
            Album album = new Album(new List<Artist>(), new List<Song>(), "album");
            Album album2 = new Album(new List<Artist>(), new List<Song>(), "album2");
            Album album3 = new Album(new List<Artist>(), new List<Song>(), "album3");
            Album album4 = new Album(new List<Artist>(), new List<Song>(), "album4");

            //add in song object Artists field the name of the artist
            song.Artists.Add(artist);
            song.Artists.Add(artist2);
            song.Artists.Add(artist3);
            song.Artists.Add(artist4);
            //song.Artists.Add(artist.Name);

            //adding song to artist
            artist.AddSong(song);
            artist.AddSong(onedance);

            //adding album to artist
            artist.AddAlbum(album);
            artist.AddAlbum(album2);

            Console.WriteLine(artist.ToString());

        }
    }
}