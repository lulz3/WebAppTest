﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebApiTest.ServiceAuto {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="AutoResult", Namespace="http://schemas.datacontract.org/2004/07/WcfDb")]
    [System.SerializableAttribute()]
    public partial class AutoResult : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Collections.Generic.List<WebApiTest.ServiceAuto.AutoContract> ValuesField;
        
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
        public System.Collections.Generic.List<WebApiTest.ServiceAuto.AutoContract> Values {
            get {
                return this.ValuesField;
            }
            set {
                if ((object.ReferenceEquals(this.ValuesField, value) != true)) {
                    this.ValuesField = value;
                    this.RaisePropertyChanged("Values");
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
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="AutoContract", Namespace="http://schemas.datacontract.org/2004/07/WcfDb")]
    [System.SerializableAttribute()]
    public partial class AutoContract : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int Id_ClovekField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NazevField;
        
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
        public int Id {
            get {
                return this.IdField;
            }
            set {
                if ((this.IdField.Equals(value) != true)) {
                    this.IdField = value;
                    this.RaisePropertyChanged("Id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Id_Clovek {
            get {
                return this.Id_ClovekField;
            }
            set {
                if ((this.Id_ClovekField.Equals(value) != true)) {
                    this.Id_ClovekField = value;
                    this.RaisePropertyChanged("Id_Clovek");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Nazev {
            get {
                return this.NazevField;
            }
            set {
                if ((object.ReferenceEquals(this.NazevField, value) != true)) {
                    this.NazevField = value;
                    this.RaisePropertyChanged("Nazev");
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
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Auto", Namespace="http://schemas.datacontract.org/2004/07/WcfDb")]
    [System.SerializableAttribute()]
    public partial class Auto : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int Id_ClovekField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NazevField;
        
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
        public int Id {
            get {
                return this.IdField;
            }
            set {
                if ((this.IdField.Equals(value) != true)) {
                    this.IdField = value;
                    this.RaisePropertyChanged("Id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Id_Clovek {
            get {
                return this.Id_ClovekField;
            }
            set {
                if ((this.Id_ClovekField.Equals(value) != true)) {
                    this.Id_ClovekField = value;
                    this.RaisePropertyChanged("Id_Clovek");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Nazev {
            get {
                return this.NazevField;
            }
            set {
                if ((object.ReferenceEquals(this.NazevField, value) != true)) {
                    this.NazevField = value;
                    this.RaisePropertyChanged("Nazev");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceAuto.IServiceAuto")]
    public interface IServiceAuto {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceAuto/GetAuto", ReplyAction="http://tempuri.org/IServiceAuto/GetAutoResponse")]
        WebApiTest.ServiceAuto.AutoResult GetAuto();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceAuto/GetAuto", ReplyAction="http://tempuri.org/IServiceAuto/GetAutoResponse")]
        System.Threading.Tasks.Task<WebApiTest.ServiceAuto.AutoResult> GetAutoAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceAuto/InsertAuto", ReplyAction="http://tempuri.org/IServiceAuto/InsertAutoResponse")]
        void InsertAuto(WebApiTest.ServiceAuto.Auto auto);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceAuto/InsertAuto", ReplyAction="http://tempuri.org/IServiceAuto/InsertAutoResponse")]
        System.Threading.Tasks.Task InsertAutoAsync(WebApiTest.ServiceAuto.Auto auto);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceAuto/UpdateAuto", ReplyAction="http://tempuri.org/IServiceAuto/UpdateAutoResponse")]
        void UpdateAuto(WebApiTest.ServiceAuto.Auto auto);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceAuto/UpdateAuto", ReplyAction="http://tempuri.org/IServiceAuto/UpdateAutoResponse")]
        System.Threading.Tasks.Task UpdateAutoAsync(WebApiTest.ServiceAuto.Auto auto);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceAuto/DeleteAuto", ReplyAction="http://tempuri.org/IServiceAuto/DeleteAutoResponse")]
        void DeleteAuto(int Id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceAuto/DeleteAuto", ReplyAction="http://tempuri.org/IServiceAuto/DeleteAutoResponse")]
        System.Threading.Tasks.Task DeleteAutoAsync(int Id);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IServiceAutoChannel : WebApiTest.ServiceAuto.IServiceAuto, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ServiceAutoClient : System.ServiceModel.ClientBase<WebApiTest.ServiceAuto.IServiceAuto>, WebApiTest.ServiceAuto.IServiceAuto {
        
        public ServiceAutoClient() {
        }
        
        public ServiceAutoClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ServiceAutoClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceAutoClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceAutoClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public WebApiTest.ServiceAuto.AutoResult GetAuto() {
            return base.Channel.GetAuto();
        }
        
        public System.Threading.Tasks.Task<WebApiTest.ServiceAuto.AutoResult> GetAutoAsync() {
            return base.Channel.GetAutoAsync();
        }
        
        public void InsertAuto(WebApiTest.ServiceAuto.Auto auto) {
            base.Channel.InsertAuto(auto);
        }
        
        public System.Threading.Tasks.Task InsertAutoAsync(WebApiTest.ServiceAuto.Auto auto) {
            return base.Channel.InsertAutoAsync(auto);
        }
        
        public void UpdateAuto(WebApiTest.ServiceAuto.Auto auto) {
            base.Channel.UpdateAuto(auto);
        }
        
        public System.Threading.Tasks.Task UpdateAutoAsync(WebApiTest.ServiceAuto.Auto auto) {
            return base.Channel.UpdateAutoAsync(auto);
        }
        
        public void DeleteAuto(int Id) {
            base.Channel.DeleteAuto(Id);
        }
        
        public System.Threading.Tasks.Task DeleteAutoAsync(int Id) {
            return base.Channel.DeleteAutoAsync(Id);
        }
    }
}
