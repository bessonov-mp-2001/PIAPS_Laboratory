//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CLIENT.ServiceReference1 {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.WebService1Soap")]
    public interface WebService1Soap {
        
        // CODEGEN: Контракт генерации сообщений с именем ShowMarshrutResult из пространства имен http://tempuri.org/ не отмечен как обнуляемый
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ShowMarshrut", ReplyAction="*")]
        CLIENT.ServiceReference1.ShowMarshrutResponse ShowMarshrut(CLIENT.ServiceReference1.ShowMarshrutRequest request);
        string ShowMarshrut();
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ShowMarshrut", ReplyAction="*")]
        System.Threading.Tasks.Task<CLIENT.ServiceReference1.ShowMarshrutResponse> ShowMarshrutAsync(CLIENT.ServiceReference1.ShowMarshrutRequest request);
        
        // CODEGEN: Контракт генерации сообщений с именем Reis из пространства имен http://tempuri.org/ не отмечен как обнуляемый
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/CheckReis", ReplyAction="*")]
        CLIENT.ServiceReference1.CheckReisResponse CheckReis(CLIENT.ServiceReference1.CheckReisRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/CheckReis", ReplyAction="*")]
        System.Threading.Tasks.Task<CLIENT.ServiceReference1.CheckReisResponse> CheckReisAsync(CLIENT.ServiceReference1.CheckReisRequest request);
        
        // CODEGEN: Контракт генерации сообщений с именем Reis из пространства имен http://tempuri.org/ не отмечен как обнуляемый
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Checkbilet", ReplyAction="*")]
        CLIENT.ServiceReference1.CheckbiletResponse Checkbilet(CLIENT.ServiceReference1.CheckbiletRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Checkbilet", ReplyAction="*")]
        System.Threading.Tasks.Task<CLIENT.ServiceReference1.CheckbiletResponse> CheckbiletAsync(CLIENT.ServiceReference1.CheckbiletRequest request);
        
        // CODEGEN: Контракт генерации сообщений с именем id из пространства имен http://tempuri.org/ не отмечен как обнуляемый
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Zakazbilet", ReplyAction="*")]
        CLIENT.ServiceReference1.ZakazbiletResponse Zakazbilet(CLIENT.ServiceReference1.ZakazbiletRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Zakazbilet", ReplyAction="*")]
        System.Threading.Tasks.Task<CLIENT.ServiceReference1.ZakazbiletResponse> ZakazbiletAsync(CLIENT.ServiceReference1.ZakazbiletRequest request);
        string Checkbilet(string pole);
        string CheckReis(string pole);
        string Zakazbilet(string pole);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class ShowMarshrutRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="ShowMarshrut", Namespace="http://tempuri.org/", Order=0)]
        public CLIENT.ServiceReference1.ShowMarshrutRequestBody Body;
        
        public ShowMarshrutRequest() {
        }
        
        public ShowMarshrutRequest(CLIENT.ServiceReference1.ShowMarshrutRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute()]
    public partial class ShowMarshrutRequestBody {
        
        public ShowMarshrutRequestBody() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class ShowMarshrutResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="ShowMarshrutResponse", Namespace="http://tempuri.org/", Order=0)]
        public CLIENT.ServiceReference1.ShowMarshrutResponseBody Body;
        
        public ShowMarshrutResponse() {
        }
        
        public ShowMarshrutResponse(CLIENT.ServiceReference1.ShowMarshrutResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class ShowMarshrutResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string ShowMarshrutResult;
        
        public ShowMarshrutResponseBody() {
        }
        
        public ShowMarshrutResponseBody(string ShowMarshrutResult) {
            this.ShowMarshrutResult = ShowMarshrutResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class CheckReisRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="CheckReis", Namespace="http://tempuri.org/", Order=0)]
        public CLIENT.ServiceReference1.CheckReisRequestBody Body;
        
        public CheckReisRequest() {
        }
        
        public CheckReisRequest(CLIENT.ServiceReference1.CheckReisRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class CheckReisRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string Reis;
        
        public CheckReisRequestBody() {
        }
        
        public CheckReisRequestBody(string Reis) {
            this.Reis = Reis;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class CheckReisResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="CheckReisResponse", Namespace="http://tempuri.org/", Order=0)]
        public CLIENT.ServiceReference1.CheckReisResponseBody Body;
        
        public CheckReisResponse() {
        }
        
        public CheckReisResponse(CLIENT.ServiceReference1.CheckReisResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class CheckReisResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string CheckReisResult;
        
        public CheckReisResponseBody() {
        }
        
        public CheckReisResponseBody(string CheckReisResult) {
            this.CheckReisResult = CheckReisResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class CheckbiletRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="Checkbilet", Namespace="http://tempuri.org/", Order=0)]
        public CLIENT.ServiceReference1.CheckbiletRequestBody Body;
        
        public CheckbiletRequest() {
        }
        
        public CheckbiletRequest(CLIENT.ServiceReference1.CheckbiletRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class CheckbiletRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string Reis;
        
        public CheckbiletRequestBody() {
        }
        
        public CheckbiletRequestBody(string Reis) {
            this.Reis = Reis;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class CheckbiletResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="CheckbiletResponse", Namespace="http://tempuri.org/", Order=0)]
        public CLIENT.ServiceReference1.CheckbiletResponseBody Body;
        
        public CheckbiletResponse() {
        }
        
        public CheckbiletResponse(CLIENT.ServiceReference1.CheckbiletResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class CheckbiletResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string CheckbiletResult;
        
        public CheckbiletResponseBody() {
        }
        
        public CheckbiletResponseBody(string CheckbiletResult) {
            this.CheckbiletResult = CheckbiletResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class ZakazbiletRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="Zakazbilet", Namespace="http://tempuri.org/", Order=0)]
        public CLIENT.ServiceReference1.ZakazbiletRequestBody Body;
        
        public ZakazbiletRequest() {
        }
        
        public ZakazbiletRequest(CLIENT.ServiceReference1.ZakazbiletRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class ZakazbiletRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string id;
        
        public ZakazbiletRequestBody() {
        }
        
        public ZakazbiletRequestBody(string id) {
            this.id = id;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class ZakazbiletResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="ZakazbiletResponse", Namespace="http://tempuri.org/", Order=0)]
        public CLIENT.ServiceReference1.ZakazbiletResponseBody Body;
        
        public ZakazbiletResponse() {
        }
        
        public ZakazbiletResponse(CLIENT.ServiceReference1.ZakazbiletResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class ZakazbiletResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string ZakazbiletResult;
        
        public ZakazbiletResponseBody() {
        }
        
        public ZakazbiletResponseBody(string ZakazbiletResult) {
            this.ZakazbiletResult = ZakazbiletResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface WebService1SoapChannel : CLIENT.ServiceReference1.WebService1Soap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class WebService1SoapClient : System.ServiceModel.ClientBase<CLIENT.ServiceReference1.WebService1Soap>, CLIENT.ServiceReference1.WebService1Soap {
        
        public WebService1SoapClient() {
        }
        
        public WebService1SoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public WebService1SoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WebService1SoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WebService1SoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        CLIENT.ServiceReference1.ShowMarshrutResponse CLIENT.ServiceReference1.WebService1Soap.ShowMarshrut(CLIENT.ServiceReference1.ShowMarshrutRequest request) {
            return base.Channel.ShowMarshrut(request);
        }
        
        public string ShowMarshrut() {
            CLIENT.ServiceReference1.ShowMarshrutRequest inValue = new CLIENT.ServiceReference1.ShowMarshrutRequest();
            inValue.Body = new CLIENT.ServiceReference1.ShowMarshrutRequestBody();
            CLIENT.ServiceReference1.ShowMarshrutResponse retVal = ((CLIENT.ServiceReference1.WebService1Soap)(this)).ShowMarshrut(inValue);
            return retVal.Body.ShowMarshrutResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<CLIENT.ServiceReference1.ShowMarshrutResponse> CLIENT.ServiceReference1.WebService1Soap.ShowMarshrutAsync(CLIENT.ServiceReference1.ShowMarshrutRequest request) {
            return base.Channel.ShowMarshrutAsync(request);
        }
        
        public System.Threading.Tasks.Task<CLIENT.ServiceReference1.ShowMarshrutResponse> ShowMarshrutAsync() {
            CLIENT.ServiceReference1.ShowMarshrutRequest inValue = new CLIENT.ServiceReference1.ShowMarshrutRequest();
            inValue.Body = new CLIENT.ServiceReference1.ShowMarshrutRequestBody();
            return ((CLIENT.ServiceReference1.WebService1Soap)(this)).ShowMarshrutAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        CLIENT.ServiceReference1.CheckReisResponse CLIENT.ServiceReference1.WebService1Soap.CheckReis(CLIENT.ServiceReference1.CheckReisRequest request) {
            return base.Channel.CheckReis(request);
        }
        
        public string CheckReis(string Reis) {
            CLIENT.ServiceReference1.CheckReisRequest inValue = new CLIENT.ServiceReference1.CheckReisRequest();
            inValue.Body = new CLIENT.ServiceReference1.CheckReisRequestBody();
            inValue.Body.Reis = Reis;
            CLIENT.ServiceReference1.CheckReisResponse retVal = ((CLIENT.ServiceReference1.WebService1Soap)(this)).CheckReis(inValue);
            return retVal.Body.CheckReisResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<CLIENT.ServiceReference1.CheckReisResponse> CLIENT.ServiceReference1.WebService1Soap.CheckReisAsync(CLIENT.ServiceReference1.CheckReisRequest request) {
            return base.Channel.CheckReisAsync(request);
        }
        
        public System.Threading.Tasks.Task<CLIENT.ServiceReference1.CheckReisResponse> CheckReisAsync(string Reis) {
            CLIENT.ServiceReference1.CheckReisRequest inValue = new CLIENT.ServiceReference1.CheckReisRequest();
            inValue.Body = new CLIENT.ServiceReference1.CheckReisRequestBody();
            inValue.Body.Reis = Reis;
            return ((CLIENT.ServiceReference1.WebService1Soap)(this)).CheckReisAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        CLIENT.ServiceReference1.CheckbiletResponse CLIENT.ServiceReference1.WebService1Soap.Checkbilet(CLIENT.ServiceReference1.CheckbiletRequest request) {
            return base.Channel.Checkbilet(request);
        }
        
        public string Checkbilet(string Reis) {
            CLIENT.ServiceReference1.CheckbiletRequest inValue = new CLIENT.ServiceReference1.CheckbiletRequest();
            inValue.Body = new CLIENT.ServiceReference1.CheckbiletRequestBody();
            inValue.Body.Reis = Reis;
            CLIENT.ServiceReference1.CheckbiletResponse retVal = ((CLIENT.ServiceReference1.WebService1Soap)(this)).Checkbilet(inValue);
            return retVal.Body.CheckbiletResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<CLIENT.ServiceReference1.CheckbiletResponse> CLIENT.ServiceReference1.WebService1Soap.CheckbiletAsync(CLIENT.ServiceReference1.CheckbiletRequest request) {
            return base.Channel.CheckbiletAsync(request);
        }
        
        public System.Threading.Tasks.Task<CLIENT.ServiceReference1.CheckbiletResponse> CheckbiletAsync(string Reis) {
            CLIENT.ServiceReference1.CheckbiletRequest inValue = new CLIENT.ServiceReference1.CheckbiletRequest();
            inValue.Body = new CLIENT.ServiceReference1.CheckbiletRequestBody();
            inValue.Body.Reis = Reis;
            return ((CLIENT.ServiceReference1.WebService1Soap)(this)).CheckbiletAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        CLIENT.ServiceReference1.ZakazbiletResponse CLIENT.ServiceReference1.WebService1Soap.Zakazbilet(CLIENT.ServiceReference1.ZakazbiletRequest request) {
            return base.Channel.Zakazbilet(request);
        }
        
        public string Zakazbilet(string id) {
            CLIENT.ServiceReference1.ZakazbiletRequest inValue = new CLIENT.ServiceReference1.ZakazbiletRequest();
            inValue.Body = new CLIENT.ServiceReference1.ZakazbiletRequestBody();
            inValue.Body.id = id;
            CLIENT.ServiceReference1.ZakazbiletResponse retVal = ((CLIENT.ServiceReference1.WebService1Soap)(this)).Zakazbilet(inValue);
            return retVal.Body.ZakazbiletResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<CLIENT.ServiceReference1.ZakazbiletResponse> CLIENT.ServiceReference1.WebService1Soap.ZakazbiletAsync(CLIENT.ServiceReference1.ZakazbiletRequest request) {
            return base.Channel.ZakazbiletAsync(request);
        }
        
        public System.Threading.Tasks.Task<CLIENT.ServiceReference1.ZakazbiletResponse> ZakazbiletAsync(string id) {
            CLIENT.ServiceReference1.ZakazbiletRequest inValue = new CLIENT.ServiceReference1.ZakazbiletRequest();
            inValue.Body = new CLIENT.ServiceReference1.ZakazbiletRequestBody();
            inValue.Body.id = id;
            return ((CLIENT.ServiceReference1.WebService1Soap)(this)).ZakazbiletAsync(inValue);
        }
    }
}
