using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using Progetto_Symposion;

namespace SymposionUtenteLib
{
    
    public class UtenteService : IUtente
    {
        private GestisciUtente _gestisciUtente = new GestisciUtente();
        private IListeSalvate _listeSalvateController = null;
        private IListePersonali _listePersonaliController = null;
        private IRecensione _recensioneController = null;
        private ISegnalazioni _segnalazioniController = null;
        private IInserimentoLibro _inserimentoLibroController = null;
        private IRicercaPubblica _ricercaPubblicaController = null;
        private IRecensioniSalvate _recensioniSalvateController = null;
        private IClassifica _classificaController = null;
   
        public void CreaListaPersonale(string nome, string genere, string username)
        {
            if (_listePersonaliController == null)
                _listePersonaliController = new ListePersonaliController(_gestisciUtente);
            _listePersonaliController.CreaListaPersonale(nome, genere, username);
        }

        public List<Lista> GetListePersonali(string username)
        {
            return _gestisciUtente.GetListePersonali(username);
        }

        public List<Lista> GetListeSalvate(string username)
        {
            return _gestisciUtente.GetListeSalvate(username);
        }

        public List<Recensione> GetRecensioniSalvate(string username)
        {
            return _gestisciUtente.GetRecensioniSalvate(username);
        }

        public List<Recensione> GetRecensioniScritte(string username)
        {
            return _gestisciUtente.GetRecensioniScritte(username);
        }

        public void ModificaListaPersonale(Lista lista)
        {
            if (_listePersonaliController == null)
                _listePersonaliController = new ListePersonaliController(_gestisciUtente);
            _listePersonaliController.ModificaListaPersonale(lista);
        }

        public void ModificaRecensione(Recensione recensione)
        {
            if (_recensioneController == null)
                _recensioneController = new RecensioneController(_gestisciUtente);
            _recensioneController.ModificaRecensione(recensione);
        }

        public void PubblicaListaPersonale(Lista lista)
        {
            if (_listePersonaliController == null)
                _listePersonaliController = new ListePersonaliController(_gestisciUtente);
            _listePersonaliController.PubblicaListaPersonale(lista);
        }

        public void PubblicaRecensione(int? punteggio, string commento, Libro libro, string username)
        {
            if (_recensioneController == null)
                _recensioneController = new RecensioneController(_gestisciUtente);
            _recensioneController.PubblicaRecensione(punteggio, commento, libro, username);
        }

        public void RimuoviLista(Lista lista, string username)
        {
            if (_listeSalvateController == null)
                _listeSalvateController = new ListeSalvateController(_gestisciUtente);
            _listeSalvateController.RimuoviLista(lista, username);
        }

        public void SalvaLista(Lista lista, string username)
        {
            if (_listeSalvateController == null)
                _listeSalvateController = new ListeSalvateController(_gestisciUtente);
            _listeSalvateController.SalvaLista(lista, username);
        }

        public void AddSegnalazioneLibro(SegnalazioneLibro segnalazioneLibro)
        {
            if (_segnalazioniController == null)
                _segnalazioniController = new SegnalazioniController();
            _segnalazioniController.AddSegnalazioneLibro(segnalazioneLibro);
        }

        public void AddSegnalazioneRecensione(SegnalazioneRecensione segnalazioneRecensione)
        {
            if (_segnalazioniController == null)
                _segnalazioniController = new SegnalazioniController();
            _segnalazioniController.AddSegnalazioneRecensione(segnalazioneRecensione);
        }

        public SegnalazioneLibro GetSegnalazioneLibro()
        {
            //il client non puo' accedervi
            return null;
        }

        public SegnalazioneRecensione GetSegnalazioneRecensione()
        {
            //Il client non puo' accedervi
            return null;
        }

        public void RegisterOperazione(string operazione, string username)
        {
            //Il client non po' accerdervi
        }

        public void SalvaRecensione(Recensione recensione, string username)
        {
            if (_recensioniSalvateController == null)
                _recensioniSalvateController = new RecensioniSalvateController(_gestisciUtente);
            _recensioniSalvateController.SalvaRecensione(recensione, username);
        }

        public void RimuoviRecensione(Recensione recensione, string username)
        {
            if (_recensioniSalvateController == null)
                _recensioniSalvateController = new RecensioniSalvateController(_gestisciUtente);
            _recensioniSalvateController.RimuoviRecensione(recensione, username);
        }

