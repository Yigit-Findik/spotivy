using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace spotivie
{
    internal class Playlist : SongCollection
    {
        public Person Owner;

        public Playlist(string title, Person owner) : base(title)
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
            return base.ToString();
        }
    }
}
