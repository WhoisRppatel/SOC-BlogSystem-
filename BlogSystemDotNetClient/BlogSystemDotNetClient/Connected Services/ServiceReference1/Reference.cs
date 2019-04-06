﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BlogSystemDotNetClient.ServiceReference1 {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="MyBlog", Namespace="http://schemas.datacontract.org/2004/07/WcfBlogServiceLibrary")]
    [System.SerializableAttribute()]
    public partial class MyBlog : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int blogNOField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string blogbyField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string contentField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime docField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string passwordField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string titleField;
        
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
        public int blogNO {
            get {
                return this.blogNOField;
            }
            set {
                if ((this.blogNOField.Equals(value) != true)) {
                    this.blogNOField = value;
                    this.RaisePropertyChanged("blogNO");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string blogby {
            get {
                return this.blogbyField;
            }
            set {
                if ((object.ReferenceEquals(this.blogbyField, value) != true)) {
                    this.blogbyField = value;
                    this.RaisePropertyChanged("blogby");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string content {
            get {
                return this.contentField;
            }
            set {
                if ((object.ReferenceEquals(this.contentField, value) != true)) {
                    this.contentField = value;
                    this.RaisePropertyChanged("content");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime doc {
            get {
                return this.docField;
            }
            set {
                if ((this.docField.Equals(value) != true)) {
                    this.docField = value;
                    this.RaisePropertyChanged("doc");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string password {
            get {
                return this.passwordField;
            }
            set {
                if ((object.ReferenceEquals(this.passwordField, value) != true)) {
                    this.passwordField = value;
                    this.RaisePropertyChanged("password");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string title {
            get {
                return this.titleField;
            }
            set {
                if ((object.ReferenceEquals(this.titleField, value) != true)) {
                    this.titleField = value;
                    this.RaisePropertyChanged("title");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.IBlog")]
    public interface IBlog {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBlog/GetData", ReplyAction="http://tempuri.org/IBlog/GetDataResponse")]
        string GetData(int value);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBlog/GetData", ReplyAction="http://tempuri.org/IBlog/GetDataResponse")]
        System.Threading.Tasks.Task<string> GetDataAsync(int value);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBlog/AddBlog", ReplyAction="http://tempuri.org/IBlog/AddBlogResponse")]
        string AddBlog(BlogSystemDotNetClient.ServiceReference1.MyBlog s);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBlog/AddBlog", ReplyAction="http://tempuri.org/IBlog/AddBlogResponse")]
        System.Threading.Tasks.Task<string> AddBlogAsync(BlogSystemDotNetClient.ServiceReference1.MyBlog s);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBlog/GetAllBlog", ReplyAction="http://tempuri.org/IBlog/GetAllBlogResponse")]
        BlogSystemDotNetClient.ServiceReference1.MyBlog[] GetAllBlog();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBlog/GetAllBlog", ReplyAction="http://tempuri.org/IBlog/GetAllBlogResponse")]
        System.Threading.Tasks.Task<BlogSystemDotNetClient.ServiceReference1.MyBlog[]> GetAllBlogAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBlog/GetBlogById", ReplyAction="http://tempuri.org/IBlog/GetBlogByIdResponse")]
        BlogSystemDotNetClient.ServiceReference1.MyBlog GetBlogById(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBlog/GetBlogById", ReplyAction="http://tempuri.org/IBlog/GetBlogByIdResponse")]
        System.Threading.Tasks.Task<BlogSystemDotNetClient.ServiceReference1.MyBlog> GetBlogByIdAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBlog/UpdateBlog", ReplyAction="http://tempuri.org/IBlog/UpdateBlogResponse")]
        string UpdateBlog(BlogSystemDotNetClient.ServiceReference1.MyBlog s);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBlog/UpdateBlog", ReplyAction="http://tempuri.org/IBlog/UpdateBlogResponse")]
        System.Threading.Tasks.Task<string> UpdateBlogAsync(BlogSystemDotNetClient.ServiceReference1.MyBlog s);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBlog/DeleteBlog", ReplyAction="http://tempuri.org/IBlog/DeleteBlogResponse")]
        string DeleteBlog(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBlog/DeleteBlog", ReplyAction="http://tempuri.org/IBlog/DeleteBlogResponse")]
        System.Threading.Tasks.Task<string> DeleteBlogAsync(int id);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IBlogChannel : BlogSystemDotNetClient.ServiceReference1.IBlog, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class BlogClient : System.ServiceModel.ClientBase<BlogSystemDotNetClient.ServiceReference1.IBlog>, BlogSystemDotNetClient.ServiceReference1.IBlog {
        
        public BlogClient() {
        }
        
        public BlogClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public BlogClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public BlogClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public BlogClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string GetData(int value) {
            return base.Channel.GetData(value);
        }
        
        public System.Threading.Tasks.Task<string> GetDataAsync(int value) {
            return base.Channel.GetDataAsync(value);
        }
        
        public string AddBlog(BlogSystemDotNetClient.ServiceReference1.MyBlog s) {
            return base.Channel.AddBlog(s);
        }
        
        public System.Threading.Tasks.Task<string> AddBlogAsync(BlogSystemDotNetClient.ServiceReference1.MyBlog s) {
            return base.Channel.AddBlogAsync(s);
        }
        
        public BlogSystemDotNetClient.ServiceReference1.MyBlog[] GetAllBlog() {
            return base.Channel.GetAllBlog();
        }
        
        public System.Threading.Tasks.Task<BlogSystemDotNetClient.ServiceReference1.MyBlog[]> GetAllBlogAsync() {
            return base.Channel.GetAllBlogAsync();
        }
        
        public BlogSystemDotNetClient.ServiceReference1.MyBlog GetBlogById(int id) {
            return base.Channel.GetBlogById(id);
        }
        
        public System.Threading.Tasks.Task<BlogSystemDotNetClient.ServiceReference1.MyBlog> GetBlogByIdAsync(int id) {
            return base.Channel.GetBlogByIdAsync(id);
        }
        
        public string UpdateBlog(BlogSystemDotNetClient.ServiceReference1.MyBlog s) {
            return base.Channel.UpdateBlog(s);
        }
        
        public System.Threading.Tasks.Task<string> UpdateBlogAsync(BlogSystemDotNetClient.ServiceReference1.MyBlog s) {
            return base.Channel.UpdateBlogAsync(s);
        }
        
        public string DeleteBlog(int id) {
            return base.Channel.DeleteBlog(id);
        }
        
        public System.Threading.Tasks.Task<string> DeleteBlogAsync(int id) {
            return base.Channel.DeleteBlogAsync(id);
        }
    }
}