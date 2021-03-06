﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

// 
// 此源代码是由 Microsoft.VSDesigner 4.0.30319.42000 版自动生成。
// 
#pragma warning disable 1591

namespace CDMIS.WebReferenceJC {
    using System;
    using System.Web.Services;
    using System.Diagnostics;
    using System.Web.Services.Protocols;
    using System.Xml.Serialization;
    using System.ComponentModel;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.79.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Web.Services.WebServiceBindingAttribute(Name="Bs.WebServiceSoap", Namespace="http://tempuri.org")]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(Ens_Messagebody))]
    public partial class BsWebService : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        private System.Threading.SendOrPostCallback GetBasicInfoOperationCompleted;
        
        private System.Threading.SendOrPostCallback GetPatientOperationCompleted;
        
        private bool useDefaultCredentialsSetExplicitly;
        
        /// <remarks/>
        public BsWebService() {
            this.Url = global::CDMIS.Properties.Settings.Default.CDMIS_WebReferenceJC_Bs_WebService;
            if ((this.IsLocalFileSystemWebService(this.Url) == true)) {
                this.UseDefaultCredentials = true;
                this.useDefaultCredentialsSetExplicitly = false;
            }
            else {
                this.useDefaultCredentialsSetExplicitly = true;
            }
        }
        
        public new string Url {
            get {
                return base.Url;
            }
            set {
                if ((((this.IsLocalFileSystemWebService(base.Url) == true) 
                            && (this.useDefaultCredentialsSetExplicitly == false)) 
                            && (this.IsLocalFileSystemWebService(value) == false))) {
                    base.UseDefaultCredentials = false;
                }
                base.Url = value;
            }
        }
        
        public new bool UseDefaultCredentials {
            get {
                return base.UseDefaultCredentials;
            }
            set {
                base.UseDefaultCredentials = value;
                this.useDefaultCredentialsSetExplicitly = true;
            }
        }
        
        /// <remarks/>
        public event GetBasicInfoCompletedEventHandler GetBasicInfoCompleted;
        
        /// <remarks/>
        public event GetPatientCompletedEventHandler GetPatientCompleted;
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/Bs.WebService.GetBasicInfo", RequestNamespace="http://tempuri.org", ResponseNamespace="http://tempuri.org", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public resSetPatient GetBasicInfo(string UserId, string PatientId, string HospitalCode) {
            object[] results = this.Invoke("GetBasicInfo", new object[] {
                        UserId,
                        PatientId,
                        HospitalCode});
            return ((resSetPatient)(results[0]));
        }
        
        /// <remarks/>
        public void GetBasicInfoAsync(string UserId, string PatientId, string HospitalCode) {
            this.GetBasicInfoAsync(UserId, PatientId, HospitalCode, null);
        }
        
        /// <remarks/>
        public void GetBasicInfoAsync(string UserId, string PatientId, string HospitalCode, object userState) {
            if ((this.GetBasicInfoOperationCompleted == null)) {
                this.GetBasicInfoOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetBasicInfoOperationCompleted);
            }
            this.InvokeAsync("GetBasicInfo", new object[] {
                        UserId,
                        PatientId,
                        HospitalCode}, this.GetBasicInfoOperationCompleted, userState);
        }
        
        private void OnGetBasicInfoOperationCompleted(object arg) {
            if ((this.GetBasicInfoCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetBasicInfoCompleted(this, new GetBasicInfoCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/Bs.WebService.GetPatient", RequestNamespace="http://tempuri.org", ResponseNamespace="http://tempuri.org", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public resSetInfo GetPatient(string UserId, string PatientId, System.DateTime StartDateTime, [System.Xml.Serialization.XmlIgnoreAttribute()] bool StartDateTimeSpecified, string HospitalCode) {
            object[] results = this.Invoke("GetPatient", new object[] {
                        UserId,
                        PatientId,
                        StartDateTime,
                        StartDateTimeSpecified,
                        HospitalCode});
            return ((resSetInfo)(results[0]));
        }
        
        /// <remarks/>
        public void GetPatientAsync(string UserId, string PatientId, System.DateTime StartDateTime, bool StartDateTimeSpecified, string HospitalCode) {
            this.GetPatientAsync(UserId, PatientId, StartDateTime, StartDateTimeSpecified, HospitalCode, null);
        }
        
        /// <remarks/>
        public void GetPatientAsync(string UserId, string PatientId, System.DateTime StartDateTime, bool StartDateTimeSpecified, string HospitalCode, object userState) {
            if ((this.GetPatientOperationCompleted == null)) {
                this.GetPatientOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetPatientOperationCompleted);
            }
            this.InvokeAsync("GetPatient", new object[] {
                        UserId,
                        PatientId,
                        StartDateTime,
                        StartDateTimeSpecified,
                        HospitalCode}, this.GetPatientOperationCompleted, userState);
        }
        
        private void OnGetPatientOperationCompleted(object arg) {
            if ((this.GetPatientCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetPatientCompleted(this, new GetPatientCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        public new void CancelAsync(object userState) {
            base.CancelAsync(userState);
        }
        
        private bool IsLocalFileSystemWebService(string url) {
            if (((url == null) 
                        || (url == string.Empty))) {
                return false;
            }
            System.Uri wsUri = new System.Uri(url);
            if (((wsUri.Port >= 1024) 
                        && (string.Compare(wsUri.Host, "localHost", System.StringComparison.OrdinalIgnoreCase) == 0))) {
                return true;
            }
            return false;
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.79.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempuri.org")]
    public partial class resSetPatient : Ens_Response {
        
        private string statusField;
        
        /// <remarks/>
        public string Status {
            get {
                return this.statusField;
            }
            set {
                this.statusField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(resSetInfo))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(resSetPatient))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.79.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempuri.org")]
    public partial class Ens_Response : Ens_Messagebody {
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(Ens_Response))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(resSetInfo))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(resSetPatient))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.79.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempuri.org")]
    public partial class Ens_Messagebody {
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.79.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempuri.org")]
    public partial class resSetInfo : Ens_Response {
        
        private string statusField;
        
        /// <remarks/>
        public string Status {
            get {
                return this.statusField;
            }
            set {
                this.statusField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.79.0")]
    public delegate void GetBasicInfoCompletedEventHandler(object sender, GetBasicInfoCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.79.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetBasicInfoCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal GetBasicInfoCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public resSetPatient Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((resSetPatient)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.79.0")]
    public delegate void GetPatientCompletedEventHandler(object sender, GetPatientCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.79.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetPatientCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal GetPatientCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public resSetInfo Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((resSetInfo)(this.results[0]));
            }
        }
    }
}

#pragma warning restore 1591