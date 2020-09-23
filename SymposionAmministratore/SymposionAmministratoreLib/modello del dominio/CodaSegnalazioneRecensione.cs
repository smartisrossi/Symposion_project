using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace Progetto_Symposion
{
    [DataContract]
    [Serializable]
    public class CodaSegnalazioneRecensione
    {
        private Queue<SegnalazioneRecensione> _codaSegnalazioneRecensione = new Queue<SegnalazioneRecensione>();

        public SegnalazioneRecensione GetNextSegnalazioneRecensione()
        {
            return _codaSegnalazioneRecensione.Dequeue();
        }

        public void AddSegnalazioneRecensione(SegnalazioneRecensione segnalazione)
        {
            _codaSegnalazioneRecensione.Enqueue(segnalazione);
        }

        public SegnalazioneRecensione[] ElencaSegnalazioniRecensione()
        {
            SegnalazioneRecensione[] result = _codaSegnalazioneRecensione.ToArray();
            return result;
        }

        public override string ToString()
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            sb.Append("Segnalazioni recensione: \n");
            foreach (SegnalazioneRecensione s in _codaSegnalazioneRecensione)
            {
                sb.Append(s.ToString() + "\n");
            }
            return sb.ToString();
        }
    }
}
