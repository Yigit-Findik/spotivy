using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace spotivie
{
    internal class SongCollection : iPlayable
    {
        private string title;
        public string Title { get { return title; } }
        protected List<iPlayable> Playables = new List<iPlayable>();

        public SongCollection(string title)
        {
            this.title = title;
        }

        public override string ToString()
        {
            return base.ToString();
        }

        public List<iPlayable> ShowPlayables()
        {
            return Playables;
        }

        public void Play()
        {
            throw new NotImplementedException();
        }

        public void Pause()
        {
            throw new NotImplementedException();
        }

        public void Stop()
        {
            throw new NotImplementedException();
        }

        public void Next()
        {
            throw new NotImplementedException();
        }

        public int length()
        {
            throw new NotImplementedException();
        }
    }
}
