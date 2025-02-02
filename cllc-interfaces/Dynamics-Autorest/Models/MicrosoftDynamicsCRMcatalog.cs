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
    /// Microsoft.Dynamics.CRM.catalog
    /// </summary>
    public partial class MicrosoftDynamicsCRMcatalog
    {
        /// <summary>
        /// Initializes a new instance of the MicrosoftDynamicsCRMcatalog
        /// class.
        /// </summary>
        public MicrosoftDynamicsCRMcatalog()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the MicrosoftDynamicsCRMcatalog
        /// class.
        /// </summary>
        public MicrosoftDynamicsCRMcatalog(int? statecode = default(int?), string _createdbyValue = default(string), string catalogid = default(string), int? timezoneruleversionnumber = default(int?), int? statuscode = default(int?), string _modifiedbyValue = default(string), string description = default(string), string versionnumber = default(string), int? utcconversiontimezonecode = default(int?), int? importsequencenumber = default(int?), string uniquename = default(string), System.DateTimeOffset? modifiedon = default(System.DateTimeOffset?), string componentidunique = default(string), System.DateTimeOffset? overriddencreatedon = default(System.DateTimeOffset?), string _createdonbehalfbyValue = default(string), bool? ismanaged = default(bool?), System.DateTimeOffset? overwritetime = default(System.DateTimeOffset?), string iscustomizable = default(string), string _parentcatalogidValue = default(string), System.DateTimeOffset? createdon = default(System.DateTimeOffset?), string _organizationidValue = default(string), string name = default(string), string _modifiedonbehalfbyValue = default(string), string displayname = default(string), int? componentstate = default(int?), string solutionid = default(string), MicrosoftDynamicsCRMsystemuser createdby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser createdonbehalfby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser modifiedby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser modifiedonbehalfby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMorganization organizationid = default(MicrosoftDynamicsCRMorganization), IList<MicrosoftDynamicsCRMsyncerror> catalogSyncErrors = default(IList<MicrosoftDynamicsCRMsyncerror>), IList<MicrosoftDynamicsCRMasyncoperation> catalogAsyncOperations = default(IList<MicrosoftDynamicsCRMasyncoperation>), IList<MicrosoftDynamicsCRMmailboxtrackingfolder> catalogMailboxTrackingFolders = default(IList<MicrosoftDynamicsCRMmailboxtrackingfolder>), IList<MicrosoftDynamicsCRMprocesssession> catalogProcessSession = default(IList<MicrosoftDynamicsCRMprocesssession>), IList<MicrosoftDynamicsCRMbulkdeletefailure> catalogBulkDeleteFailures = default(IList<MicrosoftDynamicsCRMbulkdeletefailure>), IList<MicrosoftDynamicsCRMprincipalobjectattributeaccess> catalogPrincipalObjectAttributeAccesses = default(IList<MicrosoftDynamicsCRMprincipalobjectattributeaccess>), IList<MicrosoftDynamicsCRMcatalogassignment> catalogCatalogAssignment = default(IList<MicrosoftDynamicsCRMcatalogassignment>), MicrosoftDynamicsCRMcatalog parentCatalogId = default(MicrosoftDynamicsCRMcatalog), IList<MicrosoftDynamicsCRMcatalog> subCatalogs = default(IList<MicrosoftDynamicsCRMcatalog>))
        {
            Statecode = statecode;
            this._createdbyValue = _createdbyValue;
            Catalogid = catalogid;
            Timezoneruleversionnumber = timezoneruleversionnumber;
            Statuscode = statuscode;
            this._modifiedbyValue = _modifiedbyValue;
            Description = description;
            Versionnumber = versionnumber;
            Utcconversiontimezonecode = utcconversiontimezonecode;
            Importsequencenumber = importsequencenumber;
            Uniquename = uniquename;
            Modifiedon = modifiedon;
            Componentidunique = componentidunique;
            Overriddencreatedon = overriddencreatedon;
            this._createdonbehalfbyValue = _createdonbehalfbyValue;
            Ismanaged = ismanaged;
            Overwritetime = overwritetime;
            Iscustomizable = iscustomizable;
            this._parentcatalogidValue = _parentcatalogidValue;
            Createdon = createdon;
            this._organizationidValue = _organizationidValue;
            Name = name;
            this._modifiedonbehalfbyValue = _modifiedonbehalfbyValue;
            Displayname = displayname;
            Componentstate = componentstate;
            Solutionid = solutionid;
            Createdby = createdby;
            Createdonbehalfby = createdonbehalfby;
            Modifiedby = modifiedby;
            Modifiedonbehalfby = modifiedonbehalfby;
            Organizationid = organizationid;
            CatalogSyncErrors = catalogSyncErrors;
            CatalogAsyncOperations = catalogAsyncOperations;
            CatalogMailboxTrackingFolders = catalogMailboxTrackingFolders;
            CatalogProcessSession = catalogProcessSession;
            CatalogBulkDeleteFailures = catalogBulkDeleteFailures;
            CatalogPrincipalObjectAttributeAccesses = catalogPrincipalObjectAttributeAccesses;
            CatalogCatalogAssignment = catalogCatalogAssignment;
            ParentCatalogId = parentCatalogId;
            SubCatalogs = subCatalogs;
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
        [JsonProperty(PropertyName = "_createdby_value")]
        public string _createdbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "catalogid")]
        public string Catalogid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "timezoneruleversionnumber")]
        public int? Timezoneruleversionnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "statuscode")]
        public int? Statuscode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedby_value")]
        public string _modifiedbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "versionnumber")]
        public string Versionnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "utcconversiontimezonecode")]
        public int? Utcconversiontimezonecode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "importsequencenumber")]
        public int? Importsequencenumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "uniquename")]
        public string Uniquename { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedon")]
        public System.DateTimeOffset? Modifiedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "componentidunique")]
        public string Componentidunique { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "overriddencreatedon")]
        public System.DateTimeOffset? Overriddencreatedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_createdonbehalfby_value")]
        public string _createdonbehalfbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ismanaged")]
        public bool? Ismanaged { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "overwritetime")]
        public System.DateTimeOffset? Overwritetime { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "iscustomizable")]
        public string Iscustomizable { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_parentcatalogid_value")]
        public string _parentcatalogidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdon")]
        public System.DateTimeOffset? Createdon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_organizationid_value")]
        public string _organizationidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedonbehalfby_value")]
        public string _modifiedonbehalfbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "displayname")]
        public string Displayname { get; set; }

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
        [JsonProperty(PropertyName = "catalog_SyncErrors")]
        public IList<MicrosoftDynamicsCRMsyncerror> CatalogSyncErrors { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "catalog_AsyncOperations")]
        public IList<MicrosoftDynamicsCRMasyncoperation> CatalogAsyncOperations { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "catalog_MailboxTrackingFolders")]
        public IList<MicrosoftDynamicsCRMmailboxtrackingfolder> CatalogMailboxTrackingFolders { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "catalog_ProcessSession")]
        public IList<MicrosoftDynamicsCRMprocesssession> CatalogProcessSession { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "catalog_BulkDeleteFailures")]
        public IList<MicrosoftDynamicsCRMbulkdeletefailure> CatalogBulkDeleteFailures { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "catalog_PrincipalObjectAttributeAccesses")]
        public IList<MicrosoftDynamicsCRMprincipalobjectattributeaccess> CatalogPrincipalObjectAttributeAccesses { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Catalog_CatalogAssignment")]
        public IList<MicrosoftDynamicsCRMcatalogassignment> CatalogCatalogAssignment { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ParentCatalogId")]
        public MicrosoftDynamicsCRMcatalog ParentCatalogId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "SubCatalogs")]
        public IList<MicrosoftDynamicsCRMcatalog> SubCatalogs { get; set; }

    }
}
