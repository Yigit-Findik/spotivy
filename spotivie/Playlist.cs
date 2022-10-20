using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace spotivie
{
    /*
     * This class is used to create an playlist
     */

    internal class Playlist : SongCollection
    {
        public Person Owner;

        public Playlist(Person owner, string title) : base(title)
        {
            Owner = owner;
        }

        public void Add(iPlayable playable)
        {
            //empty for now
        }

        public void Remove(iPlayable playable)
        {
            //empty for now
        }

        public override string ToString()
        {
            return "Playlist information\r\n" + "Title: " + Title + "\r\nOwner: " + Owner.Name + "\r\n";
        }
    }
}
