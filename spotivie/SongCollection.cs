using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace spotivie
{
    internal class SongCollection : iPlayable
    {
        public string Title;
        protected List<iPlayable> Playables = new List<iPlayable>();

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

        public string Title()
        {
            throw new NotImplementedException();
        }
}
