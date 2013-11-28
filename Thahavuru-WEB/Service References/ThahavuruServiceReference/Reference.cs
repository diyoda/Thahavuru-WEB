﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18051
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Thahavuru_WEB.ThahavuruServiceReference {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="InputImage", Namespace="http://schemas.datacontract.org/2004/07/Thahavuru_Service")]
    [System.SerializableAttribute()]
    public partial class InputImage : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string IDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private byte[][] ProbeField;
        
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
        public string ID {
            get {
                return this.IDField;
            }
            set {
                if ((object.ReferenceEquals(this.IDField, value) != true)) {
                    this.IDField = value;
                    this.RaisePropertyChanged("ID");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public byte[][] Probe {
            get {
                return this.ProbeField;
            }
            set {
                if ((object.ReferenceEquals(this.ProbeField, value) != true)) {
                    this.ProbeField = value;
                    this.RaisePropertyChanged("Probe");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="InputImagesList", Namespace="http://schemas.datacontract.org/2004/07/Thahavuru_Service")]
    [System.SerializableAttribute()]
    public partial class InputImagesList : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private Thahavuru_WEB.ThahavuruServiceReference.InputImage[] ProbeField;
        
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
        public Thahavuru_WEB.ThahavuruServiceReference.InputImage[] Probe {
            get {
                return this.ProbeField;
            }
            set {
                if ((object.ReferenceEquals(this.ProbeField, value) != true)) {
                    this.ProbeField = value;
                    this.RaisePropertyChanged("Probe");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ThahavuruServiceReference.IThahavuruFaceRecognitionService")]
    public interface IThahavuruFaceRecognitionService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IThahavuruFaceRecognitionService/GetMatches", ReplyAction="http://tempuri.org/IThahavuruFaceRecognitionService/GetMatchesResponse")]
        Thahavuru_WEB.ThahavuruServiceReference.InputImagesList GetMatches(Thahavuru_WEB.ThahavuruServiceReference.InputImage probeInfo);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IThahavuruFaceRecognitionService/GetMatches", ReplyAction="http://tempuri.org/IThahavuruFaceRecognitionService/GetMatchesResponse")]
        System.Threading.Tasks.Task<Thahavuru_WEB.ThahavuruServiceReference.InputImagesList> GetMatchesAsync(Thahavuru_WEB.ThahavuruServiceReference.InputImage probeInfo);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IThahavuruFaceRecognitionService/UploadFile", ReplyAction="http://tempuri.org/IThahavuruFaceRecognitionService/UploadFileResponse")]
        string UploadFile(byte[] f, string fileName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IThahavuruFaceRecognitionService/UploadFile", ReplyAction="http://tempuri.org/IThahavuruFaceRecognitionService/UploadFileResponse")]
        System.Threading.Tasks.Task<string> UploadFileAsync(byte[] f, string fileName);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IThahavuruFaceRecognitionServiceChannel : Thahavuru_WEB.ThahavuruServiceReference.IThahavuruFaceRecognitionService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ThahavuruFaceRecognitionServiceClient : System.ServiceModel.ClientBase<Thahavuru_WEB.ThahavuruServiceReference.IThahavuruFaceRecognitionService>, Thahavuru_WEB.ThahavuruServiceReference.IThahavuruFaceRecognitionService {
        
        public ThahavuruFaceRecognitionServiceClient() {
        }
        
        public ThahavuruFaceRecognitionServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ThahavuruFaceRecognitionServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ThahavuruFaceRecognitionServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ThahavuruFaceRecognitionServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public Thahavuru_WEB.ThahavuruServiceReference.InputImagesList GetMatches(Thahavuru_WEB.ThahavuruServiceReference.InputImage probeInfo) {
            return base.Channel.GetMatches(probeInfo);
        }
        
        public System.Threading.Tasks.Task<Thahavuru_WEB.ThahavuruServiceReference.InputImagesList> GetMatchesAsync(Thahavuru_WEB.ThahavuruServiceReference.InputImage probeInfo) {
            return base.Channel.GetMatchesAsync(probeInfo);
        }
        
        public string UploadFile(byte[] f, string fileName) {
            return base.Channel.UploadFile(f, fileName);
        }
        
        public System.Threading.Tasks.Task<string> UploadFileAsync(byte[] f, string fileName) {
            return base.Channel.UploadFileAsync(f, fileName);
        }
    }
}