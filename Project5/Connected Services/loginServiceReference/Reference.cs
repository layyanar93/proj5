﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Project5.loginServiceReference {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="loginServiceReference.IService1")]
    public interface IService1 {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/createUser", ReplyAction="http://tempuri.org/IService1/createUserResponse")]
        string createUser(string username, string password);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/createUser", ReplyAction="http://tempuri.org/IService1/createUserResponse")]
        System.Threading.Tasks.Task<string> createUserAsync(string username, string password);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/userLogin", ReplyAction="http://tempuri.org/IService1/userLoginResponse")]
        string userLogin(string username, string password);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/userLogin", ReplyAction="http://tempuri.org/IService1/userLoginResponse")]
        System.Threading.Tasks.Task<string> userLoginAsync(string username, string password);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/AuthUser", ReplyAction="http://tempuri.org/IService1/AuthUserResponse")]
        string AuthUser(string authString);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/AuthUser", ReplyAction="http://tempuri.org/IService1/AuthUserResponse")]
        System.Threading.Tasks.Task<string> AuthUserAsync(string authString);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IService1Channel : Project5.loginServiceReference.IService1, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class Service1Client : System.ServiceModel.ClientBase<Project5.loginServiceReference.IService1>, Project5.loginServiceReference.IService1 {
        
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
        
        public string createUser(string username, string password) {
            return base.Channel.createUser(username, password);
        }
        
        public System.Threading.Tasks.Task<string> createUserAsync(string username, string password) {
            return base.Channel.createUserAsync(username, password);
        }
        
        public string userLogin(string username, string password) {
            return base.Channel.userLogin(username, password);
        }
        
        public System.Threading.Tasks.Task<string> userLoginAsync(string username, string password) {
            return base.Channel.userLoginAsync(username, password);
        }
        
        public string AuthUser(string authString) {
            return base.Channel.AuthUser(authString);
        }
        
        public System.Threading.Tasks.Task<string> AuthUserAsync(string authString) {
            return base.Channel.AuthUserAsync(authString);
        }
    }
}
