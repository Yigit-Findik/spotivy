using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace spotivie
{
    /*
     * This class is used to create an artist
     */
    internal class Artist
    {
        public string Name;
        private List<Album> Albums;
        private List<Song> Songs;

        public Artist(string name, List<Album> albums, List<Song> songs)
        {
            Name = name;
            Albums = albums;
            Songs = songs;
        }

        public void AddSong(Song song)
        {
            Songs.Add(song);
        }

        public void AddAlbum(Album album)
        {
            Albums.Add(album);
        }

        public override string ToString()
        {
            //foreaching through the list of albums and songs so we can print them out
            List<String> songNames = new List<string>();
            foreach (Song song in Songs)
            {
                songNames.Add(song.Title);
            }
            string splitSongsList = string.Join(", ", songNames);

            List<String> albumNames = new List<string>();
            foreach (Album album in Albums)
            {
                albumNames.Add(album.Title);
            }
            string splitAlbumsList = string.Join(", ", albumNames);
            
            return "Artist information\r\n" + "Name: " + Name + "\r\nAlbums: " + splitAlbumsList + "\r\nSongs: " + splitSongsList + "\r\n";
        }
    }
}
