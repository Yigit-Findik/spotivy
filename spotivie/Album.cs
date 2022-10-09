using System;
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
            Artists = artists;
            Songs = songs;
        }
        
        public List<Artist> ShowArtists()
        {
            return Artists;
        }

        public override string ToString()
        {
            return base.ToString();
        }

    }
}