        public void InserisciLibroCover(string titolo, string autore, int? anno, string gen, string cover, string username)
        {
            if (_inserimentoLibroController == null)
                _inserimentoLibroController = new InserimentoLibroController();
            _inserimentoLibroController.InserisciLibroCover(titolo, autore, anno, gen, cover, username);
        }

        public void InserisciLibro(string titolo, string autore, int? anno, string gen, string username)
        {
            if (_inserimentoLibroController == null)
                _inserimentoLibroController = new InserimentoLibroController();
            _inserimentoLibroController.InserisciLibro(titolo, autore, anno, gen, username);
        }

        public List<Recensione> CercaRecensioniLibro(Libro libro)
        {
            if (_ricercaPubblicaController == null)
                _ricercaPubblicaController = new RicercaPubblicaController();
            return _ricercaPubblicaController.CercaRecensioniLibro(libro);
        }

        public List<Libro> CercaLibro(string titolo)
        {
            if (_ricercaPubblicaController == null)
                _ricercaPubblicaController = new RicercaPubblicaController();
            return _ricercaPubblicaController.CercaLibro(titolo);
        }

        public List<Lista> CercaLista(string nome)
        {
            if (_ricercaPubblicaController == null)
                _ricercaPubblicaController = new RicercaPubblicaController();
            return _ricercaPubblicaController.CercaLista(nome);
        }

        public List<Libro> CercaGenere(string genere)
        {
            if (_ricercaPubblicaController == null)
                _ricercaPubblicaController = new RicercaPubblicaController();
            return _ricercaPubblicaController.CercaGenere(genere);
        }

        public string CercaUtente(string username)
        {
            if (_ricercaPubblicaController == null)
                _ricercaPubblicaController = new RicercaPubblicaController();
            return _ricercaPubblicaController.CercaUtente(username);
        }

        public List<Libro> GetClassificaGenere(string gen)
        {
            if (_classificaController == null)
                _classificaController = new ClassificaController();
            return _classificaController.GetClassificaGenere(gen);
        }

        public List<Libro> GetClassificaAnno(int date)
        {
            if (_classificaController == null)
                _classificaController = new ClassificaController();
            return _classificaController.GetClassificaAnno(date);
        }

        public RemoteFileInfo DownloadFile(DownloadRequest request)
        {
            RemoteFileInfo result = new RemoteFileInfo();
            try
            {
                string filePath = System.IO.Path.Combine(@"C:\Users\mmart\Desktop\Upload", request.FileName);
                System.IO.FileInfo fileInfo = new System.IO.FileInfo(filePath);

                // check if exists
                if (!fileInfo.Exists)
                    throw new System.IO.FileNotFoundException("File not found",
                                                              request.FileName);

                // open stream
                System.IO.FileStream stream = new System.IO.FileStream(filePath,
                          System.IO.FileMode.Open, System.IO.FileAccess.Read);

                // return result 
                result.FileName = request.FileName;
                result.Length = fileInfo.Length;
                result.FileByteStream = stream;
            }
            catch (Exception ex)
            {

            }
            return result;
        }

        public void UploadFile(RemoteFileInfo request)
        {
            FileStream targetStream = null;
            Stream sourceStream = request.FileByteStream;

            string uploadFolder = @"C:\Users\mmart\Desktop\Upload";

            string filePath = Path.Combine(uploadFolder, request.FileName);

            using (targetStream = new FileStream(filePath, FileMode.Create,
                                  FileAccess.Write, FileShare.None))
            {
                //read from the input stream in 65000 byte chunks

                const int bufferLen = 65000;
                byte[] buffer = new byte[bufferLen];
                int count = 0;
                while ((count = sourceStream.Read(buffer, 0, bufferLen)) > 0)
                {
                    // save to output stream
                    targetStream.Write(buffer, 0, count);
                }
                targetStream.Close();
                sourceStream.Close();
            }
        }

        public List<Lista> CercaListaUtente(string username)
        {
            if (_ricercaPubblicaController == null)
                _ricercaPubblicaController = new RicercaPubblicaController();
            return _ricercaPubblicaController.CercaListaUtente(username);
        }

        public List<Recensione> CercaRecensioniUtente(string usernameUtente)
        {
            if (_ricercaPubblicaController == null)
                _ricercaPubblicaController = new RicercaPubblicaController();
            return _ricercaPubblicaController.CercaRecensioniUtente(usernameUtente);
        }

        public List<Lista> CercaListaPersonaleUtente(string username)
        {
            if (_ricercaPubblicaController == null)
                _ricercaPubblicaController = new RicercaPubblicaController();
            return _ricercaPubblicaController.CercaListaPersonaleUtente(username);
        }
    }
}
