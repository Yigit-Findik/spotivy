using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace spotivie
{
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
            return base.ToString();
        }
    }
}
