using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace spotivie
{
    internal interface iPlayable
    {
        public void Play();

        public void Pause();

        public void Stop();

        public void Next();

        public int length();

        //TODO: zet in de verbeterings model* Dat je een length hebt bij deze interface (dus overal moet je een length hebben)
        public string Title { get; }
    }
}
