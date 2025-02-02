// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Gov.Lclb.Cllb.Interfaces.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Microsoft.Dynamics.CRM.appconfig
    /// </summary>
    public partial class MicrosoftDynamicsCRMappconfig
    {
        /// <summary>
        /// Initializes a new instance of the MicrosoftDynamicsCRMappconfig
        /// class.
        /// </summary>
        public MicrosoftDynamicsCRMappconfig()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the MicrosoftDynamicsCRMappconfig
        /// class.
        /// </summary>
        public MicrosoftDynamicsCRMappconfig(int? componentstate = default(int?), string solutionid = default(string), int? importsequencenumber = default(int?), string versionnumber = default(string), bool? ismanaged = default(bool?), System.DateTimeOffset? overriddencreatedon = default(System.DateTimeOffset?), string _organizationidValue = default(string), System.DateTimeOffset? modifiedon = default(System.DateTimeOffset?), System.DateTimeOffset? createdon = default(System.DateTimeOffset?), string _createdbyValue = default(string), string appconfigimportxml = default(string), string _createdonbehalfbyValue = default(string), System.DateTimeOffset? overwritetime = default(System.DateTimeOffset?), string appconfigidunique = default(string), string introducedversion = default(string), string _modifiedbyValue = default(string), string _appmoduleidValue = default(string), string appconfigid = default(string), int? statecode = default(int?), int? statuscode = default(int?), string _modifiedonbehalfbyValue = default(string), MicrosoftDynamicsCRMappmodule appmoduleAppconfig = default(MicrosoftDynamicsCRMappmodule), MicrosoftDynamicsCRMsystemuser appconfigModifiedby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser appconfigModifiedonbehalfby = default(MicrosoftDynamicsCRMsystemuser), IList<MicrosoftDynamicsCRMnavigationsetting> appconfigNavigationsetting = default(IList<MicrosoftDynamicsCRMnavigationsetting>), MicrosoftDynamicsCRMsystemuser appconfigCreatedonbehalfby = default(MicrosoftDynamicsCRMsystemuser), IList<MicrosoftDynamicsCRMappconfiginstance> appconfigAppconfiginstance = default(IList<MicrosoftDynamicsCRMappconfiginstance>), MicrosoftDynamicsCRMsystemuser appconfigCreatedby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMorganization organizationAppconfig = default(MicrosoftDynamicsCRMorganization))
        {
            Componentstate = componentstate;
            Solutionid = solutionid;
            Importsequencenumber = importsequencenumber;
            Versionnumber = versionnumber;
            Ismanaged = ismanaged;
            Overriddencreatedon = overriddencreatedon;
            this._organizationidValue = _organizationidValue;
            Modifiedon = modifiedon;
            Createdon = createdon;
            this._createdbyValue = _createdbyValue;
            Appconfigimportxml = appconfigimportxml;
            this._createdonbehalfbyValue = _createdonbehalfbyValue;
            Overwritetime = overwritetime;
            Appconfigidunique = appconfigidunique;
            Introducedversion = introducedversion;
            this._modifiedbyValue = _modifiedbyValue;
            this._appmoduleidValue = _appmoduleidValue;
            Appconfigid = appconfigid;
            Statecode = statecode;
            Statuscode = statuscode;
            this._modifiedonbehalfbyValue = _modifiedonbehalfbyValue;
            AppmoduleAppconfig = appmoduleAppconfig;
            AppconfigModifiedby = appconfigModifiedby;
            AppconfigModifiedonbehalfby = appconfigModifiedonbehalfby;
            AppconfigNavigationsetting = appconfigNavigationsetting;
            AppconfigCreatedonbehalfby = appconfigCreatedonbehalfby;
            AppconfigAppconfiginstance = appconfigAppconfiginstance;
            AppconfigCreatedby = appconfigCreatedby;
            OrganizationAppconfig = organizationAppconfig;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "componentstate")]
        public int? Componentstate { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "solutionid")]
        public string Solutionid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "importsequencenumber")]
        public int? Importsequencenumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "versionnumber")]
        public string Versionnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ismanaged")]
        public bool? Ismanaged { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "overriddencreatedon")]
        public System.DateTimeOffset? Overriddencreatedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_organizationid_value")]
        public string _organizationidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedon")]
        public System.DateTimeOffset? Modifiedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdon")]
        public System.DateTimeOffset? Createdon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_createdby_value")]
        public string _createdbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "appconfigimportxml")]
        public string Appconfigimportxml { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_createdonbehalfby_value")]
        public string _createdonbehalfbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "overwritetime")]
        public System.DateTimeOffset? Overwritetime { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "appconfigidunique")]
        public string Appconfigidunique { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "introducedversion")]
        public string Introducedversion { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedby_value")]
        public string _modifiedbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_appmoduleid_value")]
        public string _appmoduleidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "appconfigid")]
        public string Appconfigid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "statecode")]
        public int? Statecode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "statuscode")]
        public int? Statuscode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedonbehalfby_value")]
        public string _modifiedonbehalfbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "appmodule_appconfig")]
        public MicrosoftDynamicsCRMappmodule AppmoduleAppconfig { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "appconfig_modifiedby")]
        public MicrosoftDynamicsCRMsystemuser AppconfigModifiedby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "appconfig_modifiedonbehalfby")]
        public MicrosoftDynamicsCRMsystemuser AppconfigModifiedonbehalfby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "appconfig_navigationsetting")]
        public IList<MicrosoftDynamicsCRMnavigationsetting> AppconfigNavigationsetting { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "appconfig_createdonbehalfby")]
        public MicrosoftDynamicsCRMsystemuser AppconfigCreatedonbehalfby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "appconfig_appconfiginstance")]
        public IList<MicrosoftDynamicsCRMappconfiginstance> AppconfigAppconfiginstance { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "appconfig_createdby")]
        public MicrosoftDynamicsCRMsystemuser AppconfigCreatedby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "organization_appconfig")]
        public MicrosoftDynamicsCRMorganization OrganizationAppconfig { get; set; }

    }
}
