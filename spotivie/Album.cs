﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace spotivie
{
    /*
     * This class is used to create an album
     */
    internal class Album : SongCollection
    {
        private List<Artist> Artists;
        private List<Song> Songs;
        
        public Album(List<Artist> artists, List<Song> songs, string title) : base(title)
        {
            Songs = songs;
            Artists = artists;
        }
        
        public string ShowArtists()
        {
            List<string> artistNames = new List<string>();
            foreach (Artist artist in Artists)
            {
                artistNames.Add(artist.Name);
            }
            string splitArtistsList = string.Join(", ", artistNames);
            return "Artists: " + splitArtistsList;
        }

        public override string ToString()
        {
            List<string> artistNames = new List<string>();
            foreach (Artist artist in Artists)
            {
                artistNames.Add(artist.Name);
            }
            string splitArtistsList = string.Join(", ", artistNames);
            
            List<string> songNames = new List<string>();
            foreach (Song song in Songs)
            {
                songNames.Add(song.Title);
            }
            string splitSongsList = string.Join(", ", songNames);
            return "Album information\r\n" + "Title: " + Title + "\r\nArtists: " + splitArtistsList + "\r\nSongs: " + splitSongsList + "\r\n";
        }

    }
}
