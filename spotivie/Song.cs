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

    internal class Song : iPlayable
    {
        public string Title { get { return title; } }
        private string title;


        public List<Artist> Artists;
        public Genre genre;
        private int Duration;

        public Song(string title, List<Artist> artists, int genre)
        {
            this.title = title;
            Artists = artists;
            this.genre = (Genre)genre;
            Random rnd = new Random();
            Duration = rnd.Next(1, 10); //randomized duration in minutes
        }

        public int length()
        {
            throw new NotImplementedException();
        }

        public void Next()
        {
            Play();
        }

        public void Pause()
        {
            Console.WriteLine("Song is paused");
        }

        public void Play()
        {
            Console.WriteLine("Playing song: " + this.title);
        }

        public void Stop()
        {
            Console.WriteLine("Stopped song: " + this.title);
        }

        public override string ToString()
        {
            List<String> artistNames = new List<string>();
            foreach (Artist artist in Artists)
            {
                artistNames.Add(artist.Name);
            }
            
            string splitArtistsList = string.Join(", ", artistNames);
            return "Song information\r\n" + "Title: " + this.title + "\r\nArtists: " + splitArtistsList + "\r\nGenre: " + genre + "\r\nDuration: " + Duration + "\r\n";
        }
    }
}
