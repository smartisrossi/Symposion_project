﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Il codice è stato generato da uno strumento.
//     Versione runtime:4.0.30319.42000
//
//     Le modifiche apportate a questo file possono provocare un comportamento non corretto e andranno perse se
//     il codice viene rigenerato.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SecurityManager.ServiceReferenceBroker {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="AccessFault", Namespace="http://schemas.datacontract.org/2004/07/SymposionBrokerLib")]
    [System.SerializableAttribute()]
    public partial class AccessFault : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string MessageField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Message {
            get {
                return this.MessageField;
            }
            set {
                if ((object.ReferenceEquals(this.MessageField, value) != true)) {
                    this.MessageField = value;
                    this.RaisePropertyChanged("Message");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReferenceBroker.IBroker")]
    public interface IBroker {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBroker/GestisciLogin", ReplyAction="http://tempuri.org/IBroker/GestisciLoginResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(SecurityManager.ServiceReferenceBroker.AccessFault), Action="http://tempuri.org/IBroker/GestisciLoginAccessFaultFault", Name="AccessFault", Namespace="http://schemas.datacontract.org/2004/07/SymposionBrokerLib")]
        string GestisciLogin(string username, string passwd, string role);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBroker/GestisciLogin", ReplyAction="http://tempuri.org/IBroker/GestisciLoginResponse")]
        System.Threading.Tasks.Task<string> GestisciLoginAsync(string username, string passwd, string role);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBroker/GestisciIscrizione", ReplyAction="http://tempuri.org/IBroker/GestisciIscrizioneResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(SecurityManager.ServiceReferenceBroker.AccessFault), Action="http://tempuri.org/IBroker/GestisciIscrizioneAccessFaultFault", Name="AccessFault", Namespace="http://schemas.datacontract.org/2004/07/SymposionBrokerLib")]
        string GestisciIscrizione(string username, string passwd, string mail, string role);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBroker/GestisciIscrizione", ReplyAction="http://tempuri.org/IBroker/GestisciIscrizioneResponse")]
        System.Threading.Tasks.Task<string> GestisciIscrizioneAsync(string username, string passwd, string mail, string role);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IBrokerChannel : SecurityManager.ServiceReferenceBroker.IBroker, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class BrokerClient : System.ServiceModel.ClientBase<SecurityManager.ServiceReferenceBroker.IBroker>, SecurityManager.ServiceReferenceBroker.IBroker {
        
        public BrokerClient() {
        }
        
        public BrokerClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public BrokerClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public BrokerClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public BrokerClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string GestisciLogin(string username, string passwd, string role) {
            return base.Channel.GestisciLogin(username, passwd, role);
        }
        
        public System.Threading.Tasks.Task<string> GestisciLoginAsync(string username, string passwd, string role) {
            return base.Channel.GestisciLoginAsync(username, passwd, role);
        }
        
        public string GestisciIscrizione(string username, string passwd, string mail, string role) {
            return base.Channel.GestisciIscrizione(username, passwd, mail, role);
        }
        
        public System.Threading.Tasks.Task<string> GestisciIscrizioneAsync(string username, string passwd, string mail, string role) {
            return base.Channel.GestisciIscrizioneAsync(username, passwd, mail, role);
        }
    }
}
