﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Gallery3WinForm.ServiceReference1 {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="clsArtist", Namespace="http://schemas.datacontract.org/2004/07/SelfHost.DTO")]
    [System.SerializableAttribute()]
    public partial class clsArtist : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string PhoneField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string SpecialityField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private Gallery3WinForm.ServiceReference1.clsWork[] WorksField;
        
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
        public string Name {
            get {
                return this.NameField;
            }
            set {
                if ((object.ReferenceEquals(this.NameField, value) != true)) {
                    this.NameField = value;
                    this.RaisePropertyChanged("Name");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Phone {
            get {
                return this.PhoneField;
            }
            set {
                if ((object.ReferenceEquals(this.PhoneField, value) != true)) {
                    this.PhoneField = value;
                    this.RaisePropertyChanged("Phone");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Speciality {
            get {
                return this.SpecialityField;
            }
            set {
                if ((object.ReferenceEquals(this.SpecialityField, value) != true)) {
                    this.SpecialityField = value;
                    this.RaisePropertyChanged("Speciality");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public Gallery3WinForm.ServiceReference1.clsWork[] Works {
            get {
                return this.WorksField;
            }
            set {
                if ((object.ReferenceEquals(this.WorksField, value) != true)) {
                    this.WorksField = value;
                    this.RaisePropertyChanged("Works");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="clsWork", Namespace="http://schemas.datacontract.org/2004/07/SelfHost.DTO")]
    [System.SerializableAttribute()]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(Gallery3WinForm.ServiceReference1.clsPhotograph))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(Gallery3WinForm.ServiceReference1.clsPainting))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(Gallery3WinForm.ServiceReference1.clsSculpture))]
    public partial class clsWork : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ArtistNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime DateField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private decimal ValueField;
        
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
        public string ArtistName {
            get {
                return this.ArtistNameField;
            }
            set {
                if ((object.ReferenceEquals(this.ArtistNameField, value) != true)) {
                    this.ArtistNameField = value;
                    this.RaisePropertyChanged("ArtistName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime Date {
            get {
                return this.DateField;
            }
            set {
                if ((this.DateField.Equals(value) != true)) {
                    this.DateField = value;
                    this.RaisePropertyChanged("Date");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Name {
            get {
                return this.NameField;
            }
            set {
                if ((object.ReferenceEquals(this.NameField, value) != true)) {
                    this.NameField = value;
                    this.RaisePropertyChanged("Name");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public decimal Value {
            get {
                return this.ValueField;
            }
            set {
                if ((this.ValueField.Equals(value) != true)) {
                    this.ValueField = value;
                    this.RaisePropertyChanged("Value");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="clsPhotograph", Namespace="http://schemas.datacontract.org/2004/07/SelfHost.DTO")]
    [System.SerializableAttribute()]
    public partial class clsPhotograph : Gallery3WinForm.ServiceReference1.clsWork {
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<float> HeightField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string TypeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<float> WidthField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<float> Height {
            get {
                return this.HeightField;
            }
            set {
                if ((this.HeightField.Equals(value) != true)) {
                    this.HeightField = value;
                    this.RaisePropertyChanged("Height");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Type {
            get {
                return this.TypeField;
            }
            set {
                if ((object.ReferenceEquals(this.TypeField, value) != true)) {
                    this.TypeField = value;
                    this.RaisePropertyChanged("Type");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<float> Width {
            get {
                return this.WidthField;
            }
            set {
                if ((this.WidthField.Equals(value) != true)) {
                    this.WidthField = value;
                    this.RaisePropertyChanged("Width");
                }
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="clsPainting", Namespace="http://schemas.datacontract.org/2004/07/SelfHost.DTO")]
    [System.SerializableAttribute()]
    public partial class clsPainting : Gallery3WinForm.ServiceReference1.clsWork {
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<float> HeightField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string TypeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<float> WidthField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<float> Height {
            get {
                return this.HeightField;
            }
            set {
                if ((this.HeightField.Equals(value) != true)) {
                    this.HeightField = value;
                    this.RaisePropertyChanged("Height");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Type {
            get {
                return this.TypeField;
            }
            set {
                if ((object.ReferenceEquals(this.TypeField, value) != true)) {
                    this.TypeField = value;
                    this.RaisePropertyChanged("Type");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<float> Width {
            get {
                return this.WidthField;
            }
            set {
                if ((this.WidthField.Equals(value) != true)) {
                    this.WidthField = value;
                    this.RaisePropertyChanged("Width");
                }
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="clsSculpture", Namespace="http://schemas.datacontract.org/2004/07/SelfHost.DTO")]
    [System.SerializableAttribute()]
    public partial class clsSculpture : Gallery3WinForm.ServiceReference1.clsWork {
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string MaterialField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<float> WeightField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Material {
            get {
                return this.MaterialField;
            }
            set {
                if ((object.ReferenceEquals(this.MaterialField, value) != true)) {
                    this.MaterialField = value;
                    this.RaisePropertyChanged("Material");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<float> Weight {
            get {
                return this.WeightField;
            }
            set {
                if ((this.WeightField.Equals(value) != true)) {
                    this.WeightField = value;
                    this.RaisePropertyChanged("Weight");
                }
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.IService1")]
    public interface IService1 {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetArtistNames", ReplyAction="http://tempuri.org/IService1/GetArtistNamesResponse")]
        string[] GetArtistNames();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetArtistNames", ReplyAction="http://tempuri.org/IService1/GetArtistNamesResponse")]
        System.Threading.Tasks.Task<string[]> GetArtistNamesAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetArtist", ReplyAction="http://tempuri.org/IService1/GetArtistResponse")]
        Gallery3WinForm.ServiceReference1.clsArtist GetArtist(string prArtistName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetArtist", ReplyAction="http://tempuri.org/IService1/GetArtistResponse")]
        System.Threading.Tasks.Task<Gallery3WinForm.ServiceReference1.clsArtist> GetArtistAsync(string prArtistName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/InsertArtist", ReplyAction="http://tempuri.org/IService1/InsertArtistResponse")]
        int InsertArtist(Gallery3WinForm.ServiceReference1.clsArtist prArtist);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/InsertArtist", ReplyAction="http://tempuri.org/IService1/InsertArtistResponse")]
        System.Threading.Tasks.Task<int> InsertArtistAsync(Gallery3WinForm.ServiceReference1.clsArtist prArtist);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/UpdateArtist", ReplyAction="http://tempuri.org/IService1/UpdateArtistResponse")]
        int UpdateArtist(Gallery3WinForm.ServiceReference1.clsArtist prArtist);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/UpdateArtist", ReplyAction="http://tempuri.org/IService1/UpdateArtistResponse")]
        System.Threading.Tasks.Task<int> UpdateArtistAsync(Gallery3WinForm.ServiceReference1.clsArtist prArtist);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IService1Channel : Gallery3WinForm.ServiceReference1.IService1, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class Service1Client : System.ServiceModel.ClientBase<Gallery3WinForm.ServiceReference1.IService1>, Gallery3WinForm.ServiceReference1.IService1 {
        
        public Service1Client() {
        }
        
        public Service1Client(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public Service1Client(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1Client(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1Client(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string[] GetArtistNames() {
            return base.Channel.GetArtistNames();
        }
        
        public System.Threading.Tasks.Task<string[]> GetArtistNamesAsync() {
            return base.Channel.GetArtistNamesAsync();
        }
        
        public Gallery3WinForm.ServiceReference1.clsArtist GetArtist(string prArtistName) {
            return base.Channel.GetArtist(prArtistName);
        }
        
        public System.Threading.Tasks.Task<Gallery3WinForm.ServiceReference1.clsArtist> GetArtistAsync(string prArtistName) {
            return base.Channel.GetArtistAsync(prArtistName);
        }
        
        public int InsertArtist(Gallery3WinForm.ServiceReference1.clsArtist prArtist) {
            return base.Channel.InsertArtist(prArtist);
        }
        
        public System.Threading.Tasks.Task<int> InsertArtistAsync(Gallery3WinForm.ServiceReference1.clsArtist prArtist) {
            return base.Channel.InsertArtistAsync(prArtist);
        }
        
        public int UpdateArtist(Gallery3WinForm.ServiceReference1.clsArtist prArtist) {
            return base.Channel.UpdateArtist(prArtist);
        }
        
        public System.Threading.Tasks.Task<int> UpdateArtistAsync(Gallery3WinForm.ServiceReference1.clsArtist prArtist) {
            return base.Channel.UpdateArtistAsync(prArtist);
        }
    }
}
