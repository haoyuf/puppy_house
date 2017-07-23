﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BusinessLayer.ServiceReference {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference.IPuppyService")]
    public interface IPuppyService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPuppyService/addNewPuppy", ReplyAction="http://tempuri.org/IPuppyService/addNewPuppyResponse")]
        void addNewPuppy(DAL.Model.Puppy newPuppyInfo);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPuppyService/addNewPuppy", ReplyAction="http://tempuri.org/IPuppyService/addNewPuppyResponse")]
        System.Threading.Tasks.Task addNewPuppyAsync(DAL.Model.Puppy newPuppyInfo);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPuppyService/getPuppyByGender", ReplyAction="http://tempuri.org/IPuppyService/getPuppyByGenderResponse")]
        DAL.Model.Puppy[] getPuppyByGender(string gender);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPuppyService/getPuppyByGender", ReplyAction="http://tempuri.org/IPuppyService/getPuppyByGenderResponse")]
        System.Threading.Tasks.Task<DAL.Model.Puppy[]> getPuppyByGenderAsync(string gender);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPuppyService/getAllPuppies", ReplyAction="http://tempuri.org/IPuppyService/getAllPuppiesResponse")]
        DAL.Model.Puppy[] getAllPuppies();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPuppyService/getAllPuppies", ReplyAction="http://tempuri.org/IPuppyService/getAllPuppiesResponse")]
        System.Threading.Tasks.Task<DAL.Model.Puppy[]> getAllPuppiesAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPuppyService/updatePuppy", ReplyAction="http://tempuri.org/IPuppyService/updatePuppyResponse")]
        void updatePuppy(DAL.Model.Puppy updatedPuppy);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPuppyService/updatePuppy", ReplyAction="http://tempuri.org/IPuppyService/updatePuppyResponse")]
        System.Threading.Tasks.Task updatePuppyAsync(DAL.Model.Puppy updatedPuppy);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPuppyService/deletePuppy", ReplyAction="http://tempuri.org/IPuppyService/deletePuppyResponse")]
        void deletePuppy(int puppyId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPuppyService/deletePuppy", ReplyAction="http://tempuri.org/IPuppyService/deletePuppyResponse")]
        System.Threading.Tasks.Task deletePuppyAsync(int puppyId);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IPuppyServiceChannel : BusinessLayer.ServiceReference.IPuppyService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class PuppyServiceClient : System.ServiceModel.ClientBase<BusinessLayer.ServiceReference.IPuppyService>, BusinessLayer.ServiceReference.IPuppyService {
        
        public PuppyServiceClient() {
        }
        
        public PuppyServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public PuppyServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public PuppyServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public PuppyServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public void addNewPuppy(DAL.Model.Puppy newPuppyInfo) {
            base.Channel.addNewPuppy(newPuppyInfo);
        }
        
        public System.Threading.Tasks.Task addNewPuppyAsync(DAL.Model.Puppy newPuppyInfo) {
            return base.Channel.addNewPuppyAsync(newPuppyInfo);
        }
        
        public DAL.Model.Puppy[] getPuppyByGender(string gender) {
            return base.Channel.getPuppyByGender(gender);
        }
        
        public System.Threading.Tasks.Task<DAL.Model.Puppy[]> getPuppyByGenderAsync(string gender) {
            return base.Channel.getPuppyByGenderAsync(gender);
        }
        
        public DAL.Model.Puppy[] getAllPuppies() {
            return base.Channel.getAllPuppies();
        }
        
        public System.Threading.Tasks.Task<DAL.Model.Puppy[]> getAllPuppiesAsync() {
            return base.Channel.getAllPuppiesAsync();
        }
        
        public void updatePuppy(DAL.Model.Puppy updatedPuppy) {
            base.Channel.updatePuppy(updatedPuppy);
        }
        
        public System.Threading.Tasks.Task updatePuppyAsync(DAL.Model.Puppy updatedPuppy) {
            return base.Channel.updatePuppyAsync(updatedPuppy);
        }
        
        public void deletePuppy(int puppyId) {
            base.Channel.deletePuppy(puppyId);
        }
        
        public System.Threading.Tasks.Task deletePuppyAsync(int puppyId) {
            return base.Channel.deletePuppyAsync(puppyId);
        }
    }
}