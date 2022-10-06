using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace spotivie
{
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
        private int Duur;
        
        public Song(string title, List<Artist> artists, int genre)
        {
            Title = title;
            Artists = artists;
            this.genre = (Genre)genre;
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
