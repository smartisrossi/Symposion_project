﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Il codice è stato generato da uno strumento.
//     Versione runtime:4.0.30319.42000
//
//     Le modifiche apportate a questo file possono provocare un comportamento non corretto e andranno perse se
//     il codice viene rigenerato.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Progetto_Symposion
{
    using System.Runtime.Serialization;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="SegnalazioneLibro", Namespace="http://schemas.datacontract.org/2004/07/Progetto_Symposion")]
    public partial class SegnalazioneLibro : object, System.Runtime.Serialization.IExtensibleDataObject
    {
        
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        private int IdField;
        
        private Progetto_Symposion.Libro LibroField;
        
        private string UsernameField;
        
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData
        {
            get
            {
                return this.extensionDataField;
            }
            set
            {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Id
        {
            get
            {
                return this.IdField;
            }
            set
            {
                this.IdField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public Progetto_Symposion.Libro Libro
        {
            get
            {
                return this.LibroField;
            }
            set
            {
                this.LibroField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Username
        {
            get
            {
                return this.UsernameField;
            }
            set
            {
                this.UsernameField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Libro", Namespace="http://schemas.datacontract.org/2004/07/Progetto_Symposion")]
    public partial class Libro : object, System.Runtime.Serialization.IExtensibleDataObject
    {
        
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        private int AnnoField;
        
        private string AutoreField;
        
        private string FilePathField;
        
        private Progetto_Symposion.genere GenField;
        
        private string TitoloField;
        
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData
        {
            get
            {
                return this.extensionDataField;
            }
            set
            {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Anno
        {
            get
            {
                return this.AnnoField;
            }
            set
            {
                this.AnnoField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Autore
        {
            get
            {
                return this.AutoreField;
            }
            set
            {
                this.AutoreField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string FilePath
        {
            get
            {
                return this.FilePathField;
            }
            set
            {
                this.FilePathField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public Progetto_Symposion.genere Gen
        {
            get
            {
                return this.GenField;
            }
            set
            {
                this.GenField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Titolo
        {
            get
            {
                return this.TitoloField;
            }
            set
            {
                this.TitoloField = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="genere", Namespace="http://schemas.datacontract.org/2004/07/Progetto_Symposion")]
    public enum genere : int
    {
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Avventura = 0,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Classici = 1,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Fantascienza = 2,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Fantasy = 3,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Giallo = 4,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Horror = 5,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Personale = 6,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Romanzo = 7,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Thriller = 8,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Umorismo = 9,
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="SegnalazioneRecensione", Namespace="http://schemas.datacontract.org/2004/07/Progetto_Symposion")]
    public partial class SegnalazioneRecensione : object, System.Runtime.Serialization.IExtensibleDataObject
    {
        
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        private int IdField;
        
        private Progetto_Symposion.Recensione RecensioneField;
        
        private string UsernameField;
        
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData
        {
            get
            {
                return this.extensionDataField;
            }
            set
            {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Id
        {
            get
            {
                return this.IdField;
            }
            set
            {
                this.IdField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public Progetto_Symposion.Recensione Recensione
        {
            get
            {
                return this.RecensioneField;
            }
            set
            {
                this.RecensioneField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Username
        {
            get
            {
                return this.UsernameField;
            }
            set
            {
                this.UsernameField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Recensione", Namespace="http://schemas.datacontract.org/2004/07/Progetto_Symposion")]
    public partial class Recensione : object, System.Runtime.Serialization.IExtensibleDataObject
    {
        
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        private string CommentoField;
        
        private int IdField;
        
        private Progetto_Symposion.Libro LibroField;
        
        private int PunteggioField;
        
        private string UsernameField;
        
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData
        {
            get
            {
                return this.extensionDataField;
            }
            set
            {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Commento
        {
            get
            {
                return this.CommentoField;
            }
            set
            {
                this.CommentoField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Id
        {
            get
            {
                return this.IdField;
            }
            set
            {
                this.IdField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public Progetto_Symposion.Libro Libro
        {
            get
            {
                return this.LibroField;
            }
            set
            {
                this.LibroField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Punteggio
        {
            get
            {
                return this.PunteggioField;
            }
            set
            {
                this.PunteggioField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Username
        {
            get
            {
                return this.UsernameField;
            }
            set
            {
                this.UsernameField = value;
            }
        }
    }
}
namespace SymposionAmministratoreLib
{
    using System.Runtime.Serialization;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="BookFault", Namespace="http://schemas.datacontract.org/2004/07/SymposionAmministratoreLib")]
    public partial class BookFault : object, System.Runtime.Serialization.IExtensibleDataObject
    {
        
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        private string MessageField;
        
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData
        {
            get
            {
                return this.extensionDataField;
            }
            set
            {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Message
        {
            get
            {
                return this.MessageField;
            }
            set
            {
                this.MessageField = value;
            }
        }
    }
}


[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
[System.ServiceModel.ServiceContractAttribute(ConfigurationName="IAmministratore")]
public interface IAmministratore
{
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISegnalazioni/GetSegnalazioneLibro", ReplyAction="http://tempuri.org/ISegnalazioni/GetSegnalazioneLibroResponse")]
    [System.ServiceModel.FaultContractAttribute(typeof(SymposionAmministratoreLib.BookFault), Action="http://tempuri.org/ISegnalazioni/GetSegnalazioneLibroBookFaultFault", Name="BookFault", Namespace="http://schemas.datacontract.org/2004/07/SymposionAmministratoreLib")]
    Progetto_Symposion.SegnalazioneLibro GetSegnalazioneLibro();
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISegnalazioni/GetSegnalazioneLibro", ReplyAction="http://tempuri.org/ISegnalazioni/GetSegnalazioneLibroResponse")]
    System.Threading.Tasks.Task<Progetto_Symposion.SegnalazioneLibro> GetSegnalazioneLibroAsync();
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISegnalazioni/GetSegnalazioneRecensione", ReplyAction="http://tempuri.org/ISegnalazioni/GetSegnalazioneRecensioneResponse")]
    [System.ServiceModel.FaultContractAttribute(typeof(SymposionAmministratoreLib.BookFault), Action="http://tempuri.org/ISegnalazioni/GetSegnalazioneRecensioneBookFaultFault", Name="BookFault", Namespace="http://schemas.datacontract.org/2004/07/SymposionAmministratoreLib")]
    Progetto_Symposion.SegnalazioneRecensione GetSegnalazioneRecensione();
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISegnalazioni/GetSegnalazioneRecensione", ReplyAction="http://tempuri.org/ISegnalazioni/GetSegnalazioneRecensioneResponse")]
    System.Threading.Tasks.Task<Progetto_Symposion.SegnalazioneRecensione> GetSegnalazioneRecensioneAsync();
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISegnalazioneLibro/GetLibro", ReplyAction="http://tempuri.org/ISegnalazioneLibro/GetLibroResponse")]
    [System.ServiceModel.FaultContractAttribute(typeof(SymposionAmministratoreLib.BookFault), Action="http://tempuri.org/ISegnalazioneLibro/GetLibroBookFaultFault", Name="BookFault", Namespace="http://schemas.datacontract.org/2004/07/SymposionAmministratoreLib")]
    Progetto_Symposion.Libro GetLibro(string titolo, string autore);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISegnalazioneLibro/GetLibro", ReplyAction="http://tempuri.org/ISegnalazioneLibro/GetLibroResponse")]
    System.Threading.Tasks.Task<Progetto_Symposion.Libro> GetLibroAsync(string titolo, string autore);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISegnalazioneLibro/AggiornaLibro", ReplyAction="http://tempuri.org/ISegnalazioneLibro/AggiornaLibroResponse")]
    [System.ServiceModel.FaultContractAttribute(typeof(SymposionAmministratoreLib.BookFault), Action="http://tempuri.org/ISegnalazioneLibro/AggiornaLibroBookFaultFault", Name="BookFault", Namespace="http://schemas.datacontract.org/2004/07/SymposionAmministratoreLib")]
    void AggiornaLibro(Progetto_Symposion.Libro libro);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISegnalazioneLibro/AggiornaLibro", ReplyAction="http://tempuri.org/ISegnalazioneLibro/AggiornaLibroResponse")]
    System.Threading.Tasks.Task AggiornaLibroAsync(Progetto_Symposion.Libro libro);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISegnalazioneRecensione/GetRecensione", ReplyAction="http://tempuri.org/ISegnalazioneRecensione/GetRecensioneResponse")]
    [System.ServiceModel.FaultContractAttribute(typeof(SymposionAmministratoreLib.BookFault), Action="http://tempuri.org/ISegnalazioneRecensione/GetRecensioneBookFaultFault", Name="BookFault", Namespace="http://schemas.datacontract.org/2004/07/SymposionAmministratoreLib")]
    Progetto_Symposion.Recensione GetRecensione(int id);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISegnalazioneRecensione/GetRecensione", ReplyAction="http://tempuri.org/ISegnalazioneRecensione/GetRecensioneResponse")]
    System.Threading.Tasks.Task<Progetto_Symposion.Recensione> GetRecensioneAsync(int id);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISegnalazioneRecensione/InviaNotificaUtente", ReplyAction="http://tempuri.org/ISegnalazioneRecensione/InviaNotificaUtenteResponse")]
    [System.ServiceModel.FaultContractAttribute(typeof(SymposionAmministratoreLib.BookFault), Action="http://tempuri.org/ISegnalazioneRecensione/InviaNotificaUtenteBookFaultFault", Name="BookFault", Namespace="http://schemas.datacontract.org/2004/07/SymposionAmministratoreLib")]
    void InviaNotificaUtente(string username);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISegnalazioneRecensione/InviaNotificaUtente", ReplyAction="http://tempuri.org/ISegnalazioneRecensione/InviaNotificaUtenteResponse")]
    System.Threading.Tasks.Task InviaNotificaUtenteAsync(string username);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISegnalazioneRecensione/EliminaRecensione", ReplyAction="http://tempuri.org/ISegnalazioneRecensione/EliminaRecensioneResponse")]
    [System.ServiceModel.FaultContractAttribute(typeof(SymposionAmministratoreLib.BookFault), Action="http://tempuri.org/ISegnalazioneRecensione/EliminaRecensioneBookFaultFault", Name="BookFault", Namespace="http://schemas.datacontract.org/2004/07/SymposionAmministratoreLib")]
    void EliminaRecensione(Progetto_Symposion.Recensione recensione);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISegnalazioneRecensione/EliminaRecensione", ReplyAction="http://tempuri.org/ISegnalazioneRecensione/EliminaRecensioneResponse")]
    System.Threading.Tasks.Task EliminaRecensioneAsync(Progetto_Symposion.Recensione recensione);
}

[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
public interface IAmministratoreChannel : IAmministratore, System.ServiceModel.IClientChannel
{
}

[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
public partial class AmministratoreClient : System.ServiceModel.ClientBase<IAmministratore>, IAmministratore
{
    
    public AmministratoreClient()
    {
    }
    
    public AmministratoreClient(string endpointConfigurationName) : 
            base(endpointConfigurationName)
    {
    }
    
    public AmministratoreClient(string endpointConfigurationName, string remoteAddress) : 
            base(endpointConfigurationName, remoteAddress)
    {
    }
    
    public AmministratoreClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
            base(endpointConfigurationName, remoteAddress)
    {
    }
    
    public AmministratoreClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
            base(binding, remoteAddress)
    {
    }
    
    public Progetto_Symposion.SegnalazioneLibro GetSegnalazioneLibro()
    {
        return base.Channel.GetSegnalazioneLibro();
    }
    
    public System.Threading.Tasks.Task<Progetto_Symposion.SegnalazioneLibro> GetSegnalazioneLibroAsync()
    {
        return base.Channel.GetSegnalazioneLibroAsync();
    }
    
    public Progetto_Symposion.SegnalazioneRecensione GetSegnalazioneRecensione()
    {
        return base.Channel.GetSegnalazioneRecensione();
    }
    
    public System.Threading.Tasks.Task<Progetto_Symposion.SegnalazioneRecensione> GetSegnalazioneRecensioneAsync()
    {
        return base.Channel.GetSegnalazioneRecensioneAsync();
    }
    
    public Progetto_Symposion.Libro GetLibro(string titolo, string autore)
    {
        return base.Channel.GetLibro(titolo, autore);
    }
    
    public System.Threading.Tasks.Task<Progetto_Symposion.Libro> GetLibroAsync(string titolo, string autore)
    {
        return base.Channel.GetLibroAsync(titolo, autore);
    }
    
    public void AggiornaLibro(Progetto_Symposion.Libro libro)
    {
        base.Channel.AggiornaLibro(libro);
    }
    
    public System.Threading.Tasks.Task AggiornaLibroAsync(Progetto_Symposion.Libro libro)
    {
        return base.Channel.AggiornaLibroAsync(libro);
    }
    
    public Progetto_Symposion.Recensione GetRecensione(int id)
    {
        return base.Channel.GetRecensione(id);
    }
    
    public System.Threading.Tasks.Task<Progetto_Symposion.Recensione> GetRecensioneAsync(int id)
    {
        return base.Channel.GetRecensioneAsync(id);
    }
    
    public void InviaNotificaUtente(string username)
    {
        base.Channel.InviaNotificaUtente(username);
    }
    
    public System.Threading.Tasks.Task InviaNotificaUtenteAsync(string username)
    {
        return base.Channel.InviaNotificaUtenteAsync(username);
    }
    
    public void EliminaRecensione(Progetto_Symposion.Recensione recensione)
    {
        base.Channel.EliminaRecensione(recensione);
    }
    
    public System.Threading.Tasks.Task EliminaRecensioneAsync(Progetto_Symposion.Recensione recensione)
    {
        return base.Channel.EliminaRecensioneAsync(recensione);
    }
}