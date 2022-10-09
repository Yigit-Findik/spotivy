using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace spotivie
{
    internal class SongCollection
    {
        public string Title;
        private List<iPlayable> Playables;

        public SongCollection(string title)
        {
            Title = title;
        }

        public override string ToString()
        {
            return base.ToString();
        }

        public List<iPlayable> ShowPlayables()
        {
            return Playables;
        }
    }
}
