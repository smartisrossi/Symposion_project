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
    [System.Runtime.Serialization.DataContractAttribute(Name="Entry", Namespace="http://schemas.datacontract.org/2004/07/Progetto_Symposion")]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(Progetto_Symposion.EntryOperazione))]
    public partial class Entry : object, System.Runtime.Serialization.IExtensibleDataObject
    {
        
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        private System.DateTime DataOraField;
        
        private string LuogoField;
        
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
        public System.DateTime DataOra
        {
            get
            {
                return this.DataOraField;
            }
            set
            {
                this.DataOraField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Luogo
        {
            get
            {
                return this.LuogoField;
            }
            set
            {
                this.LuogoField = value;
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
    [System.Runtime.Serialization.DataContractAttribute(Name="EntryOperazione", Namespace="http://schemas.datacontract.org/2004/07/Progetto_Symposion")]
    public partial class EntryOperazione : Progetto_Symposion.Entry
    {
        
        private string TipoOperazioneField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string TipoOperazione
        {
            get
            {
                return this.TipoOperazioneField;
            }
            set
            {
                this.TipoOperazioneField = value;
            }
        }
    }
}
namespace SymposionGestoreSicurezzaLib
{
    using System.Runtime.Serialization;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="BookFault", Namespace="http://schemas.datacontract.org/2004/07/SymposionGestoreSicurezzaLib")]
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
[System.ServiceModel.ServiceContractAttribute(ConfigurationName="IGestoreSicurezza")]
public interface IGestoreSicurezza
{
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILog/GetEntryOperazioni", ReplyAction="http://tempuri.org/ILog/GetEntryOperazioniResponse")]
    [System.ServiceModel.FaultContractAttribute(typeof(SymposionGestoreSicurezzaLib.BookFault), Action="http://tempuri.org/ILog/GetEntryOperazioniBookFaultFault", Name="BookFault", Namespace="http://schemas.datacontract.org/2004/07/SymposionGestoreSicurezzaLib")]
    string[] GetEntryOperazioni(System.DateTime dateTime);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILog/GetEntryOperazioni", ReplyAction="http://tempuri.org/ILog/GetEntryOperazioniResponse")]
    System.Threading.Tasks.Task<string[]> GetEntryOperazioniAsync(System.DateTime dateTime);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILog/GetEntryOperazioniInterval", ReplyAction="http://tempuri.org/ILog/GetEntryOperazioniIntervalResponse")]
    [System.ServiceModel.FaultContractAttribute(typeof(SymposionGestoreSicurezzaLib.BookFault), Action="http://tempuri.org/ILog/GetEntryOperazioniIntervalBookFaultFault", Name="BookFault", Namespace="http://schemas.datacontract.org/2004/07/SymposionGestoreSicurezzaLib")]
    string[] GetEntryOperazioniInterval(System.DateTime dateTimeStart, System.DateTime dateTimeStop);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILog/GetEntryOperazioniInterval", ReplyAction="http://tempuri.org/ILog/GetEntryOperazioniIntervalResponse")]
    System.Threading.Tasks.Task<string[]> GetEntryOperazioniIntervalAsync(System.DateTime dateTimeStart, System.DateTime dateTimeStop);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILog/GetEntryAccessi", ReplyAction="http://tempuri.org/ILog/GetEntryAccessiResponse")]
    [System.ServiceModel.FaultContractAttribute(typeof(SymposionGestoreSicurezzaLib.BookFault), Action="http://tempuri.org/ILog/GetEntryAccessiBookFaultFault", Name="BookFault", Namespace="http://schemas.datacontract.org/2004/07/SymposionGestoreSicurezzaLib")]
    string[] GetEntryAccessi(System.DateTime dateTime);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILog/GetEntryAccessi", ReplyAction="http://tempuri.org/ILog/GetEntryAccessiResponse")]
    System.Threading.Tasks.Task<string[]> GetEntryAccessiAsync(System.DateTime dateTime);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILog/GetEntryAccessiInterval", ReplyAction="http://tempuri.org/ILog/GetEntryAccessiIntervalResponse")]
    [System.ServiceModel.FaultContractAttribute(typeof(SymposionGestoreSicurezzaLib.BookFault), Action="http://tempuri.org/ILog/GetEntryAccessiIntervalBookFaultFault", Name="BookFault", Namespace="http://schemas.datacontract.org/2004/07/SymposionGestoreSicurezzaLib")]
    string[] GetEntryAccessiInterval(System.DateTime dateTimeStart, System.DateTime dateTimeStop);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILog/GetEntryAccessiInterval", ReplyAction="http://tempuri.org/ILog/GetEntryAccessiIntervalResponse")]
    System.Threading.Tasks.Task<string[]> GetEntryAccessiIntervalAsync(System.DateTime dateTimeStart, System.DateTime dateTimeStop);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILog/PrintLogAccessi", ReplyAction="http://tempuri.org/ILog/PrintLogAccessiResponse")]
    [System.ServiceModel.FaultContractAttribute(typeof(SymposionGestoreSicurezzaLib.BookFault), Action="http://tempuri.org/ILog/PrintLogAccessiBookFaultFault", Name="BookFault", Namespace="http://schemas.datacontract.org/2004/07/SymposionGestoreSicurezzaLib")]
    void PrintLogAccessi(Progetto_Symposion.Entry[] entries);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILog/PrintLogAccessi", ReplyAction="http://tempuri.org/ILog/PrintLogAccessiResponse")]
    System.Threading.Tasks.Task PrintLogAccessiAsync(Progetto_Symposion.Entry[] entries);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILog/PrintLogOperazioni", ReplyAction="http://tempuri.org/ILog/PrintLogOperazioniResponse")]
    [System.ServiceModel.FaultContractAttribute(typeof(SymposionGestoreSicurezzaLib.BookFault), Action="http://tempuri.org/ILog/PrintLogOperazioniBookFaultFault", Name="BookFault", Namespace="http://schemas.datacontract.org/2004/07/SymposionGestoreSicurezzaLib")]
    void PrintLogOperazioni(Progetto_Symposion.EntryOperazione[] entries);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILog/PrintLogOperazioni", ReplyAction="http://tempuri.org/ILog/PrintLogOperazioniResponse")]
    System.Threading.Tasks.Task PrintLogOperazioniAsync(Progetto_Symposion.EntryOperazione[] entries);
}

[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
public interface IGestoreSicurezzaChannel : IGestoreSicurezza, System.ServiceModel.IClientChannel
{
}

[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
public partial class GestoreSicurezzaClient : System.ServiceModel.ClientBase<IGestoreSicurezza>, IGestoreSicurezza
{
    
    public GestoreSicurezzaClient()
    {
    }
    
    public GestoreSicurezzaClient(string endpointConfigurationName) : 
            base(endpointConfigurationName)
    {
    }
    
    public GestoreSicurezzaClient(string endpointConfigurationName, string remoteAddress) : 
            base(endpointConfigurationName, remoteAddress)
    {
    }
    
    public GestoreSicurezzaClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
            base(endpointConfigurationName, remoteAddress)
    {
    }
    
    public GestoreSicurezzaClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
            base(binding, remoteAddress)
    {
    }
    
    public string[] GetEntryOperazioni(System.DateTime dateTime)
    {
        return base.Channel.GetEntryOperazioni(dateTime);
    }
    
    public System.Threading.Tasks.Task<string[]> GetEntryOperazioniAsync(System.DateTime dateTime)
    {
        return base.Channel.GetEntryOperazioniAsync(dateTime);
    }
    
    public string[] GetEntryOperazioniInterval(System.DateTime dateTimeStart, System.DateTime dateTimeStop)
    {
        return base.Channel.GetEntryOperazioniInterval(dateTimeStart, dateTimeStop);
    }
    
    public System.Threading.Tasks.Task<string[]> GetEntryOperazioniIntervalAsync(System.DateTime dateTimeStart, System.DateTime dateTimeStop)
    {
        return base.Channel.GetEntryOperazioniIntervalAsync(dateTimeStart, dateTimeStop);
    }
    
    public string[] GetEntryAccessi(System.DateTime dateTime)
    {
        return base.Channel.GetEntryAccessi(dateTime);
    }
    
    public System.Threading.Tasks.Task<string[]> GetEntryAccessiAsync(System.DateTime dateTime)
    {
        return base.Channel.GetEntryAccessiAsync(dateTime);
    }
    
    public string[] GetEntryAccessiInterval(System.DateTime dateTimeStart, System.DateTime dateTimeStop)
    {
        return base.Channel.GetEntryAccessiInterval(dateTimeStart, dateTimeStop);
    }
    
    public System.Threading.Tasks.Task<string[]> GetEntryAccessiIntervalAsync(System.DateTime dateTimeStart, System.DateTime dateTimeStop)
    {
        return base.Channel.GetEntryAccessiIntervalAsync(dateTimeStart, dateTimeStop);
    }
    
    public void PrintLogAccessi(Progetto_Symposion.Entry[] entries)
    {
        base.Channel.PrintLogAccessi(entries);
    }
    
    public System.Threading.Tasks.Task PrintLogAccessiAsync(Progetto_Symposion.Entry[] entries)
    {
        return base.Channel.PrintLogAccessiAsync(entries);
    }
    
    public void PrintLogOperazioni(Progetto_Symposion.EntryOperazione[] entries)
    {
        base.Channel.PrintLogOperazioni(entries);
    }
    
    public System.Threading.Tasks.Task PrintLogOperazioniAsync(Progetto_Symposion.EntryOperazione[] entries)
    {
        return base.Channel.PrintLogOperazioniAsync(entries);
    }
}
