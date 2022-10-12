﻿using System;
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
            return "Artist information\r\n" + "Name: " + Name + "\r\nAlbums: " + Albums + "\r\nSongs: " + Songs + "\r\n";
        }
    }
}
