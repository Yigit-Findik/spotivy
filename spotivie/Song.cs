using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace spotivie
{
    /*
     * This class is used to create an song
     */
    public enum Genre
    {
        POP,
        ROCK,
        HIPHOP,
        COUNTRY,
        JAZZ,
        CLASSICAL,
        BLUES,
        OTHER
    }

    internal class Song
    {
        public string Title;
        public List<Artist> Artists;
        public Genre genre;
        private int Duration;

        public Song(string title, List<Artist> artists, int genre)
        {
            Title = title;
            Artists = artists;
            this.genre = (Genre)genre;
            Random rnd = new Random();
            Duration = rnd.Next(1, 10);
        }

        public override string ToString()
        {
            List<String> artistNames = new List<string>();
            foreach (Artist artist in Artists)
            {
                artistNames.Add(artist.Name);
            }
            
            string splitArtistsList = string.Join(", ", artistNames);
            return "Song information\r\n" + "Title: " + Title + "\r\nArtists: " + splitArtistsList + "\r\nGenre: " + genre + "\r\nDuration: " + Duration + "\r\n";
        }
    }
}
