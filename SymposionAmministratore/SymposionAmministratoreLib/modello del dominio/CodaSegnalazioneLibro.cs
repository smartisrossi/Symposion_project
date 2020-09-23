using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace Progetto_Symposion
{
    [DataContract]
    [Serializable]
    public class CodaSegnalazioneLibro
    {
        private Queue<SegnalazioneLibro> _codaSegnalazioneLibro = new Queue<SegnalazioneLibro>();

        public SegnalazioneLibro GetNextSegnalazioneLibro()
        {
            return _codaSegnalazioneLibro.Dequeue();
        }

        public void AddSegnalazioneLibro(SegnalazioneLibro segnalazione)
        {
            _codaSegnalazioneLibro.Enqueue(segnalazione);
        }

        public SegnalazioneLibro[] ElencaSegnalazioniRecensione()
        {
            SegnalazioneLibro[] result = _codaSegnalazioneLibro.ToArray();
            return result;
        }

        public override string ToString()
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            sb.Append("Segnalazioni libro: \n");
            foreach (SegnalazioneLibro s in _codaSegnalazioneLibro)
            {
                sb.Append(s.ToString() + "\n");
            }
            return sb.ToString();
        }
    }
}
