﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebSegurosABC.ServicioSegurosABC {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Clientes", Namespace="http://schemas.datacontract.org/2004/07/ServicioSegurosABC")]
    [System.SerializableAttribute()]
    public partial class Clientes : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string cedulaField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string fechaField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private float montoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string nombreField;
        
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
        public string cedula {
            get {
                return this.cedulaField;
            }
            set {
                if ((object.ReferenceEquals(this.cedulaField, value) != true)) {
                    this.cedulaField = value;
                    this.RaisePropertyChanged("cedula");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string fecha {
            get {
                return this.fechaField;
            }
            set {
                if ((object.ReferenceEquals(this.fechaField, value) != true)) {
                    this.fechaField = value;
                    this.RaisePropertyChanged("fecha");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public float monto {
            get {
                return this.montoField;
            }
            set {
                if ((this.montoField.Equals(value) != true)) {
                    this.montoField = value;
                    this.RaisePropertyChanged("monto");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string nombre {
            get {
                return this.nombreField;
            }
            set {
                if ((object.ReferenceEquals(this.nombreField, value) != true)) {
                    this.nombreField = value;
                    this.RaisePropertyChanged("nombre");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServicioSegurosABC.IServicioSegurosABC")]
    public interface IServicioSegurosABC {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioSegurosABC/ConsultarPagoClientes", ReplyAction="http://tempuri.org/IServicioSegurosABC/ConsultarPagoClientesResponse")]
        WebSegurosABC.ServicioSegurosABC.Clientes[] ConsultarPagoClientes(string cedula);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioSegurosABC/ConsultarPagoClientes", ReplyAction="http://tempuri.org/IServicioSegurosABC/ConsultarPagoClientesResponse")]
        System.Threading.Tasks.Task<WebSegurosABC.ServicioSegurosABC.Clientes[]> ConsultarPagoClientesAsync(string cedula);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IServicioSegurosABCChannel : WebSegurosABC.ServicioSegurosABC.IServicioSegurosABC, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ServicioSegurosABCClient : System.ServiceModel.ClientBase<WebSegurosABC.ServicioSegurosABC.IServicioSegurosABC>, WebSegurosABC.ServicioSegurosABC.IServicioSegurosABC {
        
        public ServicioSegurosABCClient() {
        }
        
        public ServicioSegurosABCClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ServicioSegurosABCClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServicioSegurosABCClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServicioSegurosABCClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public WebSegurosABC.ServicioSegurosABC.Clientes[] ConsultarPagoClientes(string cedula) {
            return base.Channel.ConsultarPagoClientes(cedula);
        }
        
        public System.Threading.Tasks.Task<WebSegurosABC.ServicioSegurosABC.Clientes[]> ConsultarPagoClientesAsync(string cedula) {
            return base.Channel.ConsultarPagoClientesAsync(cedula);
        }
    }
}
