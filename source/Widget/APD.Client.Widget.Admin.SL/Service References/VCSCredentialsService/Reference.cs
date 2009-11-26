﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.4927
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// This code was auto-generated by Microsoft.Silverlight.ServiceReference, version 3.0.40624.0
// 
namespace APD.Client.Widget.Admin.SL.VCSCredentialsService {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="", ConfigurationName="VCSCredentialsService.VCSCredentialsService")]
    public interface VCSCredentialsService {
        
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="urn:VCSCredentialsService/Check", ReplyAction="urn:VCSCredentialsService/CheckResponse")]
        System.IAsyncResult BeginCheck(string provider, string url, string username, string password, System.AsyncCallback callback, object asyncState);
        
        bool EndCheck(System.IAsyncResult result);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    public interface VCSCredentialsServiceChannel : APD.Client.Widget.Admin.SL.VCSCredentialsService.VCSCredentialsService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    public partial class CheckCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        public CheckCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        public bool Result {
            get {
                base.RaiseExceptionIfNecessary();
                return ((bool)(this.results[0]));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    public partial class VCSCredentialsServiceClient : System.ServiceModel.ClientBase<APD.Client.Widget.Admin.SL.VCSCredentialsService.VCSCredentialsService>, APD.Client.Widget.Admin.SL.VCSCredentialsService.VCSCredentialsService {
        
        private BeginOperationDelegate onBeginCheckDelegate;
        
        private EndOperationDelegate onEndCheckDelegate;
        
        private System.Threading.SendOrPostCallback onCheckCompletedDelegate;
        
        private BeginOperationDelegate onBeginOpenDelegate;
        
        private EndOperationDelegate onEndOpenDelegate;
        
        private System.Threading.SendOrPostCallback onOpenCompletedDelegate;
        
        private BeginOperationDelegate onBeginCloseDelegate;
        
        private EndOperationDelegate onEndCloseDelegate;
        
        private System.Threading.SendOrPostCallback onCloseCompletedDelegate;
        
        public VCSCredentialsServiceClient() {
        }
        
        public VCSCredentialsServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public VCSCredentialsServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public VCSCredentialsServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public VCSCredentialsServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public System.Net.CookieContainer CookieContainer {
            get {
                System.ServiceModel.Channels.IHttpCookieContainerManager httpCookieContainerManager = this.InnerChannel.GetProperty<System.ServiceModel.Channels.IHttpCookieContainerManager>();
                if ((httpCookieContainerManager != null)) {
                    return httpCookieContainerManager.CookieContainer;
                }
                else {
                    return null;
                }
            }
            set {
                System.ServiceModel.Channels.IHttpCookieContainerManager httpCookieContainerManager = this.InnerChannel.GetProperty<System.ServiceModel.Channels.IHttpCookieContainerManager>();
                if ((httpCookieContainerManager != null)) {
                    httpCookieContainerManager.CookieContainer = value;
                }
                else {
                    throw new System.InvalidOperationException("Unable to set the CookieContainer. Please make sure the binding contains an HttpC" +
                            "ookieContainerBindingElement.");
                }
            }
        }
        
        public event System.EventHandler<CheckCompletedEventArgs> CheckCompleted;
        
        public event System.EventHandler<System.ComponentModel.AsyncCompletedEventArgs> OpenCompleted;
        
        public event System.EventHandler<System.ComponentModel.AsyncCompletedEventArgs> CloseCompleted;
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.IAsyncResult APD.Client.Widget.Admin.SL.VCSCredentialsService.VCSCredentialsService.BeginCheck(string provider, string url, string username, string password, System.AsyncCallback callback, object asyncState) {
            return base.Channel.BeginCheck(provider, url, username, password, callback, asyncState);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        bool APD.Client.Widget.Admin.SL.VCSCredentialsService.VCSCredentialsService.EndCheck(System.IAsyncResult result) {
            return base.Channel.EndCheck(result);
        }
        
        private System.IAsyncResult OnBeginCheck(object[] inValues, System.AsyncCallback callback, object asyncState) {
            string provider = ((string)(inValues[0]));
            string url = ((string)(inValues[1]));
            string username = ((string)(inValues[2]));
            string password = ((string)(inValues[3]));
            return ((APD.Client.Widget.Admin.SL.VCSCredentialsService.VCSCredentialsService)(this)).BeginCheck(provider, url, username, password, callback, asyncState);
        }
        
        private object[] OnEndCheck(System.IAsyncResult result) {
            bool retVal = ((APD.Client.Widget.Admin.SL.VCSCredentialsService.VCSCredentialsService)(this)).EndCheck(result);
            return new object[] {
                    retVal};
        }
        
        private void OnCheckCompleted(object state) {
            if ((this.CheckCompleted != null)) {
                InvokeAsyncCompletedEventArgs e = ((InvokeAsyncCompletedEventArgs)(state));
                this.CheckCompleted(this, new CheckCompletedEventArgs(e.Results, e.Error, e.Cancelled, e.UserState));
            }
        }
        
        public void CheckAsync(string provider, string url, string username, string password) {
            this.CheckAsync(provider, url, username, password, null);
        }
        
        public void CheckAsync(string provider, string url, string username, string password, object userState) {
            if ((this.onBeginCheckDelegate == null)) {
                this.onBeginCheckDelegate = new BeginOperationDelegate(this.OnBeginCheck);
            }
            if ((this.onEndCheckDelegate == null)) {
                this.onEndCheckDelegate = new EndOperationDelegate(this.OnEndCheck);
            }
            if ((this.onCheckCompletedDelegate == null)) {
                this.onCheckCompletedDelegate = new System.Threading.SendOrPostCallback(this.OnCheckCompleted);
            }
            base.InvokeAsync(this.onBeginCheckDelegate, new object[] {
                        provider,
                        url,
                        username,
                        password}, this.onEndCheckDelegate, this.onCheckCompletedDelegate, userState);
        }
        
        private System.IAsyncResult OnBeginOpen(object[] inValues, System.AsyncCallback callback, object asyncState) {
            return ((System.ServiceModel.ICommunicationObject)(this)).BeginOpen(callback, asyncState);
        }
        
        private object[] OnEndOpen(System.IAsyncResult result) {
            ((System.ServiceModel.ICommunicationObject)(this)).EndOpen(result);
            return null;
        }
        
        private void OnOpenCompleted(object state) {
            if ((this.OpenCompleted != null)) {
                InvokeAsyncCompletedEventArgs e = ((InvokeAsyncCompletedEventArgs)(state));
                this.OpenCompleted(this, new System.ComponentModel.AsyncCompletedEventArgs(e.Error, e.Cancelled, e.UserState));
            }
        }
        
        public void OpenAsync() {
            this.OpenAsync(null);
        }
        
        public void OpenAsync(object userState) {
            if ((this.onBeginOpenDelegate == null)) {
                this.onBeginOpenDelegate = new BeginOperationDelegate(this.OnBeginOpen);
            }
            if ((this.onEndOpenDelegate == null)) {
                this.onEndOpenDelegate = new EndOperationDelegate(this.OnEndOpen);
            }
            if ((this.onOpenCompletedDelegate == null)) {
                this.onOpenCompletedDelegate = new System.Threading.SendOrPostCallback(this.OnOpenCompleted);
            }
            base.InvokeAsync(this.onBeginOpenDelegate, null, this.onEndOpenDelegate, this.onOpenCompletedDelegate, userState);
        }
        
        private System.IAsyncResult OnBeginClose(object[] inValues, System.AsyncCallback callback, object asyncState) {
            return ((System.ServiceModel.ICommunicationObject)(this)).BeginClose(callback, asyncState);
        }
        
        private object[] OnEndClose(System.IAsyncResult result) {
            ((System.ServiceModel.ICommunicationObject)(this)).EndClose(result);
            return null;
        }
        
        private void OnCloseCompleted(object state) {
            if ((this.CloseCompleted != null)) {
                InvokeAsyncCompletedEventArgs e = ((InvokeAsyncCompletedEventArgs)(state));
                this.CloseCompleted(this, new System.ComponentModel.AsyncCompletedEventArgs(e.Error, e.Cancelled, e.UserState));
            }
        }
        
        public void CloseAsync() {
            this.CloseAsync(null);
        }
        
        public void CloseAsync(object userState) {
            if ((this.onBeginCloseDelegate == null)) {
                this.onBeginCloseDelegate = new BeginOperationDelegate(this.OnBeginClose);
            }
            if ((this.onEndCloseDelegate == null)) {
                this.onEndCloseDelegate = new EndOperationDelegate(this.OnEndClose);
            }
            if ((this.onCloseCompletedDelegate == null)) {
                this.onCloseCompletedDelegate = new System.Threading.SendOrPostCallback(this.OnCloseCompleted);
            }
            base.InvokeAsync(this.onBeginCloseDelegate, null, this.onEndCloseDelegate, this.onCloseCompletedDelegate, userState);
        }
        
        protected override APD.Client.Widget.Admin.SL.VCSCredentialsService.VCSCredentialsService CreateChannel() {
            return new VCSCredentialsServiceClientChannel(this);
        }
        
        private class VCSCredentialsServiceClientChannel : ChannelBase<APD.Client.Widget.Admin.SL.VCSCredentialsService.VCSCredentialsService>, APD.Client.Widget.Admin.SL.VCSCredentialsService.VCSCredentialsService {
            
            public VCSCredentialsServiceClientChannel(System.ServiceModel.ClientBase<APD.Client.Widget.Admin.SL.VCSCredentialsService.VCSCredentialsService> client) : 
                    base(client) {
            }
            
            public System.IAsyncResult BeginCheck(string provider, string url, string username, string password, System.AsyncCallback callback, object asyncState) {
                object[] _args = new object[4];
                _args[0] = provider;
                _args[1] = url;
                _args[2] = username;
                _args[3] = password;
                System.IAsyncResult _result = base.BeginInvoke("Check", _args, callback, asyncState);
                return _result;
            }
            
            public bool EndCheck(System.IAsyncResult result) {
                object[] _args = new object[0];
                bool _result = ((bool)(base.EndInvoke("Check", _args, result)));
                return _result;
            }
        }
    }
}
