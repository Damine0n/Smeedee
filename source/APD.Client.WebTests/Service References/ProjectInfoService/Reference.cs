﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.1
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace APD.Client.WebTests.ProjectInfoService {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://agileprojectdashboard.org", ConfigurationName="ProjectInfoService.ProjectInfoRepositoryService")]
    public interface ProjectInfoRepositoryService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://agileprojectdashboard.org/ProjectInfoRepositoryService/Get", ReplyAction="http://agileprojectdashboard.org/ProjectInfoRepositoryService/GetResponse")]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(APD.DomainModel.Framework.AllSpecification<APD.DomainModel.ProjectInfo.ProjectInfoServer>))]
        System.Collections.Generic.List<APD.DomainModel.ProjectInfo.ProjectInfoServer> Get(APD.DomainModel.Framework.Specification<APD.DomainModel.ProjectInfo.ProjectInfoServer> specification);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ProjectInfoRepositoryServiceChannel : APD.Client.WebTests.ProjectInfoService.ProjectInfoRepositoryService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ProjectInfoRepositoryServiceClient : System.ServiceModel.ClientBase<APD.Client.WebTests.ProjectInfoService.ProjectInfoRepositoryService>, APD.Client.WebTests.ProjectInfoService.ProjectInfoRepositoryService {
        
        public ProjectInfoRepositoryServiceClient() {
        }
        
        public ProjectInfoRepositoryServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ProjectInfoRepositoryServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ProjectInfoRepositoryServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ProjectInfoRepositoryServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public System.Collections.Generic.List<APD.DomainModel.ProjectInfo.ProjectInfoServer> Get(APD.DomainModel.Framework.Specification<APD.DomainModel.ProjectInfo.ProjectInfoServer> specification) {
            return base.Channel.Get(specification);
        }
    }
}
