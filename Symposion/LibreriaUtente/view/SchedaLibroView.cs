using Progetto_Symposion;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Libreria
{
    public partial class SchedaLibroView : Form
    {
        private string _addr;
        private string _username;
        private Libro _libro;

        private SchedaLibro _schedaLibro;
        private LaMiaLibreria _laMiaLibreria;

        public SchedaLibroView(string addr, string username, Libro libro)
        {
            InitializeComponent();

            _addr = addr;
            _username = username;
            _libro = libro;

            _schedaLibro = new SchedaLibro(_libro, addr, username);
            _laMiaLibreria = new LaMiaLibreria(_username, _addr);

            textBoxTitoloLibro.Text = _libro.Titolo;
            textBoxAutoreLibro.Text = _libro.Autore;
            textBoxAnnoLibro.Text = _libro.Anno.ToString();
            textBoxGenereLibro.Text = _libro.Gen.ToString();

            if (_libro.FilePath == null) { }
            else
            {
                _schedaLibro.DownloadCopertina();
                pictureBoxCopertina.SizeMode = PictureBoxSizeMode.StretchImage;

                if (!File.Exists("C:\\Users\\mmart\\Desktop\\Download\\" + _libro.FilePath))
                {
                    try
                    {
                        BasicHttpBinding myBinding = new BasicHttpBinding();
                        myBinding.MaxReceivedMessageSize = 2147483647;
                        myBinding.MaxBufferSize = 2147483647;
                        EndpointAddress myEndpoint = new EndpointAddress(_addr);
                        ChannelFactory<IUtente> myChannelFactory = new ChannelFactory<IUtente>(myBinding, myEndpoint);
                        // Create a channel.
                        IUtente client = myChannelFactory.CreateChannel();
                        DownloadRequest requestData = new DownloadRequest();

                        RemoteFileInfo fileInfo = new RemoteFileInfo();
                        requestData.FileName = _libro.FilePath;

                        try
                        {
                            fileInfo = client.DownloadFile(requestData);
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine(e.Message);
                        }
                        Console.ReadLine();

                        string pathNew = @"C:\Users\mmart\Desktop\Download\" + _libro.FilePath;
                        int numBytesToRead = (int)fileInfo.Length;
                        byte[] buffer = new byte[483647];
                        byte[] bytes = new byte[numBytesToRead];
                        int bytesRead = 0;

                        while (numBytesToRead > 0)
                        {
                            // Read may return anything from 0 to numBytesToRead.
                            int n = fileInfo.FileByteStream.Read(buffer, bytesRead, buffer.Length);

                            // Break when the end of the file is reached.
                            if (n == 0)
                                break;
                            Array.Copy(buffer, 0, bytes, bytesRead, n);
                            bytesRead += n;
                            numBytesToRead -= n;
                        }
                        numBytesToRead = bytes.Length;

                        // Write the byte array to the other FileStream.
                        using (FileStream fsNew = new FileStream(pathNew, FileMode.Create, FileAccess.Write))
                        {
                            fsNew.Write(bytes, 0, numBytesToRead);
                        }

                        ((IClientChannel)client).Close();
                    }
                    catch
                    {

                    }
                }

                pictureBoxCopertina.Image = Image.FromFile("C:\\Users\\mmart\\Desktop\\Download\\"+_libro.FilePath);
            }
        }

        private void bunifuImageButtonBack_Click(object sender, EventArgs e)
        {
            new Salotto(_addr, _username).Show();
            this.Hide();
        }

        private void buttonVisualizzaRecensioni_Click(object sender, EventArgs e)
        {
            List<Recensione> recensioniLibro = _schedaLibro.GetRecensioni();

            new ElencoRecensioni(_addr, _username, recensioniLibro, _libro).Show();
            this.Hide();
        }

        private void buttonPubblicaRecensione_Click(object sender, EventArgs e)
        {
            new PubblicaRecensione(_addr, _username, _schedaLibro).Show();
            this.Hide();
        }

        private void buttonSegnala_Click(object sender, EventArgs e)
        {
            _schedaLibro.SegnalaLibro(_libro);
            System.Windows.Forms.MessageBox.Show("Segnalazione libro inviata");

        }

        private void buttonAggiungiALista_Click(object sender, EventArgs e)
        {
            List<Lista> liste = _laMiaLibreria.GetLeMieListe();

            new ElencoListeUtente(_addr, _username, _libro, liste).Show();
            this.Hide();
        }
    }
}
