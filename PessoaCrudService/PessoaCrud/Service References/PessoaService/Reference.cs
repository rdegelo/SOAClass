﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18444
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PessoaCrud.PessoaService {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Pessoa", Namespace="http://tempuri.org/")]
    [System.SerializableAttribute()]
    public partial class Pessoa : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        private int ChaveField;
        
        private int IdadeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NomeField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public int Chave {
            get {
                return this.ChaveField;
            }
            set {
                if ((this.ChaveField.Equals(value) != true)) {
                    this.ChaveField = value;
                    this.RaisePropertyChanged("Chave");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public int Idade {
            get {
                return this.IdadeField;
            }
            set {
                if ((this.IdadeField.Equals(value) != true)) {
                    this.IdadeField = value;
                    this.RaisePropertyChanged("Idade");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false)]
        public string Nome {
            get {
                return this.NomeField;
            }
            set {
                if ((object.ReferenceEquals(this.NomeField, value) != true)) {
                    this.NomeField = value;
                    this.RaisePropertyChanged("Nome");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="PessoaService.Service1Soap")]
    public interface Service1Soap {
        
        // CODEGEN: Generating message contract since element name pessoa from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Inserir", ReplyAction="*")]
        PessoaCrud.PessoaService.InserirResponse Inserir(PessoaCrud.PessoaService.InserirRequest request);
        
        // CODEGEN: Generating message contract since element name GetPessoaByKeyResult from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetPessoaByKey", ReplyAction="*")]
        PessoaCrud.PessoaService.GetPessoaByKeyResponse GetPessoaByKey(PessoaCrud.PessoaService.GetPessoaByKeyRequest request);
        
        // CODEGEN: Generating message contract since element name GetAllPessoasResult from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetAllPessoas", ReplyAction="*")]
        PessoaCrud.PessoaService.GetAllPessoasResponse GetAllPessoas(PessoaCrud.PessoaService.GetAllPessoasRequest request);
        
        // CODEGEN: Generating message contract since element name pessoa from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/RemovePessoa", ReplyAction="*")]
        PessoaCrud.PessoaService.RemovePessoaResponse RemovePessoa(PessoaCrud.PessoaService.RemovePessoaRequest request);
        
        // CODEGEN: Generating message contract since element name pessoa from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/EditPessoa", ReplyAction="*")]
        PessoaCrud.PessoaService.EditPessoaResponse EditPessoa(PessoaCrud.PessoaService.EditPessoaRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class InserirRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="Inserir", Namespace="http://tempuri.org/", Order=0)]
        public PessoaCrud.PessoaService.InserirRequestBody Body;
        
        public InserirRequest() {
        }
        
        public InserirRequest(PessoaCrud.PessoaService.InserirRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class InserirRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public PessoaCrud.PessoaService.Pessoa pessoa;
        
        public InserirRequestBody() {
        }
        
        public InserirRequestBody(PessoaCrud.PessoaService.Pessoa pessoa) {
            this.pessoa = pessoa;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class InserirResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="InserirResponse", Namespace="http://tempuri.org/", Order=0)]
        public PessoaCrud.PessoaService.InserirResponseBody Body;
        
        public InserirResponse() {
        }
        
        public InserirResponse(PessoaCrud.PessoaService.InserirResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute()]
    public partial class InserirResponseBody {
        
        public InserirResponseBody() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetPessoaByKeyRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetPessoaByKey", Namespace="http://tempuri.org/", Order=0)]
        public PessoaCrud.PessoaService.GetPessoaByKeyRequestBody Body;
        
        public GetPessoaByKeyRequest() {
        }
        
        public GetPessoaByKeyRequest(PessoaCrud.PessoaService.GetPessoaByKeyRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class GetPessoaByKeyRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=0)]
        public int Key;
        
        public GetPessoaByKeyRequestBody() {
        }
        
        public GetPessoaByKeyRequestBody(int Key) {
            this.Key = Key;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetPessoaByKeyResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetPessoaByKeyResponse", Namespace="http://tempuri.org/", Order=0)]
        public PessoaCrud.PessoaService.GetPessoaByKeyResponseBody Body;
        
        public GetPessoaByKeyResponse() {
        }
        
        public GetPessoaByKeyResponse(PessoaCrud.PessoaService.GetPessoaByKeyResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class GetPessoaByKeyResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public PessoaCrud.PessoaService.Pessoa GetPessoaByKeyResult;
        
        public GetPessoaByKeyResponseBody() {
        }
        
        public GetPessoaByKeyResponseBody(PessoaCrud.PessoaService.Pessoa GetPessoaByKeyResult) {
            this.GetPessoaByKeyResult = GetPessoaByKeyResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetAllPessoasRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetAllPessoas", Namespace="http://tempuri.org/", Order=0)]
        public PessoaCrud.PessoaService.GetAllPessoasRequestBody Body;
        
        public GetAllPessoasRequest() {
        }
        
        public GetAllPessoasRequest(PessoaCrud.PessoaService.GetAllPessoasRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute()]
    public partial class GetAllPessoasRequestBody {
        
        public GetAllPessoasRequestBody() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetAllPessoasResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetAllPessoasResponse", Namespace="http://tempuri.org/", Order=0)]
        public PessoaCrud.PessoaService.GetAllPessoasResponseBody Body;
        
        public GetAllPessoasResponse() {
        }
        
        public GetAllPessoasResponse(PessoaCrud.PessoaService.GetAllPessoasResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class GetAllPessoasResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public PessoaCrud.PessoaService.Pessoa[] GetAllPessoasResult;
        
        public GetAllPessoasResponseBody() {
        }
        
        public GetAllPessoasResponseBody(PessoaCrud.PessoaService.Pessoa[] GetAllPessoasResult) {
            this.GetAllPessoasResult = GetAllPessoasResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class RemovePessoaRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="RemovePessoa", Namespace="http://tempuri.org/", Order=0)]
        public PessoaCrud.PessoaService.RemovePessoaRequestBody Body;
        
        public RemovePessoaRequest() {
        }
        
        public RemovePessoaRequest(PessoaCrud.PessoaService.RemovePessoaRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class RemovePessoaRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public PessoaCrud.PessoaService.Pessoa pessoa;
        
        public RemovePessoaRequestBody() {
        }
        
        public RemovePessoaRequestBody(PessoaCrud.PessoaService.Pessoa pessoa) {
            this.pessoa = pessoa;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class RemovePessoaResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="RemovePessoaResponse", Namespace="http://tempuri.org/", Order=0)]
        public PessoaCrud.PessoaService.RemovePessoaResponseBody Body;
        
        public RemovePessoaResponse() {
        }
        
        public RemovePessoaResponse(PessoaCrud.PessoaService.RemovePessoaResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute()]
    public partial class RemovePessoaResponseBody {
        
        public RemovePessoaResponseBody() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class EditPessoaRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="EditPessoa", Namespace="http://tempuri.org/", Order=0)]
        public PessoaCrud.PessoaService.EditPessoaRequestBody Body;
        
        public EditPessoaRequest() {
        }
        
        public EditPessoaRequest(PessoaCrud.PessoaService.EditPessoaRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class EditPessoaRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public PessoaCrud.PessoaService.Pessoa pessoa;
        
        public EditPessoaRequestBody() {
        }
        
        public EditPessoaRequestBody(PessoaCrud.PessoaService.Pessoa pessoa) {
            this.pessoa = pessoa;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class EditPessoaResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="EditPessoaResponse", Namespace="http://tempuri.org/", Order=0)]
        public PessoaCrud.PessoaService.EditPessoaResponseBody Body;
        
        public EditPessoaResponse() {
        }
        
        public EditPessoaResponse(PessoaCrud.PessoaService.EditPessoaResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute()]
    public partial class EditPessoaResponseBody {
        
        public EditPessoaResponseBody() {
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface Service1SoapChannel : PessoaCrud.PessoaService.Service1Soap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class Service1SoapClient : System.ServiceModel.ClientBase<PessoaCrud.PessoaService.Service1Soap>, PessoaCrud.PessoaService.Service1Soap {
        
        public Service1SoapClient() {
        }
        
        public Service1SoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public Service1SoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1SoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1SoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        PessoaCrud.PessoaService.InserirResponse PessoaCrud.PessoaService.Service1Soap.Inserir(PessoaCrud.PessoaService.InserirRequest request) {
            return base.Channel.Inserir(request);
        }
        
        public void Inserir(PessoaCrud.PessoaService.Pessoa pessoa) {
            PessoaCrud.PessoaService.InserirRequest inValue = new PessoaCrud.PessoaService.InserirRequest();
            inValue.Body = new PessoaCrud.PessoaService.InserirRequestBody();
            inValue.Body.pessoa = pessoa;
            PessoaCrud.PessoaService.InserirResponse retVal = ((PessoaCrud.PessoaService.Service1Soap)(this)).Inserir(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        PessoaCrud.PessoaService.GetPessoaByKeyResponse PessoaCrud.PessoaService.Service1Soap.GetPessoaByKey(PessoaCrud.PessoaService.GetPessoaByKeyRequest request) {
            return base.Channel.GetPessoaByKey(request);
        }
        
        public PessoaCrud.PessoaService.Pessoa GetPessoaByKey(int Key) {
            PessoaCrud.PessoaService.GetPessoaByKeyRequest inValue = new PessoaCrud.PessoaService.GetPessoaByKeyRequest();
            inValue.Body = new PessoaCrud.PessoaService.GetPessoaByKeyRequestBody();
            inValue.Body.Key = Key;
            PessoaCrud.PessoaService.GetPessoaByKeyResponse retVal = ((PessoaCrud.PessoaService.Service1Soap)(this)).GetPessoaByKey(inValue);
            return retVal.Body.GetPessoaByKeyResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        PessoaCrud.PessoaService.GetAllPessoasResponse PessoaCrud.PessoaService.Service1Soap.GetAllPessoas(PessoaCrud.PessoaService.GetAllPessoasRequest request) {
            return base.Channel.GetAllPessoas(request);
        }
        
        public PessoaCrud.PessoaService.Pessoa[] GetAllPessoas() {
            PessoaCrud.PessoaService.GetAllPessoasRequest inValue = new PessoaCrud.PessoaService.GetAllPessoasRequest();
            inValue.Body = new PessoaCrud.PessoaService.GetAllPessoasRequestBody();
            PessoaCrud.PessoaService.GetAllPessoasResponse retVal = ((PessoaCrud.PessoaService.Service1Soap)(this)).GetAllPessoas(inValue);
            return retVal.Body.GetAllPessoasResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        PessoaCrud.PessoaService.RemovePessoaResponse PessoaCrud.PessoaService.Service1Soap.RemovePessoa(PessoaCrud.PessoaService.RemovePessoaRequest request) {
            return base.Channel.RemovePessoa(request);
        }
        
        public void RemovePessoa(PessoaCrud.PessoaService.Pessoa pessoa) {
            PessoaCrud.PessoaService.RemovePessoaRequest inValue = new PessoaCrud.PessoaService.RemovePessoaRequest();
            inValue.Body = new PessoaCrud.PessoaService.RemovePessoaRequestBody();
            inValue.Body.pessoa = pessoa;
            PessoaCrud.PessoaService.RemovePessoaResponse retVal = ((PessoaCrud.PessoaService.Service1Soap)(this)).RemovePessoa(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        PessoaCrud.PessoaService.EditPessoaResponse PessoaCrud.PessoaService.Service1Soap.EditPessoa(PessoaCrud.PessoaService.EditPessoaRequest request) {
            return base.Channel.EditPessoa(request);
        }
        
        public void EditPessoa(PessoaCrud.PessoaService.Pessoa pessoa) {
            PessoaCrud.PessoaService.EditPessoaRequest inValue = new PessoaCrud.PessoaService.EditPessoaRequest();
            inValue.Body = new PessoaCrud.PessoaService.EditPessoaRequestBody();
            inValue.Body.pessoa = pessoa;
            PessoaCrud.PessoaService.EditPessoaResponse retVal = ((PessoaCrud.PessoaService.Service1Soap)(this)).EditPessoa(inValue);
        }
    }
}