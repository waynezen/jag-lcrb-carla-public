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
    /// Microsoft.Dynamics.CRM.ptm_mscrmaddonscommetadata
    /// </summary>
    public partial class MicrosoftDynamicsCRMptmMscrmaddonscommetadata
    {
        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMptmMscrmaddonscommetadata class.
        /// </summary>
        public MicrosoftDynamicsCRMptmMscrmaddonscommetadata()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMptmMscrmaddonscommetadata class.
        /// </summary>
        public MicrosoftDynamicsCRMptmMscrmaddonscommetadata(int? statecode = default(int?), string ptmName = default(string), string _modifiedbyValue = default(string), int? ptmObjecttypecode = default(int?), string _organizationidValue = default(string), System.DateTimeOffset? createdon = default(System.DateTimeOffset?), string versionnumber = default(string), string _createdonbehalfbyValue = default(string), string ptmFullxml = default(string), string _createdbyValue = default(string), int? importsequencenumber = default(int?), int? statuscode = default(int?), System.DateTimeOffset? modifiedon = default(System.DateTimeOffset?), bool? ptmIscustomizable = default(bool?), string ptmLocalizedlabels = default(string), string ptmMscrmaddonscommetadataid = default(string), int? utcconversiontimezonecode = default(int?), int? timezoneruleversionnumber = default(int?), string _modifiedonbehalfbyValue = default(string), System.DateTimeOffset? overriddencreatedon = default(System.DateTimeOffset?), string ptmValue = default(string), MicrosoftDynamicsCRMsystemuser createdby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser createdonbehalfby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser modifiedby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser modifiedonbehalfby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMorganization organizationid = default(MicrosoftDynamicsCRMorganization), IList<MicrosoftDynamicsCRMsyncerror> ptmMscrmaddonscommetadataSyncErrors = default(IList<MicrosoftDynamicsCRMsyncerror>), IList<MicrosoftDynamicsCRMasyncoperation> ptmMscrmaddonscommetadataAsyncOperations = default(IList<MicrosoftDynamicsCRMasyncoperation>), IList<MicrosoftDynamicsCRMmailboxtrackingfolder> ptmMscrmaddonscommetadataMailboxTrackingFolders = default(IList<MicrosoftDynamicsCRMmailboxtrackingfolder>), IList<MicrosoftDynamicsCRMprocesssession> ptmMscrmaddonscommetadataProcessSession = default(IList<MicrosoftDynamicsCRMprocesssession>), IList<MicrosoftDynamicsCRMbulkdeletefailure> ptmMscrmaddonscommetadataBulkDeleteFailures = default(IList<MicrosoftDynamicsCRMbulkdeletefailure>), IList<MicrosoftDynamicsCRMprincipalobjectattributeaccess> ptmMscrmaddonscommetadataPrincipalObjectAttributeAccesses = default(IList<MicrosoftDynamicsCRMprincipalobjectattributeaccess>))
        {
            Statecode = statecode;
            PtmName = ptmName;
            this._modifiedbyValue = _modifiedbyValue;
            PtmObjecttypecode = ptmObjecttypecode;
            this._organizationidValue = _organizationidValue;
            Createdon = createdon;
            Versionnumber = versionnumber;
            this._createdonbehalfbyValue = _createdonbehalfbyValue;
            PtmFullxml = ptmFullxml;
            this._createdbyValue = _createdbyValue;
            Importsequencenumber = importsequencenumber;
            Statuscode = statuscode;
            Modifiedon = modifiedon;
            PtmIscustomizable = ptmIscustomizable;
            PtmLocalizedlabels = ptmLocalizedlabels;
            PtmMscrmaddonscommetadataid = ptmMscrmaddonscommetadataid;
            Utcconversiontimezonecode = utcconversiontimezonecode;
            Timezoneruleversionnumber = timezoneruleversionnumber;
            this._modifiedonbehalfbyValue = _modifiedonbehalfbyValue;
            Overriddencreatedon = overriddencreatedon;
            PtmValue = ptmValue;
            Createdby = createdby;
            Createdonbehalfby = createdonbehalfby;
            Modifiedby = modifiedby;
            Modifiedonbehalfby = modifiedonbehalfby;
            Organizationid = organizationid;
            PtmMscrmaddonscommetadataSyncErrors = ptmMscrmaddonscommetadataSyncErrors;
            PtmMscrmaddonscommetadataAsyncOperations = ptmMscrmaddonscommetadataAsyncOperations;
            PtmMscrmaddonscommetadataMailboxTrackingFolders = ptmMscrmaddonscommetadataMailboxTrackingFolders;
            PtmMscrmaddonscommetadataProcessSession = ptmMscrmaddonscommetadataProcessSession;
            PtmMscrmaddonscommetadataBulkDeleteFailures = ptmMscrmaddonscommetadataBulkDeleteFailures;
            PtmMscrmaddonscommetadataPrincipalObjectAttributeAccesses = ptmMscrmaddonscommetadataPrincipalObjectAttributeAccesses;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "statecode")]
        public int? Statecode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ptm_name")]
        public string PtmName { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedby_value")]
        public string _modifiedbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ptm_objecttypecode")]
        public int? PtmObjecttypecode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_organizationid_value")]
        public string _organizationidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdon")]
        public System.DateTimeOffset? Createdon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "versionnumber")]
        public string Versionnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_createdonbehalfby_value")]
        public string _createdonbehalfbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ptm_fullxml")]
        public string PtmFullxml { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_createdby_value")]
        public string _createdbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "importsequencenumber")]
        public int? Importsequencenumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "statuscode")]
        public int? Statuscode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedon")]
        public System.DateTimeOffset? Modifiedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ptm_iscustomizable")]
        public bool? PtmIscustomizable { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ptm_localizedlabels")]
        public string PtmLocalizedlabels { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ptm_mscrmaddonscommetadataid")]
        public string PtmMscrmaddonscommetadataid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "utcconversiontimezonecode")]
        public int? Utcconversiontimezonecode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "timezoneruleversionnumber")]
        public int? Timezoneruleversionnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedonbehalfby_value")]
        public string _modifiedonbehalfbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "overriddencreatedon")]
        public System.DateTimeOffset? Overriddencreatedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ptm_value")]
        public string PtmValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdby")]
        public MicrosoftDynamicsCRMsystemuser Createdby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdonbehalfby")]
        public MicrosoftDynamicsCRMsystemuser Createdonbehalfby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedby")]
        public MicrosoftDynamicsCRMsystemuser Modifiedby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedonbehalfby")]
        public MicrosoftDynamicsCRMsystemuser Modifiedonbehalfby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "organizationid")]
        public MicrosoftDynamicsCRMorganization Organizationid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ptm_mscrmaddonscommetadata_SyncErrors")]
        public IList<MicrosoftDynamicsCRMsyncerror> PtmMscrmaddonscommetadataSyncErrors { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ptm_mscrmaddonscommetadata_AsyncOperations")]
        public IList<MicrosoftDynamicsCRMasyncoperation> PtmMscrmaddonscommetadataAsyncOperations { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ptm_mscrmaddonscommetadata_MailboxTrackingFolders")]
        public IList<MicrosoftDynamicsCRMmailboxtrackingfolder> PtmMscrmaddonscommetadataMailboxTrackingFolders { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ptm_mscrmaddonscommetadata_ProcessSession")]
        public IList<MicrosoftDynamicsCRMprocesssession> PtmMscrmaddonscommetadataProcessSession { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ptm_mscrmaddonscommetadata_BulkDeleteFailures")]
        public IList<MicrosoftDynamicsCRMbulkdeletefailure> PtmMscrmaddonscommetadataBulkDeleteFailures { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ptm_mscrmaddonscommetadata_PrincipalObjectAttributeAccesses")]
        public IList<MicrosoftDynamicsCRMprincipalobjectattributeaccess> PtmMscrmaddonscommetadataPrincipalObjectAttributeAccesses { get; set; }

    }
}
