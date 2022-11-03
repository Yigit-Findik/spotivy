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

        //TODO: zet in de verbeterings model* Dat je een title hebt bij deze interface (dus overal moet je een title hebben dat iPlayable implementeert)
        public string Title { get; }
    }
}
