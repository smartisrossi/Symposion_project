using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using Progetto_Symposion;

namespace SymposionAmministratoreLib
{
    public class AmministratoreService : IAmministratore
    {
        private SegnalazioniController _segnalazioni = new SegnalazioniController();
        private ISegnalazioneLibro _segnalazioneLibro = null;
        private ISegnalazioneRecensione _segnalazioneRecensione = null;
        public void AddSegnalazioneLibro(SegnalazioneLibro segnalazioneLibro)
        {
            _segnalazioni.AddSegnalazioneLibro(segnalazioneLibro);
        }

        public void AddSegnalazioneRecensione(SegnalazioneRecensione segnalazioneRecensione)
        {
            _segnalazioni.AddSegnalazioneRecensione(segnalazioneRecensione);
        }

        public void AggiornaLibro(Libro libro)
        {
            if (_segnalazioneLibro == null)
                _segnalazioneLibro = new SegnalazioneLibroController(_segnalazioni);
            _segnalazioneLibro.AggiornaLibro(libro);
        }

        public void EliminaRecensione(Recensione recensione)
        {
            if (_segnalazioneRecensione == null)
                _segnalazioneRecensione = new SegnalazioneRecensioneController(_segnalazioni);
            _segnalazioneRecensione.EliminaRecensione(recensione);
        }

        public Libro GetLibro(string titolo, string autore)
        {
            if (_segnalazioneLibro == null)
                _segnalazioneLibro = new SegnalazioneLibroController(_segnalazioni);
            return _segnalazioneLibro.GetLibro(titolo, autore);
        }

        public Recensione GetRecensione(int id)
        {
            if (_segnalazioneRecensione == null)
                _segnalazioneRecensione = new SegnalazioneRecensioneController(_segnalazioni);
            return _segnalazioneRecensione.GetRecensione(id);
        }

        public SegnalazioneLibro GetSegnalazioneLibro()
        {
            return _segnalazioni.GetSegnalazioneLibro();
        }

        public SegnalazioneRecensione GetSegnalazioneRecensione()
        {
            return _segnalazioni.GetSegnalazioneRecensione();
        }

        public void InviaNotificaUtente(string username)
        {
            if (_segnalazioneRecensione == null)
                _segnalazioneRecensione = new SegnalazioneRecensioneController(_segnalazioni);
            _segnalazioneRecensione.InviaNotificaUtente(username);
        }
    }
}
